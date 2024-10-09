using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConsoleApp
{
    internal class Car : Vehicle, IVehicle
    {
        public void Move()
        {
            Console.WriteLine("Four tires are on the floor");
        }
    }
}
