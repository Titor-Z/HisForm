﻿using App.Common;
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
    public partial class FrmSupplierEdit : CCSkinMain
    {
        //**********************************
        // 声明id容器：
        private int intId;
        public FrmSupplierEdit(int intId = 0) {
            InitializeComponent();
            this.intId = intId;
        }

        //************************************************************************
        // 操作状态切换：
        // 如果当前窗体获取到传入的ID，则打开的状态为编辑：
        private void FrmSupplierEdit_Load(object sender, EventArgs e) {
            if (intId == 0) {
                this.Text = "添加" + this.Text;
            }
            else {
                this.Text = "修改" + this.Text;
                DataRow dr = new ModSupplier().setWhere("id > 0 ", true).getFind(intId);
                if (dr == null) {
                    Function.showMessage("数据不存在！");
                    this.Close();
                }
                else {
                    txtSupplierCode.Text = dr["supplierCode"].ToString();
                    txtSupplierName.Text = dr["supplierName"].ToString();
                    txtSpell.Text        = dr["spell"].ToString();
                    txtAddress.Text      = dr["address"].ToString();
                    txtPost.Text = dr["post"].ToString();
                    txtTel.Text = dr["tel"].ToString();
                    txtBankCode.Text = dr["bankCode"].ToString();
                    txtLinkman.Text = dr["linkMan"].ToString();
                    txtBankName.Text = dr["bankName"].ToString();

                    chkIsPass.Checked = Convert.ToBoolean(dr["isPass"]);
                }
            }
        }

        //************************************************************************
        // 关闭当前窗体：
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
