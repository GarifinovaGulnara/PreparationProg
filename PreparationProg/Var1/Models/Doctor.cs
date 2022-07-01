using PreparationProg.Intr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Models
{
    public class Doctor: Unit, IUnit
    {
        public new int Health = 30;
        public new int Mana = 80;
        public void Service()
        {
            Console.WriteLine("Htals");
        }
    }
}
