using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Var9.Service
{
    interface ITextService
    {
        public void SaveText(string text);
        public string GetText();
    }
}
