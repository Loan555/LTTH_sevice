namespace demo2
{
    partial class Form1
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
            this.VND2USD = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VND2USD
            // 
            this.VND2USD.Location = new System.Drawing.Point(120, 168);
            this.VND2USD.Name = "VND2USD";
            this.VND2USD.Size = new System.Drawing.Size(104, 43);
            this.VND2USD.TabIndex = 0;
            this.VND2USD.Text = "VND2USD";
            this.VND2USD.UseVisualStyleBackColor = true;
            this.VND2USD.Click += new System.EventHandler(this.VND2USD_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(271, 179);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(51, 20);
            this.lblKetQua.TabIndex = 1;
            this.lblKetQua.Text = "label1";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(140, 92);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 26);
            this.txtMoney.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.VND2USD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VND2USD;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtMoney;
    }
}

