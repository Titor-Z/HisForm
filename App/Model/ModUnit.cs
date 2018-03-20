using System;
using System.Collections.Generic;
using System.Linq;
using App.Common;
using System.Text;

namespace App.Model
{
    class ModUnit: DbHelper
    {
        public ModUnit()
        {
            this.strTable = "unit";
            this.strWhere = "(isPass = 1)";
        }
    }
}
