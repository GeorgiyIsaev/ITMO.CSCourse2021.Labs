using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 7. Создание и использование ссылочных переменных*/
/*Упражнение 4. Проверка наличия реализации интерфейса*/

namespace ITMO.CSCourse2021.Labs.Lab07.E4.IsItFormattable
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            ulong ul = 0;
            string s = "Test";

            Console.WriteLine("int: {0}", Utils.IsItFormattable(i));
            Console.WriteLine("ulong: {0}", Utils.IsItFormattable(ul));
            Console.WriteLine("String: {0}", Utils.IsItFormattable(s));


        }
    }
}
