using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Var14
{
    public class Doctor
    {
        delegate void HealthChange(string message);
        event HealthChange healthch;
        public int Health { get; set; }
        public void LossOfHealth(int h)
        {
            Health -= h;
            if (healthch != null) healthch($"Health: {Health}");
        }
        public void HealthBoost(int h)
        {
            Health += h;
            if (healthch != null) healthch($"Health: {Health}");
        }
    }
}
