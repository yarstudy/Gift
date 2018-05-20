using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    public class Lollipop : AbstractCandy
    {
        //Constructor
        public Lollipop(string name, int weight, int sugar)
            : base(name, weight, sugar)
        {
        }
    }
}
