namespace ThirdTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            var text = Console.ReadLine();
            Console.WriteLine(CheckBracket(text));
        }
        public static string CheckBracket(string text)
        {
            var indexesBracket = new List<int>();
            for (int index = 0; index < text.Length; index++)
            {
                if (text[index] == '(')
                    indexesBracket.Add(index);
                else if (text[index] == ')')
                {
                    if (indexesBracket.Count > 0)
                        indexesBracket.Remove(indexesBracket.Count - 1);
                    else indexesBracket.Add(index);
                }
            }
            if (indexesBracket.Count != 0) return $"Скобки расставлены неверно. Позиция первой неверной скобки {indexesBracket[0] + 1}";
            else return "Скобки расставлены верно.";
        }
    }
}
