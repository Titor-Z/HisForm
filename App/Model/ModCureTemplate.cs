using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModCureTemplate:DbHelper
    {
        public ModCureTemplate()
        {
            this.strTable = "cureTemplate";
            this.strWhere = "(ispass = 1)";
        }
    }
}
