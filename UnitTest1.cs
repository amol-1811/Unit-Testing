using System.Reflection;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Unit_Testing
{
    public class Tests
    {
        private Program program;
        private PrimeNum prime;
        private LeapYear leap;

        [SetUp]
        public void Setup()
        {
            program = new Program();
            prime = new PrimeNum();
            leap = new LeapYear();
            
        }

        [Test]
        public void SumAndDiff()
        {
            var program = new Program();

            int a = 5;
            int b = 10;

            var result = program.Addition(a, b);

            Assert.AreEqual(15, result);
        }

        [Test]
        public void CheckPrime()
        {
            int n = 10;

            var result = PrimeNum.IsPrime(n);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void CheckLeapYear()
        {
            int n = 2000;

            var res = LeapYear.IsLeapYear(n);

            Assert.AreEqual(true, res);
        }
    }
}