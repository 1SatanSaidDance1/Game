using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    internal class TextValidator : IValidate
    {
        public bool IsConvertableToInt(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                return Int32.TryParse(text, out int result);
            }
            else
            {
                return false;
            }
        }
    }
}
