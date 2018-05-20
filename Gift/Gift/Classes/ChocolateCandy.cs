﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    public class ChocolateCandy : AbstractCandy, ICandyFilling
    {
        public string CandyFilling { get; private set; } //Property

        //Constructor
        public ChocolateCandy(string candyName, int candyWeight, int candySugar, string candyFilling)
            : base(candyName, candyWeight, candySugar)
        {
            CandyFilling = candyFilling;
        }
        public void GetFilling() //Show filling
        {
            Console.WriteLine("Chocolate candy {0} contains filling {1}", CandyName, CandyFilling);
        }
        public override void CandyInfo() //Overrided basic method
        {
            Console.WriteLine("Chocolate candy: {0}, Weight: {1} gram, Sugar: {2} gram, Filling: {3}\n", CandyName, CandyWeight, CandySugar, CandyFilling);
        }
    }
}
