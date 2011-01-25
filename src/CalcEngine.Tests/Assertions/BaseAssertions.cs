using CalcEngine.Expressions;
using NUnit.Framework;


namespace CalcEngine.Tests.Assertions
{
	public static class BaseAssertions
	{
		/// <summary>
		/// Asserts the object is of the specified type using an NUnit assertion.
		/// </summary>
		/// <typeparam name="TExpectedType">The type this object should be</typeparam>
		/// <param name="testSubject">The object being tested.</param>
		public static void ShouldBe<TExpectedType>(this object testSubject)
		{
			Assert.IsInstanceOf<TExpectedType>(testSubject);
		}
	}
}