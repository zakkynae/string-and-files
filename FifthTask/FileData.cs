using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthTask
{
    internal class FileData
    {
        public string Name;
        public string Extension;
        public long Length;
        public DateTime DateOfCreation;

        public FileData(string extension, long length, DateTime dateOfCreation, string name)
        {
            Extension = extension;
            Length = length;
            DateOfCreation = dateOfCreation;
            Name = name;
        }

        public string GetString() => $"Имя файла: {Name} Разрешение файла: {Extension} Размер файла: {Length} Дата содания: {DateOfCreation}\n";
    }
}
