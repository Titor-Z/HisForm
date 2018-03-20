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
    public partial class FrmAntibiosisLevel : CCSkinMain
    {
        //***************************************************
        //委托
        public FrmMain tabFrom
        {
            get;set;
        }
        public FrmAntibiosisLevel()
        {
            InitializeComponent();
        }
        //***************************************************
        //加载
        private void FrmAntibiosisLevel_Load(object sender, EventArgs e)
        {
            showData();
        }
        //***************************************************
        //数据调用
        public void showData()
        {
            DataTable db = new ModAntibiosisLevel().setWhere("id > 0", true).getSelect();
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
        //*****************************************************************
        //添加
        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmAntibiosisLevelEdit frm = new FrmAntibiosisLevelEdit();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                showData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //*****************************************************************
        //修改
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmAntibiosisLevelEdit frm = new FrmAntibiosisLevelEdit(Convert.ToInt32(grd.CurrentRow.Cells["id"].Value));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                showData();
            }
        }
    }
}
