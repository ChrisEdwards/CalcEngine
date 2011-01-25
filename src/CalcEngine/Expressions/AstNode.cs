using System;
using System.Collections.Generic;
using System.Threading;


namespace CalcEngine.Expressions
{
	/// <summary>
	/// Implementaion of the INode interface defining the base node object comprising a
	/// nodetree.
	/// </summary>
	public abstract class AstNode : ICloneable
	{
		/// <summary>
		/// The child nodes of this parent node.
		/// </summary>
		private List< AstNode > _children;

		/// <summary>
		/// The unique identifier for this node.
		/// </summary>
		private readonly int _id = _staticId;

		/// <summary>
		/// The parent node this child node belongs to.
		/// </summary>
		private AstNode _parent;

		/// <summary>
		/// Static counter used to automatically assign unique IDs to nodes.
		/// </summary>
		private static int _staticId;


		/// <summary>
		/// Creates a default AstNode object auto-assigning the ID.
		/// </summary>
		internal AstNode()
		{
			Interlocked.Increment( ref _staticId );
		}


		/// <summary>
		/// Accept a visitor object.
		/// <p> This is an implementation of the AcyclicVisitor pattern by Robert C. Martin.
		/// Details of the pattern and its usage can be found at ObjectMentor.com.<br /> URL:
		/// http://www.objectmentor.com/resources/articles/acv.pdf
		/// </p>
		/// </summary>
		/// <param name="visitor">Visitor object to call the "visit" upon.</param>
		/// <param name="sessionData">Data relevant to the visitor's visit.</param>
		/// <returns>object</returns>
		internal abstract object Accept( IAstNodeVisitor visitor, object sessionData );


		/// <summary>
		/// Adds a new child node.
		/// </summary>
		/// <param name="node">The node to add.</param>
		public virtual void AddChild( AstNode node )
		{
			if ( _children == null )
				_children = new List< AstNode >();
			_children.Add( node );
			node._parent = this;
		}


		/// <summary>
		/// Accept a visitor object to all the child nodes of this node.
		/// </summary>
		/// <param name="visitor">Visitor object to call the "visit" upon.</param>
		/// <param name="data">Data relevant to the visitor's visit.</param>
		/// <returns>object</returns>
		internal virtual object ChildrenAccept( IAstNodeVisitor visitor, object data )
		{
			if ( _children != null )
			{
				foreach ( AstNode t in _children )
					t.Accept( visitor, data );
			}
			return data;
		}


		/// <summary>
		/// Compares two nodes to see if they are equal.
		/// </summary>
		/// <param name="node1">First node to check.</param>
		/// <param name="node2">Second node to check.</param>
		/// <returns>boolean - true if children matched</returns>
		internal bool ChildrenEqual( AstNode node1, AstNode node2 )
		{
			if ( ( node1.Children != null ) || ( node2.Children != null ) )
			{
				if ( ( ( node1.Children == null ) || ( node2.Children == null ) ) || ( node1.Children.Count != node2.Children.Count ) )
					return false;
				for ( int j = 0; j < node1.Children.Count; j++ )
				{
					if ( !node1.GetChild( j ).Equals( node2.GetChild( j ) ) )
						return false;
				}
			}
			return true;
		}


		public object Clone()
		{
			throw new Exception( "The method or operation is not implemented." );
		}


		/// <summary>
		/// Retrieves a child node by index. 
		/// </summary>
		/// <param name="index">Zero-based index of the child node to retrtieve.</param>
		/// <returns>AstNode child</returns>
		public virtual AstNode GetChild( int index )
		{
			return _children[index];
		}


		/// <summary>
		/// The child nodes of this parent node.
		/// </summary>
		internal List< AstNode > Children
		{
			get { return _children; }
		}

		/// <summary>
		/// The unique identifier for this node.
		/// Not currently used, but will be required in the future.
		/// </summary>
		internal virtual int Id
		{
			get { return _id; }
		}

		/// <summary>
		/// Retrieves the number of child nodes under this node.
		/// </summary>
		public int NumChildren
		{
			get
			{
				if ( _children != null )
					return _children.Count;
				return 0;
			}
		}

		/// <summary>
		/// The parent node this child node belongs to.
		/// </summary>
		public AstNode Parent
		{
			get { return _parent; }
			set { _parent = value; }
		}

		public virtual int Type
		{
			get { throw new Exception( "The method or operation is not implemented." ); }
			set { throw new Exception( "The method or operation is not implemented." ); }
		}
	}
}