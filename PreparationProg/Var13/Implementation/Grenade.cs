using PreparationProg.Var13.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Var13.Implementation
{
    public class Grenade : Weapon, IGrenade
    {
        public Grenade(int damage, double weist, double range, double damageRadius) : base(damage, weist, range, damageRadius)
        {
        }

        public void DealingDamage()
        {
            Console.WriteLine("");
        }
        public void Throw()
        {

        }
    }
}
