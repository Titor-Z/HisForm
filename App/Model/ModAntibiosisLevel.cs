using System;
using System.Collections.Generic;
using System.Linq;
using App.Common;
using System.Text;

namespace App.Model
{
    class ModAntibiosisLevel:DbHelper
    {
        public ModAntibiosisLevel()
        {
            this.strTable = "antibiosisLevel";
            this.strWhere = "(ispass = 1)";
        }
    }
}
