Console.Write("Введите предложение: ");
var phrase = Console.ReadLine();
Console.Write("Введите букву: ");
var letter = char.Parse(Console.ReadLine());
Console.WriteLine($"Процент содержания буквы {letter} в предложении - {CountPercent(phrase, letter)}%");
Console.Write("Введите буквосочетание: ");
var subString = Console.ReadLine();
Console.WriteLine($"Число вхождений буквосочетания {subString} - {CountOccurrences(phrase, subString)}");
Console.WriteLine($"Кол-во слов в предложении - {CountWords(phrase)}");
Console.WriteLine($"Кол-во гласных в предложении - {CountVowels(phrase)}");

double CountPercent(string text, char symbol)
{
    var count = 0;
    var length = 0;
    foreach (var letter in text)
    {
        if(Char.ToLower(letter) == Char.ToLower(symbol)) count++;
        if(Char.IsLetter(letter)) length++;
    }
    return Math.Round(100 * (double)count / length);
}

int CountOccurrences(string text, string subString) => (text.Length - text.ToLower().Replace(subString.ToLower(),
    "").Length) / subString.Length;

int CountWords(string text) => text.Split(' ').Length;

int CountVowels(string text)
{
    var vowelLetters = new List <char> { 'а', 'и', 'е', 'ё', 'о', 'у', 'ы', 'э', 'ю', 'я'};
    var count = 0;
    foreach (var letter in text)
        if(vowelLetters.Contains(Char.ToLower(letter))) count++;
    return count;
}


