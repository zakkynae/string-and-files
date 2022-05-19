Console.Write("Введите предложение: ");
var phrase = Console.ReadLine();
Console.Write("Введите букву: ");
var letter = char.Parse(Console.ReadLine());
PrintPercent(phrase, letter);

void PrintPercent(string text, char symbol)
{
    var count = 0;
    var length = 0;
    foreach (var letter in text)
    {
        if(Char.ToLower(letter) == Char.ToLower(symbol)) count++;
        if(Char.IsLetter(letter)) length++;
    }
    Console.WriteLine($"Процент содержания буквы {symbol} в предложении - {(double)count / (double)length}");
}

