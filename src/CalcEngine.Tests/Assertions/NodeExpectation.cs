using System;
using CalcEngine.Expressions;


namespace CalcEngine.Tests.Assertions
{
	public class NodeExpectation
	{

		private readonly Action< AstNode > _assertionMethod;


		public NodeExpectation( Action< AstNode > assertionMethod )
		{
			_assertionMethod = assertionMethod;
		}


		public void AssertIsSatisfiedBy( AstNode node )
		{
			_assertionMethod( node );
		}
	}
}