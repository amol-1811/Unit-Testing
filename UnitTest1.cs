using System.Reflection;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Unit_Testing
{
    public class Tests
    {
        private Program program;
        private PrimeNum prime;

        [SetUp]
        public void Setup()
        {
            program = new Program();
            prime = new PrimeNum();
            
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
    }
}