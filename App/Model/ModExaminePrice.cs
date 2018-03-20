using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModExaminePrice:DbHelper
    {
        public ModExaminePrice()
        {
            this.strTable = "examinePrice";
            this.strWhere = "(ispass = 1)";
        }
    }
}
