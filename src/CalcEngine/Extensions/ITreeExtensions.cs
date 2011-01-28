using Antlr.Runtime.Tree;


namespace CalcEngine.Extensions
{
	internal static class TreeExtensions
	{
		/// <summary>
		/// Gets the first child of a node.
		/// </summary>
		/// <param name="node">The node.</param>
		/// <returns></returns>
		internal static ITree FirstChild( this ITree node )
		{
			return node.GetChild( 0 );
		}
	}
}