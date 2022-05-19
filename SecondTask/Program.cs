Console.Write("Введите текст: ");
var text = Console.ReadLine();
Console.WriteLine($"Кол-во цифр в тексте - {CountDigits(text)}");
Console.WriteLine($"Порядковый номер 9 - {text.IndexOf('9') + 1}");
Console.WriteLine($"Наибольшее кол-во идущих подряд одинаковых символов - {CountChars(text)}");

int CountDigits(string text)
{
    var count = 0;
    foreach (var element in text)
        if (Char.IsDigit(element)) count++;
    return count;
}
int CountChars(string text)
{
    var count = 1;
    var max = 1;
    var chars = text.ToCharArray();

    for(int i = 0; i < chars.Length - 1; i++)
    {
        if (chars[i] == chars[i + 1])
        {
            count++;
            if (count > max) max = count;
        }
        else count = 1;        
    }
    return max;
}
