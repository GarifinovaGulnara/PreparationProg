using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Var4
{
    public class Handgun : IWeapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Capacity { get; set; }
        string AmmunitionType { get; set; }
        public Handgun(int damage, int capacity, string ammunitionType, string name)
        {
            Name = name;
            Damage = damage;
            Capacity = capacity;
            AmmunitionType = ammunitionType;
        }

        public int DealingDamage()
        {
            Random rnd = new Random();
            return rnd.Next(1, Damage);
        }
    }
}
