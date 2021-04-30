using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Labs.Lab06._02
{
    public class BankAccount
    {
        public void Populate(long number, decimal balance)
        {
            accNo = number;
            accBal = balance;
            accType = AccountType.Checking;
        }
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }
        public AccountType Type()
        {
            return accType;
        }
        public string TypeToString()
        {
            return accType.ToString();
        }


    }
}
