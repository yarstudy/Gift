using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    public class ChocolateCandy : AbstractCandy, ICandyFilling
    {
        public string candyFilling;
        public string CandyFilling { get; set; }
        public ChocolateCandy(string chocoName, int chocoWeight, int chocoSugar, string candyFilling) 
            : base(chocoName, chocoWeight, chocoSugar)
        {
            CandyFilling = candyFilling;
        }
        public void GetFilling() { }
    }
}
