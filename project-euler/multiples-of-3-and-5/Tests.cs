using NUnit.Framework;

namespace multiples_of_3_and_5
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void GivesCorrectSum()
        {
            var multipleSumService = new MultipleSumService();

            var sum = multipleSumService.CalculateSum();

            Assert.That(sum, Is.EqualTo(233168));
        }
    }
}