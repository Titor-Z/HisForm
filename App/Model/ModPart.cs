using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModPart:DbHelper
    {
        public ModPart()
        {
            this.strTable = "part";
            this.strWhere = "(ispass = 1)";
        }
    }
}
