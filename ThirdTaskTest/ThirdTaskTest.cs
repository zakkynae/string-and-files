using NUnit.Framework;
namespace ThirdTask.Test
{
    [TestFixture]
    public class Tests
    {
        [TestCase("()", "������ ����������� �����.")]
        [TestCase("(())", "������ ����������� �����.")]
        [TestCase("())", $"������ ����������� �������. ������� ������ �������� ������ 3")]
        [TestCase("(()", $"������ ����������� �������. ������� ������ �������� ������ 1")]
        [TestCase("", "������ ����������� �����.")]
        public void CheckBracketTest(string text, string answer)
        {
            Assert.AreEqual(answer, Program.CheckBracket(text));
        }
    }
}