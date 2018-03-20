using System;
using System.Collections.Generic;
using System.Linq;
using App.Common;
using System.Text;

namespace App.Model
{
    class ModChargeType:DbHelper
    {
        public ModChargeType()
        {
            this.strTable = "chargeType";
            this.strWhere = "(ispass = 1)";
        }
    }
}
