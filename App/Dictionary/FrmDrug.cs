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
	public partial class FrmDrug:CCSkinMain {
		public FrmDrug() {
			InitializeComponent();
		}

		private void FrmDrug_Load(object sender, EventArgs e) {

		}

		private void btnInsert_Click(object sender, EventArgs e) {
			new FrmDrugEdit().ShowDialog();
		}
	}
}
