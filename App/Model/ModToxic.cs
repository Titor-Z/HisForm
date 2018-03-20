using System;
using System.Collections.Generic;
using System.Linq;
using App.Common;
using System.Text;

namespace App.Model
{
    class ModToxic : DbHelper
    {
        public ModToxic()
        {
            this.strTable = "toxic";
            this.strWhere = "(ispass = 1)";
        }
    }
}
