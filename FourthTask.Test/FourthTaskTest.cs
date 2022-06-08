namespace FourthTask.Test
{
    public class Tests
    {
        [TestCase("���� ���� ����", 20, "����    ����    ����")]
        [TestCase("���� ���� ����", 21, "����     ����    ����")]
        [TestCase("���� ���� � ����", 19, "����  ����  �  ����")]
        [TestCase("���� ���� � ����", 20, "����   ����  �  ����")]
        [TestCase("���� ���� � ����", 21, "����   ����   �  ����")]
        public void ChangingLengthTest(string text, int newlength, string result)
        {
            Assert.AreEqual(result, Program.ChangingLength(text, newlength));
        }
    }
}