using App.Common;

namespace App.Model
{
    class ModPart:DbHelper
    {
        public ModPart()
        {
            this.strTable = "part";
            this.strWhere = "(isPass = 1)";
        }
    }
}
