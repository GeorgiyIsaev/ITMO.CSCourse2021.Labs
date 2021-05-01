using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ITMO.CSCourse2021.Labs.Lab12.E1.Indexer
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
		}
	}

}
