﻿
namespace PA6
{
    partial class frmCWID
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
			this.lblCWID = new System.Windows.Forms.Label();
			this.txtCWID = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblCWID
			// 
			this.lblCWID.AutoSize = true;
			this.lblCWID.Location = new System.Drawing.Point(29, 37);
			this.lblCWID.Name = "lblCWID";
			this.lblCWID.Size = new System.Drawing.Size(155, 24);
			this.lblCWID.TabIndex = 0;
			this.lblCWID.Text = "Enter your CWID:";
			// 
			// txtCWID
			// 
			this.txtCWID.Location = new System.Drawing.Point(265, 37);
			this.txtCWID.Name = "txtCWID";
			this.txtCWID.Size = new System.Drawing.Size(194, 29);
			this.txtCWID.TabIndex = 1;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(265, 97);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(86, 34);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(373, 97);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(86, 34);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmCWID
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 150);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtCWID);
			this.Controls.Add(this.lblCWID);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "frmCWID";
			this.Text = "CWID";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label lblCWID;
		private System.Windows.Forms.TextBox txtCWID;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnClose;
	}
}

