using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Person
    {
        string name;

        public Person(string name)
        {
            this.name = name;
        }

        public void DisplayName()
        {
            Console.WriteLine("Welcome " + name);
        }
    }
}
