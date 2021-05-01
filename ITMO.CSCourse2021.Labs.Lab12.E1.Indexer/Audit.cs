using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.CSCourse2021.Labs.Lab12.E1.PropertiesBankAccount
{
	namespace Banking
	{
		public class Audit
		{
			private string fileName;
			private StreamWriter auditFile;
			private bool closed = false;

			public Audit(string fileToUse)
			{
				this.fileName = fileToUse;
				this.auditFile = File.AppendText(fileToUse);
			}

			public void RecordTransaction(object sender, AuditEventArgs eventData)
			{
				BankTransaction tempTrans = eventData.getTransaction();
				if (tempTrans != null)
					this.auditFile.WriteLine("Amount: {0}\tDate: {1}", tempTrans.Amount(), tempTrans.When());
			}

			public void Close()
			{
				if (!closed)
				{
					this.auditFile.Close();
					closed = true;
				}
			}
		}
	}
}
