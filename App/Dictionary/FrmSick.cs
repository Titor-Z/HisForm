using App.Model;
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
    public partial class FrmSick : CCSkinMain
    {
        //********************************************************
        //委托
        public FrmMain tabfrom
        {
            get;set;
        }
        public FrmSick()
        {
            InitializeComponent();
        }
        //*******************************************************
        //加载
        private void FrmSick_Load(object sender, EventArgs e)
        {
            showDate();
        }
        //*******************************************************
        //显示数据
        public void showDate()
        {
            DataTable db = new ModSick().setWhere("id > 0", true).getSelect();
            if (db == null)
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;

                int intIndex = 0;
                if (grd.Rows.Count > 0 )
                {
                    intIndex = grd.CurrentRow.Index;
                }

                grd.AutoGenerateColumns = false;
                grd.DataSource = db;
                grd.Rows[intIndex].Cells[1].Selected = true;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmSickEdit frm = new FrmSickEdit();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
