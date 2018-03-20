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
    public partial class FrmExaminePrice : CCSkinMain
    {
        public FrmExaminePrice()
        {
            InitializeComponent();
        }

        private void FrmExaminePrice_Load(object sender, EventArgs e)
        {

        }

        private void skinToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmExaminePriceEdit frm = new FrmExaminePriceEdit();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
