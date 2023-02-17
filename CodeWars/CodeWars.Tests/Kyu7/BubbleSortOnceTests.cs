
using CodeWars.Katas.Kyu7;

namespace CodeWars.Tests.Kyu7
{
    public class BubbleSortOnceTests
    {
        [Test]
        public void ExampleTest()
        {
            // Example test case from description

            var expected = new int[] { 7, 5, 3, 1, 2, 4, 6, 8, 9 };
            var actual = new int[] { 9, 7, 5, 3, 1, 2, 4, 6, 8 };
            Assert.That(BubbleSortOnce.BubbleSort(actual), Is.EqualTo(expected));
        }
    }
}
