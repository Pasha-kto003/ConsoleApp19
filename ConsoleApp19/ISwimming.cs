using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    interface ISwimming
    {
        public void Swim()
        {
            Console.WriteLine(this + " Плывет в новую точку");
        }
    }
}
