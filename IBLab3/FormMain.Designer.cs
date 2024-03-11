namespace IBLab3
{
    partial class FormMain
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
            this.buttonChoosePasswordFile = new System.Windows.Forms.Button();
            this.radioButtonManualPassword = new System.Windows.Forms.RadioButton();
            this.textBoxManualPassword = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radioButtonChoosePasswordFile = new System.Windows.Forms.RadioButton();
            this.textBoxPasswordFilePath = new System.Windows.Forms.TextBox();
            this.textBoxDecryptFilePath = new System.Windows.Forms.TextBox();
            this.textBoxSourceFilePath = new System.Windows.Forms.TextBox();
            this.textBoxEncryptFilePath = new System.Windows.Forms.TextBox();
            this.buttonChooseEncryptFile = new System.Windows.Forms.Button();
            this.buttonChooseDecryptFile = new System.Windows.Forms.Button();
            this.buttonChooseSourceFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChoosePasswordFile
            // 
            this.buttonChoosePasswordFile.Location = new System.Drawing.Point(512, 36);
            this.buttonChoosePasswordFile.Name = "buttonChoosePasswordFile";
            this.buttonChoosePasswordFile.Size = new System.Drawing.Size(126, 23);
            this.buttonChoosePasswordFile.TabIndex = 0;
            this.buttonChoosePasswordFile.Text = "Выбрать файл";
            this.buttonChoosePasswordFile.UseVisualStyleBackColor = true;
            this.buttonChoosePasswordFile.Click += new System.EventHandler(this.buttonChoosePasswordFile_Click);
            // 
            // radioButtonManualPassword
            // 
            this.radioButtonManualPassword.AutoSize = true;
            this.radioButtonManualPassword.Location = new System.Drawing.Point(15, 13);
            this.radioButtonManualPassword.Name = "radioButtonManualPassword";
            this.radioButtonManualPassword.Size = new System.Drawing.Size(144, 17);
            this.radioButtonManualPassword.TabIndex = 1;
            this.radioButtonManualPassword.TabStop = true;
            this.radioButtonManualPassword.Text = "Ввести пароль вручную";
            this.radioButtonManualPassword.UseVisualStyleBackColor = true;
            this.radioButtonManualPassword.CheckedChanged += new System.EventHandler(this.radioButtonManualPassword_CheckedChanged);
            // 
            // textBoxManualPassword
            // 
            this.textBoxManualPassword.Enabled = false;
            this.textBoxManualPassword.Location = new System.Drawing.Point(175, 12);
            this.textBoxManualPassword.Name = "textBoxManualPassword";
            this.textBoxManualPassword.Size = new System.Drawing.Size(463, 20);
            this.textBoxManualPassword.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radioButtonChoosePasswordFile
            // 
            this.radioButtonChoosePasswordFile.AutoSize = true;
            this.radioButtonChoosePasswordFile.Location = new System.Drawing.Point(15, 39);
            this.radioButtonChoosePasswordFile.Name = "radioButtonChoosePasswordFile";
            this.radioButtonChoosePasswordFile.Size = new System.Drawing.Size(154, 17);
            this.radioButtonChoosePasswordFile.TabIndex = 1;
            this.radioButtonChoosePasswordFile.TabStop = true;
            this.radioButtonChoosePasswordFile.Text = "Выбрать файл с паролем";
            this.radioButtonChoosePasswordFile.UseVisualStyleBackColor = true;
            // 
            // textBoxPasswordFilePath
            // 
            this.textBoxPasswordFilePath.Enabled = false;
            this.textBoxPasswordFilePath.Location = new System.Drawing.Point(175, 38);
            this.textBoxPasswordFilePath.Name = "textBoxPasswordFilePath";
            this.textBoxPasswordFilePath.Size = new System.Drawing.Size(331, 20);
            this.textBoxPasswordFilePath.TabIndex = 2;
            // 
            // textBoxDecryptFilePath
            // 
            this.textBoxDecryptFilePath.Enabled = false;
            this.textBoxDecryptFilePath.Location = new System.Drawing.Point(302, 138);
            this.textBoxDecryptFilePath.Name = "textBoxDecryptFilePath";
            this.textBoxDecryptFilePath.Size = new System.Drawing.Size(336, 20);
            this.textBoxDecryptFilePath.TabIndex = 2;
            // 
            // textBoxSourceFilePath
            // 
            this.textBoxSourceFilePath.Enabled = false;
            this.textBoxSourceFilePath.Location = new System.Drawing.Point(302, 80);
            this.textBoxSourceFilePath.Name = "textBoxSourceFilePath";
            this.textBoxSourceFilePath.Size = new System.Drawing.Size(336, 20);
            this.textBoxSourceFilePath.TabIndex = 2;
            // 
            // textBoxEncryptFilePath
            // 
            this.textBoxEncryptFilePath.Enabled = false;
            this.textBoxEncryptFilePath.Location = new System.Drawing.Point(302, 109);
            this.textBoxEncryptFilePath.Name = "textBoxEncryptFilePath";
            this.textBoxEncryptFilePath.Size = new System.Drawing.Size(336, 20);
            this.textBoxEncryptFilePath.TabIndex = 2;
            // 
            // buttonChooseEncryptFile
            // 
            this.buttonChooseEncryptFile.Location = new System.Drawing.Point(15, 107);
            this.buttonChooseEncryptFile.Name = "buttonChooseEncryptFile";
            this.buttonChooseEncryptFile.Size = new System.Drawing.Size(281, 23);
            this.buttonChooseEncryptFile.TabIndex = 0;
            this.buttonChooseEncryptFile.Text = "Выбрать файл назначения для шифрования";
            this.buttonChooseEncryptFile.UseVisualStyleBackColor = true;
            this.buttonChooseEncryptFile.Click += new System.EventHandler(this.buttonChooseEncryptFile_Click);
            // 
            // buttonChooseDecryptFile
            // 
            this.buttonChooseDecryptFile.Location = new System.Drawing.Point(15, 136);
            this.buttonChooseDecryptFile.Name = "buttonChooseDecryptFile";
            this.buttonChooseDecryptFile.Size = new System.Drawing.Size(281, 23);
            this.buttonChooseDecryptFile.TabIndex = 0;
            this.buttonChooseDecryptFile.Text = "Выбрать файл назанчения для расшифрования";
            this.buttonChooseDecryptFile.UseVisualStyleBackColor = true;
            this.buttonChooseDecryptFile.Click += new System.EventHandler(this.buttonChooseDecryptFile_Click);
            // 
            // buttonChooseSourceFile
            // 
            this.buttonChooseSourceFile.Location = new System.Drawing.Point(15, 78);
            this.buttonChooseSourceFile.Name = "buttonChooseSourceFile";
            this.buttonChooseSourceFile.Size = new System.Drawing.Size(281, 23);
            this.buttonChooseSourceFile.TabIndex = 0;
            this.buttonChooseSourceFile.Text = "Выбрать исходный файл";
            this.buttonChooseSourceFile.UseVisualStyleBackColor = true;
            this.buttonChooseSourceFile.Click += new System.EventHandler(this.buttonChooseSourceFile_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 172);
            this.Controls.Add(this.textBoxEncryptFilePath);
            this.Controls.Add(this.textBoxSourceFilePath);
            this.Controls.Add(this.textBoxDecryptFilePath);
            this.Controls.Add(this.textBoxPasswordFilePath);
            this.Controls.Add(this.radioButtonChoosePasswordFile);
            this.Controls.Add(this.textBoxManualPassword);
            this.Controls.Add(this.radioButtonManualPassword);
            this.Controls.Add(this.buttonChooseSourceFile);
            this.Controls.Add(this.buttonChooseDecryptFile);
            this.Controls.Add(this.buttonChooseEncryptFile);
            this.Controls.Add(this.buttonChoosePasswordFile);
            this.Name = "FormMain";
            this.Text = "Главная";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChoosePasswordFile;
        private System.Windows.Forms.RadioButton radioButtonManualPassword;
        private System.Windows.Forms.TextBox textBoxManualPassword;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton radioButtonChoosePasswordFile;
        private System.Windows.Forms.TextBox textBoxPasswordFilePath;
        private System.Windows.Forms.TextBox textBoxDecryptFilePath;
        private System.Windows.Forms.TextBox textBoxSourceFilePath;
        private System.Windows.Forms.TextBox textBoxEncryptFilePath;
        private System.Windows.Forms.Button buttonChooseEncryptFile;
        private System.Windows.Forms.Button buttonChooseDecryptFile;
        private System.Windows.Forms.Button buttonChooseSourceFile;
    }
}