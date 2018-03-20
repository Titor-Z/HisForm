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
    public partial class FrmChargeTypeEdit : CCSkinMain
    {
        //定义一个私有变量
        private int intId;
        public FrmChargeTypeEdit(int intId = 0)
        {
            InitializeComponent();
            this.intId = intId;
        }

        private void FrmSubjectEdit_Load(object sender, EventArgs e)
        {
            if (this.intId == 0 )
            {
                this.Text = "添加" + this.Text;
            }
            else
            {
                this.Text = "修改" + this.Text;
                DataRow dr = new ModChargeType().setWhere("id > 0 ", true).getFind(intId);
                if (dr == null)
                {
                    Function.showMessage("记录为空");
                    this.Close();
                }
                else
                {
                    txtChargeTypeCode.Text = dr["chargeTypeCode"].ToString();
                    txtChargeTypeName.Text = dr["chargeTypeName"].ToString();

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
