using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Var08.Service
{
    interface ICounterService
    {
        public void Increment();
        public int GetCount();

    }
}
