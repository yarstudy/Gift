using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    public abstract class AbstractCandy //base class for all candies
    {   
        //Properties
        public string CandyName { get; protected set; }
        public int CandyWeight { get; protected set; }
        public int CandySugar { get; protected set; }

        //Constructor
        public AbstractCandy(string candyName, int candyWeight, int candySugar) 
        {
            CandyName = candyName;
            CandyWeight = candyWeight;
            CandySugar = candySugar;
        }

        public virtual void CandyInfo() //Method for demonstrating candies
        {
            Console.WriteLine("Candy name: {0}, Weight: {1} gram, Sugar: {2} gram\n", CandyName, CandyWeight, CandySugar);
        }
    }
}
