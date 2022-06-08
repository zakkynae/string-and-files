using NUnit.Framework;
namespace ThirdTask.Test
{
    [TestFixture]
    public class Tests
    {
        [TestCase("()", "Скобки расставлены верно.")]
        [TestCase("(())", "Скобки расставлены верно.")]
        [TestCase("())", $"Скобки расставлены неверно. Позиция первой неверной скобки 3")]
        [TestCase("(()", $"Скобки расставлены неверно. Позиция первой неверной скобки 1")]
        [TestCase("", "Скобки расставлены верно.")]
        public void CheckBracketTest(string text, string answer)
        {
            Assert.AreEqual(answer, Program.CheckBracket(text));
        }
    }
}