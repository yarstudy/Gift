using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{


    public class ChewyCandy : AbstractCandy, ICandyStuffing
    {
        public string candyStuffing;
        public string CandyStuffing { get; set; }

        public ChewyCandy(string candyName, int candyWeight, int candySugar, string candyStuffing)
            : base(candyName, candyWeight, candySugar)
        {
            CandyStuffing = candyStuffing;
        }
        public void GetStuffing() { Console.WriteLine("This chewy candy contains the stuffing {0}", candyStuffing); }

    }
}
