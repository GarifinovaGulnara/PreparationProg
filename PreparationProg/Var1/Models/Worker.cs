using PreparationProg.Intr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Models
{
    public class Worker: Unit, IUnit
    {
        public new int Health = 50;
        public new int Mana = 10;
        public void Service()
        {
            Console.WriteLine("Worked");
        }
    }
}
