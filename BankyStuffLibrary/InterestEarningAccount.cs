using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankyStuffLibrary
{
    public class InterestEarningAccount : BankAccount
    {
        //Will get a credit of 2% of the month-ending-balance.
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {

        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                decimal interest = Balance * 0.005m;
                MakeDeposit(interest, DateTime.Now, "Monthly Deposit Interest");
            }
        }
    }
}
