using System;
using System.Collections.Generic;
using System.Linq;
using App.Common;
using System.Text;

namespace App.Model
{
    class ModPack:DbHelper
    {
        public ModPack()
        {
            this.strTable = "pack";
            this.strWhere = "(ispass = 1)";
        }
    }
}
