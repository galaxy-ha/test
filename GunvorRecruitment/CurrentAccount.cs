using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GunvorRecruitment
{
    public class CurrentAccount
    {
        public decimal Balance { get; private set; }

        public int OverDraft { get; set; }

        public string PersonName { get; set; }

        decimal DepositAmount;
        decimal WithdrawAmount;
        public void Deposit(decimal amount)
        {
            var tempValue = Balance;
            var newValue = tempValue + amount;
            Balance = newValue;
            DepositAmount = amount;
        }

        public void Withdraw(decimal amount)
        {
            var tempValue = Balance;
            var newValue = tempValue - amount;
            Balance = newValue;
            WithdrawAmount = amount;
        }
        public void ClientHistory(string name)
        {
            List<object> HistoryList = new List<object>();
            HistoryList.Add(PersonName);
            HistoryList.Add(DepositAmount);
            HistoryList.Add(WithdrawAmount);
            HistoryList.Add(Balance);
        }
    }
}
