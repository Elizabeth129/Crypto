namespace Cryptography
{
    partial class Login
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin1 = new System.Windows.Forms.Button();
            this.comboBoxDisks = new System.Windows.Forms.ComboBox();
            this.comboBoxDisks2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(43, 27);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(42, 17);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логін";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(43, 94);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 17);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(46, 56);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(133, 22);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(46, 124);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(133, 22);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonLogin1
            // 
            this.buttonLogin1.Location = new System.Drawing.Point(574, 166);
            this.buttonLogin1.Name = "buttonLogin1";
            this.buttonLogin1.Size = new System.Drawing.Size(170, 57);
            this.buttonLogin1.TabIndex = 4;
            this.buttonLogin1.Text = "Увійти";
            this.buttonLogin1.UseVisualStyleBackColor = true;
            this.buttonLogin1.Click += new System.EventHandler(this.buttonLogin1_Click);
            // 
            // comboBoxDisks
            // 
            this.comboBoxDisks.FormattingEnabled = true;
            this.comboBoxDisks.Location = new System.Drawing.Point(281, 54);
            this.comboBoxDisks.Name = "comboBoxDisks";
            this.comboBoxDisks.Size = new System.Drawing.Size(164, 24);
            this.comboBoxDisks.TabIndex = 5;
            // 
            // comboBoxDisks2
            // 
            this.comboBoxDisks2.FormattingEnabled = true;
            this.comboBoxDisks2.Location = new System.Drawing.Point(281, 122);
            this.comboBoxDisks2.Name = "comboBoxDisks2";
            this.comboBoxDisks2.Size = new System.Drawing.Size(164, 24);
            this.comboBoxDisks2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Оберіть на якому USB-накопчувачу знаходиться ключ від даного аккаунту";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Оберіть жорткий диск, на якому знаходиться ключ від даного аккаунту";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 244);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDisks2);
            this.Controls.Add(this.comboBoxDisks);
            this.Controls.Add(this.buttonLogin1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Name = "Login";
            this.Text = "Логін";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin1;
        private System.Windows.Forms.ComboBox comboBoxDisks;
        private System.Windows.Forms.ComboBox comboBoxDisks2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}