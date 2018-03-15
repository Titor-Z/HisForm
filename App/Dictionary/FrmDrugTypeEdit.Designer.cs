namespace App.Dictionary
{
    partial class FrmDrugTypeEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkIsPass = new CCWin.SkinControl.SkinCheckBox();
            this.txtDrugTypeCode = new CCWin.SkinControl.SkinTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new CCWin.SkinControl.SkinButton();
            this.btnClose = new CCWin.SkinControl.SkinButton();
            this.txtDrugType = new CCWin.SkinControl.SkinTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.skinGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkIsPass
            // 
            this.chkIsPass.AutoSize = true;
            this.chkIsPass.BackColor = System.Drawing.Color.Transparent;
            this.chkIsPass.Checked = true;
            this.chkIsPass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsPass.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkIsPass.DownBack = null;
            this.chkIsPass.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkIsPass.Location = new System.Drawing.Point(125, 171);
            this.chkIsPass.MouseBack = null;
            this.chkIsPass.Name = "chkIsPass";
            this.chkIsPass.NormlBack = null;
            this.chkIsPass.SelectedDownBack = null;
            this.chkIsPass.SelectedMouseBack = null;
            this.chkIsPass.SelectedNormlBack = null;
            this.chkIsPass.Size = new System.Drawing.Size(75, 21);
            this.chkIsPass.TabIndex = 2;
            this.chkIsPass.Text = "是否启用";
            this.chkIsPass.UseVisualStyleBackColor = false;
            // 
            // txtDrugTypeCode
            // 
            this.txtDrugTypeCode.BackColor = System.Drawing.Color.Transparent;
            this.txtDrugTypeCode.DownBack = null;
            this.txtDrugTypeCode.Icon = null;
            this.txtDrugTypeCode.IconIsButton = false;
            this.txtDrugTypeCode.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDrugTypeCode.IsPasswordChat = '\0';
            this.txtDrugTypeCode.IsSystemPasswordChar = false;
            this.txtDrugTypeCode.Lines = new string[0];
            this.txtDrugTypeCode.Location = new System.Drawing.Point(125, 70);
            this.txtDrugTypeCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtDrugTypeCode.MaxLength = 32767;
            this.txtDrugTypeCode.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtDrugTypeCode.MouseBack = null;
            this.txtDrugTypeCode.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDrugTypeCode.Multiline = false;
            this.txtDrugTypeCode.Name = "txtDrugTypeCode";
            this.txtDrugTypeCode.NormlBack = null;
            this.txtDrugTypeCode.Padding = new System.Windows.Forms.Padding(5);
            this.txtDrugTypeCode.ReadOnly = false;
            this.txtDrugTypeCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDrugTypeCode.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtDrugTypeCode.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDrugTypeCode.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDrugTypeCode.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtDrugTypeCode.SkinTxt.ForeColor = System.Drawing.Color.Black;
            this.txtDrugTypeCode.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtDrugTypeCode.SkinTxt.Name = "BaseText";
            this.txtDrugTypeCode.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtDrugTypeCode.SkinTxt.TabIndex = 0;
            this.txtDrugTypeCode.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDrugTypeCode.SkinTxt.WaterText = "请输入编号";
            this.txtDrugTypeCode.TabIndex = 0;
            this.txtDrugTypeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDrugTypeCode.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDrugTypeCode.WaterText = "请输入编号";
            this.txtDrugTypeCode.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(82, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox1.Controls.Add(this.label5);
            this.skinGroupBox1.Controls.Add(this.label2);
            this.skinGroupBox1.Controls.Add(this.btnSave);
            this.skinGroupBox1.Controls.Add(this.chkIsPass);
            this.skinGroupBox1.Controls.Add(this.btnClose);
            this.skinGroupBox1.Controls.Add(this.txtDrugType);
            this.skinGroupBox1.Controls.Add(this.label3);
            this.skinGroupBox1.Controls.Add(this.txtDrugTypeCode);
            this.skinGroupBox1.Controls.Add(this.label1);
            this.skinGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(4, 28);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(392, 265);
            this.skinGroupBox1.TabIndex = 5;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(72, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(72, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "*";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSave.DownBack = null;
            this.btnSave.Location = new System.Drawing.Point(110, 221);
            this.btnSave.MouseBack = null;
            this.btnSave.Name = "btnSave";
            this.btnSave.NormlBack = null;
            this.btnSave.Size = new System.Drawing.Size(76, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClose.DownBack = null;
            this.btnClose.Location = new System.Drawing.Point(207, 221);
            this.btnClose.MouseBack = null;
            this.btnClose.Name = "btnClose";
            this.btnClose.NormlBack = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDrugType
            // 
            this.txtDrugType.BackColor = System.Drawing.Color.Transparent;
            this.txtDrugType.DownBack = null;
            this.txtDrugType.Icon = null;
            this.txtDrugType.IconIsButton = false;
            this.txtDrugType.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDrugType.IsPasswordChat = '\0';
            this.txtDrugType.IsSystemPasswordChar = false;
            this.txtDrugType.Lines = new string[0];
            this.txtDrugType.Location = new System.Drawing.Point(125, 112);
            this.txtDrugType.Margin = new System.Windows.Forms.Padding(0);
            this.txtDrugType.MaxLength = 32767;
            this.txtDrugType.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtDrugType.MouseBack = null;
            this.txtDrugType.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDrugType.Multiline = true;
            this.txtDrugType.Name = "txtDrugType";
            this.txtDrugType.NormlBack = null;
            this.txtDrugType.Padding = new System.Windows.Forms.Padding(5);
            this.txtDrugType.ReadOnly = false;
            this.txtDrugType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDrugType.Size = new System.Drawing.Size(184, 29);
            // 
            // 
            // 
            this.txtDrugType.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDrugType.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDrugType.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtDrugType.SkinTxt.ForeColor = System.Drawing.Color.Black;
            this.txtDrugType.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtDrugType.SkinTxt.Multiline = true;
            this.txtDrugType.SkinTxt.Name = "BaseText";
            this.txtDrugType.SkinTxt.Size = new System.Drawing.Size(174, 19);
            this.txtDrugType.SkinTxt.TabIndex = 0;
            this.txtDrugType.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDrugType.SkinTxt.WaterText = "请输入名称";
            this.txtDrugType.TabIndex = 1;
            this.txtDrugType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDrugType.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDrugType.WaterText = "请输入名称";
            this.txtDrugType.WordWrap = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(82, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "名称：";
            // 
            // FrmDrugTypeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.skinGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDrugTypeEdit";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑药品类型";
            this.Load += new System.EventHandler(this.FrmDrugTypeEdit_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinCheckBox chkIsPass;
        private CCWin.SkinControl.SkinTextBox txtDrugTypeCode;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinButton btnSave;
        private CCWin.SkinControl.SkinButton btnClose;
        private CCWin.SkinControl.SkinTextBox txtDrugType;
        private System.Windows.Forms.Label label3;
    }
}