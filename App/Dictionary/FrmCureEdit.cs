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
    public partial class FrmCureEdit : CCSkinMain
    {
        //*******************************************
        //声明一个私有变量
        private int intId;
        public FrmCureEdit(int intId = 0)
        {
            InitializeComponent();

            this.intId = intId;
        }

        private void FrmCureEdit_Load(object sender, EventArgs e)
        {
            if (intId == 0 )
            {
                this.Text = "添加" + this.Text;
                ParseCombobox.setUnit(cmbUnitId);//计量单位
                ParseCombobox.setChargeType(cmbChargeTypeId);//收费科目
                ParseCombobox.setFinanceType(cmbFinanceTypeId);//财务费率
                ParseCombobox.setInvoiceType(cmbInvoiceTypeId);//发票分类
            }
            else
            {
                this.Text = "修改" + this.Text;

                DataRow dr = new ModCure().setWhere("id > 0", true).getFind(intId);

                txtCureName.Text = dr["cureName"].ToString();
                txtSpell.Text = dr["spell"].ToString();
                txtMedicineCode.Text = dr["medicineCode"].ToString();
                txtSpec.Text = dr["spce"].ToString();
                //下拉框
                ParseCombobox.setUnit(cmbUnitId, dr["unitId"]);
                ParseCombobox.setChargeType(cmbChargeTypeId,dr["chargeTypeId"]);
                ParseCombobox.setFinanceType(cmbFinanceTypeId, dr["financeTypeId"]);
                ParseCombobox.setInvoiceType(cmbInvoiceTypeId, dr["invoiceTypeId"]);
				//复选框
				chkIsPass.Checked = Convert.ToBoolean(dr["isPass"]);

			}
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
