using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBLab3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonChooseSourceFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxSourceFilePath.Text = openFileDialog1.FileName;
        }

        private void buttonChooseDecryptFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxDecryptFilePath.Text = openFileDialog1.FileName;
        }

        private void buttonChooseEncryptFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxEncryptFilePath.Text = openFileDialog1.FileName;
        }

        private void buttonChoosePasswordFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxPasswordFilePath.Text = openFileDialog1.FileName;
        }

        private void radioButtonManualPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxManualPassword.Enabled = radioButtonManualPassword.Checked;
        }
    }
}
