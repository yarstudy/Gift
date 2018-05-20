using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gift
{


    public class ChewyCandy : AbstractCandy, IFilling
    {
        public string filling;
        public string Filling { get; set; }

        public ChewyCandy(string name, int weight, int sugar, string filling)
            : base(name, weight, sugar)
        {
            Filling = filling;
        }
        public void GetFilling() { }

    }
}

