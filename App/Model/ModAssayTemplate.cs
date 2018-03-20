using System;
using System.Collections.Generic;
using App.Common;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModAssayTemplate:DbHelper
    {
        public ModAssayTemplate()
        {
            this.strTable = "assayTemplate";
            this.strWhere = "(ispass = 1)";
        }

    }
}
