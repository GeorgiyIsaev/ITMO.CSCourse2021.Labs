using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Labs.Lab12.E3.Indexers
{
	namespace Banking
	{
		public class AuditEventArgs : System.EventArgs
		{
			private readonly BankTransaction transData = null;

			public AuditEventArgs(BankTransaction transaction)
			{
				this.transData = transaction;
			}

			public BankTransaction getTransaction()
			{
				return this.transData;
			}

		}
	}

}
