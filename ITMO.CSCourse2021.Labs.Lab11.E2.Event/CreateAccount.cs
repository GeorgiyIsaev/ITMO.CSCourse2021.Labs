using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Лабораторная работа 11. Перегрузка операторов и использование событий*/
/*Упражнение 2. Определение и использование событий*/

namespace ITMO.CSCourse2021.Labs.Lab11.E2.Event
{
    class CreateAccount
    {
		static void Main()
		{
			Banking.Audit testAudit = new Banking.Audit("AuditTrail.dat");
			Banking.BankTransaction testTran = new Banking.BankTransaction(500);
			Banking.AuditEventArgs testArg = new Banking.AuditEventArgs(testTran);
			testAudit.RecordTransaction(null, testArg);

			Banking.BankTransaction testTran2 = new Banking.BankTransaction(-200);
			Banking.AuditEventArgs testArg2 = new Banking.AuditEventArgs(testTran2);
			testAudit.RecordTransaction(null, testArg2);

			testAudit.Close();

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
