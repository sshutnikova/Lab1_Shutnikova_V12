using NUnit.Framework;
using ConsoleApp_lab1;

namespace TestProject1
{
    public class ProgramTests
    {
        [Test]
        public void TestExpression1()
        {
            double x = 1, y = 2, a = 3;
            double expected = 48.167;
            double result = Program.Calculate1(x, y, a);
            Assert.AreEqual(expected, result, 0.001);
        }

        [Test]
        public void TestExpression2()
        {
            double x = 1, y = 2, a = 3;
            double expected = 7.649;
            double result = Program.Calculate2(x, y, a);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}