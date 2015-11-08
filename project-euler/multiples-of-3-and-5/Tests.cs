using NUnit.Framework;

namespace multiples_of_3_and_5
{
    [TestFixture]
    public class Tests
    {
        [TestCase(10, 23)]
        [TestCase(100, 2318)]
        [TestCase(1000, 233168)]
        [TestCase(10000, 23331668)]
        public void GivesCorrectSum(int upperLimit, int expectedSum)
        {
            var multipleSumService = new MultipleSumService();

            var sum = multipleSumService.CalculateSum(upperLimit);

            Assert.That(sum, Is.EqualTo(expectedSum));
        }
    }
}