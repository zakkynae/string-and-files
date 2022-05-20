using System.Text;
Console.Write("Введите текст: ");
var text = Console.ReadLine();
Console.Write("Введите желаемую длину текста: ");
var newlength = int.Parse(Console.ReadLine());
ChangingLength(text, newlength);

void ChangingLength(string text, int newlength)
{
    var textLength = text.Length;// длина всего текста м м м - 5 м м м м - 7
    var countSplintters = textLength - text.Replace(" ", "").Length;//кол-во пробелов м м м(5) - ммм(3) = 2 м м м м(7) - мммм(4) = 3
    var splittersLength = newlength - text.Replace(" ", "").Length; //общая длина разделителей для новой длины м   м   м(9) - ммм(3) = 6 м  м м м(8) - мммм(4) = 4
    var newSplitterLength = (int)(Math.Ceiling((double)splittersLength / countSplintters)); //Наибольшая длина одного разделителя
    var newSplitter = splittersLength % countSplintters; //сколько должно быть максимальнйо длины, если больше 0 то остаток = кол-ву наибольшей длины, если нуля то все одинаковые
    var words = text.Split(" ");
    var newText = new StringBuilder();
    var count = 0;
    if(newSplitter > 0)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (count < newSplitter)
            {
                newText.Append(words[i]);
                newText.Append(' ', newSplitterLength);
                count++;
            }
            else
            {
                newText.Append(words[i]);
                newText.Append(' ', newSplitterLength - 1);
            }
        }
    }
    else
    {
        for (int i = 0; i < words.Length; i++)
        {
            newText.Append(words[i]);
            newText.Append(' ', newSplitterLength);
        }
    }
    
    Console.WriteLine(textLength);
    Console.WriteLine(countSplintters);
    Console.WriteLine(splittersLength);
    Console.WriteLine(newSplitterLength);
    Console.WriteLine(newSplitter);
    Console.WriteLine(newText.ToString().Trim());
    Console.WriteLine(newText.ToString().Trim().Length);
}