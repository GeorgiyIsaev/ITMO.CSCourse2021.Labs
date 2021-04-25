using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 5. Создание и использование массивов*/
/*Упражнение 01: Запуск приложения с аргументами*/
namespace ITMO.CSCourse2021.Labs.Lab05._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.ReadKey();
            /* Запуска приложения с аругументами
             * 1. Открыть командную строку
             * 2. Кинуть скомпилированый файл .exe в командную строку
             * 3. После полного имяни через пробел ввести несколько аругметов:
            C:\Users\Isaev>C:\Repository\ITMO.CSCourse2021.Labs\ITMO.CSCourse2021.Lab
            s.Lab05._01\bin\Debug\ITMO.CSCourse2021.Labs.Lab05._01.exe help notHelp
             * Варинт 02: Создать ярылк .exe-файла, в свойствах у полного имени объекта
             прописать аргументы после знака тире:  
            C:\Repository\ITMO.CSCourse2021.Labs\ITMO.CSCourse2021.Labs.Lab0
            5._01\bin\Debug\ITMO.CSCourse2021.Labs.Lab05._01.exe -help nothelp
             */

        }
    }
}
