using IceCreamParlor;

namespace IceCreamParlorTest
{
    public class Tests
    {
        List<int> arrayPrices1 = new List<int>();
        List<int> arrayPrices2 = new List<int>();
        int money = 0;

        [SetUp]
        public void Setup()
        {
            arrayPrices1 = new List<int> { 1, 4, 5, 3, 2 };
            arrayPrices2 = new List<int> { 2, 2, 4, 3 };
            money = 4;
        }

        //This test is on the description of the problem
        [Test]
        public void TestFirstUse()
        {
            List<int> expectedList = new List<int> { 1, 4 };
            List<int> result = Result.IcecreamParlor(money, arrayPrices1);

            Assert.That(result, Is.EqualTo(expectedList));
        }

        //This test is in the description of the problem
        [Test]
        public void TestSecondUse()
        {
            List<int> expectedList = new List<int> { 1, 2 };
            List<int> result = Result.IcecreamParlor(money, arrayPrices2);

            Assert.That(result, Is.EqualTo(expectedList));
        }

        //Own tests
        [Test]
        public void TestThirdList()
        {
            List<int> expectedList = new List<int> { 2, 4 };
            List<int> arrayOfPrices = new List<int> { 4, 1, 5, 3, 2 };
            List<int> result = Result.IcecreamParlor(money, arrayOfPrices);

            Assert.That(result, Is.EqualTo(expectedList));
        }

        [Test]
        public void TestFourthList()
        {
            List<int> expectedList = new List<int> { 1, 2 };
            List<int> arrayOfPrices = new List<int> { 4, 1, 5, 3, 2 };
            money = 5;
            List<int> result = Result.IcecreamParlor(money, arrayOfPrices);

            Assert.That(result, Is.EqualTo(expectedList));
        }

        [Test]
        public void TestFithList()
        {
            List<int> expectedList = new List<int> { 1, 5 };
            List<int> arrayOfPrices = new List<int> { 4, 1, 5, 3, 2 };
            money = 6;
            List<int> result = Result.IcecreamParlor(money, arrayOfPrices);

            Assert.That(result, Is.EqualTo(expectedList));
        }
    }
}