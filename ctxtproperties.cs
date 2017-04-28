using System;
using System.Drawing;
using System.Windows.Forms;
using CryptotextEditorAPI;

namespace CryptotextEditor
{
    internal partial class ctxtproperties : Form
    {
        internal string thisFilePath;
        Editor editor;

        internal ctxtproperties(string filePath, bool onlyProperties, Editor editor)
        {
            this.editor = editor;
            InitializeComponent();
            thisFilePath = filePath;
            if (onlyProperties == true)
            {
                readFileProperties(filePath);
            }
            else
            {
                comboBoxEncryption.SelectedIndex = 0;
            }
            Language lang = new Language(this);
            lang.changeLangCtxtProperties(Application.StartupPath + "\\" + Settings.editorLangPath);
        }

        private void readFileProperties(string filePath)
        {
            ctxtFile cTextFile = new ctxtFile(filePath);

            if (cTextFile.GetEncryption() == ctxtFile.Encryption.TimeAES) { comboBoxEncryption.SelectedIndex = 0; }
            else if (cTextFile.GetEncryption() == ctxtFile.Encryption.CryptotextEditorAES)
            {
                comboBoxEncryption.SelectedIndex = 1;
                string plainPassword = ctxtFile.GetPassphrase(filePath);

                if (plainPassword.Length > 1)
                {
                    checkBoxSavePassInFile.Checked = true;
                    textBoxPassphrase.Text = plainPassword;
                }
                else
                {
                    checkBoxSavePassInFile.Checked = false;
                    textBoxPassphrase.Focus();
                }
            }
            else { comboBoxEncryption.SelectedIndex = 2; }

            if (ctxtProperties.DocIsRTF(filePath) == true)
            {
                checkBoxWithRTF.Checked = true;
            }
            else
            {
                checkBoxWithRTF.Checked = false;
            }
        }

        private void comboBoxEncryption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEncryption.SelectedIndex == 0 | comboBoxEncryption.SelectedIndex == 2)
            {
                this.Size = new Size(300, 174);
                groupBoxAES.Visible = false;
                buttonSave.Enabled = true;
            }
            else
            {
                this.Size = new Size(300, 278);
                groupBoxAES.Visible = true;
                if(textBoxPassphrase.TextLength < 2)
                {
                    buttonSave.Enabled = false;
                }
            }
        }

        private void textBoxPassphrase_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassphrase.TextLength > 1)
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ctxtFile.Encryption sEnc;

            if (comboBoxEncryption.SelectedIndex == 0) { sEnc = ctxtFile.Encryption.TimeAES; }
            else if (comboBoxEncryption.SelectedIndex == 1) { sEnc = ctxtFile.Encryption.CryptotextEditorAES; }
            else { sEnc = ctxtFile.Encryption.Base64; }

            ctxtFile ctxtfile = new ctxtFile(thisFilePath);

            ctxtfile.encName = sEnc;
            ctxtfile.SaveWithRTF = checkBoxWithRTF.Checked;
            ctxtfile.PassPhrase = textBoxPassphrase.Text;
            ctxtfile.SavePassString = checkBoxSavePassInFile.Checked;

            ctxtfile.WriteFile(editor.Document.Rtf);

            System.IO.FileInfo fi = new System.IO.FileInfo(thisFilePath);
            editor.Text = fi.Name.ToString() + " - CryptotextEditor";

            Settings.CurrentFileSaved = true;
            Settings.CurrentFilePath = thisFilePath;

            if (Settings.LastOpenedFile != thisFilePath)
            {
                editor.MenuItemFileLastOpened.Text = fi.Name.ToString();
                Settings.LastOpenedFile = thisFilePath;
            }

            Settings.Save();
            this.Close();
        }

        private void checkBoxSavePassInFile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSavePassInFile.Checked == false)
            {
                checkBoxWithRTF.Checked = false;
            }
        }

        private void checkBoxWithRTF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWithRTF.Checked == true)
            {
                checkBoxSavePassInFile.Checked = true;
            }
        }

        private void groupBoxEnc_Enter(object sender, EventArgs e)
        {

        }
    }
}
