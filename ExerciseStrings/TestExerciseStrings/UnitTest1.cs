using ExerciseStrings;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStep1()
        {
            SumIntFromString s = new SumIntFromString();
            var n = s.Add("");
            Assert.True(n == 0, "Result is " + n);
            n = s.Add("1");
            Assert.True(n == 1);
            n = s.Add("1,2");
            Assert.True(n == 3);
        }

        [Test]
        public void TestStep2()
        {
            SumIntFromString s = new SumIntFromString();
            Assert.True(s.Add("1,2,3,4,5") == 15);
        }

        [Test]
        public void TestStep3()
        {
            SumIntFromString s = new SumIntFromString();
            Assert.Throws<NegativeNotAllowedException>(() => { s.Add("1,-2,3,4,5"); });
        }

        [Test]
        public void TestStep4()
        {
            SumIntFromString s = new SumIntFromString();
            Assert.True(s.Add("1000,2") == 2);
        }

        [Test]
        public void TestStep5()
        {
            SumIntFromString s = new SumIntFromString();
            Assert.True(s.Add("//[***]//1***2***3") == 6);
        }

        [Test]
        public void TestStep6()
        {
            SumIntFromString s = new SumIntFromString();
            Assert.True(s.Add("//[*][%]//1*2%3") == 6);
        }

        [Test]
        public void TestStep7()
        {
            SumIntFromString s = new SumIntFromString();
            Assert.True(s.Add("//[*.][%.]//1*.2%.3") == 6);
        }
    }
}