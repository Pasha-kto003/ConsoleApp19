using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
     class Dog : Animal, IWalking
    {
        public string Name
        { get; set; }
        
        public override string ToString() => Name;
        public Dog(string name, DateTime birthday)
        {
            Name = name;
            BirthDay = birthday;
        }
        
    }
}
