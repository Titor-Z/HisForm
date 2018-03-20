using System;
using System.Collections.Generic;
using System.Linq;
using App.Common;
using System.Text;

namespace App.Model
{
    class ModUsage:DbHelper
    {
        public ModUsage()
        {
            this.strTable = "usage";
            this.strWhere = "(ispass = 1)";
        }
    }
}
