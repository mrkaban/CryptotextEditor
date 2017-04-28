namespace CryptotextEditor
{
    partial class ctxtproperties
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxEnc = new System.Windows.Forms.GroupBox();
            this.comboBoxEncryption = new System.Windows.Forms.ComboBox();
            this.groupBoxOthers = new System.Windows.Forms.GroupBox();
            this.checkBoxWithRTF = new System.Windows.Forms.CheckBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassphrase = new System.Windows.Forms.TextBox();
            this.checkBoxSavePassInFile = new System.Windows.Forms.CheckBox();
            this.groupBoxAES = new System.Windows.Forms.GroupBox();
            this.groupBoxEnc.SuspendLayout();
            this.groupBoxOthers.SuspendLayout();
            this.groupBoxAES.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(207, 216);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(12, 216);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(189, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxEnc
            // 
            this.groupBoxEnc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEnc.Controls.Add(this.comboBoxEncryption);
            this.groupBoxEnc.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEnc.Name = "groupBoxEnc";
            this.groupBoxEnc.Size = new System.Drawing.Size(270, 46);
            this.groupBoxEnc.TabIndex = 2;
            this.groupBoxEnc.TabStop = false;
            this.groupBoxEnc.Text = "Выберите шифрование";
            this.groupBoxEnc.Enter += new System.EventHandler(this.groupBoxEnc_Enter);
            // 
            // comboBoxEncryption
            // 
            this.comboBoxEncryption.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.comboBoxEncryption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEncryption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncryption.FormattingEnabled = true;
            this.comboBoxEncryption.Items.AddRange(new object[] {
            "AES 256 бит (по умолчанию / авто)",
            "AES 256 бит (пароль)",
            "Base64"});
            this.comboBoxEncryption.Location = new System.Drawing.Point(6, 19);
            this.comboBoxEncryption.Name = "comboBoxEncryption";
            this.comboBoxEncryption.Size = new System.Drawing.Size(258, 21);
            this.comboBoxEncryption.TabIndex = 0;
            this.comboBoxEncryption.SelectedIndexChanged += new System.EventHandler(this.comboBoxEncryption_SelectedIndexChanged);
            // 
            // groupBoxOthers
            // 
            this.groupBoxOthers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOthers.Controls.Add(this.checkBoxWithRTF);
            this.groupBoxOthers.Location = new System.Drawing.Point(12, 168);
            this.groupBoxOthers.Name = "groupBoxOthers";
            this.groupBoxOthers.Size = new System.Drawing.Size(270, 42);
            this.groupBoxOthers.TabIndex = 3;
            this.groupBoxOthers.TabStop = false;
            this.groupBoxOthers.Text = "Другие настройки";
            // 
            // checkBoxWithRTF
            // 
            this.checkBoxWithRTF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxWithRTF.AutoSize = true;
            this.checkBoxWithRTF.Checked = true;
            this.checkBoxWithRTF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWithRTF.Location = new System.Drawing.Point(6, 19);
            this.checkBoxWithRTF.Name = "checkBoxWithRTF";
            this.checkBoxWithRTF.Size = new System.Drawing.Size(259, 17);
            this.checkBoxWithRTF.TabIndex = 0;
            this.checkBoxWithRTF.Text = "Сохранить в Rich-Text-Format (рекомендуется)";
            this.checkBoxWithRTF.UseVisualStyleBackColor = true;
            this.checkBoxWithRTF.CheckedChanged += new System.EventHandler(this.checkBoxWithRTF_CheckedChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 22);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(48, 13);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Пароль:";
            // 
            // textBoxPassphrase
            // 
            this.textBoxPassphrase.Location = new System.Drawing.Point(68, 19);
            this.textBoxPassphrase.MaxLength = 48;
            this.textBoxPassphrase.Name = "textBoxPassphrase";
            this.textBoxPassphrase.Size = new System.Drawing.Size(196, 20);
            this.textBoxPassphrase.TabIndex = 1;
            this.textBoxPassphrase.TextChanged += new System.EventHandler(this.textBoxPassphrase_TextChanged);
            // 
            // checkBoxSavePassInFile
            // 
            this.checkBoxSavePassInFile.Checked = true;
            this.checkBoxSavePassInFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSavePassInFile.Location = new System.Drawing.Point(25, 45);
            this.checkBoxSavePassInFile.Name = "checkBoxSavePassInFile";
            this.checkBoxSavePassInFile.Size = new System.Drawing.Size(218, 47);
            this.checkBoxSavePassInFile.TabIndex = 2;
            this.checkBoxSavePassInFile.Text = "Сохраните пароль, зашифрованный в файле, который CryptotextEditor может автоматич" +
    "ески открыть.";
            this.checkBoxSavePassInFile.UseVisualStyleBackColor = true;
            this.checkBoxSavePassInFile.CheckedChanged += new System.EventHandler(this.checkBoxSavePassInFile_CheckedChanged);
            // 
            // groupBoxAES
            // 
            this.groupBoxAES.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAES.Controls.Add(this.checkBoxSavePassInFile);
            this.groupBoxAES.Controls.Add(this.textBoxPassphrase);
            this.groupBoxAES.Controls.Add(this.labelPassword);
            this.groupBoxAES.Location = new System.Drawing.Point(12, 64);
            this.groupBoxAES.Name = "groupBoxAES";
            this.groupBoxAES.Size = new System.Drawing.Size(270, 98);
            this.groupBoxAES.TabIndex = 3;
            this.groupBoxAES.TabStop = false;
            this.groupBoxAES.Text = "AES";
            // 
            // ctxtproperties
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(294, 251);
            this.Controls.Add(this.groupBoxOthers);
            this.Controls.Add(this.groupBoxAES);
            this.Controls.Add(this.groupBoxEnc);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ctxtproperties";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTXT настройки";
            this.groupBoxEnc.ResumeLayout(false);
            this.groupBoxOthers.ResumeLayout(false);
            this.groupBoxOthers.PerformLayout();
            this.groupBoxAES.ResumeLayout(false);
            this.groupBoxAES.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxEncryption;
        private System.Windows.Forms.TextBox textBoxPassphrase;
        internal System.Windows.Forms.GroupBox groupBoxEnc;
        internal System.Windows.Forms.Label labelPassword;
        internal System.Windows.Forms.CheckBox checkBoxSavePassInFile;
        public System.Windows.Forms.GroupBox groupBoxAES;
        internal System.Windows.Forms.GroupBox groupBoxOthers;
        internal System.Windows.Forms.CheckBox checkBoxWithRTF;
    }
}