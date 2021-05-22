using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 5. Создание и использование массивов*/
/*Упражнение 1. Работа с массивами размерных типов.*/
/*Систематизируйте и резюмируйте информацию о содержимом файла*/

namespace ITMO.CSCourse2021.Labs.Lab05.E1.ArgumentsMain.v3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            char[] contents;
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                StreamReader reader = new StreamReader(stream);
                int size = (int)stream.Length;
                contents = new char[size];
                for (int i = 0; i < size; i++)
                {
                    contents[i] = (char)reader.Read();
                }
                FileDetails.Summarize(contents);               
            }
            foreach (char ch in contents)
            {
                Console.Write(ch);
            }
            Console.ReadKey();
        }
    }
}
