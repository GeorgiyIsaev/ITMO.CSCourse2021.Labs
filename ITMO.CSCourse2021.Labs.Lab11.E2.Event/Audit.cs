using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Labs.Lab11.E2.Event
{

    namespace Banking
    {
        class Audit 
        {
            private event AuditEventHandler AuditingTransaction = null;
            private string filename;
            private StreamWriter auditFile;
            private bool closed = false;

            public Audit(string fileToUse)
            {
                this.filename = fileToUse;
                this.auditFile = File.AppendText(fileToUse);
            }
            public void RecordTransaction(object sender, AuditEventArgs eventData)
            {
                BankTransaction tempTrans = eventData.getTransaction();
                if (tempTrans != null)
                    this.auditFile.WriteLine("Amount: {0}\tDate: {1}",
                    tempTrans.Amount(), tempTrans.When());
            }
            public void Close()
            {
                if (!closed)
                {
                    this.auditFile.Close();
                    closed = true;
                }
            }
            public void AddOnAuditingTransaction(AuditEventHandler handler)
            {
                this.AuditingTransaction += handler;
            }
            public void RemoveOnAuditingTransaction(AuditEventHandler handler)
            {
                this.AuditingTransaction -= handler;
            }


        }
    }
}
