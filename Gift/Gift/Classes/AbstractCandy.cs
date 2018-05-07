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
        public string CandyName { get; private set; }
        public int CandyWeight { get; private set; }
        public int CandySugar { get; private set; }
        public AbstractCandy(string candyName, int candyWeight, int candySugar)
        {
            CandyName = candyName;
            CandyWeight = candyWeight;
            CandySugar = candySugar;
        }
    }
}
