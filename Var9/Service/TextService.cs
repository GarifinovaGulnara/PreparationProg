using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Var9.Service
{
    public class TextService : ITextService
    {
        public string Text { get; set; } = " ";
        public string GetText()
        {
            return Text;
        }

        public void SaveText(string text)
        {
            Text = text;
        }
    }
}
