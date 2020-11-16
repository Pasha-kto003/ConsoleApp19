using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    class Bird : Animal, IFlying
    {
        public string Name
        { get; set; }
        
        public override string ToString() => Name;
        public Bird(string name, DateTime birthday)
        {
            Name = name;
            BirthDay = birthday;
        }
    }
}
