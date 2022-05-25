using System.Reflection;
namespace FifthTask
{
    class Program
    {
        private static string fileName = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\Database.txt";

        static void FilingBase(string[] files)
        {
            foreach (var file in files)
            {
                try
                {
                    var fileInf = new FileInfo(file);
                    var fileData = new FileData(fileInf.Extension, fileInf.Length, fileInf.CreationTime, fileInf.Name);
                    File.AppendAllText(fileName, fileData.GetString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }
        static void TraverseTree(string path)
        {
            var dir = new Stack<string>();//создали стек для хранения всех папок
            if (!Directory.Exists(path)) //проверяем, существует ли данная дирректория и если существует, то =>
            {
                throw new ArgumentException();
            }
            dir.Push(path);//=> то добавляем в стек для обхода
            while (dir.Count > 0)
            {
                var currentDir = dir.Pop(); // извлекаем и возвращаем текущую дирректорию их стека
                string[] subDirs; //список поддиректорий
                try
                {
                    subDirs = Directory.GetDirectories(currentDir); //получаем массив поддиректорий текущей дирректории
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                string[] files; //массив файлов текущей дирректории
                try
                {
                    files = Directory.GetFiles(currentDir);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                FilingBase(files);
                foreach (var str in subDirs)
                    dir.Push(str);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите дирректорию, которую хотите проанализировать: ");
            var path = Console.ReadLine();
            TraverseTree(path);
        }

    } 
}

