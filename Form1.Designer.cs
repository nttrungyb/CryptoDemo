namespace PaymentGateway.CryptoDemo2
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
            this.txtRawString = new System.Windows.Forms.TextBox();
            this.txtSignatureString = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRawString
            // 
            this.txtRawString.Location = new System.Drawing.Point(85, 45);
            this.txtRawString.Name = "txtRawString";
            this.txtRawString.Size = new System.Drawing.Size(503, 20);
            this.txtRawString.TabIndex = 0;
            // 
            // txtSignatureString
            // 
            this.txtSignatureString.Location = new System.Drawing.Point(85, 91);
            this.txtSignatureString.Name = "txtSignatureString";
            this.txtSignatureString.Size = new System.Drawing.Size(503, 20);
            this.txtSignatureString.TabIndex = 1;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(507, 217);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 2;
            this.btnVerify.Text = "Kiểm tra";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtSignatureString);
            this.Controls.Add(this.txtRawString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRawString;
        private System.Windows.Forms.TextBox txtSignatureString;
        private System.Windows.Forms.Button btnVerify;
    }
}

