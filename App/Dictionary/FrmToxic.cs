using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.Dictionary {
	public partial class FrmToxic : CCSkinMain {
		public FrmToxic() {
			InitializeComponent();
		}

		private void FrmToxic_Load(object sender, EventArgs e) {

		}

		private void btnInsert_Click(object sender, EventArgs e) {
			FrmToxicEdit frm = new FrmToxicEdit();
			frm.ShowDialog();
		}

		private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
