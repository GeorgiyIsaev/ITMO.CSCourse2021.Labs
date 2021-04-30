using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 2. Создание и использование размерных типов данных*/

namespace TMO.CSCourse2021.Labs.Lab02_Struct
{
    public enum AccountType { Checking, Deposit }

    public struct BankAccount 
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }


    class Struct
    {
        static void Main(string[] args)
        {
            /*Упражнение 2. Создание и использование структуры*/
            BankAccount goldAccount;
            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            goldAccount.accNo = 123;
            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Acct Number {0}", goldAccount.accNo);
            Console.WriteLine("Acct Type {0}", goldAccount.accType);
            Console.WriteLine("Acct Balance ${0}", goldAccount.accBal);
            Console.ReadKey();

            /*Упражнение 3.Добавление возможности ввода/ вывода*/
            Console.Write("Enter account number: ");
            goldAccount.accNo = long.Parse(Console.ReadLine());
            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Acct Number {0}", goldAccount.accNo);
            Console.WriteLine("Acct Type {0}", goldAccount.accType);
            Console.WriteLine("Acct Balance ${0}", goldAccount.accBal);
            Console.ReadKey();
        }
    }
}
