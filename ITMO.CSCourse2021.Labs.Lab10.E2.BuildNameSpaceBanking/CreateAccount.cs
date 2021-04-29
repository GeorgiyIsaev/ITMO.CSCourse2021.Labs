using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 10. Использование модификатора доступа internal и создание сборок*/
/*Упражнение 2. Организация классов в сборку*/

namespace ITMO.CSCourse2021.Labs.Lab10.E2.BuildNameSpaceBanking
{
    class CreateAccount
    {
		static void Main()
		{
			Console.WriteLine("Sid's Account");
			long sidsAccNo = Banking.Bank.CreateAccount();
			Banking.BankAccount sids = Banking.Bank.GetAccount(sidsAccNo);
			TestDeposit(sids);
			TestWithdraw(sids);
			Write(sids);
			if (Banking.Bank.CloseAccount(sidsAccNo))
				Console.WriteLine("Account closed");
			else
				Console.WriteLine("Something went wrong closing the account");

			/*Создание библиотеки через комндную строку:
			 *	c:\> csc /target:library /out:bank.dll a*.cs b*.cs
				c:\> dir	
			 */

		}


		static void TestDeposit(Banking.BankAccount acc)
		{
			Console.Write("Enter amount to deposit: ");
			decimal amount = decimal.Parse(Console.ReadLine());
			acc.Deposit(amount);
		}

		static void TestWithdraw(Banking.BankAccount acc)
		{
			Console.Write("Enter amount to withdraw: ");
			decimal amount = decimal.Parse(Console.ReadLine());
			acc.Withdraw(amount);
		}

		static void Write(Banking.BankAccount acc)
		{
			Console.WriteLine("Account number is {0}", acc.Number());
			Console.WriteLine("Account balance is {0}", acc.Balance());
			Console.WriteLine("Account type is {0}", acc.Type());
			Console.WriteLine("Transactions:");
			foreach (Banking.BankTransaction tran in acc.Transactions())
			{
				Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
			}
			Console.WriteLine();
		}

	}
}
