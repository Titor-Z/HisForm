using System;
using System.Collections.Generic;
using System.Linq;
using App.Common;
using System.Text;

namespace App.Model
{
    class ModInvoiceType:DbHelper
    {
        public ModInvoiceType()
        {
            this.strTable = "invoiceType";
            this.strWhere = "(ispass = 1)";
        }
    }
}
