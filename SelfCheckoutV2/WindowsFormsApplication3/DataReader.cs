﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    interface DataReader
    {
        void ReadData <T>(CustomArray <T> dataArray, string path);
    }
}
