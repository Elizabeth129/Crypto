namespace Cryptography
{
    partial class Registration
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
            this.progressBarPassword = new System.Windows.Forms.ProgressBar();
            this.comboBoxDisks = new System.Windows.Forms.ComboBox();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.comboBoxDisks2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(49, 32);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(42, 17);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логін";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(49, 125);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 17);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(52, 72);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(124, 22);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(52, 174);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(124, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // progressBarPassword
            // 
            this.progressBarPassword.Location = new System.Drawing.Point(52, 214);
            this.progressBarPassword.Name = "progressBarPassword";
            this.progressBarPassword.Size = new System.Drawing.Size(202, 13);
            this.progressBarPassword.TabIndex = 4;
            // 
            // comboBoxDisks
            // 
            this.comboBoxDisks.FormattingEnabled = true;
            this.comboBoxDisks.Location = new System.Drawing.Point(319, 70);
            this.comboBoxDisks.Name = "comboBoxDisks";
            this.comboBoxDisks.Size = new System.Drawing.Size(157, 24);
            this.comboBoxDisks.TabIndex = 5;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(485, 243);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(166, 69);
            this.buttonRegistration.TabIndex = 6;
            this.buttonRegistration.Text = "Зареєструватися";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // comboBoxDisks2
            // 
            this.comboBoxDisks2.FormattingEnabled = true;
            this.comboBoxDisks2.Location = new System.Drawing.Point(319, 172);
            this.comboBoxDisks2.Name = "comboBoxDisks2";
            this.comboBoxDisks2.Size = new System.Drawing.Size(157, 24);
            this.comboBoxDisks2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Оберіть на якому USB-накопчувачу буде знаходитися ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Оберіть жорткий диск, на якому буде знаходитися ключ";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 328);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDisks2);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.comboBoxDisks);
            this.Controls.Add(this.progressBarPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Name = "Registration";
            this.Text = "Реєстрація";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ProgressBar progressBarPassword;
        private System.Windows.Forms.ComboBox comboBoxDisks;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.ComboBox comboBoxDisks2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}