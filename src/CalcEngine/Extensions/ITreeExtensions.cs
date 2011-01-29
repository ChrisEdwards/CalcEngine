using Antlr.Runtime.Tree;


namespace CalcEngine.Extensions
{
	internal static class TreeExtensions
	{
		/// <summary>
		/// Gets the first child of a node.
		/// </summary>
		/// <param name="node">The node to get the first child of.</param>
		/// <returns>The first child of this node.</returns>
		internal static ITree FirstChild( this ITree node )
		{
			return node.GetChild( 0 );
		}
	}
}