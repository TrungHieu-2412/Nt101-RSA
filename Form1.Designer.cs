namespace RSA
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCiphertext = new System.Windows.Forms.TextBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnSecureSend = new System.Windows.Forms.Button();
            this.btnSecureReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số nguyên tố p";
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(12, 37);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(205, 30);
            this.txtP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số nguyên tố q";
            // 
            // txtQ
            // 
            this.txtQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQ.Location = new System.Drawing.Point(12, 126);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(205, 30);
            this.txtQ.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(265, 61);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(118, 62);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Tạo Khóa";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Public Key (n, e)";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicKey.Location = new System.Drawing.Point(436, 45);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ReadOnly = true;
            this.txtPublicKey.Size = new System.Drawing.Size(205, 30);
            this.txtPublicKey.TabIndex = 6;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivateKey.Location = new System.Drawing.Point(436, 126);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.Size = new System.Drawing.Size(205, 30);
            this.txtPrivateKey.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Private Key (n, d)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bản rõ (Plaintext)";
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaintext.Location = new System.Drawing.Point(13, 228);
            this.txtPlaintext.Multiline = true;
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(628, 391);
            this.txtPlaintext.TabIndex = 10;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(12, 644);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(124, 53);
            this.btnEncrypt.TabIndex = 11;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(701, 644);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(124, 53);
            this.btnDecrypt.TabIndex = 12;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(696, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bản mã (Ciphertext)";
            // 
            // txtCiphertext
            // 
            this.txtCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiphertext.Location = new System.Drawing.Point(701, 228);
            this.txtCiphertext.Multiline = true;
            this.txtCiphertext.Name = "txtCiphertext";
            this.txtCiphertext.Size = new System.Drawing.Size(593, 391);
            this.txtCiphertext.TabIndex = 14;
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(224, 644);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(124, 53);
            this.btnSign.TabIndex = 15;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(897, 644);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(124, 53);
            this.btnVerify.TabIndex = 16;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnSecureSend
            // 
            this.btnSecureSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecureSend.Location = new System.Drawing.Point(436, 644);
            this.btnSecureSend.Name = "btnSecureSend";
            this.btnSecureSend.Size = new System.Drawing.Size(205, 53);
            this.btnSecureSend.TabIndex = 17;
            this.btnSecureSend.Text = "Sign - Encrypt";
            this.btnSecureSend.UseVisualStyleBackColor = true;
            this.btnSecureSend.Click += new System.EventHandler(this.btnSecureSend_Click);
            // 
            // btnSecureReceive
            // 
            this.btnSecureReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecureReceive.Location = new System.Drawing.Point(1089, 644);
            this.btnSecureReceive.Name = "btnSecureReceive";
            this.btnSecureReceive.Size = new System.Drawing.Size(205, 53);
            this.btnSecureReceive.TabIndex = 18;
            this.btnSecureReceive.Text = "Decrypt - Verify";
            this.btnSecureReceive.UseVisualStyleBackColor = true;
            this.btnSecureReceive.Click += new System.EventHandler(this.btnSecureReceive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 709);
            this.Controls.Add(this.btnSecureReceive);
            this.Controls.Add(this.btnSecureSend);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.txtCiphertext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtPlaintext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCiphertext;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnSecureSend;
        private System.Windows.Forms.Button btnSecureReceive;
    }
}

