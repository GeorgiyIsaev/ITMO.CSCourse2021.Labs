using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Лабораторная работа 5. Создание и использование массивов*/
/*Упражнение 1. Работа с массивами размерных типов.*/
/*Считайте содержимое текстового файла в массив*/

namespace ITMO.CSCourse2021.Labs.Lab05._02
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            int size = (int)stream.Length;
            char[] contents = new char[size];
            for (int i = 0; i < size; i++)
            {
                contents[i] = (char)reader.Read();
            }
            foreach (char ch in contents)
            {
                Console.Write(ch);
            }
            Console.ReadKey();
        }
    }
}
