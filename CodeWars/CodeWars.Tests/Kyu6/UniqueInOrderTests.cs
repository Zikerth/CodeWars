using CodeWars.Katas.Kyu6;

namespace CodeWars.Tests.Kyu6
{
    public class UniqueInOrderTests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void EmptyTest()
            {
                Assert.That(UniqueInOrder_Kata.UniqueInOrder(""), Is.EqualTo(""));
            }
            [Test]
            public void Test1()
            {
                Assert.That(UniqueInOrder_Kata.UniqueInOrder("AAAABBBCCDAABBB"), Is.EqualTo("ABCDAB"));
            }
            [Test]
            public void Test2()
            {
                Assert.That(UniqueInOrder_Kata.UniqueInOrder(new int[]{1, 2, 2, 3, 3}), Is.EqualTo(new int[] { 1, 2, 3 }));
            }
        }
    }
}
