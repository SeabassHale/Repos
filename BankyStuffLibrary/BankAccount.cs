using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankyStuffLibrary
{
    //This is a CLASS or TYPE (of object)
    public class BankAccount
    {
        private static int accountNumberSeed = 1000000001;

        //Number, Owner and Balance are all PROPERTIES (Properties are the basic variables of any given object)
        public string Number { get; }

        public string Owner { get; set; }
        
        public decimal Balance 
        { 
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        //This is the CONSTRUCTOR (This is the "form" or template for creating each new instance of an object)

        private readonly decimal _minimumBalance;

        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }

        public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
        {
            //"this." isn't always necessary.
            this.Owner = name;
            _minimumBalance = minimumBalance;
            if (initialBalance > 0)
                MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        //MakeDeposit and MakeWithdrawal are both METHODS (Methods are blocks of code that perform a single function)
        public void MakeDeposit (decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
            Transaction? withdrawal = new(-amount, date, note);
            allTransactions.Add(withdrawal);
            if (overdraftTransaction != null)
                allTransactions.Add(overdraftTransaction);
        }
        
        protected virtual Transaction? CheckWithdrawalLimit (bool isOverdrawn)
        {
            if (isOverdrawn)
                throw new InvalidOperationException("Not sufficint funds for this withdrawal");
            else
                return default;
        }

        /* This was part of the above MakeWithdrawal method. It was replace by the Transaction? gubbins and the virtual CheckWithdrawalLimit method. You commented it out because you're a coward...
         
            if (Balance - amount < _minimumBalance)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }*/

        public virtual void PerformMonthEndTransactions()
        {

        }

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tNote");
            foreach (var item in allTransactions)
            {
                balance =+item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.AmountForHumans}\t{item.Notes}");
            }
            report.AppendLine($"Closing Balance: {Balance}");

            return report.ToString();

        }


    }

}
