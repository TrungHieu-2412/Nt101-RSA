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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCiphertext = new System.Windows.Forms.TextBox();
            this.txtP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQ = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGenerate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEncrypt = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtPrivateKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPublicKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSecureReceive = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnVerify = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDecrypt = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSecureSend = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSign = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(29, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "q:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(621, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Public Key (n, e)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(621, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Private Key (n, d)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(621, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Plaintext";
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaintext.Location = new System.Drawing.Point(33, 228);
            this.txtPlaintext.Multiline = true;
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(564, 391);
            this.txtPlaintext.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(29, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ciphertext";
            // 
            // txtCiphertext
            // 
            this.txtCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiphertext.Location = new System.Drawing.Point(625, 228);
            this.txtCiphertext.Multiline = true;
            this.txtCiphertext.Name = "txtCiphertext";
            this.txtCiphertext.Size = new System.Drawing.Size(564, 391);
            this.txtCiphertext.TabIndex = 14;
            // 
            // txtP
            // 
            this.txtP.Animated = true;
            this.txtP.AutoRoundedCorners = true;
            this.txtP.BorderColor = System.Drawing.Color.HotPink;
            this.txtP.BorderRadius = 19;
            this.txtP.BorderThickness = 3;
            this.txtP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtP.DefaultText = "";
            this.txtP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtP.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtP.Location = new System.Drawing.Point(33, 42);
            this.txtP.Name = "txtP";
            this.txtP.PlaceholderText = "";
            this.txtP.SelectedText = "";
            this.txtP.Size = new System.Drawing.Size(442, 40);
            this.txtP.TabIndex = 19;
            // 
            // txtQ
            // 
            this.txtQ.Animated = true;
            this.txtQ.AutoRoundedCorners = true;
            this.txtQ.BorderColor = System.Drawing.Color.HotPink;
            this.txtQ.BorderRadius = 19;
            this.txtQ.BorderThickness = 3;
            this.txtQ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQ.DefaultText = "";
            this.txtQ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQ.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtQ.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQ.Location = new System.Drawing.Point(33, 115);
            this.txtQ.Name = "txtQ";
            this.txtQ.PlaceholderText = "";
            this.txtQ.SelectedText = "";
            this.txtQ.Size = new System.Drawing.Size(442, 40);
            this.txtQ.TabIndex = 20;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Animated = true;
            this.btnGenerate.BorderColor = System.Drawing.Color.White;
            this.btnGenerate.BorderThickness = 2;
            this.btnGenerate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerate.FillColor2 = System.Drawing.Color.Azure;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnGenerate.Location = new System.Drawing.Point(509, 42);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(88, 40);
            this.btnGenerate.TabIndex = 21;
            this.btnGenerate.Text = "Key";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Animated = true;
            this.btnEncrypt.AutoRoundedCorners = true;
            this.btnEncrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncrypt.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEncrypt.FillColor2 = System.Drawing.Color.HotPink;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(261, 166);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(108, 45);
            this.btnEncrypt.TabIndex = 22;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Animated = true;
            this.txtPrivateKey.AutoRoundedCorners = true;
            this.txtPrivateKey.BorderColor = System.Drawing.Color.HotPink;
            this.txtPrivateKey.BorderRadius = 19;
            this.txtPrivateKey.BorderThickness = 3;
            this.txtPrivateKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrivateKey.DefaultText = "";
            this.txtPrivateKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrivateKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrivateKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrivateKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrivateKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrivateKey.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtPrivateKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrivateKey.Location = new System.Drawing.Point(620, 115);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.PlaceholderText = "";
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.SelectedText = "";
            this.txtPrivateKey.Size = new System.Drawing.Size(457, 40);
            this.txtPrivateKey.TabIndex = 23;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Animated = true;
            this.txtPublicKey.AutoRoundedCorners = true;
            this.txtPublicKey.BorderColor = System.Drawing.Color.HotPink;
            this.txtPublicKey.BorderRadius = 19;
            this.txtPublicKey.BorderThickness = 3;
            this.txtPublicKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublicKey.DefaultText = "";
            this.txtPublicKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPublicKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPublicKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPublicKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPublicKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPublicKey.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtPublicKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPublicKey.Location = new System.Drawing.Point(620, 42);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.PlaceholderText = "";
            this.txtPublicKey.ReadOnly = true;
            this.txtPublicKey.SelectedText = "";
            this.txtPublicKey.Size = new System.Drawing.Size(457, 40);
            this.txtPublicKey.TabIndex = 24;
            // 
            // btnSecureReceive
            // 
            this.btnSecureReceive.Animated = true;
            this.btnSecureReceive.AutoRoundedCorners = true;
            this.btnSecureReceive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSecureReceive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSecureReceive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSecureReceive.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSecureReceive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSecureReceive.FillColor2 = System.Drawing.Color.HotPink;
            this.btnSecureReceive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSecureReceive.ForeColor = System.Drawing.Color.White;
            this.btnSecureReceive.Location = new System.Drawing.Point(1076, 166);
            this.btnSecureReceive.Name = "btnSecureReceive";
            this.btnSecureReceive.Size = new System.Drawing.Size(108, 45);
            this.btnSecureReceive.TabIndex = 27;
            this.btnSecureReceive.Text = "Sign - Decrypt";
            this.btnSecureReceive.Click += new System.EventHandler(this.btnSecureReceive_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Animated = true;
            this.btnVerify.AutoRoundedCorners = true;
            this.btnVerify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVerify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVerify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerify.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVerify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVerify.FillColor2 = System.Drawing.Color.HotPink;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(962, 166);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(108, 45);
            this.btnVerify.TabIndex = 28;
            this.btnVerify.Text = "Verify";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Animated = true;
            this.btnDecrypt.AutoRoundedCorners = true;
            this.btnDecrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrypt.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecrypt.FillColor2 = System.Drawing.Color.HotPink;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.Location = new System.Drawing.Point(848, 166);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(108, 45);
            this.btnDecrypt.TabIndex = 29;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnSecureSend
            // 
            this.btnSecureSend.Animated = true;
            this.btnSecureSend.AutoRoundedCorners = true;
            this.btnSecureSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSecureSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSecureSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSecureSend.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSecureSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSecureSend.FillColor2 = System.Drawing.Color.HotPink;
            this.btnSecureSend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSecureSend.ForeColor = System.Drawing.Color.White;
            this.btnSecureSend.Location = new System.Drawing.Point(489, 166);
            this.btnSecureSend.Name = "btnSecureSend";
            this.btnSecureSend.Size = new System.Drawing.Size(108, 45);
            this.btnSecureSend.TabIndex = 30;
            this.btnSecureSend.Text = "Sign - Encrypt";
            this.btnSecureSend.Click += new System.EventHandler(this.btnSecureSend_Click);
            // 
            // btnSign
            // 
            this.btnSign.Animated = true;
            this.btnSign.AutoRoundedCorners = true;
            this.btnSign.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSign.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSign.FillColor2 = System.Drawing.Color.HotPink;
            this.btnSign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSign.ForeColor = System.Drawing.Color.White;
            this.btnSign.Location = new System.Drawing.Point(375, 166);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(108, 45);
            this.btnSign.TabIndex = 31;
            this.btnSign.Text = "Sign";
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1201, 634);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnSecureSend);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnSecureReceive);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtCiphertext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPlaintext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCiphertext;
        private Guna.UI2.WinForms.Guna2TextBox txtP;
        private Guna.UI2.WinForms.Guna2TextBox txtQ;
        private Guna.UI2.WinForms.Guna2GradientButton btnGenerate;
        private Guna.UI2.WinForms.Guna2GradientButton btnEncrypt;
        private Guna.UI2.WinForms.Guna2TextBox txtPrivateKey;
        private Guna.UI2.WinForms.Guna2TextBox txtPublicKey;
        private Guna.UI2.WinForms.Guna2GradientButton btnSecureReceive;
        private Guna.UI2.WinForms.Guna2GradientButton btnVerify;
        private Guna.UI2.WinForms.Guna2GradientButton btnDecrypt;
        private Guna.UI2.WinForms.Guna2GradientButton btnSecureSend;
        private Guna.UI2.WinForms.Guna2GradientButton btnSign;
    }
}

