using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 5. Создание и использование массивов*/
/*Упражнение 01: Запуск приложения с аргументами*/
namespace ITMO.CSCourse2021.Labs.Lab05.E1.ArgumentsMain.v1.HelpInfo
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
            /* Запуска приложения с аргументами
            * Вариант 01: 1. Открыть командную строку
            * 2. Кинуть скомпилированный файл .exe в командную строку
            * 3. После полного имени файла через пробел ввести несколько аргументов:
            C:\Users\Isaev>C:\Repository\ITMO.CSCourse2021.Labs\ITMO.CSCourse2021.Lab
            s.Lab05._01\bin\Debug\ITMO.CSCourse2021.Labs.Lab05._01.exe help notHelp
            * Вариант 02: Создать ярылк .exe-файла, в свойствах у полного имени 
            * объекта прописать аргументы после знака тире:  
            C:\Repository\ITMO.CSCourse2021.Labs\ITMO.CSCourse2021.Labs.Lab05._01
            \bin\Debug \ITMO.CSCourse2021.Labs.Lab05._01.exe -help nothelp
            */


        }
    }
}
