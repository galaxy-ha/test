using System;
using System.Runtime.Remoting.Messaging;

namespace GunvorRecruitment
{
    public class AccountOverDrawnException : Exception
    {
        private CurrentAccount _subject;
        public string EXP(int amount)
        {
          if (amount > _subject.OverDraft)
            {
                return ("FAILED");
            } else
            {
                return ("PASSED");
            }
            
        }
    }
}