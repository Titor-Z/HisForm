namespace App.Dictionary
{
    partial class FrmToxicEdit
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
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new CCWin.SkinControl.SkinButton();
            this.chkIsPass = new CCWin.SkinControl.SkinCheckBox();
            this.btnClose = new CCWin.SkinControl.SkinButton();
            this.txtToxicName = new CCWin.SkinControl.SkinTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToxicCode = new CCWin.SkinControl.SkinTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.skinGroupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.skinGroupBox1.Controls.Add(this.txtToxicName);
            this.skinGroupBox1.Controls.Add(this.label3);
            this.skinGroupBox1.Controls.Add(this.txtToxicCode);
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
            // txtToxicName
            // 
            this.txtToxicName.BackColor = System.Drawing.Color.Transparent;
            this.txtToxicName.DownBack = null;
            this.txtToxicName.Icon = null;
            this.txtToxicName.IconIsButton = false;
            this.txtToxicName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtToxicName.IsPasswordChat = '\0';
            this.txtToxicName.IsSystemPasswordChar = false;
            this.txtToxicName.Lines = new string[0];
            this.txtToxicName.Location = new System.Drawing.Point(125, 112);
            this.txtToxicName.Margin = new System.Windows.Forms.Padding(0);
            this.txtToxicName.MaxLength = 32767;
            this.txtToxicName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtToxicName.MouseBack = null;
            this.txtToxicName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtToxicName.Multiline = true;
            this.txtToxicName.Name = "txtToxicName";
            this.txtToxicName.NormlBack = null;
            this.txtToxicName.Padding = new System.Windows.Forms.Padding(5);
            this.txtToxicName.ReadOnly = false;
            this.txtToxicName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtToxicName.Size = new System.Drawing.Size(184, 29);
            // 
            // 
            // 
            this.txtToxicName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToxicName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToxicName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtToxicName.SkinTxt.ForeColor = System.Drawing.Color.Black;
            this.txtToxicName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtToxicName.SkinTxt.Multiline = true;
            this.txtToxicName.SkinTxt.Name = "BaseText";
            this.txtToxicName.SkinTxt.Size = new System.Drawing.Size(174, 19);
            this.txtToxicName.SkinTxt.TabIndex = 0;
            this.txtToxicName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtToxicName.SkinTxt.WaterText = "请输入名称";
            this.txtToxicName.TabIndex = 1;
            this.txtToxicName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtToxicName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtToxicName.WaterText = "请输入名称";
            this.txtToxicName.WordWrap = true;
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
            // txtToxicCode
            // 
            this.txtToxicCode.BackColor = System.Drawing.Color.Transparent;
            this.txtToxicCode.DownBack = null;
            this.txtToxicCode.Icon = null;
            this.txtToxicCode.IconIsButton = false;
            this.txtToxicCode.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtToxicCode.IsPasswordChat = '\0';
            this.txtToxicCode.IsSystemPasswordChar = false;
            this.txtToxicCode.Lines = new string[0];
            this.txtToxicCode.Location = new System.Drawing.Point(125, 70);
            this.txtToxicCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtToxicCode.MaxLength = 32767;
            this.txtToxicCode.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtToxicCode.MouseBack = null;
            this.txtToxicCode.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtToxicCode.Multiline = false;
            this.txtToxicCode.Name = "txtToxicCode";
            this.txtToxicCode.NormlBack = null;
            this.txtToxicCode.Padding = new System.Windows.Forms.Padding(5);
            this.txtToxicCode.ReadOnly = false;
            this.txtToxicCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtToxicCode.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtToxicCode.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToxicCode.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToxicCode.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtToxicCode.SkinTxt.ForeColor = System.Drawing.Color.Black;
            this.txtToxicCode.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtToxicCode.SkinTxt.Name = "BaseText";
            this.txtToxicCode.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtToxicCode.SkinTxt.TabIndex = 0;
            this.txtToxicCode.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtToxicCode.SkinTxt.WaterText = "请输入编号";
            this.txtToxicCode.TabIndex = 0;
            this.txtToxicCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtToxicCode.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtToxicCode.WaterText = "请输入编号";
            this.txtToxicCode.WordWrap = true;
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
            // FrmToxicEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.skinGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmToxicEdit";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑毒理定义";
            this.Load += new System.EventHandler(this.FrmToxicEdit_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinButton btnSave;
        private CCWin.SkinControl.SkinCheckBox chkIsPass;
        private CCWin.SkinControl.SkinButton btnClose;
        private CCWin.SkinControl.SkinTextBox txtToxicName;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinTextBox txtToxicCode;
        private System.Windows.Forms.Label label1;
    }
}