using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 8. Создание объектов и управление ресурсами*/
/*Упражнение 3. Использование шаблона для удаления объектов*/

namespace ITMO.CSCourse2021.Labs.Lab08.E3.PatternRemoveObject
{
    class CreateAccount
    {
        static void Main()
        {
            using (BankAccount acc1 = new BankAccount())
            {
                acc1.Deposit(100);
                acc1.Withdraw(50);
                acc1.Deposit(75);
                acc1.Withdraw(50);
                acc1.Withdraw(30);
                acc1.Deposit(40);
                acc1.Deposit(200);
                acc1.Withdraw(250);
                acc1.Deposit(25);
                Write(acc1);
            }

            Console.ReadKey();
        }

        static void Write(BankAccount acc)
        {
            Console.WriteLine("Account number is {0}", acc.Number());
            Console.WriteLine("Account balance is {0}", acc.Balance());
            Console.WriteLine("Account type is {0}", acc.Type());
            Console.WriteLine("Transactions:");
            foreach (BankTransaction tran in acc.Transactions())
            {
                Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
            }
            Console.WriteLine();
        }

    }
}
