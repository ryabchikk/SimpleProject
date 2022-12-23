using NUnit.Framework;

namespace SimpleProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMult()
        {
            Assert.Pass();
            Assert.IsTrue(Program.MultiplyTwoNumbers(10, 2)==20);
            Assert.IsTrue(Program.MultiplyTwoNumbers(2, 2) != 5);
        }
        
        [Test]
        public void TestSum()
        {
            Assert.Pass();
            Assert.IsTrue(Program.SumTwoNumbers(10, 2) == 12);
            Assert.IsTrue(Program.SumTwoNumbers(2, 2) != 5);
        }

        [Test]
        public void TestSub()
        {
            Assert.Pass();
            Assert.IsTrue(Program.SubtractTwoNumbers(10, 2) == 8);
            Assert.IsTrue(Program.SubtractTwoNumbers(2, 2) != -1);
        }
    }
}