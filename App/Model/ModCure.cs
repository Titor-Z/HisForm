using System;
using System.Collections.Generic;
using System.Linq;
using App.Common;
using System.Text;

namespace App.Model
{
    class ModCure:DbHelper
    {
        public ModCure()
        {
            this.strTable = "cure";
            this.strWhere = "(ispass = 1)";
        }
    }
}
