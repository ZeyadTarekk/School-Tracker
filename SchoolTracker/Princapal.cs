using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
{
    class Princapal : Member, iPayee
    {
        public void pay()
        {
            Console.WriteLine("Paying Princiapal");
        }
    }
}
