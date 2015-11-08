using System;
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

        [Test]
        public void ThrowsForNumbersBelowTwo()
        {
            var service = new LargestPrimeFactorService();
            Assert.Throws<InvalidOperationException>(() => service.CalculateLargestPrimeFactor(1));
        }

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(11)]
        [TestCase(13)]
        [TestCase(17)]
        [TestCase(19)]
        [TestCase(23)]
        [TestCase(233)]
        [TestCase(677)]
        [TestCase(701)]
        [TestCase(997)]
        public void NumberIsPrime(int value)
        {
            var number = new Number(value);

            var isPrime = number.IsPrime();

            Assert.True(isPrime);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(4)]
        [TestCase(6)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        [TestCase(12)]
        [TestCase(14)]
        [TestCase(15)]
        [TestCase(16)]
        [TestCase(18)]
        [TestCase(20)]
        [TestCase(77)]
        [TestCase(490)]
        [TestCase(681)]
        public void NumberIsNotPrime(int value)
        {
            var number = new Number(value);

            var isPrime = number.IsPrime();

            Assert.False(isPrime);
        }
    }
}