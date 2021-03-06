grammar AntlrCalcEngine;

options {
	language = 'CSharp2';
	// We're going to output an AST.
	output = AST;
	ASTLabelType = CommonTree;
}

tokens {
	// Class tokens.
	CLASS;
	BASE_CLASS;
	DISCRIMINATOR;
	PROPERTY;
	RELATIONSHIP;
	JOIN;
	TARGET;

	// General
	NAME;	
	STATEMENT_BLOCK;
	FORMULA;
	
	// Expression tokens.
	MODIFIERS;
	EXPRESSION;
	IDENTIFIER;
	THIS;
	ENTITY;
	FUNCTION;
	NAME;
	PARAMETERS;
	FILTER;
	SOURCE;
	CRITERIA;
	
	// Operators
	OP_OR;
	OP_AND;
	OP_NOT;
	OP_EQ;
	OP_NE;
	OP_LT;
	OP_GT;
	OP_LTE;
	OP_GTE;
	OP_ADD;
	OP_SUBTRACT;
	OP_MULTIPLY;
	OP_DIVIDE;
	OP_MODULUS;
	OP_ASSIGN;
	OP_UNARY_NEGATION;
	
	// Bool Values
	TRUE;
	FALSE;
}

@namespace { CalcEngine.Parsers.Antlr }


/*----------------------------------------------------------
 * PARSER RULES
 *----------------------------------------------------------*/

root
	:	rootLevelStatement*
	;
rootLevelStatement
	:	formulaDeclaration 
	|	classDeclaration
	;


// BEGIN CLASS DECLARATIONS

classDeclaration
	:	'class' name baseClassDeclaration? classStatementBlock -> ^( CLASS name baseClassDeclaration? classStatementBlock )
	;
baseClassDeclaration
	:	':' name 'where' expression -> ^( BASE_CLASS name ^( DISCRIMINATOR expression ) )
	;
classStatementBlock
	:	'{' classLevelStatement* '}' -> ^( STATEMENT_BLOCK classLevelStatement* )
	;
classLevelStatement
	:	propertyDeclaration
	|	relationshipDeclaration
	;
name
	:	x=ID -> NAME[$x]
	;
	
// Properties.
propertyDeclaration
	:	'property' name propertyModifiers? ';' -> ^( PROPERTY name propertyModifiers? )
	;
propertyModifiers
	:	exclusivePropertyModifier -> ^( MODIFIERS exclusivePropertyModifier )
	|	propertyModifier+ -> ^( MODIFIERS propertyModifier+ )
	;
exclusivePropertyModifier
	:	'primarykey'
	;
propertyModifier
	:	'calculated'
	|	'abstract'
	;
	
// Relationships.
relationshipDeclaration
	:	'relationship' name '=' relationshipJoinDeclaration ';' -> ^( RELATIONSHIP name relationshipJoinDeclaration )
	;
relationshipJoinDeclaration
	:	name 'where' expression -> ^( JOIN ^( TARGET name ) ^( CRITERIA expression ) )
	;

// END CLASS DECLARATIONS


// FORMULA DECLARATION

formulaDeclaration
	:	entityChainNoFilter assignmentOp expression ';' -> ^( FORMULA ^( assignmentOp entityChainNoFilter expression ) )
	;
	
	
// BEGIN EXPRESSION LOOP
	
expression
	:	orExpr
	;
orExpr
	:	andExpr ( orOp^ andExpr )*
	;
andExpr
	:	equalityExpr ( andOp^ equalityExpr )*
	;	
equalityExpr
	:	relationalExpr ( ( equalsOp^ | notEqualsOp^ ) relationalExpr )*
	;
relationalExpr
	:	additiveExpr ( ( ltOp^ | gtOp^ | lteOp^ | gteOp^ ) additiveExpr )*
	;	
additiveExpr
	:	multiplicativeExpr ( ( addOp^ | subtractOp^ ) multiplicativeExpr )*
	;	
multiplicativeExpr
	:	unaryExpr ( ( multiplyOp^ | divideOp^ | modulusOp^ ) unaryExpr )*
	;		
unaryExpr
	:	unaryNegationOp^? negationExpr
	;	
negationExpr
	:	( notOp^ )* primaryExpr
	;	
primaryExpr
	:	'('! expression ')'!
	|	number
	|	booleanValue
	|	LITERAL
	|	functionCall
	|	entityChain
	;

// END EXPRESSION LOOP


// BEGIN OPERATORS

notOp
	:	x='not' -> OP_NOT[$x]
	|	x='!' -> OP_NOT[$x]
	;
orOp 
	:	x='or' -> OP_OR[$x]
	|	x='||' -> OP_OR[$x]
	;
andOp
	:	x='and' -> OP_AND[$x]
	|	x='&&'  -> OP_AND[$x]
	;
modulusOp
	:	x='mod' -> OP_MODULUS[$x]
	|	x='%'   -> OP_MODULUS[$x]
	;
equalsOp
	:	x='==' -> OP_EQ[$x] 
	|	x='='  -> OP_EQ[$x]
	;
notEqualsOp
	:	x='!=' -> OP_NE[$x]
	|	x='<>' -> OP_NE[$x]
	;
ltOp
	:	x='<' -> OP_LT[$x]
	;
gtOp
	:	x='>' -> OP_GT[$x]
	;
lteOp
	:	x='<=' -> OP_LTE[$x]
	;
gteOp
	:	x='>=' -> OP_GTE[$x]
	;
addOp
	:	x='+' -> OP_ADD[$x]
	;
subtractOp
	:	x='-' -> OP_SUBTRACT[$x]
	;
multiplyOp
	:	x='*' -> OP_MULTIPLY[$x]
	;
divideOp
	:	x='/' -> OP_DIVIDE[$x]
	;
unaryNegationOp
	:	x='-' -> OP_UNARY_NEGATION[$x]
	;
assignmentOp
	:	x='=' -> OP_ASSIGN[$x]
	;
// END OPERATORS


// BEGIN ENTITY 

entityChain
	:	 ( thisKeyword | filteredEntity ) ( '.'^ filteredEntity )*
	;
entityChainNoFilter
	:	entity ( '.'^ entity )*
	;
filteredEntity 
	:	entity^ criteria?
	;
thisKeyword
	:	x='this' -> THIS[$x]
	;
entity
//	:	ID -> ^( ENTITY ID )
	:	x=ID -> ENTITY[$x]
	;
criteria
	:	'[' expression ']' -> ^( CRITERIA expression )
	;

// END ENTITY

		
functionCall
	:	x=ID '(' ( expression ( ',' expression )* )? ')' -> ^( FUNCTION[$x] expression* )
	;


// MISC
	
identifier
	:	ID -> ^( IDENTIFIER ID )
	;	
number
	: 	INT 
	| 	FLOAT
	;
booleanValue
	:	x='true' -> TRUE[$x]
	|	x='false' -> FALSE[$x]
	;
		
/*----------------------------------------------------------
 * LEXER RULES
 *----------------------------------------------------------*/

	
LITERAL
	:	DQUOT ~DQUOT* DQUOT
	|	SQUOT ~SQUOT* SQUOT
	;
	
SQUOT
	:	'\''
	;
DQUOT
	:	'"'
	;
 
ID  :	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*
    ;

INT :	'0'..'9'+
    ;

FLOAT
    :   ('0'..'9')+ '.' ('0'..'9')* EXPONENT?
    |   '.' ('0'..'9')+ EXPONENT?
    |   ('0'..'9')+ EXPONENT
    ;

COMMENT
    :   '//' ~('\n'|'\r')* '\r'? '\n' {$channel=HIDDEN;}
    |   '/*' ( options {greedy=false;} : . )* '*/' {$channel=HIDDEN;}
    ;

WS  :   ( ' '
        | '\t'
        | '\r'
        | '\n'
        ) {$channel=HIDDEN;}
    ;

STRING
    :  '"' ( ESC_SEQ | ~('\\'|'"') )* '"'
    ;

CHAR:  '\'' ( ESC_SEQ | ~('\''|'\\') ) '\''
    ;

fragment
EXPONENT : ('e'|'E') ('+'|'-')? ('0'..'9')+ ;

fragment
HEX_DIGIT : ('0'..'9'|'a'..'f'|'A'..'F') ;

fragment
ESC_SEQ
    :   '\\' ('b'|'t'|'n'|'f'|'r'|'\"'|'\''|'\\')
    |   UNICODE_ESC
    |   OCTAL_ESC
    ;

fragment
OCTAL_ESC
    :   '\\' ('0'..'3') ('0'..'7') ('0'..'7')
    |   '\\' ('0'..'7') ('0'..'7')
    |   '\\' ('0'..'7')
    ;

fragment
UNICODE_ESC
    :   '\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
    ;
