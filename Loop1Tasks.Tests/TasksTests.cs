using NUnit.Framework;

namespace Loop1Tasks.Tests
{
    [TestFixture]
    public class TasksTests
    {
        [TestCase(1, 12, 42)]
        [TestCase(5, 25, 150)]
        [TestCase(14, 30, 198)]
        public void Task1_ReturnsCorrectValue(int n, int m, int expected)
        {            
            var actual = Tasks.Task1(n, m);
            Assert.AreEqual(expected, actual, "Task1 returns incorrect value.");
        }

        [TestCase(1, 9, 25)]
        [TestCase(9, 25, 153)]
        [TestCase(15, 30, 176)]
        public void Task2_ReturnsCorrectValue(int n, int m, int expected)
        {
            var actual = Tasks.Task2(n, m);
            Assert.AreEqual(expected, actual, "Task2 returns incorrect value.");
        }

        [TestCase(465780, 30)]
        [TestCase(598469, 41)]
        [TestCase(6502, 13)]
        public void Task3_ReturnsCorrectValue(int n, int expected)
        {
            var actual = Tasks.Task3(n);
            Assert.AreEqual(expected, actual, "Task3 returns incorrect value.");
        }
    }
}
