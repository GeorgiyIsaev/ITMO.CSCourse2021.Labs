using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 11. Перегрузка операторов и использование событий*/
/*Упражнение 1. Перегрузка операторов для класса BankAccount*/

namespace ITMO.CSCourse2021.Labs.Lab11.E1.OverloadingMethods
{
    class CreateAccount
    {
		static void Main()
		{
			long accNo1 = Bank.CreateAccount(AccountType.Checking, 100);
			long accNo2 = Bank.CreateAccount(AccountType.Checking, 100);

			BankAccount acc1 = Bank.GetAccount(accNo1);
			BankAccount acc2 = Bank.GetAccount(accNo2);

			/*Тестрирование операторов равенства*/
			if (acc1 == acc2)
			{
				Console.WriteLine("Both accounts are the same. They should not be!");
			}
			else
			{
				Console.WriteLine("The accounts are different. Good!");
			}

			if (acc1 != acc2)
			{
				Console.WriteLine("The accounts are different. Good!");
			}
			else
			{
				Console.WriteLine("Both accounts are the same. They should not be!");
			}

			BankAccount acc3 = Bank.GetAccount(accNo1);
			if (acc1 == acc3)
			{
				Console.WriteLine("The accounts are the same. Good!");
			}
			else
			{
				Console.WriteLine("The accounts are different. They should not be!");
			}

			if (acc1 != acc3)
			{
				Console.WriteLine("The accounts are different. They should not be!");
			}
			else
			{
				Console.WriteLine("The accounts are the same. Good!");
			}

			/*Тестирование переопределенных методов Equals и ToString*/
			if (acc1.Equals(acc2))
			{
				Console.WriteLine("The accounts are the same. Good!");
			}
			if (!acc1.Equals(acc2))
			{
				Console.WriteLine("The accounts are different. They should not be!");
			}
			Console.WriteLine("acc1 – {0}", acc1);
			Console.WriteLine("acc2 – {0}", acc2);
			Console.WriteLine("acc3 – {0}", acc3);


		}


		static void TestDeposit(BankAccount acc)
		{
			Console.Write("Enter amount to deposit: ");
			decimal amount = decimal.Parse(Console.ReadLine());
			acc.Deposit(amount);
		}

		static void TestWithdraw(BankAccount acc)
		{
			Console.Write("Enter amount to withdraw: ");
			decimal amount = decimal.Parse(Console.ReadLine());
			acc.Withdraw(amount);
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
