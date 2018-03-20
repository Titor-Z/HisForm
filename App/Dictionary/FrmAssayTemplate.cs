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
    public partial class FrmAssayTemplate : CCSkinMain
    {
        //**********************************************************
        //委托
        public FrmMain tabFrom
        {
            get;set;
        }
        public FrmAssayTemplate()
        {
            InitializeComponent();
        }
        //**********************************************************
        //加载
        private void FrmAssayTemplate_Load(object sender, EventArgs e)
        {
            showData();
        }
        //**********************************************************
        //数据调用
        public void showData()
        {
            DataTable db = new ModAssayTemplate().setWhere("id > 0", true).getSelect();
            if (db == null)
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;

                int intIdex = 0;
                if (grd.Rows.Count > 0)
                {
                    intIdex = grd.CurrentRow.Index;
                }

                grd.AutoGenerateColumns = false;
                grd.DataSource = db;
                grd.Rows[intIdex].Cells[1].Selected = true;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmAssayTemplateEdit frm = new FrmAssayTemplateEdit();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                showData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmAssayTemplateEdit frm = new FrmAssayTemplateEdit(Convert.ToInt32(grd.CurrentRow.Cells["id"].Value));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                showData();
            }
        }
    }
}
