using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.Dictionary
{
    public partial class FrmDoctorLevel : CCSkinMain
    {
        public FrmDoctorLevel()
        {
            InitializeComponent();
        }

        private void FrmDoctorLevel_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmDoctorLevelEdit frm = new FrmDoctorLevelEdit();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
