using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Var13.Implementation
{
    public class Weapon
    {
        public Weapon(int damage, double weist, double range, double damageRadius)
        {
            Damage = damage;
            Weist = weist;
            Range = range;
            DamageRadius = damageRadius;
        }

        public int Damage { get; set; }
        public double Weist { get; set; }
        public double Range { get; set; }
        public double DamageRadius { get; set; }
    }
}
