using NUnit.Framework;

namespace even_fibonacci_numbers
{
    [TestFixture]
    public class Tests
    {
        [TestCase(90, 44)]
        public void GivesCorrectSum(int upperLimit, int expectedSum)
        {
            var evenFibonacciSumService = new EvenFibonacciSumService();

            var sum = evenFibonacciSumService.CalculateSum(upperLimit);

            Assert.That(sum, Is.EqualTo(expectedSum));
        }
    }
}