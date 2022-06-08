namespace FourthTask.Test
{
    public class Tests
    {
        [TestCase("Мама мыла раму", 20, "Мама    мыла    раму")]
        [TestCase("Мама мыла раму", 21, "Мама     мыла    раму")]
        [TestCase("Мама мыла и раму", 19, "Мама  мыла  и  раму")]
        [TestCase("Мама мыла и раму", 20, "Мама   мыла  и  раму")]
        [TestCase("Мама мыла и раму", 21, "Мама   мыла   и  раму")]
        public void ChangingLengthTest(string text, int newlength, string result)
        {
            Assert.AreEqual(result, Program.ChangingLength(text, newlength));
        }
    }
}