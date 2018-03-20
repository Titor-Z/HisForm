using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModExamineTemplate:DbHelper
    {
        public ModExamineTemplate()
        {
            this.strTable = "examineTemplate";
            this.strWhere = "(ispass = 1)";
        }
    }
}
