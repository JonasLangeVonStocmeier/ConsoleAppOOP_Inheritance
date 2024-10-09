using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConsoleApp
{
    internal class Motorcycle : Vehicle, IVehicle
    {
        public void Move()
        {
            Console.WriteLine("Two tires are on the floor");
        }
    }
}
