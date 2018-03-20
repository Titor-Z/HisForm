using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModPayType:DbHelper
    {
        public ModPayType()
        {
            this.strTable = "payType";
            this.strWhere = "(ispass = 1)";
        }
    }
}
