using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Var08.Service
{
    public class CounterService : ICounterService
    {
        public int Count { get; set; }
        public void Increment()
        {
            Count++;
        }
        public int GetCount()
        {
            return Count;
        }
    }
}
