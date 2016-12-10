using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class ProductWeighEventArgs
    {
        public int Weight;
        public ProductWeighEventArgs(int weight)
        {
            Weight = weight;
        }
    }
}
