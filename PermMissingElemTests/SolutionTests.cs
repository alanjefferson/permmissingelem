using NUnit.Framework;
using PermMissingElem;

namespace PermMissingElemTests
{
	public class Tests
	{
		private Solution _solution { get; set; } = null!;

		[SetUp]
		public void Setup()
		{
			_solution = new Solution();
		}

		[Test]
		public void PermMissingElem_Test1()
		{
			int result = _solution.solution(new int[] { 2, 3, 1, 5 });
			Assert.AreEqual(4, result);
		}

		[Test]
		public void PermMissingElem_Test2()
		{
			int result = _solution.solution(new int[] { 6, 2, 4, 5 });
			Assert.AreEqual(3, result);
		}
	}
}