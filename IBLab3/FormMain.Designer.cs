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
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кемВыполненноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChoosePasswordFile
            // 
            this.buttonChoosePasswordFile.Enabled = false;
            this.buttonChoosePasswordFile.Location = new System.Drawing.Point(509, 50);
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
            this.radioButtonManualPassword.Location = new System.Drawing.Point(12, 27);
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
            this.textBoxManualPassword.Location = new System.Drawing.Point(172, 26);
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
            this.radioButtonChoosePasswordFile.Location = new System.Drawing.Point(12, 53);
            this.radioButtonChoosePasswordFile.Name = "radioButtonChoosePasswordFile";
            this.radioButtonChoosePasswordFile.Size = new System.Drawing.Size(154, 17);
            this.radioButtonChoosePasswordFile.TabIndex = 1;
            this.radioButtonChoosePasswordFile.TabStop = true;
            this.radioButtonChoosePasswordFile.Text = "Выбрать файл с паролем";
            this.radioButtonChoosePasswordFile.UseVisualStyleBackColor = true;
            this.radioButtonChoosePasswordFile.CheckedChanged += new System.EventHandler(this.radioButtonChoosePasswordFile_CheckedChanged);
            // 
            // textBoxPasswordFilePath
            // 
            this.textBoxPasswordFilePath.Enabled = false;
            this.textBoxPasswordFilePath.Location = new System.Drawing.Point(172, 52);
            this.textBoxPasswordFilePath.Name = "textBoxPasswordFilePath";
            this.textBoxPasswordFilePath.Size = new System.Drawing.Size(331, 20);
            this.textBoxPasswordFilePath.TabIndex = 2;
            // 
            // textBoxDecryptFilePath
            // 
            this.textBoxDecryptFilePath.Enabled = false;
            this.textBoxDecryptFilePath.Location = new System.Drawing.Point(299, 152);
            this.textBoxDecryptFilePath.Name = "textBoxDecryptFilePath";
            this.textBoxDecryptFilePath.Size = new System.Drawing.Size(336, 20);
            this.textBoxDecryptFilePath.TabIndex = 2;
            // 
            // textBoxSourceFilePath
            // 
            this.textBoxSourceFilePath.Enabled = false;
            this.textBoxSourceFilePath.Location = new System.Drawing.Point(299, 94);
            this.textBoxSourceFilePath.Name = "textBoxSourceFilePath";
            this.textBoxSourceFilePath.Size = new System.Drawing.Size(336, 20);
            this.textBoxSourceFilePath.TabIndex = 2;
            // 
            // textBoxEncryptFilePath
            // 
            this.textBoxEncryptFilePath.Enabled = false;
            this.textBoxEncryptFilePath.Location = new System.Drawing.Point(299, 123);
            this.textBoxEncryptFilePath.Name = "textBoxEncryptFilePath";
            this.textBoxEncryptFilePath.Size = new System.Drawing.Size(336, 20);
            this.textBoxEncryptFilePath.TabIndex = 2;
            // 
            // buttonChooseEncryptFile
            // 
            this.buttonChooseEncryptFile.Location = new System.Drawing.Point(12, 121);
            this.buttonChooseEncryptFile.Name = "buttonChooseEncryptFile";
            this.buttonChooseEncryptFile.Size = new System.Drawing.Size(281, 23);
            this.buttonChooseEncryptFile.TabIndex = 0;
            this.buttonChooseEncryptFile.Text = "Выбрать файл назначения для шифрования";
            this.buttonChooseEncryptFile.UseVisualStyleBackColor = true;
            this.buttonChooseEncryptFile.Click += new System.EventHandler(this.buttonChooseEncryptFile_Click);
            // 
            // buttonChooseDecryptFile
            // 
            this.buttonChooseDecryptFile.Location = new System.Drawing.Point(12, 150);
            this.buttonChooseDecryptFile.Name = "buttonChooseDecryptFile";
            this.buttonChooseDecryptFile.Size = new System.Drawing.Size(281, 23);
            this.buttonChooseDecryptFile.TabIndex = 0;
            this.buttonChooseDecryptFile.Text = "Выбрать файл назначения для расшифрования";
            this.buttonChooseDecryptFile.UseVisualStyleBackColor = true;
            this.buttonChooseDecryptFile.Click += new System.EventHandler(this.buttonChooseDecryptFile_Click);
            // 
            // buttonChooseSourceFile
            // 
            this.buttonChooseSourceFile.Location = new System.Drawing.Point(12, 92);
            this.buttonChooseSourceFile.Name = "buttonChooseSourceFile";
            this.buttonChooseSourceFile.Size = new System.Drawing.Size(281, 23);
            this.buttonChooseSourceFile.TabIndex = 0;
            this.buttonChooseSourceFile.Text = "Выбрать исходный файл";
            this.buttonChooseSourceFile.UseVisualStyleBackColor = true;
            this.buttonChooseSourceFile.Click += new System.EventHandler(this.buttonChooseSourceFile_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(523, 178);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(112, 23);
            this.buttonEncrypt.TabIndex = 3;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(405, 178);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(112, 23);
            this.buttonDecrypt.TabIndex = 3;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заданиеToolStripMenuItem,
            this.кемВыполненноToolStripMenuItem,
            this.справочнаяИнформацияToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // заданиеToolStripMenuItem
            // 
            this.заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            this.заданиеToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.заданиеToolStripMenuItem.Text = "Задание";
            this.заданиеToolStripMenuItem.Click += new System.EventHandler(this.заданиеToolStripMenuItem_Click);
            // 
            // кемВыполненноToolStripMenuItem
            // 
            this.кемВыполненноToolStripMenuItem.Name = "кемВыполненноToolStripMenuItem";
            this.кемВыполненноToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.кемВыполненноToolStripMenuItem.Text = "Кем выполненно";
            this.кемВыполненноToolStripMenuItem.Click += new System.EventHandler(this.кемВыполненноToolStripMenuItem_Click);
            // 
            // справочнаяИнформацияToolStripMenuItem
            // 
            this.справочнаяИнформацияToolStripMenuItem.Name = "справочнаяИнформацияToolStripMenuItem";
            this.справочнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.справочнаяИнформацияToolStripMenuItem.Text = "Справочная информация";
            this.справочнаяИнформацияToolStripMenuItem.Click += new System.EventHandler(this.справочнаяИнформацияToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 212);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Главная";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кемВыполненноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочнаяИнформацияToolStripMenuItem;
    }
}