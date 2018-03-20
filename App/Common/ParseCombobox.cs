using App.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace App.Common {
	class ParseCombobox {
		//****************************************************************************************************
		//性别
		public static void setSex(ComboBox cmb, Object value = null) {
			DataTable dt = new DataTable();

			DataColumn dcText = new DataColumn("text");
			DataColumn dcValue = new DataColumn("value");

			dt.Columns.Add(dcText);
			dt.Columns.Add(dcValue);

			string[] arr = { "", "男", "女" };
			foreach (string val in arr) {
				DataRow dr = dt.NewRow();

				if (val == "") {
					dr["text"] = "--请选择性别--";
				} else {
					dr["text"] = val;
				}

				dr["value"] = val;

				dt.Rows.Add(dr);
			}

			cmb.DataSource = dt;
			cmb.DisplayMember = "text";
			cmb.ValueMember = "value";

			if (value == null) {
				cmb.SelectedValue = "";
			} else {
				cmb.SelectedValue = value.ToString();
			}
		}
		//****************************************************************************************************
		//婚姻状况
		public static void setMarital(ComboBox cmb, Object value = null) {
			DataTable dt = new DataTable();

			DataColumn dcText = new DataColumn("text");
			DataColumn dcValue = new DataColumn("value");

			dt.Columns.Add(dcText);
			dt.Columns.Add(dcValue);

			string[] arr = { "", "已婚", "未婚", "离异" };
			foreach (string val in arr) {
				DataRow dr = dt.NewRow();

				if (val == "") {
					dr["text"] = "--请选择婚姻状况--";
				} else {
					dr["text"] = val;
				}

				dr["value"] = val;

				dt.Rows.Add(dr);
			}

			cmb.DataSource = dt;
			cmb.DisplayMember = "text";
			cmb.ValueMember = "value";

			if (value == null) {
				cmb.SelectedValue = "";
			} else {
				cmb.SelectedValue = value.ToString();
			}
		}
		//****************************************************************************************************
		//血型
		public static void setBlood(ComboBox cmb, Object value = null) {
			DataTable dt = new DataTable();

			DataColumn dcText = new DataColumn("text");
			DataColumn dcValue = new DataColumn("value");

			dt.Columns.Add(dcText);
			dt.Columns.Add(dcValue);

			string[] arr = { "", "A型", "B型", "AB型", "O型", "Rh型" };
			foreach (string val in arr) {
				DataRow dr = dt.NewRow();

				if (val == "") {
					dr["text"] = "--请选择血型--";
				} else {
					dr["text"] = val;
				}

				dr["value"] = val;

				dt.Rows.Add(dr);
			}

			cmb.DataSource = dt;
			cmb.DisplayMember = "text";
			cmb.ValueMember = "value";

			if (value == null) {
				cmb.SelectedValue = "";
			} else {
				cmb.SelectedValue = value.ToString();
			}
		}
		//****************************************************************************************************
		//民族
		public static void setNation(ComboBox cmb, Object value = null) {
			DataTable dt = new DataTable();

			DataColumn dcText = new DataColumn("text");
			DataColumn dcValue = new DataColumn("value");

			dt.Columns.Add(dcText);
			dt.Columns.Add(dcValue);

			string[] arr = { "", "汉族", "回族", "满族", "蒙古族", "藏族", "维吾尔族", "苗族", "彝族", "壮族", "布依族", "朝鲜族", "侗族", "瑶族", "白族", "土家族", "哈尼族", "哈萨克族", "傣族", "黎族", "僳僳族", "佤族", "畲族", "高山族", "拉祜族", "水族", "东乡族", "纳西族", "景颇族", "柯尔克孜族", "土族", "达斡尔族", "仫佬族", "羌族", "布朗族", "撒拉族", "毛南族", "仡佬族", "锡伯族", "阿昌族", "普米族", "塔吉克族", "怒族", "乌孜别克族", "俄罗斯族", "鄂温克族", "德昂族", "保安族", "裕固族", "京族", "塔塔尔族", "独龙族", "鄂伦春族", "赫哲族", "门巴族", "珞巴族", "基诺族" };
			foreach (string val in arr) {
				DataRow dr = dt.NewRow();

				if (val == "") {
					dr["text"] = "--请选择民族--";
				} else {
					dr["text"] = val;
				}

				dr["value"] = val;

				dt.Rows.Add(dr);
			}

			cmb.DataSource = dt;
			cmb.DisplayMember = "text";
			cmb.ValueMember = "value";

			if (value == null) {
				cmb.SelectedValue = "";
			} else {
				cmb.SelectedValue = value.ToString();
			}
		}
		//****************************************************************************************************
		//院区
		public static void setHospital(ComboBox cmb, Object value = null) {
			DataTable dt = new ModHospital().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("hospitalName");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["hospitalName"] = "--请选择院区--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "hospitalName";

			cmb.SelectedValue = Convert.ToInt32(value);
		}
		//****************************************************************************************************
		//科室类型
		public static void setDepartmentType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModDepartmentType().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("departmentType");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["departmentType"] = "--请选择科室类型--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "departmentType";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//科室
		public static void setDepartment(ComboBox cmb, Object value = null) {
			DataTable dt = new ModDepartment().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("departmentName");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["departmentName"] = "--请选择科室--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "departmentName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//员工类型
		public static void setWorkerType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModWorkerType().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("workerType");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["workerType"] = "--请选择员工类型--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "workerType";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//员工
		public static void setWorker(ComboBox cmb, Object value = null) {
			DataTable dt = new ModWorker().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("realname");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["realname"] = "--请选择员工--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "realname";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//会员级别
		public static void setUserLevel(ComboBox cmb, Object value = null) {
			DataTable dt = new ModUserLevel().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("userLevel");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["userLevel"] = "--请选择会员级别--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "userLevel";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//患者来源
		public static void setUserSource(ComboBox cmb, Object value = null) {
			DataTable dt = new ModUserSource().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("userSource");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["userSource"] = "--请选择患者来源--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "userSource";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//患者类型
		public static void setUserType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModUserType().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("userType");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["userType"] = "--请选择患者类型--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "userType";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//职业类型
		public static void setJobType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModJobType().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("jobType");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["jobType"] = "--请选择职业类型--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "jobType";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//证件类型
		public static void setCertificateType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModCertificateType().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("certificateType");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["certificateType"] = "--请选择证件类型--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "certificateType";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//联系人关系
		public static void setRelation(ComboBox cmb, Object value = null) {
			DataTable dt = new ModRelation().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("relationName");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["relationName"] = "--请选择联系人关系--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "relationName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//短信模板
		public static void setSmsTemplate(ComboBox cmb, Object value = null) {
			DataTable dt = new ModSmsTemplate().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("templateName");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["templateName"] = "--请选择短信模板--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "templateName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//话术模板
		public static void setSayTemplate(ComboBox cmb, Object value = null) {
			DataTable dt = new ModSayTemplate().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("templateName");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["templateName"] = "--请选择话术模板--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "templateName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//备注模板
		public static void setRemarkTemplate(ComboBox cmb, Object value = null) {
			DataTable dt = new ModRemarkTemplate().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("templateName");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["templateName"] = "--请选择备注模板--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "templateName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//挂号类型
		public static void setRegisterType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModRegisterType().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("registerType");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["registerType"] = "--挂号类型--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "registerType";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//计量单位
		public static void setUnit(ComboBox cmb, Object value = null) {
			DataTable dt = new ModUnit().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("unitName");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["unitName"] = "--计量单位--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "unitName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//收费科目
		public static void setChargeType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModChargeType().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("chargeTypeName");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}
			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["chargeTypeName"] = "--收费类型--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "chargeTypeName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//财务分类
		public static void setFinanceType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModFinanceType().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("financeTypeName");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["financeTypeName"] = "--财务分类--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "financeTypeName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//发票分类
		public static void setInvoiceType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModInvoiceType().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("invoiceTypeName");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["invoiceTypeName"] = "--发票分类--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "invoiceTypeName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//生产厂商
		public static void setFactory(ComboBox cmb, Object value = null) {
			DataTable dt = new ModFactory().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("factoryName");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["factoryName"] = "--发票分类--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "factoryName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//抗菌药物级别 
		public static void setAntibiosisLevel(ComboBox cmb, Object value = null) {
			DataTable dt = new ModAntibiosisLevel().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("antibiosisLevelName");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["antibiosisLevelName"] = "--抗菌药物级别--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "antibiosisLevelName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
		//药品类型  
		public static void setDrugType(ComboBox cmb, Object value = null) {
			DataTable dt = new ModDrugType().getSelect();
			if (dt == null) {
				dt = new DataTable();

				DataColumn dcText = new DataColumn("id");
				DataColumn dcValue = new DataColumn("drugTypeName");

				dt.Columns.Add(dcText);
				dt.Columns.Add(dcValue);
			}

			DataRow dr = dt.NewRow();
			dr["id"] = 0;
			dr["drugTypeName"] = "--药品类型--";
			dt.Rows.InsertAt(dr, 0);

			cmb.DataSource = dt;
			cmb.ValueMember = "id";
			cmb.DisplayMember = "drugTypeName";

			if (value == null) {
				cmb.SelectedValue = 0;
			} else {
				cmb.SelectedValue = Convert.ToInt32(value);
			}
		}
		//****************************************************************************************************
	}
}
