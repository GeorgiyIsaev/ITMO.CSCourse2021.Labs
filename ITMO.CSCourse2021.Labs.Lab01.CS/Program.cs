using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 1. Создание простой C#-программы */

namespace ITMO.CSCourse2021.Labs.Lab01.CS
{
    class Greeter
    {
        static void Main(string[] args)
        {
            /*Упражнение 1.Создание простой программы*/
            /*Упражнение 2.Компиляция и запуск C#-программы из командной строки*/
            /*Упражнение 3.Использование отладчика Visual Studio.NET*/
            string address = System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory();
            Console.WriteLine("address: {0}", address);
            Console.WriteLine("Please enter your name");
            string myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);
           
            /*Упражнение 4. Добавление в C#-программу обработчика исключительных ситуаций*/
            try
            {
                Console.WriteLine("Please enter the first integer");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);

                Console.WriteLine("Please enter the second integer");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);

                int k = i / j;
                Console.WriteLine("The result of dividing {0} by {1} is {2}", i, j, k);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }
            Console.Read();

        }

    }
}
