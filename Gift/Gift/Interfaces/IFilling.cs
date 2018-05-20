using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    interface IFilling //Interface to Filling
    {
        string Filling { get; }
        void GetFilling();
    }
}