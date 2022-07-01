using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationProg.Var13.Abstraction
{
    public interface IGrenade : IDamager
    {
        public void Throw();
    }
}
