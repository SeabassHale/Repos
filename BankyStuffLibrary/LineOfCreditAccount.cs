using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankyStuffLibrary
{
    public class LineOfCreditAccount : BankAccount
    {
        //Can have a negative balance, but not be greater in absolute value than the credit limit.
        //Will incur an interest charge each month where the end of month balance isn't 0.
        //Will incur a fee on each withdrawal that goes over the credit limit.


        public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
        {

        }

        protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
            isOverdrawn
            ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
            : default;

        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0 )
            {
                //Negate the balance to get a positive interest charge:
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Monthly Interest Charge");
            }
        }

    }
}
