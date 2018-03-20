using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModExaminePack:DbHelper
    {
        public ModExaminePack()
        {
            this.strTable = "examinePack";
            this.strWhere = "(ispass = 1 )";
        }
    }
}
