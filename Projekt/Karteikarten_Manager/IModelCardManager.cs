﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteikarten_Manager
{
    interface IModelCardManager
    {
        void genXMLFromCSV(string filename, string fileoutputname);
    }
}
