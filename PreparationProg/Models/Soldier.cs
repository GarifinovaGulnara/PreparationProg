using PreparationProg.Intr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Models
{
    public class Soldier: Unit, IUnit
    {
        public new int Health = 80;
        public new int Mana = 30;
        public void Service()
        {
            Console.WriteLine("Serves");
        }
    }
}
