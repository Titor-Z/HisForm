using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModFactory:DbHelper
    {
        public ModFactory()
        {
            this.strTable = "factory";
            this.strWhere = "(ispass = 1)";
        }
    }
}
