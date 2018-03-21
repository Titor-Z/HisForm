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
    public partial class FrmPayTypeEdit : CCSkinMain
    {
       //**********************************
        private int intId;
        public FrmPayTypeEdit(int intId = 0) {
            InitializeComponent();
            this.intId = intId;
        }

        //************************************************************************
        // 操作状态切换：
        // 如果当前窗体获取到传入的ID，则打开的状态为编辑：
        private void FrmPayTypeEdit_Load(object sender, EventArgs e) {
            if (intId == 0) {
                this.Text = "添加" + this.Text;
            }
            else {
                this.Text = "修改" + this.Text;
                DataRow dr = new ModPayType().setWhere("id > 0 ", true).getFind(intId);
                if (dr == null) {
                    Function.showMessage("数据不存在！");
                    this.Close();
                }
                else {
                    txtPayTypeCode.Text = dr["payTypeCode"].ToString();
                    txtPayTypeName.Text = dr["payTypeName"].ToString();

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
