using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModConformation:DbHelper
    {
        public ModConformation()
        {
            this.strTable = "conformation";
            this.strWhere = "(ispass = 1)";
        }
    }
}
