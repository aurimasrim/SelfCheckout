using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class ProductScanEventArgs : EventArgs
    {
        public string Barcode;
        public ProductScanEventArgs(string barcode)
        {
            Barcode = barcode;
        }
    }
}
