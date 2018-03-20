﻿using System;
using System.Windows.Forms;

namespace App.Common {
	class ParseGrid {
		//****************************************************************************************************
		//显示启用
		public static void showPass(DataGridView grd, DataGridViewCellFormattingEventArgs e) {
			if (grd.Columns[e.ColumnIndex].DataPropertyName == "isPass") {
				if (Convert.ToInt32(e.Value) == 1) {
					e.Value = "启用";
				} else {
					e.Value = "禁用";

					grd.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
				}
			}
		}
		//****************************************************************************************************
	}
}
