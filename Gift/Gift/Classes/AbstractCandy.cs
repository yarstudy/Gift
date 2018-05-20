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
        public string Name { get; protected set; }
        public int Weight { get; protected set; }
        public int Sugar { get; protected set; }

        //Constructor
        public AbstractCandy(string name, int weight, int sugar) 
        {
            Name = name;
            Weight = weight;
            Sugar = sugar;
        }

        public virtual void Info() //Method for demonstrating candies
        {
            Console.WriteLine("Candy name: {0}, Weight: {1} gram, Sugar: {2} gram\n", Name, Weight, Sugar);
        }
    }
}
