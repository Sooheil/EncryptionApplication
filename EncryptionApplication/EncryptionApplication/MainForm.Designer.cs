namespace EncryptionApplication
{
    partial class MainForm
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
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.decryptionButton = new System.Windows.Forms.Button();
            this.encryptionButton = new System.Windows.Forms.Button();
            this.Destination = new System.Windows.Forms.Button();
            this.FileSelect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(14, 13);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(347, 22);
            this.sourceTextBox.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(14, 43);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(347, 22);
            this.destinationTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.decryptionButton);
            this.groupBox1.Controls.Add(this.encryptionButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 97);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(3, 18);
            this.progressBar.Maximum = 11;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(466, 23);
            this.progressBar.TabIndex = 2;
            // 
            // decryptionButton
            // 
            this.decryptionButton.Image = global::EncryptionApplication.Properties.Resources.unlock;
            this.decryptionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.decryptionButton.Location = new System.Drawing.Point(281, 47);
            this.decryptionButton.Name = "decryptionButton";
            this.decryptionButton.Size = new System.Drawing.Size(113, 45);
            this.decryptionButton.TabIndex = 1;
            this.decryptionButton.Text = "  Decryption";
            this.decryptionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decryptionButton.UseVisualStyleBackColor = true;
            this.decryptionButton.Click += new System.EventHandler(this.decryptionButton_Click);
            // 
            // encryptionButton
            // 
            this.encryptionButton.Image = global::EncryptionApplication.Properties.Resources._lock;
            this.encryptionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.encryptionButton.Location = new System.Drawing.Point(73, 47);
            this.encryptionButton.Name = "encryptionButton";
            this.encryptionButton.Size = new System.Drawing.Size(113, 45);
            this.encryptionButton.TabIndex = 0;
            this.encryptionButton.Text = "  Encryption";
            this.encryptionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.encryptionButton.UseVisualStyleBackColor = true;
            this.encryptionButton.Click += new System.EventHandler(this.encryptionButton_Click);
            // 
            // Destination
            // 
            this.Destination.Image = global::EncryptionApplication.Properties.Resources.if_document_save_as_118915;
            this.Destination.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Destination.Location = new System.Drawing.Point(369, 42);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(87, 25);
            this.Destination.TabIndex = 3;
            this.Destination.Text = "Destination";
            this.Destination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Destination.UseVisualStyleBackColor = true;
            this.Destination.Click += new System.EventHandler(this.Destination_Click);
            // 
            // FileSelect
            // 
            this.FileSelect.Image = global::EncryptionApplication.Properties.Resources.if_Open_1493293;
            this.FileSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FileSelect.Location = new System.Drawing.Point(369, 11);
            this.FileSelect.Name = "FileSelect";
            this.FileSelect.Size = new System.Drawing.Size(87, 25);
            this.FileSelect.TabIndex = 1;
            this.FileSelect.Text = "Choose File";
            this.FileSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileSelect.UseVisualStyleBackColor = true;
            this.FileSelect.Click += new System.EventHandler(this.FileSelect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 170);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.FileSelect);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.sourceTextBox);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption/Decryption";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Button FileSelect;
        private System.Windows.Forms.Button Destination;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button decryptionButton;
        private System.Windows.Forms.Button encryptionButton;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

