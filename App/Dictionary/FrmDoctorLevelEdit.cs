using App.Common;
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
    public partial class FrmDoctorLevelEdit : CCSkinMain
    {
		//**************************************************
		//声明一个私有变量
		private int intId;
        public FrmDoctorLevelEdit(int intId = 0)
        {
            InitializeComponent();
			this.intId = intId;
        }

        private void FrmDoctorLevelEdit_Load(object sender, EventArgs e)
        {
			if (intId == 0) {
				this.Text = "添加" + this.Text;
			} else {
				this.Text = "修改" + this.Text;

				DataRow dr = new ModDoctorLevel().setWhere("id > 0", true).getFind(intId);
				if (dr == null) {
					Function.showMessage("数据不存在！");
					this.Close();
				} else {
					txtDoctorLevelCode.Text = dr["doctorLevelCode"].ToString();
					txtDoctorLevelName.Text = dr["doctorLevelName"].ToString();

					chkIsPass.Checked = Convert.ToBoolean(dr["isPass"]);
				}
			}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
