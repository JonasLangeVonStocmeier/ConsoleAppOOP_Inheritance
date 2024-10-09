using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConsoleApp
{
    internal class Helicopter : Plane
    {
        public override void Landing()
        {
            Console.WriteLine("The Helicopter is landing slowly");
            // base.Landing();
        }
    }
}
