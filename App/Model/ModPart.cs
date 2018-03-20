<<<<<<< HEAD
﻿using App.Common;
=======
﻿using System;
using App.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
>>>>>>> pr/5

namespace App.Model
{
    class ModPart:DbHelper
    {
        public ModPart()
        {
            this.strTable = "part";
<<<<<<< HEAD
            this.strWhere = "(isPass = 1)";
=======
            this.strWhere = "(ispass = 1)";
>>>>>>> pr/5
        }
    }
}
