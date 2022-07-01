using PreparationProg.Intr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Var3
{
    public class Pistol : Weapon3
    {
        public Pistol(int damage, int capacity, string ammunitionType) : base(damage, capacity, ammunitionType)
        {
        }
        public int DealingDamage()
        {
            Random rnd = new Random();
            return rnd.Next(1, Damage);
        }
    }
}
