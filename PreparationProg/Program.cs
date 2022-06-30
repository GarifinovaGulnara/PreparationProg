using PreparationProg.Weapons;
using System;

namespace PreparationProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon han = new Handgun(300, 9, "type", "name)");
            han.GetInfo();

        }
    }
}
