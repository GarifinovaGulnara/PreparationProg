using PreparationProg.Var13.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Var13.Implementation
{
    public class Pistol : Weapon, IPistol
    {
        public int Shop { get; set; }
        public Pistol(int damage, double weist, double range, double damageRadius, int shop) : base(damage, weist, range, damageRadius)
        {
            Shop = shop;
        }

        public void DealingDamage()
        {

        }
        public void Recharge()
        {

        }
    }
}
