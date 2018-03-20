using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModDrugType:DbHelper
    {
        public ModDrugType()
        {
            this.strTable = "drugType";
            this.strWhere = "(ispass = 1)";
        }
    }
}
