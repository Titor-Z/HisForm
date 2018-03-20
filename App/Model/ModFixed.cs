using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Model
{
    class ModFixed:DbHelper
    {
        public ModFixed()
        {
            this.strTable = "fixed";
            this.strWhere = "(ispass = 1)";
        }
    }
}
