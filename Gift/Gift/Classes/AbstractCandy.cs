using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    public abstract class AbstractCandy
    {
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public int Sugar { get; private set; }
        public AbstractCandy(string candyName, int candyWeight, int candySugar)
        {
            Name = candyName;
            Weight = candyWeight;
            Sugar = candySugar;
        }
    }
}
