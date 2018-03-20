namespace App.Cashier
{
    partial class FrmRecharge
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
            this.skinChatRichTextBox1 = new CCWin.SkinControl.SkinChatRichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.skinNumericUpDown1 = new CCWin.SkinControl.SkinNumericUpDown();
            this.btnSave = new CCWin.SkinControl.SkinButton();
            this.btnClose = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinChatRichTextBox1
            // 
            this.skinChatRichTextBox1.Location = new System.Drawing.Point(7, 31);
            this.skinChatRichTextBox1.Name = "skinChatRichTextBox1";
            this.skinChatRichTextBox1.SelectControl = null;
            this.skinChatRichTextBox1.SelectControlIndex = 0;
            this.skinChatRichTextBox1.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.skinChatRichTextBox1.Size = new System.Drawing.Size(386, 262);
            this.skinChatRichTextBox1.TabIndex = 0;
            this.skinChatRichTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "充值金额：";
            // 
            // skinNumericUpDown1
            // 
            this.skinNumericUpDown1.Location = new System.Drawing.Point(166, 113);
            this.skinNumericUpDown1.Name = "skinNumericUpDown1";
            this.skinNumericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.skinNumericUpDown1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSave.DownBack = null;
            this.btnSave.Location = new System.Drawing.Point(104, 209);
            this.btnSave.MouseBack = null;
            this.btnSave.Name = "btnSave";
            this.btnSave.NormlBack = null;
            this.btnSave.Size = new System.Drawing.Size(76, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存&(S)";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClose.DownBack = null;
            this.btnClose.Location = new System.Drawing.Point(201, 209);
            this.btnClose.MouseBack = null;
            this.btnClose.Name = "btnClose";
            this.btnClose.NormlBack = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭&(C)";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // FrmRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.skinNumericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skinChatRichTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRecharge";
            this.ShowDrawIcon = false;
            this.Text = "充值";
            ((System.ComponentModel.ISupportInitialize)(this.skinNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinChatRichTextBox skinChatRichTextBox1;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinNumericUpDown skinNumericUpDown1;
        private CCWin.SkinControl.SkinButton btnSave;
        private CCWin.SkinControl.SkinButton btnClose;
    }
}