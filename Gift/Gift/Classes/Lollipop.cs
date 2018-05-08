using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{


    public class Lollipop : AbstractCandy
    {
        public Lollipop(string candyName, int candyWeight, int candySugar)
            : base(candyName, candyWeight, candySugar)
        {
        }
    }
}
