using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Common;

namespace App.Model
{
    class ModDrugHouse:DbHelper
    {
        public ModDrugHouse()
        {
            this.strTable = "drugHouse";
            this.strWhere = "(ispass = 1)";
        }
    }
}
