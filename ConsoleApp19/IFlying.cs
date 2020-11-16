using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    interface IFlying
    {
        public void Fly()
        {
            Console.WriteLine(this + " Летит в новую точку");
        }
    }
}
