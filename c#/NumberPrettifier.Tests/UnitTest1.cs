using NUnit.Framework;
using NumberPrettifier;

namespace NumberPrettifier.Tests
{
    public class PrettifyNumberTests
    {
        [TestCase(532, "532")]
        [TestCase(1000000, "1M")]
        [TestCase(2500000.34, "2.5M")]
        [TestCase(1123456789, "1.1B")]
        [TestCase(1000000000000, "1T")]
        public void TestPrettifyNumber(double input, string expected)
        {
            Assert.AreEqual(expected, Program.PrettifyNumber(input));
        }
    }
}
