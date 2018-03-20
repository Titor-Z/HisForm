using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using App.Common;
using App.Model;

namespace App.Dictionary
{
    public partial class FrmSample : CCSkinMain
    {
        //********************************************************************
        //委托
        public FrmMain tabForm
        {
            get;set;
        }
        public FrmSample()
        {
            InitializeComponent();
        }
        //********************************************************************
        //加载
        private void FrmSample_Load(object sender, EventArgs e)
        {
            showData();
        }
        //********************************************************************
        //数据显示
        public void showData()
        {
            DataTable db = new ModSample().setWhere("id > 0 ", true).getSelect();
            if (db == null)
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;

                int intIndex = 0;
                if (grd.Rows.Count > 0)
                {
                    intIndex = grd.CurrentRow.Index;
                }

                grd.AutoGenerateColumns = false;
                grd.DataSource = db;
                grd.Rows[intIndex].Cells[1].Selected = true;
            }
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void skinToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
