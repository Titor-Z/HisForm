﻿using App.Model;
using CCWin;
using System;
using System.Data;

namespace App.Dictionary {
    public partial class FrmPart : CCSkinMain
    {
        //****************************************************************************************************
        //委托：
        public FrmMain tabForm
        {
            get; set;
        }

        //****************************************************************************************************
        // 构造开始：
        public FrmPart()
        {
            InitializeComponent();
        }

        //****************************************************************************************************
        // 显示数据：
        private void Frmpart_Load(object sender, EventArgs e)
        {
            showData();
        }

        //****************************************************************************************************
        // 定义公用显示数据方法：
        private void showData()
        {
            // 查询记录集：
            DataTable dt = new ModPart().setWhere("id > 0").getSelect();

            // 如果获取的数据集为空，则将修改按钮设为 禁用。
            if (dt == null) {
                btnUpdate.Enabled = false;
            } else {
                btnUpdate.Enabled = true;

                // 获得数据格
                int intIndex = 0;
                if (grd.Rows.Count > 0) {
                    intIndex = grd.CurrentRow.Index;
                }

                grd.AutoGenerateColumns = false;
                grd.DataSource = dt;
                grd.Rows[intIndex].Cells[1].Selected = true;
            }
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
