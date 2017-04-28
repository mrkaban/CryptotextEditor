namespace CryptotextEditor
{
    partial class HashFileForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.groupBoxHashes = new System.Windows.Forms.GroupBox();
            this.checkBoxHashRipemd160 = new System.Windows.Forms.CheckBox();
            this.checkBoxHashSha384 = new System.Windows.Forms.CheckBox();
            this.checkBoxHashSha1 = new System.Windows.Forms.CheckBox();
            this.checkBoxHashSha256 = new System.Windows.Forms.CheckBox();
            this.checkBoxHashSha512 = new System.Windows.Forms.CheckBox();
            this.checkBoxHashMd5 = new System.Windows.Forms.CheckBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.groupBoxHashes.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.Location = new System.Drawing.Point(12, 14);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(370, 20);
            this.textBoxFilePath.TabIndex = 0;
            this.textBoxFilePath.TextChanged += new System.EventHandler(this.textBoxFilePath_TextChanged);
            // 
            // groupBoxHashes
            // 
            this.groupBoxHashes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHashes.Controls.Add(this.checkBoxHashRipemd160);
            this.groupBoxHashes.Controls.Add(this.checkBoxHashSha384);
            this.groupBoxHashes.Controls.Add(this.checkBoxHashSha1);
            this.groupBoxHashes.Controls.Add(this.checkBoxHashSha256);
            this.groupBoxHashes.Controls.Add(this.checkBoxHashSha512);
            this.groupBoxHashes.Controls.Add(this.checkBoxHashMd5);
            this.groupBoxHashes.Location = new System.Drawing.Point(12, 41);
            this.groupBoxHashes.Name = "groupBoxHashes";
            this.groupBoxHashes.Size = new System.Drawing.Size(370, 100);
            this.groupBoxHashes.TabIndex = 2;
            this.groupBoxHashes.TabStop = false;
            this.groupBoxHashes.Text = "Хэши";
            // 
            // checkBoxHashRipemd160
            // 
            this.checkBoxHashRipemd160.AutoSize = true;
            this.checkBoxHashRipemd160.Location = new System.Drawing.Point(55, 42);
            this.checkBoxHashRipemd160.Name = "checkBoxHashRipemd160";
            this.checkBoxHashRipemd160.Size = new System.Drawing.Size(89, 17);
            this.checkBoxHashRipemd160.TabIndex = 5;
            this.checkBoxHashRipemd160.Text = "RIPEMD 160";
            this.checkBoxHashRipemd160.UseVisualStyleBackColor = true;
            // 
            // checkBoxHashSha384
            // 
            this.checkBoxHashSha384.AutoSize = true;
            this.checkBoxHashSha384.Location = new System.Drawing.Point(55, 65);
            this.checkBoxHashSha384.Name = "checkBoxHashSha384";
            this.checkBoxHashSha384.Size = new System.Drawing.Size(69, 17);
            this.checkBoxHashSha384.TabIndex = 4;
            this.checkBoxHashSha384.Text = "SHA-384";
            this.checkBoxHashSha384.UseVisualStyleBackColor = true;
            // 
            // checkBoxHashSha1
            // 
            this.checkBoxHashSha1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHashSha1.AutoSize = true;
            this.checkBoxHashSha1.Checked = true;
            this.checkBoxHashSha1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHashSha1.Location = new System.Drawing.Point(220, 19);
            this.checkBoxHashSha1.Name = "checkBoxHashSha1";
            this.checkBoxHashSha1.Size = new System.Drawing.Size(57, 17);
            this.checkBoxHashSha1.TabIndex = 3;
            this.checkBoxHashSha1.Text = "SHA-1";
            this.checkBoxHashSha1.UseVisualStyleBackColor = true;
            // 
            // checkBoxHashSha256
            // 
            this.checkBoxHashSha256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHashSha256.AutoSize = true;
            this.checkBoxHashSha256.Location = new System.Drawing.Point(220, 42);
            this.checkBoxHashSha256.Name = "checkBoxHashSha256";
            this.checkBoxHashSha256.Size = new System.Drawing.Size(69, 17);
            this.checkBoxHashSha256.TabIndex = 2;
            this.checkBoxHashSha256.Text = "SHA-256";
            this.checkBoxHashSha256.UseVisualStyleBackColor = true;
            // 
            // checkBoxHashSha512
            // 
            this.checkBoxHashSha512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHashSha512.AutoSize = true;
            this.checkBoxHashSha512.Location = new System.Drawing.Point(220, 65);
            this.checkBoxHashSha512.Name = "checkBoxHashSha512";
            this.checkBoxHashSha512.Size = new System.Drawing.Size(69, 17);
            this.checkBoxHashSha512.TabIndex = 1;
            this.checkBoxHashSha512.Text = "SHA-512";
            this.checkBoxHashSha512.UseVisualStyleBackColor = true;
            // 
            // checkBoxHashMd5
            // 
            this.checkBoxHashMd5.AutoSize = true;
            this.checkBoxHashMd5.Checked = true;
            this.checkBoxHashMd5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHashMd5.Location = new System.Drawing.Point(55, 19);
            this.checkBoxHashMd5.Name = "checkBoxHashMd5";
            this.checkBoxHashMd5.Size = new System.Drawing.Size(49, 17);
            this.checkBoxHashMd5.TabIndex = 0;
            this.checkBoxHashMd5.Text = "MD5";
            this.checkBoxHashMd5.UseVisualStyleBackColor = true;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 147);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(370, 43);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Вычислить";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // HashFileForm
            // 
            this.AcceptButton = this.buttonGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 202);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.groupBoxHashes);
            this.Controls.Add(this.textBoxFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HashFileForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хэш генератор";
            this.groupBoxHashes.ResumeLayout(false);
            this.groupBoxHashes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.GroupBox groupBoxHashes;
        private System.Windows.Forms.CheckBox checkBoxHashMd5;
        private System.Windows.Forms.CheckBox checkBoxHashRipemd160;
        private System.Windows.Forms.CheckBox checkBoxHashSha384;
        private System.Windows.Forms.CheckBox checkBoxHashSha1;
        private System.Windows.Forms.CheckBox checkBoxHashSha256;
        private System.Windows.Forms.CheckBox checkBoxHashSha512;
        private System.Windows.Forms.Button buttonGenerate;
    }
}