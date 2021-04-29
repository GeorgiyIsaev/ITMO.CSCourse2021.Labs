using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Labs.Lab10.E1.Internal
{ 
    class BankTransaction
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
