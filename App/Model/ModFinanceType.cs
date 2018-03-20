using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModFinanceType:DbHelper
    {
        public ModFinanceType()
        {
            this.strTable = "financeType";
            this.strWhere = "(ispass = 1)";
        }
    }
}
