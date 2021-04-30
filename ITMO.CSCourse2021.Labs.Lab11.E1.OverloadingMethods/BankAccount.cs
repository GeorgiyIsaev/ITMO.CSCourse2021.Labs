using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ITMO.CSCourse2021.Labs.Lab11.E1.OverloadingMethods
{
	sealed public class BankAccount : IDisposable
	{
		private long accNo;
		private decimal accBal;
		private AccountType accType;
		private Queue tranQueue = new Queue();
		private bool disposed = false;

		private static long nextNumber = 123;

		// Constructors
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

		// Dispose Method

		public void Dispose()
		{
			if (!disposed)
			{
				StreamWriter swFile = File.AppendText("Transactions.Dat");
				swFile.WriteLine("Account number is {0}", accNo);
				swFile.WriteLine("Account balance is {0}", accBal);
				swFile.WriteLine("Account type is {0}", accType);
				swFile.WriteLine("Transactions:");
				foreach (BankTransaction tran in tranQueue)
				{
					swFile.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
				}
				swFile.Close();
				disposed = true;
				GC.SuppressFinalize(this);
			}
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

		~BankAccount()
		{
			Dispose();
		}

		/*	Переопределите операторы = = и !=*/
		public static bool operator ==(BankAccount acc1, BankAccount acc2)
		{
			if ((acc1.accNo == acc2.accNo) &&
			(acc1.accType == acc2.accType) &&
			(acc1.accBal == acc2.accBal))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public static bool operator !=(BankAccount acc1, BankAccount acc2)
		{
			return !(acc1 == acc2);
		}


		/*	Переопределите методы Equals, ToString и GetHashCode*/
		public override bool Equals(Object acc1)
		{
			return this == (BankAccount)acc1;
		}
		public override string ToString()
		{
			string retVal = "Number: " + this.accNo + "\tType: ";
			retVal += (this.accType == AccountType.Checking) ? "Checking" : "Deposit";
			retVal += "\tBalance: " + this.accBal;
			return retVal;
		}
		public override int GetHashCode()
		{
			return (int)this.accNo;
		}


	}
}
