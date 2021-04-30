using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.CSCourse2021.Labs.Lab11.E2.Event
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
