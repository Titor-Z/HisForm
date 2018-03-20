using System;
using System.Collections.Generic;
using System.Linq;
using App.Common;
using System.Text;

namespace App.Model
{
    class ModMedicareType:DbHelper
    {
        public ModMedicareType()
        {
            this.strTable = "medicareType"; 
            this.strWhere = "(ispass = 1)";
        }
    }
}
