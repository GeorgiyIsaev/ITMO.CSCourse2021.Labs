using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Labs.Lab11.E2.Event
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
