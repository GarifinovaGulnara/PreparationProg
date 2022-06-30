using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Weapons
{
    public class Weapon
    {
        public Weapon(int damage, int capacity, string ammunitionType)
        {
            Damage = damage;
            Capacity = capacity;
            AmmunitionType = ammunitionType;
        }

        public int Damage { get; set; }
        public int Capacity { get; set; }
        public string AmmunitionType { get; set; }
        public int DealingDamage()
        {
            Random rnd = new Random();
            return rnd.Next(1, Damage);
        }
        public virtual void GetInfo()
        {
            Console.WriteLine(Capacity + " " + AmmunitionType);
        }
    }
}
