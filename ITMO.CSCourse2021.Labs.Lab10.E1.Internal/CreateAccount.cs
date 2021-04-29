using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 10. Использование модификатора доступа internal и создание сборок*/
/*Упражнение 1. Создание класса с модификатором internal*/

namespace ITMO.CSCourse2021.Labs.Lab10.E1.Internal
{
    class CreateAccount
    {
		static void Main()
		{
			Console.WriteLine("Sid's Account");
			Bank bank = new Bank();
			BankAccount sids = bank.CreateAccount();
			TestDeposit(sids);
			TestWithdraw(sids);
			Write(sids);
			sids.Dispose();

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
