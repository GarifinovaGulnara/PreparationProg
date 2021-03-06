using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Var3
{
    public class Handgun : Weapon3
    {
        public string Name { get; set; }
        public Handgun(int damage, int capacity, string ammunitionType, string name) : base(damage, capacity, ammunitionType)
        {
            Name = name;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{Damage}, {Capacity}, {AmmunitionType}, {Name}");
        }
    }
}
