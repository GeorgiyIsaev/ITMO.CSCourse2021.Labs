using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ITMO.CSCourse2021.Labs.Lab10.E1.Internal
{
    sealed public class BankAccount : IDisposable
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextNumber = 123;
        private Queue tranQueue = new Queue();
        private bool disposed = false;

        internal BankAccount()
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = 0;
        }
        internal BankAccount(AccountType aType)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = 0;
        }
        internal BankAccount(decimal aBal)
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = aBal;
        }
        internal BankAccount(AccountType aType, decimal aBal)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = aBal;
        }      

        public void Populate(decimal balance)
        {
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
        }

        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
                BankTransaction tran = new BankTransaction(-amount);
                tranQueue.Enqueue(tran);
            }
            return sufficientFunds;
        }
        
        public decimal Deposit(decimal amount)
        {
            accBal += amount;
            BankTransaction tran = new BankTransaction(amount);
            tranQueue.Enqueue(tran);
            return accBal;
        }
        public Queue Transactions()
        {
            return tranQueue;
        }

        public long Number()
        {
            return accNo;
        }

        public decimal Balance()
        {
            return accBal;
        }

        public string Type()
        {
            return accType.ToString();
        }

        private static long NextNumber()
        {
            return nextNumber++;
        }

        public void Dispose()
        {
            if (!disposed)
            {
                SaveInFile();
                disposed = true;
                GC.SuppressFinalize(this);
            }
        }
        ~BankAccount()
        {
            if (!disposed)
            {
                SaveInFile();
                disposed = true;
            }
        }
        public void SaveInFile(string namefile = "Transactions.Dat")
        {
            using (StreamWriter swFile = File.AppendText(namefile))
            {
                swFile.WriteLine("Account number is {0}", accNo);
                swFile.WriteLine("Account balance is {0}", accBal);
                swFile.WriteLine("Account type is {0}", accType);
                swFile.WriteLine("Transactions:");
                foreach (BankTransaction tran in tranQueue)
                {
                    swFile.WriteLine("Date/Time: {0}\tAmount:{1}", tran.When(), tran.Amount());
                }
                swFile.Close();
            }
        }
    }
}
