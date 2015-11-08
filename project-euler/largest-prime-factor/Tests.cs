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
        [TestCase(5, true)]
        [TestCase(6, false)]
        [TestCase(7, true)]
        [TestCase(8, false)]
        [TestCase(9, false)]
        [TestCase(10, false)]
        [TestCase(11, true)]
        [TestCase(12, false)]
        [TestCase(13, true)]
        [TestCase(14, false)]
        [TestCase(15, false)]
        [TestCase(16, false)]
        [TestCase(17, true)]
        [TestCase(18, false)]
        [TestCase(19, true)]
        [TestCase(20, false)]
        [TestCase(23, true)]
        [TestCase(77, false)]
        [TestCase(233, true)]
        [TestCase(490, false)]
        [TestCase(677, true)]
        [TestCase(681, false)]
        [TestCase(701, true)]
        [TestCase(997, true)]
        public void NumberKnowsIfItIsPrime(int value, bool expectedIsPrime)
        {
            var number = new Number(value);

            var isPrime = number.IsPrime();

            Assert.That(isPrime, Is.EqualTo(expectedIsPrime));
        }
    }
}