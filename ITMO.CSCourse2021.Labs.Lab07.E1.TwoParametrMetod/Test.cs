using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 7. Создание и использование ссылочных переменных
Упражнение 1. Добавление метода экземпляра с двумя параметрами.
*/


namespace ITMO.CSCourse2021.Labs.Lab07.E1.TwoParametrMetod
{
    class Test
    {
        public static void Main()
        {
            BankAccount b1 = new BankAccount();
            b1.Populate(100);

            BankAccount b2 = new BankAccount();
            b2.Populate(100);

            Console.WriteLine("Before transfer");
            Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance());
            Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance());

            b1.TransferFrom(b2, 10);

            Console.WriteLine("After transfer");
            Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance());
            Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance());
        }

    }
}
