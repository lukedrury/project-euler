using NUnit.Framework;

namespace largest_prime_factor
{
    [TestFixture]
    public class Tests
    {
        [TestCase(13195, 29)]
        public void CorrectLargestPrimeFactor(int target, int expectedLargestPrimeFactor)
        {
            var service =  new LargestPrimeFactorService();

            var largestPrimeFactor = service.CalculateLargestPrimeFactor(target);

            Assert.That(largestPrimeFactor, Is.EqualTo(expectedLargestPrimeFactor));
        }

        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        public void NumberKnowsIfItIsPrime(int value, bool expectedIsPrime)
        {
            var number = new Number(value);

            var isPrime = number.IsPrime();

            Assert.That(isPrime, Is.EqualTo(expectedIsPrime));
        }
    }
}