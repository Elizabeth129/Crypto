namespace Cryptography
{
    partial class Encryption
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
            this.openFileToEncrypt = new System.Windows.Forms.OpenFileDialog();
            this.textBoxOpenFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.folderBrowserDialogEncrypt = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxFolderEncrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOpenFolderEncrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFileEncryptName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFolderKey = new System.Windows.Forms.TextBox();
            this.buttonFolderKey = new System.Windows.Forms.Button();
            this.folderBrowserDialogKey = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFileKeyName = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileToEncrypt
            // 
            this.openFileToEncrypt.FileName = "openFileToEncrypt";
            // 
            // textBoxOpenFile
            // 
            this.textBoxOpenFile.Location = new System.Drawing.Point(44, 65);
            this.textBoxOpenFile.Name = "textBoxOpenFile";
            this.textBoxOpenFile.Size = new System.Drawing.Size(340, 22);
            this.textBoxOpenFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Файл, який бажаєте зашифрувати";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(44, 106);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(150, 44);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Відкрити файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxFolderEncrypt
            // 
            this.textBoxFolderEncrypt.Location = new System.Drawing.Point(44, 207);
            this.textBoxFolderEncrypt.Name = "textBoxFolderEncrypt";
            this.textBoxFolderEncrypt.Size = new System.Drawing.Size(340, 22);
            this.textBoxFolderEncrypt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Оберіть папку, де бажаєте зберегти зашифрований файл";
            // 
            // buttonOpenFolderEncrypt
            // 
            this.buttonOpenFolderEncrypt.Location = new System.Drawing.Point(44, 250);
            this.buttonOpenFolderEncrypt.Name = "buttonOpenFolderEncrypt";
            this.buttonOpenFolderEncrypt.Size = new System.Drawing.Size(150, 44);
            this.buttonOpenFolderEncrypt.TabIndex = 5;
            this.buttonOpenFolderEncrypt.Text = "Відкрити папку";
            this.buttonOpenFolderEncrypt.UseVisualStyleBackColor = true;
            this.buttonOpenFolderEncrypt.Click += new System.EventHandler(this.buttonOpenFolderEncrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ім\'я (з розширенням) зашифрованого файлу";
            // 
            // textBoxFileEncryptName
            // 
            this.textBoxFileEncryptName.Location = new System.Drawing.Point(44, 345);
            this.textBoxFileEncryptName.Name = "textBoxFileEncryptName";
            this.textBoxFileEncryptName.Size = new System.Drawing.Size(340, 22);
            this.textBoxFileEncryptName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Оберіть папку, де бажаєте зберегти файл-ключ";
            // 
            // textBoxFolderKey
            // 
            this.textBoxFolderKey.Location = new System.Drawing.Point(559, 65);
            this.textBoxFolderKey.Name = "textBoxFolderKey";
            this.textBoxFolderKey.Size = new System.Drawing.Size(322, 22);
            this.textBoxFolderKey.TabIndex = 9;
            // 
            // buttonFolderKey
            // 
            this.buttonFolderKey.Location = new System.Drawing.Point(559, 106);
            this.buttonFolderKey.Name = "buttonFolderKey";
            this.buttonFolderKey.Size = new System.Drawing.Size(150, 44);
            this.buttonFolderKey.TabIndex = 10;
            this.buttonFolderKey.Text = "Відкрити папку";
            this.buttonFolderKey.UseVisualStyleBackColor = true;
            this.buttonFolderKey.Click += new System.EventHandler(this.buttonFolderKey_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ім\'я (без розширення) файлу-ключа";
            // 
            // textBoxFileKeyName
            // 
            this.textBoxFileKeyName.Location = new System.Drawing.Point(559, 207);
            this.textBoxFileKeyName.Name = "textBoxFileKeyName";
            this.textBoxFileKeyName.Size = new System.Drawing.Size(322, 22);
            this.textBoxFileKeyName.TabIndex = 12;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(731, 345);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(150, 44);
            this.buttonEncrypt.TabIndex = 13;
            this.buttonEncrypt.Text = "Зашифрувати";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 421);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxFileKeyName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonFolderKey);
            this.Controls.Add(this.textBoxFolderKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFileEncryptName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOpenFolderEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFolderEncrypt);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOpenFile);
            this.Name = "Encryption";
            this.Text = "Шифрування";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Encryption_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileToEncrypt;
        private System.Windows.Forms.TextBox textBoxOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogEncrypt;
        private System.Windows.Forms.TextBox textBoxFolderEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOpenFolderEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFileEncryptName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFolderKey;
        private System.Windows.Forms.Button buttonFolderKey;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFileKeyName;
        private System.Windows.Forms.Button buttonEncrypt;
    }
}