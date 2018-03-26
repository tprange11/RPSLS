using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Person
    {
        public string name;

        public Person()
        {
            
        }

        public virtual void DisplayName()
        {
            Console.WriteLine("Welcome " + name);
        }
    }
}
