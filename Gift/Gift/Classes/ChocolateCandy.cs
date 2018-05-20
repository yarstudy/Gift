using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    public class ChocolateCandy : AbstractCandy, IFilling
    {
        public string Filling { get; private set; } //Property

        //Constructor
        public ChocolateCandy(string name, int weight, int sugar, string filling)
            : base(name, weight, sugar)
        {
            Filling = filling;
        }
        public void GetFilling() //Show filling
        {
            Console.WriteLine("Chocolate candy {0} contains filling {1}", Name, Filling);
        }
        public override void Info() //Overrided basic method
        {
            Console.WriteLine("Chocolate candy: {0}, Weight: {1} gram, Sugar: {2} gram, Filling: {3}\n", Name, Weight, Sugar, Filling);
        }
    }
}
