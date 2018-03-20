using System;
using System.Collections.Generic;
using System.Linq;
using App.Common;
using System.Text;

namespace App.Model
{
    class ModDoctorLevel:DbHelper
    {
        public ModDoctorLevel()
        {
            this.strTable = "doctorLevel";
            this.strWhere = "(ispass = 1)";
        }
    }
}
