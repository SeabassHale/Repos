using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankyStuffLibrary
{
    public class GiftCardAccount : BankAccount
    {
        //Can be refilled with a specified amount once each month, on the last day of the month.

        private readonly decimal _monthlyDeposit = 0m;

        public GiftCardAccount(string name, decimal initialBalance, decimal MonthlyDeposit = 0) : base(name, initialBalance) => _monthlyDeposit = MonthlyDeposit;

        public override void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit != 0)
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly Deposit");
        }


    }



}

