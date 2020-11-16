using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    class Fish : Animal, ISwimming
    {
        public string Name
        { get; set; }
     
        public override string ToString() => Name;
        public Fish(string name, DateTime birthday)
        {
            Name = name;
            BirthDay = birthday;
        }
    }
}
