using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GunvorRecruitment
{
    class SavingsAccount
    {
        System.Threading.Timer _timer;
        public decimal SavingBalance { get; set; }
        public string WithDrawStatus { get; set; }
        public string InterestStatus { get; set; }
        public void Start30DayTimer()
        {
            TimeSpan span = new TimeSpan(30, 0, 0, 0);
            TimeSpan disablePeriodic = new TimeSpan(0, 0, 0, 0, -1);
            _timer = new System.Threading.Timer(timer_WithDrawStatus, null,
                span, disablePeriodic);
        }
        public void YearinterestTimer()
        {
            TimeSpan span = new TimeSpan(365, 0, 0, 0);
            TimeSpan disablePeriodic = new TimeSpan(0, 0, 0, 0, -1);
            _timer = new System.Threading.Timer(timer_Yearinterest, null,
                span, disablePeriodic);
        }
        public void timer_WithDrawStatus(object state)
        {
            WithDrawStatus = "available";
            _timer.Dispose();
        }
        public void timer_Yearinterest(object state)
        {
            InterestStatus = "interest";
            _timer.Dispose();
        }
        public void SavingDeposit(decimal amount)
        {
            var tempValue = SavingBalance;
            var newValue = tempValue + amount;
            SavingBalance = newValue;
        }
        public void SavingWithdraw(decimal amount)
        {
            if (WithDrawStatus == "available")
            {
                if (amount <= SavingBalance)
                {
                    var tempValue = SavingBalance;
                    var newValue = tempValue - amount;
                    SavingBalance = newValue;
                    WithDrawStatus = "limited";
                }
            }
                
        }
        public void SavingWithdrawWithInterest()
        {
            if (InterestStatus == "interest")
            {
                var tempValue = SavingBalance;
                var newValue = tempValue / 100;
                newValue = newValue * 2;
                SavingBalance = newValue + SavingBalance;
                InterestStatus = "limited";
            }

        }
        public void SavingInterestCalculator( int year)
        {
            for (int i = 1; i <= year; i++)
            {
                var tempValue = SavingBalance;
                var newValue = tempValue / 100;
                newValue = newValue * 2;
                SavingBalance = newValue + SavingBalance;
            }
        }
    }
}
