using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
{
    interface iPayee
    {
        void pay();
    }
    class PayRoll
    {


        List<iPayee> payees = new List<iPayee>();

        public PayRoll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Princapal());
        }

        public void payAll()
        {
            foreach (var payee in payees)
            {
                payee.pay();
            }
        }
    }
}
