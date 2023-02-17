using CodeWars.Katas.Kyu6;

namespace CodeWars.Tests.Kyu6
{
    public class SumOfDigits_DigitalRootTests
    {
        [TestFixture]
        public class NumberTest
        {
            [TestCase(0, ExpectedResult = 0)]
            [TestCase(10, ExpectedResult = 1)]
            [TestCase(16, ExpectedResult = 7)]
            [TestCase(195, ExpectedResult = 6)]
            [TestCase(992, ExpectedResult = 2)]
            [TestCase(167346, ExpectedResult = 9)]
            [TestCase(999999999999, ExpectedResult = 9)]
            [TestCase(6185037353081530669, ExpectedResult = 7)]
            public int Tests(long n)
            {
                return SumOfDigits_DigitalRoot.DigitalRoot(n);
            }
        }
    }
}
