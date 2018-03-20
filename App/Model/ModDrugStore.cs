using App.Common;

namespace App.Model {
	class ModDrugStore : DbHelper {
		public ModDrugStore() {
			this.strTable = "drugStore";
            this.strWhere = "(ispass = 1)";
		}
	}
}
