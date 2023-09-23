using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EncryptionApplication
{
    public partial class MainForm : Form
    {
        private string _ext;
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Encryption method
        /// </summary>
        /// <param name="inputPath">path of your file</param>
        /// <param name="outputPath">destination of encrypted file(with file name and extension)</param>
        public void Encryption(string inputPath, string outputPath)
        {
            FileStream input = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
            try
            {
                byte[] dta = new byte[input.Length];
                progressBar.Value++;
                input.Read(dta, 0, (int)input.Length);
                progressBar.Value++;
                input.Close();
                progressBar.Value++;
                FileStream output = new FileStream(outputPath, FileMode.Create, FileAccess.Write);
                progressBar.Value++;
                DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();
                progressBar.Value++;
                cryptic.Key = ASCIIEncoding.ASCII.GetBytes("YOUR8KEY");  // You can customize these values, but remember the maximum length
                progressBar.Value++;
                cryptic.IV = ASCIIEncoding.ASCII.GetBytes("YOURIVS8");   // for this encryption method is 8 characters each.
                progressBar.Value++;
                CryptoStream crStream = new CryptoStream(output, cryptic.CreateEncryptor(), CryptoStreamMode.Write);
                progressBar.Value++;
                crStream.Write(dta, 0, dta.Length);
                progressBar.Value++;
                crStream.Close();
                progressBar.Value++;
                output.Close();
                progressBar.Value++;
                MessageBox.Show("mission accomplished", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar.Value = 0;
            }
            catch(Exception ex)
            {
                progressBar.Value = 0;
                MessageBox.Show("The desired operation encountered an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }
        }
        public void Decryption(string inputPath, string outputPath)
        {
            FileStream input = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
            try
            {
                DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();
                progressBar.Value++;
                cryptic.Key = ASCIIEncoding.ASCII.GetBytes("YOUR8KEY");// You can customize these values, but remember the maximum length
                progressBar.Value++;
                cryptic.IV = ASCIIEncoding.ASCII.GetBytes("YOURIVS8");// for this encryption method is 8 characters each.
                progressBar.Value++;
                CryptoStream crStream = new CryptoStream(input, cryptic.CreateDecryptor(), CryptoStreamMode.Read);
                progressBar.Value++;
                byte[] dta = new byte[input.Length];
                progressBar.Value++;
                BinaryReader reader = new BinaryReader(crStream);
                progressBar.Value++;
                reader.Read(dta, 0, (int)input.Length);
                progressBar.Value++;
                reader.Close();
                progressBar.Value++;
                input.Close();
                progressBar.Value++;
                FileStream output = new FileStream(outputPath, FileMode.Create, FileAccess.Write);
                progressBar.Value++;
                output.Write(dta, 0, dta.Length);
                progressBar.Value++;
                output.Close();
                MessageBox.Show("mission accomplished", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar.Value = 0;
            }
            catch(Exception ex)
            {
                progressBar.Value = 0;
                MessageBox.Show("The desired operation encountered an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Select source of file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                sourceTextBox.Text = openFileDialog.FileName;
                _ext = Path.GetExtension(openFileDialog.FileName);
                Destination.Enabled = true;
            }
        }
        /// <summary>
        /// Select destination of file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Destination_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "(*" + _ext + ")" + "|" + "*" + _ext;
            saveFileDialog.DefaultExt = _ext;
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                destinationTextBox.Text = saveFileDialog.FileName;
                encryptionButton.Enabled = true;
                decryptionButton.Enabled = true;
            }
        }
        private void encryptionButton_Click(object sender, EventArgs e)
        {
            Encryption(sourceTextBox.Text, destinationTextBox.Text);
        }
        private void decryptionButton_Click(object sender, EventArgs e)
        {
            Decryption(sourceTextBox.Text,destinationTextBox.Text);
        }
    }
}
