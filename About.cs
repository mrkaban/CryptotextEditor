using System;
using System.Windows.Forms;

namespace CryptotextEditor
{
    internal partial class About : Form
    {
        internal About()
        {
            InitializeComponent();
            this.labelCryptotextEditorVer.Text = Application.ProductName + "\r\nВерсия " + Application.ProductVersion.ToString();
            if (System.IO.File.Exists("about.png") == true)
            {
                pictureBox2.Load("about.png");
            }
            else
            {
                pictureBox2.Visible = false;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://xn--90abhbolvbbfgb9aje4m.xn--p1ai/");
        }

        private void linkLabelIconeden_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://xn--90abhbolvbbfgb9aje4m.xn--p1ai/");
        }
        
        private void LinkLabelFacebookLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        	System.Diagnostics.Process.Start("https://xn--90abhbolvbbfgb9aje4m.xn--p1ai/");
        }
    }
}
