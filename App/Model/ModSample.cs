using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Common;

namespace App.Model
{
    class ModSample : DbHelper {

        public ModSample()
            {
            this.strTable = "Sample";
            this.strWhere = "(ispass = 1)";
            }
    }
}
