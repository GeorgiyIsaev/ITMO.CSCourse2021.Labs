#define DEBUG_ACCOUNT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*Лабораторная работа 13. Создание и использование атрибутов*/
/*Упражнение 1. Использование атрибута Conditional*/

namespace ITMO.CSCourse2021.Labs.Lab13.E1.UseAttributeConditional
{
	using Banking;
	class CreateAccount
	{
		static void Main()
		{

			long accNo1 = Bank.CreateAccount(AccountType.Checking, 100);
			BankAccount myAccount = Bank.GetAccount(accNo1);
			myAccount.DumpToScreen();
		}

		static void Write(BankAccount acc)
		{
		
		}

	}
}
