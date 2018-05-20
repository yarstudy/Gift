using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gift
{


    public class ChewyCandy : AbstractCandy, ICandyFilling
    {
        public string candyFilling;
        public string CandyFilling { get; set; }

        public ChewyCandy(string candyName, int candyWeight, int candySugar, string candyFilling)
            : base(candyName, candyWeight, candySugar)
        {
            CandyStuffing = candyStuffing;
        }
        public void GetFilling() { }

    }
}

