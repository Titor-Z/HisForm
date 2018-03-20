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
    public partial class FrmDeviceEdit : CCSkinMain
    {
		//***************************************
		//声明一个私有变量
		private int intId;
        public FrmDeviceEdit(int intId = 0)
        {
            InitializeComponent();
			this.intId = intId;
        }

        private void FrmDeviceEdit_Load(object sender, EventArgs e)
        {
			if (intId == 0) {
				this.Text = "添加" + this.Text;
				ParseCombobox.setFactory(cmbFactoryId);
			} else {
				this.Text = "修改" + this.Text;

				DataRow dr = new ModDevice().setWhere("id > 0", true).getFind(intId);
				if (dr == null) {
					Function.showMessage("数据不存在！");
				} else {
					txtDeviceCode.Text = dr["deviceCode"].ToString();
					txtDeviceName.Text = dr["deviceName"].ToString();
					txtSpell.Text = dr["spell"].ToString();

					chkIsPass.Checked = Convert.ToBoolean(dr["isPass"]);

					//下拉框
					ParseCombobox.setFactory(cmbFactoryId,dr["MANUFACTURER"]);
				}
			}

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
