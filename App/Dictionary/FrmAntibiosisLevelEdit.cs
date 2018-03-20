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
    public partial class FrmAntibiosisLevelEdit : CCSkinMain
    {
        private int intId;
        //****************************************************************************************************
        public FrmAntibiosisLevelEdit(int intId = 0)
        {
            InitializeComponent();

            this.intId = intId;
        }
        //****************************************************************************************************
        private void FrmAntibiosisLevelEdit_Load(object sender, EventArgs e)
        {
            if (intId == 0)
            {
                this.Text = "添加" + this.Text;
            }
            else
            {
                this.Text = "修改" + this.Text;

                DataRow dr = new ModAntibiosisLevel().setWhere("id > 0", true).getFind(intId);
                if (dr == null)
                {
                    Function.showMessage("记录为空");
                    this.Close();
                }
                else
                {
                    txtAntibiosisLevelCode.Text = dr["antibiosisLevelCode"].ToString();
                    txtAntibiosisLevelName.Text = dr["antibiosisLevelName"].ToString();

                    chkIsPass.Checked = Convert.ToBoolean(dr["isPass"]);
                }
            }
        }
        //****************************************************************************************************
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //****************************************************************************************************
    }
}
