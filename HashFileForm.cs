using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CryptotextEditor
{
    internal partial class HashFileForm : Form
    {
        internal Editor MainEditor;

        internal HashFileForm(string filePath, Editor ed)
        {
            InitializeComponent();
            textBoxFilePath.Text = filePath;
            this.MainEditor = ed;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            List<string> allHashes = new List<string>();
            
            if (checkBoxHashMd5.Checked)
            {
                allHashes.Add("md5");
            }
            if (checkBoxHashSha1.Checked)
            {
                allHashes.Add("sha1");
            }
            if (checkBoxHashSha256.Checked)
            {
                allHashes.Add("sha256");
            }
            if (checkBoxHashSha384.Checked)
            {
                allHashes.Add("sha384");
            }
            if (checkBoxHashSha512.Checked)
            {
                allHashes.Add("sha512");
            }
            if (checkBoxHashRipemd160.Checked)
            {
                allHashes.Add("ripemd160");
            }

            MainEditor.fh.hashFile(textBoxFilePath.Text, allHashes.ToArray());
            Cursor.Current = Cursors.Default;
            this.Close();
        }

        private void textBoxFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        /*~HashFile()
        {
            // Einstellungen speichern
        } //*/
    }
}
