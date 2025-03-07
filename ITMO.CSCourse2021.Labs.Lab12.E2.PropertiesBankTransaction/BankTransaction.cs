﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Labs.Lab12.E2.PropertiesBankTransaction
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

			public decimal Amount
			{
				get { return amount; }
			}

			public DateTime When
			{
				get { return when; }
			}
		}
	}
}
