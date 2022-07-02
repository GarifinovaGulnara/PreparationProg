using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Weapons
{
    public class Handgun : Weapon3
    {
        public string Name { get; set; }
        public Handgun(int damage, int capacity, string ammunitionType, string name) : base(damage, capacity, ammunitionType)
        {
            Name = name;
        }

        public int DealingDemage()
        {
            Random rnd = new Random();
            return rnd.Next(1, Damage);
        }
    }
}
