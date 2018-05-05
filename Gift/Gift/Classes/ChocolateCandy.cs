using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    public class ChocolateCandy : AbstractCandy, ICandyStuffing
    {
        public string candyStuffing;
        public string CandyStuffing { get; set; }
        public ChocolateCandy(string chocoName, int chocoWeight, int chocoSugar, string candyStuffing) 
            : base(chocoName, chocoWeight, chocoSugar)
        {
            CandyStuffing = candyStuffing;
        }
        public void GetStuffing() { Console.WriteLine("This chocolate candy contains the stuffing {0}", candyStuffing); }
    }
}
