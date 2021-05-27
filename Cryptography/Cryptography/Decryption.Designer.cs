namespace Cryptography
{
    partial class Decryption
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
            this.textBoxOpenFileToDecrypt = new System.Windows.Forms.TextBox();
            this.buttonOpenFileToDecrypt = new System.Windows.Forms.Button();
            this.openFileToDecrypt = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFolderDec = new System.Windows.Forms.TextBox();
            this.buttonFolderDec = new System.Windows.Forms.Button();
            this.folderBrowserDialogDec = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFileDec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFileKey = new System.Windows.Forms.TextBox();
            this.buttonFileKey = new System.Windows.Forms.Button();
            this.openFileDialogKey = new System.Windows.Forms.OpenFileDialog();
            this.buttonDecryption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файл, який бажаєте дешифрувати";
            // 
            // textBoxOpenFileToDecrypt
            // 
            this.textBoxOpenFileToDecrypt.Location = new System.Drawing.Point(30, 59);
            this.textBoxOpenFileToDecrypt.Name = "textBoxOpenFileToDecrypt";
            this.textBoxOpenFileToDecrypt.Size = new System.Drawing.Size(362, 22);
            this.textBoxOpenFileToDecrypt.TabIndex = 1;
            // 
            // buttonOpenFileToDecrypt
            // 
            this.buttonOpenFileToDecrypt.Location = new System.Drawing.Point(30, 98);
            this.buttonOpenFileToDecrypt.Name = "buttonOpenFileToDecrypt";
            this.buttonOpenFileToDecrypt.Size = new System.Drawing.Size(145, 43);
            this.buttonOpenFileToDecrypt.TabIndex = 2;
            this.buttonOpenFileToDecrypt.Text = "Відкрити файл";
            this.buttonOpenFileToDecrypt.UseVisualStyleBackColor = true;
            this.buttonOpenFileToDecrypt.Click += new System.EventHandler(this.buttonOpenFileToDecrypt_Click);
            // 
            // openFileToDecrypt
            // 
            this.openFileToDecrypt.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Оберіть папку, де бажаєте зберегти розшифрований файл";
            // 
            // textBoxFolderDec
            // 
            this.textBoxFolderDec.Location = new System.Drawing.Point(30, 192);
            this.textBoxFolderDec.Name = "textBoxFolderDec";
            this.textBoxFolderDec.Size = new System.Drawing.Size(362, 22);
            this.textBoxFolderDec.TabIndex = 4;
            // 
            // buttonFolderDec
            // 
            this.buttonFolderDec.Location = new System.Drawing.Point(30, 230);
            this.buttonFolderDec.Name = "buttonFolderDec";
            this.buttonFolderDec.Size = new System.Drawing.Size(145, 43);
            this.buttonFolderDec.TabIndex = 5;
            this.buttonFolderDec.Text = "Відкрити папку";
            this.buttonFolderDec.UseVisualStyleBackColor = true;
            this.buttonFolderDec.Click += new System.EventHandler(this.buttonFolderDec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ім\'я (з розширенням) розшифрованого файлу";
            // 
            // textBoxFileDec
            // 
            this.textBoxFileDec.Location = new System.Drawing.Point(30, 325);
            this.textBoxFileDec.Name = "textBoxFileDec";
            this.textBoxFileDec.Size = new System.Drawing.Size(362, 22);
            this.textBoxFileDec.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Файл-ключ, що відповідає даному закодованому файлу";
            // 
            // textBoxFileKey
            // 
            this.textBoxFileKey.Location = new System.Drawing.Point(541, 59);
            this.textBoxFileKey.Name = "textBoxFileKey";
            this.textBoxFileKey.Size = new System.Drawing.Size(381, 22);
            this.textBoxFileKey.TabIndex = 9;
            // 
            // buttonFileKey
            // 
            this.buttonFileKey.Location = new System.Drawing.Point(541, 98);
            this.buttonFileKey.Name = "buttonFileKey";
            this.buttonFileKey.Size = new System.Drawing.Size(145, 43);
            this.buttonFileKey.TabIndex = 10;
            this.buttonFileKey.Text = "Відкрити файл";
            this.buttonFileKey.UseVisualStyleBackColor = true;
            this.buttonFileKey.Click += new System.EventHandler(this.buttonFileKey_Click);
            // 
            // openFileDialogKey
            // 
            this.openFileDialogKey.FileName = "openFileDialog1";
            // 
            // buttonDecryption
            // 
            this.buttonDecryption.Location = new System.Drawing.Point(769, 315);
            this.buttonDecryption.Name = "buttonDecryption";
            this.buttonDecryption.Size = new System.Drawing.Size(145, 43);
            this.buttonDecryption.TabIndex = 11;
            this.buttonDecryption.Text = "Розшифрувати";
            this.buttonDecryption.UseVisualStyleBackColor = true;
            this.buttonDecryption.Click += new System.EventHandler(this.buttonDecryption_Click);
            // 
            // Decryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 403);
            this.Controls.Add(this.buttonDecryption);
            this.Controls.Add(this.buttonFileKey);
            this.Controls.Add(this.textBoxFileKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFileDec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFolderDec);
            this.Controls.Add(this.textBoxFolderDec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOpenFileToDecrypt);
            this.Controls.Add(this.textBoxOpenFileToDecrypt);
            this.Controls.Add(this.label1);
            this.Name = "Decryption";
            this.Text = "Дешифрування";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Decryption_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOpenFileToDecrypt;
        private System.Windows.Forms.Button buttonOpenFileToDecrypt;
        private System.Windows.Forms.OpenFileDialog openFileToDecrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFolderDec;
        private System.Windows.Forms.Button buttonFolderDec;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFileDec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFileKey;
        private System.Windows.Forms.Button buttonFileKey;
        private System.Windows.Forms.OpenFileDialog openFileDialogKey;
        private System.Windows.Forms.Button buttonDecryption;
    }
}