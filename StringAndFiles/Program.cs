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
Console.WriteLine($"Верно ли, что в предложении есть 5 подряд идущих одинаковых символов? {ContainsFiveLetters(phrase)}");
Console.WriteLine($"Фраза в обратном порядке - {ReverseText(phrase)}");

#region Кол-во вхождения буквы 
double CountPercent(string text, char symbol)
{
    var count = 0;
    var length = 0;
    foreach (var letter in text)
    {
        if(Char.ToLower(letter) == Char.ToLower(symbol)) count++;
        if(Char.IsLetter(letter)) length++;
    }
    return 100 * count / length;
}
#endregion
#region Кол-во вхождений подстроки
int CountOccurrences(string text, string subString) => (text.Length - text.ToLower().Replace(subString.ToLower(),
    "").Length) / subString.Length;
#endregion
#region Кол-во слов в предложении
int CountWords(string text) => text.Split(' ').Length;
#endregion
#region Кол-во гласных букв
int CountVowels(string text)
{
    var vowelLetters = new List <char> { 'а', 'и', 'е', 'ё', 'о', 'у', 'ы', 'э', 'ю', 'я'};
    var count = 0;
    foreach (var letter in text)
        if(vowelLetters.Contains(Char.ToLower(letter))) count++;
    return count;
}
#endregion
#region Наличие 5 одинаковых символов
string ContainsFiveLetters(string text)
{
    var count = 1;
    for(int i = 0; i < text.Length - 1; i++)
    {
        if (count == 5) break;
        if (Char.ToLower(text[i]) == Char.ToLower(text[i + 1])) count++;
        else count = 1;
    }
    return count < 5 ? "Не правда" : "Правда";
}
#endregion
#region Строка наоборот
string ReverseText(string text)
{
    var reverseText = text.Split(' ').Reverse();
    return String.Join(" ", reverseText);
}
#endregion


