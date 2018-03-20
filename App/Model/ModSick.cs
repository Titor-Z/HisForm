using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Common;

namespace App.Model
{
    class ModSick : DbHelper
    {
        public ModSick()
        {
            this.strTable = "Sick";
            this.strWhere = "(ispass = 1)";
;        }
    }
}
