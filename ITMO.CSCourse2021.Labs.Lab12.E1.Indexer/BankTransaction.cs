using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Labs.Lab12.E1.PropertiesBankAccount
{
	namespace Banking
	{
		public class BankTransaction
		{
			private readonly decimal amount;
			private readonly DateTime when;

			public BankTransaction(decimal tranAmount)
			{
				amount = tranAmount;
				when = DateTime.Now;
			}

			public decimal Amount()
			{
				return amount;
			}

			public DateTime When()
			{
				return when;
			}
		}
	}
}
