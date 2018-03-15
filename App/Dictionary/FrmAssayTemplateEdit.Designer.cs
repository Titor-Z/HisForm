namespace App.Dictionary
{
    partial class FrmAssayTemplateEdit
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
<<<<<<< HEAD
			this.components = new System.ComponentModel.Container();
			this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSave = new CCWin.SkinControl.SkinButton();
			this.chkIsPass = new CCWin.SkinControl.SkinCheckBox();
			this.btnClose = new CCWin.SkinControl.SkinButton();
			this.skinTextBox4 = new CCWin.SkinControl.SkinTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.skinTextBox3 = new CCWin.SkinControl.SkinTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
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
			this.skinGroupBox1.Controls.Add(this.skinTextBox4);
			this.skinGroupBox1.Controls.Add(this.label4);
			this.skinGroupBox1.Controls.Add(this.skinTextBox3);
			this.skinGroupBox1.Controls.Add(this.label3);
			this.skinGroupBox1.Controls.Add(this.skinTextBox1);
			this.skinGroupBox1.Controls.Add(this.label1);
			this.skinGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
			this.skinGroupBox1.Location = new System.Drawing.Point(4, 28);
			this.skinGroupBox1.Name = "skinGroupBox1";
			this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
			this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
			this.skinGroupBox1.Size = new System.Drawing.Size(392, 265);
			this.skinGroupBox1.TabIndex = 3;
			this.skinGroupBox1.TabStop = false;
			this.skinGroupBox1.Text = "吧";
			this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Red;
			this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
			this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(72, 97);
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
			this.label2.Location = new System.Drawing.Point(72, 54);
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
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "保存&(S)";
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
			this.chkIsPass.TabIndex = 3;
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
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "关闭&(C)";
			this.btnClose.UseVisualStyleBackColor = false;
			// 
			// skinTextBox4
			// 
			this.skinTextBox4.BackColor = System.Drawing.Color.Transparent;
			this.skinTextBox4.DownBack = null;
			this.skinTextBox4.Icon = null;
			this.skinTextBox4.IconIsButton = false;
			this.skinTextBox4.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.skinTextBox4.IsPasswordChat = '\0';
			this.skinTextBox4.IsSystemPasswordChar = false;
			this.skinTextBox4.Lines = new string[0];
			this.skinTextBox4.Location = new System.Drawing.Point(125, 128);
			this.skinTextBox4.Margin = new System.Windows.Forms.Padding(0);
			this.skinTextBox4.MaxLength = 32767;
			this.skinTextBox4.MinimumSize = new System.Drawing.Size(28, 28);
			this.skinTextBox4.MouseBack = null;
			this.skinTextBox4.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.skinTextBox4.Multiline = true;
			this.skinTextBox4.Name = "skinTextBox4";
			this.skinTextBox4.NormlBack = null;
			this.skinTextBox4.Padding = new System.Windows.Forms.Padding(5);
			this.skinTextBox4.ReadOnly = false;
			this.skinTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.skinTextBox4.Size = new System.Drawing.Size(184, 29);
			// 
			// 
			// 
			this.skinTextBox4.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.skinTextBox4.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.skinTextBox4.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.skinTextBox4.SkinTxt.ForeColor = System.Drawing.Color.Black;
			this.skinTextBox4.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.skinTextBox4.SkinTxt.Multiline = true;
			this.skinTextBox4.SkinTxt.Name = "BaseText";
			this.skinTextBox4.SkinTxt.Size = new System.Drawing.Size(174, 19);
			this.skinTextBox4.SkinTxt.TabIndex = 0;
			this.skinTextBox4.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.skinTextBox4.SkinTxt.WaterText = "请输入拼音";
			this.skinTextBox4.TabIndex = 2;
			this.skinTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.skinTextBox4.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.skinTextBox4.WaterText = "请输入拼音";
			this.skinTextBox4.WordWrap = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(82, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "拼音：";
			// 
			// skinTextBox3
			// 
			this.skinTextBox3.BackColor = System.Drawing.Color.Transparent;
			this.skinTextBox3.DownBack = null;
			this.skinTextBox3.Icon = null;
			this.skinTextBox3.IconIsButton = false;
			this.skinTextBox3.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.skinTextBox3.IsPasswordChat = '\0';
			this.skinTextBox3.IsSystemPasswordChar = false;
			this.skinTextBox3.Lines = new string[0];
			this.skinTextBox3.Location = new System.Drawing.Point(125, 85);
			this.skinTextBox3.Margin = new System.Windows.Forms.Padding(0);
			this.skinTextBox3.MaxLength = 32767;
			this.skinTextBox3.MinimumSize = new System.Drawing.Size(28, 28);
			this.skinTextBox3.MouseBack = null;
			this.skinTextBox3.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.skinTextBox3.Multiline = true;
			this.skinTextBox3.Name = "skinTextBox3";
			this.skinTextBox3.NormlBack = null;
			this.skinTextBox3.Padding = new System.Windows.Forms.Padding(5);
			this.skinTextBox3.ReadOnly = false;
			this.skinTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.skinTextBox3.Size = new System.Drawing.Size(184, 29);
			// 
			// 
			// 
			this.skinTextBox3.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.skinTextBox3.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.skinTextBox3.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.skinTextBox3.SkinTxt.ForeColor = System.Drawing.Color.Black;
			this.skinTextBox3.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.skinTextBox3.SkinTxt.Multiline = true;
			this.skinTextBox3.SkinTxt.Name = "BaseText";
			this.skinTextBox3.SkinTxt.Size = new System.Drawing.Size(174, 19);
			this.skinTextBox3.SkinTxt.TabIndex = 0;
			this.skinTextBox3.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.skinTextBox3.SkinTxt.WaterText = "请输入名称";
			this.skinTextBox3.TabIndex = 1;
			this.skinTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.skinTextBox3.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.skinTextBox3.WaterText = "请输入名称";
			this.skinTextBox3.WordWrap = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(82, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "名称：";
			// 
			// skinTextBox1
			// 
			this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
			this.skinTextBox1.DownBack = null;
			this.skinTextBox1.Icon = null;
			this.skinTextBox1.IconIsButton = false;
			this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.skinTextBox1.IsPasswordChat = '\0';
			this.skinTextBox1.IsSystemPasswordChar = false;
			this.skinTextBox1.Lines = new string[0];
			this.skinTextBox1.Location = new System.Drawing.Point(125, 43);
			this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
			this.skinTextBox1.MaxLength = 32767;
			this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
			this.skinTextBox1.MouseBack = null;
			this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.skinTextBox1.Multiline = false;
			this.skinTextBox1.Name = "skinTextBox1";
			this.skinTextBox1.NormlBack = null;
			this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
			this.skinTextBox1.ReadOnly = false;
			this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.skinTextBox1.Size = new System.Drawing.Size(185, 28);
			// 
			// 
			// 
			this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.skinTextBox1.SkinTxt.ForeColor = System.Drawing.Color.Black;
			this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.skinTextBox1.SkinTxt.Name = "BaseText";
			this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(175, 18);
			this.skinTextBox1.SkinTxt.TabIndex = 0;
			this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.skinTextBox1.SkinTxt.WaterText = "请输入编号";
			this.skinTextBox1.TabIndex = 0;
			this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.skinTextBox1.WaterText = "请输入编号";
			this.skinTextBox1.WordWrap = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(82, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "编号：";
			// 
			// FrmAssayTemplateEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 300);
			this.Controls.Add(this.skinGroupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmAssayTemplateEdit";
			this.ShowDrawIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "";
			this.Load += new System.EventHandler(this.FrmAssayTemplateEdit_Load);
			this.skinGroupBox1.ResumeLayout(false);
			this.skinGroupBox1.PerformLayout();
			this.ResumeLayout(false);
=======
            this.components = new System.ComponentModel.Container();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new CCWin.SkinControl.SkinButton();
            this.chkIsPass = new CCWin.SkinControl.SkinCheckBox();
            this.btnClose = new CCWin.SkinControl.SkinButton();
            this.txtSpell = new CCWin.SkinControl.SkinTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTemplateName = new CCWin.SkinControl.SkinTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemplateCode = new CCWin.SkinControl.SkinTextBox();
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
            this.skinGroupBox1.Controls.Add(this.txtSpell);
            this.skinGroupBox1.Controls.Add(this.label4);
            this.skinGroupBox1.Controls.Add(this.txtTemplateName);
            this.skinGroupBox1.Controls.Add(this.label3);
            this.skinGroupBox1.Controls.Add(this.txtTemplateCode);
            this.skinGroupBox1.Controls.Add(this.label1);
            this.skinGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(4, 28);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(392, 265);
            this.skinGroupBox1.TabIndex = 0;
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
            this.label5.Location = new System.Drawing.Point(72, 97);
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
            this.label2.Location = new System.Drawing.Point(72, 54);
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
            this.btnSave.TabIndex = 4;
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
            this.chkIsPass.TabIndex = 3;
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
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSpell
            // 
            this.txtSpell.BackColor = System.Drawing.Color.Transparent;
            this.txtSpell.DownBack = null;
            this.txtSpell.Icon = null;
            this.txtSpell.IconIsButton = false;
            this.txtSpell.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtSpell.IsPasswordChat = '\0';
            this.txtSpell.IsSystemPasswordChar = false;
            this.txtSpell.Lines = new string[0];
            this.txtSpell.Location = new System.Drawing.Point(125, 128);
            this.txtSpell.Margin = new System.Windows.Forms.Padding(0);
            this.txtSpell.MaxLength = 32767;
            this.txtSpell.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtSpell.MouseBack = null;
            this.txtSpell.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtSpell.Multiline = true;
            this.txtSpell.Name = "txtSpell";
            this.txtSpell.NormlBack = null;
            this.txtSpell.Padding = new System.Windows.Forms.Padding(5);
            this.txtSpell.ReadOnly = false;
            this.txtSpell.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSpell.Size = new System.Drawing.Size(184, 29);
            // 
            // 
            // 
            this.txtSpell.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpell.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSpell.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtSpell.SkinTxt.ForeColor = System.Drawing.Color.Black;
            this.txtSpell.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtSpell.SkinTxt.Multiline = true;
            this.txtSpell.SkinTxt.Name = "BaseText";
            this.txtSpell.SkinTxt.Size = new System.Drawing.Size(174, 19);
            this.txtSpell.SkinTxt.TabIndex = 0;
            this.txtSpell.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtSpell.SkinTxt.WaterText = "请输入拼音";
            this.txtSpell.TabIndex = 2;
            this.txtSpell.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSpell.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtSpell.WaterText = "请输入拼音";
            this.txtSpell.WordWrap = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(82, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "拼音：";
            // 
            // txtTemplateName
            // 
            this.txtTemplateName.BackColor = System.Drawing.Color.Transparent;
            this.txtTemplateName.DownBack = null;
            this.txtTemplateName.Icon = null;
            this.txtTemplateName.IconIsButton = false;
            this.txtTemplateName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtTemplateName.IsPasswordChat = '\0';
            this.txtTemplateName.IsSystemPasswordChar = false;
            this.txtTemplateName.Lines = new string[0];
            this.txtTemplateName.Location = new System.Drawing.Point(125, 85);
            this.txtTemplateName.Margin = new System.Windows.Forms.Padding(0);
            this.txtTemplateName.MaxLength = 32767;
            this.txtTemplateName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtTemplateName.MouseBack = null;
            this.txtTemplateName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtTemplateName.Multiline = true;
            this.txtTemplateName.Name = "txtTemplateName";
            this.txtTemplateName.NormlBack = null;
            this.txtTemplateName.Padding = new System.Windows.Forms.Padding(5);
            this.txtTemplateName.ReadOnly = false;
            this.txtTemplateName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTemplateName.Size = new System.Drawing.Size(184, 29);
            // 
            // 
            // 
            this.txtTemplateName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemplateName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemplateName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtTemplateName.SkinTxt.ForeColor = System.Drawing.Color.Black;
            this.txtTemplateName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtTemplateName.SkinTxt.Multiline = true;
            this.txtTemplateName.SkinTxt.Name = "BaseText";
            this.txtTemplateName.SkinTxt.Size = new System.Drawing.Size(174, 19);
            this.txtTemplateName.SkinTxt.TabIndex = 0;
            this.txtTemplateName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTemplateName.SkinTxt.WaterText = "请输入名称";
            this.txtTemplateName.TabIndex = 1;
            this.txtTemplateName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTemplateName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTemplateName.WaterText = "请输入名称";
            this.txtTemplateName.WordWrap = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(82, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "名称：";
            // 
            // txtTemplateCode
            // 
            this.txtTemplateCode.BackColor = System.Drawing.Color.Transparent;
            this.txtTemplateCode.DownBack = null;
            this.txtTemplateCode.Icon = null;
            this.txtTemplateCode.IconIsButton = false;
            this.txtTemplateCode.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtTemplateCode.IsPasswordChat = '\0';
            this.txtTemplateCode.IsSystemPasswordChar = false;
            this.txtTemplateCode.Lines = new string[0];
            this.txtTemplateCode.Location = new System.Drawing.Point(125, 43);
            this.txtTemplateCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtTemplateCode.MaxLength = 32767;
            this.txtTemplateCode.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtTemplateCode.MouseBack = null;
            this.txtTemplateCode.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtTemplateCode.Multiline = false;
            this.txtTemplateCode.Name = "txtTemplateCode";
            this.txtTemplateCode.NormlBack = null;
            this.txtTemplateCode.Padding = new System.Windows.Forms.Padding(5);
            this.txtTemplateCode.ReadOnly = false;
            this.txtTemplateCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTemplateCode.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtTemplateCode.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemplateCode.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTemplateCode.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtTemplateCode.SkinTxt.ForeColor = System.Drawing.Color.Black;
            this.txtTemplateCode.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtTemplateCode.SkinTxt.Name = "BaseText";
            this.txtTemplateCode.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtTemplateCode.SkinTxt.TabIndex = 0;
            this.txtTemplateCode.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTemplateCode.SkinTxt.WaterText = "请输入编号";
            this.txtTemplateCode.TabIndex = 0;
            this.txtTemplateCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTemplateCode.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTemplateCode.WaterText = "请输入编号";
            this.txtTemplateCode.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(82, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // FrmAssayTemplateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.skinGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAssayTemplateEdit";
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑化验模板";
            this.Load += new System.EventHandler(this.FrmAssayTemplateEdit_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.ResumeLayout(false);
>>>>>>> MergeDrugDirectoryFiles

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinButton btnSave;
        private CCWin.SkinControl.SkinCheckBox chkIsPass;
        private CCWin.SkinControl.SkinButton btnClose;
        private CCWin.SkinControl.SkinTextBox txtSpell;
        private System.Windows.Forms.Label label4;
        private CCWin.SkinControl.SkinTextBox txtTemplateName;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinTextBox txtTemplateCode;
        private System.Windows.Forms.Label label1;
    }
}