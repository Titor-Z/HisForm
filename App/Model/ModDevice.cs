﻿using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModDevice:DbHelper
    {
        public ModDevice()
        {
            this.strTable = "device";
            this.strWhere = "(ispass = 1)";
        }
    }
}
