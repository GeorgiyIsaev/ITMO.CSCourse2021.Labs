using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Labs.Lab10.E1.Internal
{
    public class Bank
    {
        //private Bank() { /*Приватный конструткор*/}
       

        public long CreateAccount()
        {
            BankAccount newAcc = new BankAccount();
            long accNo = newAcc.Number();
            accounts[accNo] = newAcc;
            return accNo;
        }
        public long CreateAccount(AccountType aType)
        {
            BankAccount newAcc = new BankAccount(aType);
            long accNo = newAcc.Number();
            accounts[accNo] = newAcc;
            return accNo;
        }
        public long CreateAccount(decimal aBal)
        {
            BankAccount newAcc = new BankAccount(aBal);
            long accNo = newAcc.Number();
            accounts[accNo] = newAcc;
            return accNo;
        }
        public long CreateAccount(AccountType aType, decimal aBal)
        {
            BankAccount newAcc = new BankAccount(aType, aBal);
            long accNo = newAcc.Number();
            accounts[accNo] = newAcc;
            return accNo;
        }


        public bool CloseAccount(long accNo)
        {
            BankAccount closing = (BankAccount)accounts[accNo];
            if (closing != null)
            {
                accounts.Remove(accNo);
                closing.Dispose();
                return true;
            }
            else
            {
                return false;
            }      
        }
        public BankAccount GetAccount(long accNo)
        {
            return (BankAccount)accounts[accNo];
        }
        private static Hashtable accounts = new Hashtable();
     
    }
}
