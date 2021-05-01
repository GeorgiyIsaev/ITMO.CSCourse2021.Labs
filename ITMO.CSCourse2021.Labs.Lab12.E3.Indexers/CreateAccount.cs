using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*Лабораторная работа 12. Использование свойств и индексаторов*/
/*Упражнение 3. Создание и использование индексаторов*/

namespace ITMO.CSCourse2021.Labs.Lab12.E3.Indexers
{
	using Banking;
	class CreateAccount
	{
		static void Main()
		{

			long accNo1 = Bank.CreateAccount(AccountType.Checking, 100);
			long accNo2 = Bank.CreateAccount(AccountType.Checking, 100);

			BankAccount acc1 = Bank.GetAccount(accNo1);
			BankAccount acc2 = Bank.GetAccount(accNo2);

			Console.WriteLine("acc1 - {0}", acc1);
			Console.WriteLine("acc2 - {0}", acc2);

			for (int i = 0; i < 5; i++)
			{
				acc1.Deposit(100);
				acc1.Withdraw(50);
			}
			Write(acc1);

			Console.WriteLine("acc1 - {0}", acc1);
			Console.WriteLine("acc2 - {0}", acc2);
		}

		static void Write(BankAccount acc)
		{
			Console.WriteLine("Account number is {0}", acc.Number);
			Console.WriteLine("Account balance is {0}", acc.Balance());
			Console.WriteLine("Account type is {0}", acc.Type);

			Console.WriteLine("Transactions");		
			Queue tranQueue = acc.Transactions();
			for (int counter = 0; counter < tranQueue.Count; counter++)
			{
				BankTransaction tran = acc[counter];
				Console.WriteLine("Date: {0}\tAmount: {1}", tran.When, tran.Amount);
			}



		
		}

	}
}
