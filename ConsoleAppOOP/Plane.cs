using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConsoleApp
{
    internal class Plane : Vehicle, IVehicle
    {
        public bool HasJetEngine { get; set; }

        public void Move()
        {
            Console.WriteLine("The tires are in the air");
        }
        public virtual void Landing()
        {
            Console.WriteLine("It is landing");
        }
    }
}
