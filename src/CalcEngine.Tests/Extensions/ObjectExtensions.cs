namespace CalcEngine.Tests.Extensions
{
	public static class ObjectExtensions
	{
		/// <summary>
		/// Casts the specific object as the specified type.
		/// </summary>
		/// <typeparam name="T">The type to cast the object as</typeparam>
		/// <param name="obj">The object to cast.</param>
		/// <returns></returns>
		public static T As<T>(this object obj)
		{
			return (T)obj;
		}
	}
}