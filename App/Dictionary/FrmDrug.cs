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

namespace App.Dictionary {
	public partial class FrmDrug:CCSkinMain
    {
        //***********************************************
        //委托
        public FrmMain tabFrom
        {
            get; set;
        }
        public FrmDrug() {
			InitializeComponent();
		}
        //************************************************************
        //加载
        private void FrmDrug_Load(object sender, EventArgs e)
        {
            showData();
        }
        //************************************************************
        //数据调用
        public void showData()
        {
            DataTable db = new ModDrug().setWhere("id > 0", true).getSelect();
            if (db == null)
            {
                toolStripButton1.Enabled = false;
            }
            else
            {
                toolStripButton1.Enabled = true;

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
		//****************************************************************
		//添加
		private void btnInsert_Click(object sender, EventArgs e) {
			//new FrmDrugEdit().ShowDialog();
			FrmDrugEdit frm = new FrmDrugEdit();
			if (frm.ShowDialog() == DialogResult.OK) {
				showData();
			}
		}
		//****************************************************************
		//修改
		private void toolStripButton1_Click(object sender, EventArgs e) {
			FrmDrugEdit frm = new FrmDrugEdit(Convert.ToInt32(grd.CurrentRow.Cells["id"].Value));
			if (frm.ShowDialog() == DialogResult.OK) {
				showData();
			}
		}
	}
}
