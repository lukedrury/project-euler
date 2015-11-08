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
    }
}