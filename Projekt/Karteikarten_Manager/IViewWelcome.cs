﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karteikarten_Manager
{
    interface IViewWelcome
    {
        void setController(IControllerCardManager controllerCardManager);
    }
}
