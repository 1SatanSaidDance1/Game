using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    internal class Randomizer : IRandomize
    {
        public int RandomNumber(int minValue, int maxValue)
        {
            return new Random().Next(minValue, maxValue);
        }
    }
}
