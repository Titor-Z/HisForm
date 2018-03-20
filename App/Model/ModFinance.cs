using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModFinance:DbHelper
    {
        public ModFinance()
        {
            this.strTable = "finance";
            this.strWhere = "(ispass = 1)";
        }
    }
}
