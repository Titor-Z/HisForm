using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModDrug:DbHelper
    {
        public ModDrug()
        {
            this.strTable = "drug";
            this.strWhere = "(ispass = 1)";
        }
    }
}
