using PreparationProg.Var13.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Var13.Implementation
{
    public class CombatKnife : Weapon, IKnife
    {
        public CombatKnife(int damage, double weist, double range, double damageRadius) : base(damage, weist, range, damageRadius)
        {
        }

        public void Chopping()
        {
            Console.WriteLine("Chopping knife");
        }
        public void DealingDamage()
        {
            Console.WriteLine();
        }
    }
}
