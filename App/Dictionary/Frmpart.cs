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
    public partial class FrmPart : CCSkinMain
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of d4976f3... Merge branch 'pr/5' into BindToDatabase
        //****************************************************************************************************
        //委托：
        public FrmMain tabForm
        {
            get; set;
        }

        //****************************************************************************************************
        // 构造开始：
<<<<<<< HEAD
=======
        //***********************************************
        //委托
        public FrmMain tabFrom
        {
            get; set;
        }
>>>>>>> pr/5
=======
>>>>>>> parent of 19c8a7b... changes
=======
>>>>>>> parent of d4976f3... Merge branch 'pr/5' into BindToDatabase
        public FrmPart()
        {
            InitializeComponent();
        }

        private void Frmpart_Load(object sender, EventArgs e)
        {

<<<<<<< HEAD
                grd.AutoGenerateColumns = false;
                grd.DataSource = dt;
                grd.Rows[intIndex].Cells[1].Selected = true;
            }
<<<<<<< HEAD
=======
        //************************************************************
        //加载
        private void Frmpart_Load(object sender, EventArgs e)
        {
            showData();
>>>>>>> pr/5
=======
>>>>>>> parent of 19c8a7b... changes
=======
>>>>>>> parent of d4976f3... Merge branch 'pr/5' into BindToDatabase
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmPart frm = new FrmPart();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
