using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
{
    class Teacher : Member , iPayee
    {
        public string Subject;
        public void pay()
        {
            Console.WriteLine("Paying Teacher");
        }
    }
}
