using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Var3
{
    public class Weapon3
    {
        public Weapon3(int damage, int capacity, string ammunitionType)
        {
            Damage = damage;
            Capacity = capacity;
            AmmunitionType = ammunitionType;
        }

        public int Damage { get; set; }
        public int Capacity { get; set; }
        public string AmmunitionType { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine(Capacity + " " + AmmunitionType);
        }
    }
}
