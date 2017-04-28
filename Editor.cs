using System;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CryptotextEditorAPI;

namespace CryptotextEditor
{
    internal partial class Editor : Form
    {
        internal FileHandler fh;
        Language lang;
        internal string msgRestoreBackup = "Создана резервная копия последнего текста, возможно, сбой CryptotextEditor.\nВосстановить?";
        internal string msgNotSaved = "Ваш документ не сохранён!";
        internal string msgSaveQuestion = "Вы хотите сохранить документ?";
        internal string labelSave = "Сохранить";

        internal Editor(string args)
        {
            InitializeComponent();
            fh = new FileHandler(this);
            lang = new Language(this);
            lang.changeLangEditor(Application.StartupPath + "\\" + Settings.editorLangPath);
            this.Location = new Point(Settings.editorLocation.X, Settings.editorLocation.Y);
            this.Size = new Size(Settings.EditorSize.Width, Settings.EditorSize.Height);

            //listCustomScripts();

            if (args.Length > 0)
            {
                fh.OpenFile(args);
            }
        }
        int changedChars = 0;

        private void Editor_Load(object sender, EventArgs e)
        {
            Settings.CurrentFileSaved = true;

            if (Document.Text.Length == 0)
            {
                Settings.CurrentFilePath = "";
            }
            if (Settings.LastOpenedFile.Length > 2)
            {
                FileInfo fi = new FileInfo(Settings.LastOpenedFile);
                MenuItemFileLastOpened.Text = fi.Name.ToString();
            }

            Document.WordWrap = Settings.WordWrap;
            MenuItemFormatWordWrap.Checked = Settings.WordWrap;
            Document.DetectUrls = Settings.DetectUrls;
            MenuItemFormatDetectUrls.Checked = Settings.DetectUrls;
            MenuItemFormatAutoSave.Checked = Settings.AutoSave;

            if (Settings.editorToolBox == false)
            {
                MainToolStrip.Visible = false;
                MenuItemFormatToolbox.Checked = false;
                Document.Location = new Point(0, (Document.Location.Y - 25));
                Document.Size = new Size(Document.Size.Width, (Document.Size.Height + 25));
            }

            if (File.Exists(Settings.tmpPath + "\\~CryptotextEditortext32.tmp") == true)
            {
                DialogResult MsgBoxResult;
                MsgBoxResult = MessageBox.Show(msgRestoreBackup, "Сбой Cryptotext Editor", MessageBoxButtons.YesNo);
                if (MsgBoxResult == DialogResult.Yes)
                {
                    fh.AutoSave(1);
                }
            }
        }

        private void Editor_Closing(object sender, FormClosingEventArgs e)
        {
            if (Settings.CurrentFileSaved == false & Document.TextLength != 0)
            {
                DialogResult MsgBoxResult;
                MsgBoxResult = MessageBox.Show(msgNotSaved + "\n" + msgSaveQuestion, "CryptotextEditor", MessageBoxButtons.YesNoCancel);
                if (MsgBoxResult == DialogResult.Yes)
                {
                    fh.SaveOpendFile();
                }
                else if (MsgBoxResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

            if(this.WindowState != FormWindowState.Maximized & this.WindowState != FormWindowState.Minimized)
            {
                Settings.editorLocation = this.Location;
                Settings.EditorSize = this.Size;
            }

            if (File.Exists(Settings.tmpPath + "\\~CryptotextEditortext32.tmp") == true)
            {
                FileInfo fitmp = new FileInfo(Settings.tmpPath + "\\~CryptotextEditortext32.tmp");
                fitmp.Delete();
            }

            Settings.Save();
        }

        private void timerCheckFunctions_Tick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText() == true)
            {
                MenuItemEditPaste.Enabled = true;
                docMenuStripPaste.Enabled = true;
                mtsPaste.Enabled = true;
            }
            else
            {
                MenuItemEditPaste.Enabled = false;
                docMenuStripPaste.Enabled = false;
                mtsPaste.Enabled = false;
            }
        }

        private void Document_TextChanged(object sender, EventArgs e)
        {
            statusLabelLines.Text = "длина: " + Document.Text.Length.ToString() + "   линии: " + Document.Lines.Count();
            changedChars += 1;
            if (Settings.CurrentFileSaved == true)
            {
                Settings.CurrentFileSaved = false;
            }

            if (Document.CanUndo)
            {
                MenuItemEditUndo.Enabled = true;
                mtsUndo.Enabled = true;
            }
            else
            {
                MenuItemEditUndo.Enabled = false;
                mtsUndo.Enabled = false;
            }

            if (Document.CanRedo)
            {
                MenuItemEditRedo.Enabled = true;
                mtsRedo.Enabled = true;
            }
            else
            {
                MenuItemEditRedo.Enabled = false;
                mtsRedo.Enabled = false;
            }

            if (changedChars > 30)
            {
                fh.AutoSave(0);
                changedChars = 0;
            }
        }

        private void Document_SelectionChanged(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length > 0)
            {
                statusLabelSelected.Visible = true;
                statusLabelSelected.Text = "|  сел: " + Document.SelectedText.Length.ToString();
                docMenuStripCopy.Enabled = true;
                MenuItemEditCopy.Enabled = true;
                mtsCopy.Enabled = true;
                docMenuStripCut.Enabled = true;
                MenuItemEditCut.Enabled = true;
                mtsCut.Enabled = true;
                MenuItemEditDelete.Enabled = true;
            }
            else
            {
                statusLabelSelected.Visible = false;
                MenuItemEditCopy.Enabled = false;
                docMenuStripCopy.Enabled = false;
                mtsCopy.Enabled = false;
                MenuItemEditCut.Enabled = false;
                docMenuStripCut.Enabled = false;
                mtsCut.Enabled = false;
                MenuItemEditDelete.Enabled = false;
                statusLabelFont.Text = Document.SelectionFont.Name.ToString() + ", " + Document.SelectionFont.Size.ToString() + ", " + Document.SelectionFont.Style.ToString();
            }
        }

        /* # # # # # # # # # # # # # # # # # # # # # # # # */
        /* # # # # # # # # # # BUTTONS # # # # # # # # # # */
        /* # # # # # # # # # # # # # # # # # # # # # # # # */

        /* ##### FILE MENU ##### */

        private void MenuItemFileNew_Click(object sender, EventArgs e)
        {
            if (Settings.CurrentFileSaved == true | Document.TextLength == 0)
            {
                fh.ClearDocument();
            }
            else if (Settings.CurrentFileSaved == false)
            {
                DialogResult Result;
                Result = MessageBox.Show(msgSaveQuestion, labelSave, MessageBoxButtons.YesNoCancel);
                if (Result == DialogResult.No)
                {
                    fh.ClearDocument();
                }
                else if (Result == DialogResult.Yes)
                {
                    fh.SaveOpendFile();
                    fh.ClearDocument();
                }
            }
        }

        private void MenuItemFileOpen_Click(object sender, EventArgs e)
        {
            if (Settings.CurrentFileSaved == true | Document.TextLength == 0)
            {
                fh.OpenNewFile();
            }
            else
            {
                DialogResult Result;
                Result = MessageBox.Show(msgSaveQuestion, labelSave, MessageBoxButtons.YesNoCancel);
                if (Result == DialogResult.Yes)
                {
                    fh.SaveOpendFile();
                    fh.OpenNewFile();
                }
                else if (Result == DialogResult.No)
                {
                    fh.OpenNewFile();
                }
            }
        }

        private void MenuItemFileSave_Click(object sender, EventArgs e)
        {
            fh.SaveOpendFile();
        }

        private void MenuItemFileSaveAs_Click(object sender, EventArgs e)
        {
            fh.SaveInDirectory();
        }

        private void MenuItemFileProperties_Click(object sender, EventArgs e)
        {
            if (ctxtProperties.DocIsCTXT(Settings.CurrentFilePath) == true)
            {
                ctxtproperties ctxtp = new ctxtproperties(Settings.CurrentFilePath, true, this);
                ctxtp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Этот файл не является CTXT-файлом!");
            }
        }

        private void MenuItemFileHash_Click(object sender, EventArgs e)
        {
            if (Settings.CurrentFileSaved != true & Document.TextLength != 0)
            {
                DialogResult Result;
                Result = MessageBox.Show(msgSaveQuestion, labelSave +"?", MessageBoxButtons.YesNoCancel);
                if (Result == DialogResult.Yes)
                {
                    fh.SaveOpendFile();
                }
                else if (Result == DialogResult.Cancel)
                {
                    return;
                }
            }

            fh.HashNewFile();
        }

        private void MenuItemFileLastOpened_Click(object sender, EventArgs e)
        {
            if (Settings.CurrentFileSaved == true | Document.TextLength == 0)
            {
                fh.OpenFile(Settings.LastOpenedFile);
            }
            else
            {
                DialogResult Result;
                Result = MessageBox.Show(msgSaveQuestion, labelSave + "?", MessageBoxButtons.YesNoCancel);
                if (Result == DialogResult.Yes)
                {
                    fh.SaveOpendFile();
                    fh.OpenFile(Settings.LastOpenedFile);
                }
                else if (Result == DialogResult.No)
                {
                    fh.OpenFile(Settings.LastOpenedFile);
                }
            }
        }

        private void MenuItemFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* ##### EDIT MENU ##### */

        private void MenuItemEditUndo_Click(object sender, EventArgs e)
        {
            if (Document.CanUndo)
            {
                Document.Undo();
            }
        }

        private void MenuItemEditRedo_Click(object sender, EventArgs e)
        {
            if (Document.CanRedo)
            {
                Document.Redo();
            }
        }

        private void MenuItemEditCut_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Document.Cut();
        }

        private void MenuItemEditCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Document.Copy();
        }

        private void MenuItemEditPaste_Click(object sender, EventArgs e)
        {
            Document.Paste();
        }

        private void MenuItemEditDelete_Click(object sender, EventArgs e)
        {
            Document.SelectedText = "";
        }

        private void MenuItemEditMarkupAll_Click(object sender, EventArgs e)
        {
            Document.SelectAll();
        }

        private void MenuItemEditTextUppercase_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length == 0)
            {
                Document.SelectAll();
            }
            Document.SelectedText = Document.SelectedText.ToUpper();
        }

        private void MenuItemEditTextLowercase_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length == 0)
            {
                Document.SelectAll();
            }
            Document.SelectedText = Document.SelectedText.ToLower();
        }

        private void MenuItemEditTextSentenceCase_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo ti = cultureInfo.TextInfo;
            if (Document.SelectedText.Length == 0)
            {
                Document.SelectAll();
            }
            Document.SelectedText = ti.ToTitleCase(Document.SelectedText);
        }

        private void MenuItemEditTimeDate_Click(object sender, EventArgs e)
        {
            Document.SelectedText = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + " " + DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
        }

        /* ##### FORMAT MENU ##### */

        private void MenuItemFormatWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            Document.WordWrap = MenuItemFormatWordWrap.Checked;
            Settings.WordWrap = MenuItemFormatWordWrap.Checked;
        }

        private void MenuItemFormatDetectUrls_CheckedChanged(object sender, EventArgs e)
        {
            Document.DetectUrls = MenuItemFormatDetectUrls.Checked;
            Settings.DetectUrls = MenuItemFormatDetectUrls.Checked;
        }

        private void MenuItemFormatAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            Settings.AutoSave = MenuItemFormatAutoSave.Checked;
        }

        private void MenuItemFormatFont_Click(object sender, EventArgs e)
        {
            FontDialog MainFontDialog = new FontDialog();
            MainFontDialog.Font = Document.SelectionFont;

            if (MainFontDialog.ShowDialog() == DialogResult.OK)
            {
                Document.SelectionFont = MainFontDialog.Font;
            }
        }

        private void MenuItemFormatAligLeft_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void MenuItemFormatAligCenter_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void MenuItemFormatAligRight_Click(object sender, EventArgs e)
        {
            Document.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void MenuItemFormatToolbox_Click(object sender, EventArgs e)
        {
            if (MainToolStrip.Visible == true)
            {
                Settings.editorToolBox = false;
                MainToolStrip.Visible = false;
                Document.Location = new Point(0, (Document.Location.Y - 25));
                Document.Size = new Size(Document.Size.Width, (Document.Size.Height + 25));

            }
            else
            {
                Settings.editorToolBox = true;
                MainToolStrip.Visible = true;
                Document.Location = new Point(0, (Document.Location.Y + 25));
                Document.Size = new Size(Document.Size.Width, (Document.Size.Height - 25));
            }
        }

        private void MenuItemFormatReset_Click(object sender, EventArgs e)
        {
            MenuItemFormatWordWrap.Checked = true;
            MenuItemFormatDetectUrls.Checked = true;
            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }
            Document.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
            Document.SelectionAlignment = HorizontalAlignment.Left;
        }

        /* ##### ENCRYPTION MENU ##### */

        private void MenuItemEncryptionAES_Click(object sender, EventArgs e)
        {
            showAesToolStrip();
        }

        private void MenuItemEncryptionBase64encode_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }
            Document.SelectedText = encryptions.ToBase64(Document.SelectedText);
        }

        private void MenuItemEncryptionBase64decode_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }
            Document.SelectedText = encryptions.FromBase64(Document.SelectedText);
        }

        private void MenuItemEncryptionBytesEncode_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }
            Document.SelectedText = encryptions.ToArcsByte(Document.SelectedText);
        }

        private void MenuItemEncryptionByteDecode_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }
            Document.SelectedText = encryptions.FromArcsByte(Document.SelectedText);
        }

        private void MenuItemEncryptionLeetspeak_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }
            Leetspeak leet = new Leetspeak();
            Document.SelectedText = leet.Convert(Document.SelectedText);
        }

        private void MenuItemEncryptionRot13_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }
            Document.SelectedText = encryptions.ToRot13(Document.SelectedText);
        }

        /* ##### HASH MENU ##### */

        private void MenuItemHashMd5_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }
            Document.SelectedText = hashString.md5(Document.SelectedText);
        }

        private void MenuItemHashSha1_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }
            Document.SelectedText = hashString.Sha1(Document.SelectedText);
        }

        private void MenuItemHashSha256_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }
            Document.SelectedText = hashString.Sha256(Document.SelectedText);
        }

        private void MenuItemHashSha384_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }
            Document.SelectedText = hashString.Sha384(Document.SelectedText);
        }

        private void MenuItemHashSha512_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }
            Document.SelectedText = hashString.Sha512(Document.SelectedText);
        }

        private void MenuItemHashRipemd160_Click(object sender, EventArgs e)
        {
            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }
            Document.SelectedText = hashString.RIPEMD160(Document.SelectedText);
        }

        /* # # # # # # # # # # # # # # # # # # # # # # # # */
        /* # # # # # # # # #  LANGUAGE   # # # # # # # # # */
        /* # # # # # # # # # # # # # # # # # # # # # # # # */

        private void MenuItemLangEnglish_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\lang\\english.xml"))
            {
                lang.changeLangEditor(Application.StartupPath + "\\lang\\english.xml");
            }
            else
            {
                MessageBox.Show("Не найден английский перевод!");
            }
        }

        private void MenuItemLangGerman_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\lang\\german.xml"))
            {
                lang.changeLangEditor(Application.StartupPath + "\\lang\\german.xml");
            }
            else
            {
                MessageBox.Show("Не найден немецкий перевод!");
            }
        }

        private void MenuItemLangSpanish_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\lang\\spanish.xml"))
            {
                lang.changeLangEditor(Application.StartupPath + "\\lang\\spanish.xml");
            }
            else
            {
                MessageBox.Show("Не найден испанский перевод!");
            }
        }

        private void MenuItemLangrussian_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\lang\\russian.xml"))
            {
                lang.changeLangEditor(Application.StartupPath + "\\lang\\russian.xml");
            }
            else
            {
                MessageBox.Show("Не найден русский перевод!");
            }
        }

        /* # # # # # # # # # # # # # # # # # # # # # # # # */
        /* # # # # # # # # # #  ABOUT  # # # # # # # # # # */
        /* # # # # # # # # # # # # # # # # # # # # # # # # */

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            Form about = new CryptotextEditor.About();
            about.ShowDialog();
        }

        /* # # # # # # # # # # # # # # # # # # # # # # # # */
        /* # # # # # # # # SEARCH FUNCTION # # # # # # # # */
        /* # # # # # # # # # # # # # # # # # # # # # # # # */

        private void toolStripTextBoxSearchingString_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                toolStripButtonSearch_ButtonClick(null, null);
            }
        }

        private void MenuItemEditSearch_Click(object sender, EventArgs e)
        {
            if (toolStripSearch.Visible == false)
            {
                toolStripSearch.Visible = true;
                Document.Location = new Point(0, (Document.Location.Y + 25));
                Document.Size = new Size(Document.Size.Width, (Document.Size.Height - 25));

                if (Document.Text.Length < 9000)
                {
                    string[] sWords = Document.Text.Split(new Char[] { ' ', '\n', '/', '\\', '(', '[', ',', '.' });
                    AutoCompleteStringCollection data = new AutoCompleteStringCollection();

                    foreach (string word in sWords)
                    {
                        data.Add(word);
                    }

                    toolStripTextBoxSearchingString.AutoCompleteCustomSource = data;
                }
            }

            toolStripTextBoxSearchingString.SelectAll();
            toolStripTextBoxSearchingString.Focus();
        }

        private void toolStripButtonCloseSearch_Click(object sender, EventArgs e)
        {
            Document.Size = new Size(Document.Size.Width, (Document.Size.Height + 25));
            Document.Location = new Point(0, (Document.Location.Y - 25));
            toolStripSearch.Visible = false;
        }

        private void toolStripButtonSearch_ButtonClick(object sender, EventArgs e)
        {
            string sString = toolStripTextBoxSearchingString.Text;
            if (sString.Length > 0)
            {
                int iPos = (Document.SelectionStart + Document.SelectionLength);

                if (toolStripSearchBigSmallYes.Checked == true)
                {
                    if (Document.Find(sString, iPos, RichTextBoxFinds.MatchCase) == -1)
                    {
                        Document.Find(sString, 0, RichTextBoxFinds.MatchCase);
                    }
                    else
                    {
                        Document.Find(sString, iPos, RichTextBoxFinds.MatchCase);
                    }
                }
                else
                {
                    if (Document.Find(sString, iPos, RichTextBoxFinds.None) == -1)
                    {
                        Document.Find(sString, 0, RichTextBoxFinds.None);
                    }
                    else
                    {
                        Document.Find(sString, iPos, RichTextBoxFinds.None);
                    }
                }
            }
        }

        /* # # # # # # # # # # # # # # # # # # # # # # # # */
        /* # # # # # # # # AES  ENCRYPTION # # # # # # # # */
        /* # # # # # # # # # # # # # # # # # # # # # # # # */

        private void toolStripButtonCloseAES_Click(object sender, EventArgs e)
        {
            showAesToolStrip();
        }

        internal void showAesToolStrip()
        {
            if (toolStripAES.Visible == false)
            {
                toolStripAES.Visible = true;
                Document.Location = new Point(0, (Document.Location.Y + 25));
                Document.Size = new Size(Document.Size.Width, (Document.Size.Height - 25));
                toolStripTextBoxAESPassphrase.Focus();
            }
            else
            {
                Document.Size = new Size(Document.Size.Width, (Document.Size.Height + 25));
                Document.Location = new Point(0, (Document.Location.Y - 25));
                toolStripAES.Visible = false;
                Document.Focus();
            }
        }

        private void toolStripButtonAESencrypt_Click(object sender, EventArgs e)
        {
            if (!(Document.SelectedText.Length > 0))
            {
                Document.SelectAll();
            }
            Document.SelectedText = encryptions.AESencrypt(Document.SelectedText, toolStripTextBoxAESPassphrase.Text);
        }

        private void toolStripButtonAESdecrypt_Click(object sender, EventArgs e)
        {
            if (!(Document.SelectedText.Length > 0))
            {
                Document.SelectAll();
            }
            Document.SelectedText = encryptions.AESdecrypt(Document.SelectedText, toolStripTextBoxAESPassphrase.Text);
        }

        private void toolStripTextBoxAESPassphrase_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBoxAESPassphrase.Text.Length > 0)
            {
                toolStripButtonAESencrypt.Enabled = true;
                toolStripButtonAESdecrypt.Enabled = true;
            }
            else
            {
                toolStripButtonAESencrypt.Enabled = false;
                toolStripButtonAESdecrypt.Enabled = false;
            }
        }

        /* # # # # # # # # # # # # # # # # # # # # # # # # */
        /* # # # # # # # # # SYSTEM TRAY # # # # # # # # # */
        /* # # # # # # # # # # # # # # # # # # # # # # # # */

        private void MenuItemSystemTray_Click(object sender, EventArgs e)
        {
            notifyIconCryptotextEditor.Text = this.Text;
            notifyIconCryptotextEditor.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

        private void notifyIconCryptotextEditor_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIconCryptotextEditor.Visible = false;
        }

        private void docMenuStripFontSize8_Click(object sender, EventArgs e)
        {
            Document.SelectionFont = new Font(Document.SelectionFont.FontFamily, 8);
        }

        private void docMenuStripFontSize12_Click(object sender, EventArgs e)
        {
            Document.SelectionFont = new Font(Document.SelectionFont.FontFamily, 12);
        }

        private void docMenuStripFontSize14_Click(object sender, EventArgs e)
        {
            Document.SelectionFont = new Font(Document.SelectionFont.FontFamily, 14);
        }

        private void docMenuStripFontSize16_Click(object sender, EventArgs e)
        {
            Document.SelectionFont = new Font(Document.SelectionFont.FontFamily, 16);
        }

        /* # # # # # # # # # # # # # # # # # # # # # # # # */
        /* # # # # # # # # CUSTOM ITEMS # # # # # # # # #  */
        /* # # # # # # # # # # # # # # # # # # # # # # # # */

        /*private void listCustomScripts()
        {
            if (Directory.Exists(Application.StartupPath + "\\custom"))
            {
                foreach (string cjsFile in Directory.GetFiles(Application.StartupPath + "\\custom"))
                {
                    if (cjsFile.EndsWith(".js"))
                    {
                        FileInfo fi = new FileInfo(cjsFile);
                        string itemName = (fi.Name).Remove((fi.Name.Length - 3), 3);
                        ToolStripMenuItem newMI = new ToolStripMenuItem(itemName);

                        ToolStripMenuItem newMIencrypt = new ToolStripMenuItem(itemName + "Encrypt");
                        newMIencrypt.Name = itemName + "Encrypt";
                        newMIencrypt.Tag = itemName;
                        newMIencrypt.Text = MenuItemEncryptionBase64encode.Text;
                        newMIencrypt.Click += delegate(object sender, EventArgs e)
                        {
                            encryptCustomScript(fi.FullName);
                        };

                        ToolStripMenuItem newMIdecrypt = new ToolStripMenuItem(itemName + "Decrypt");
                        newMIdecrypt.Name = itemName + "Decrypt";
                        newMIdecrypt.Tag = itemName;
                        newMIdecrypt.Text = MenuItemEncryptionBase64decode.Text;
                        newMIdecrypt.Click += delegate(object sender, EventArgs e)
                        {
                            decryptCustomScript(fi.FullName);
                        };
                        
                        newMI.DropDownItems.Add(newMIencrypt);
                        newMI.DropDownItems.Add(newMIdecrypt);
                        MenuItemEncryption.DropDownItems.Add(newMI);
                    }
                }
            }
        }

        private void encryptCustomScript(string filePath)
        {
            CustomEncryptionScripts ces = new CustomEncryptionScripts(filePath);

            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }

            Document.SelectedText = ces.encryptString(Document.SelectedText);
        }

        private void decryptCustomScript(string filePath)
        {
            CustomEncryptionScripts ces = new CustomEncryptionScripts(filePath);

            if (Document.SelectedText.Length < 1)
            {
                Document.SelectAll();
            }

            Document.SelectedText = ces.decryptString(Document.SelectedText);
        }*/

        private void Document_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
