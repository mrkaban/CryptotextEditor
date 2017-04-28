using System;
using System.IO;
using System.Windows.Forms;
using CryptotextEditorAPI;

namespace CryptotextEditor
{
    internal class FileHandler
    {
        Editor MainForm;

        internal FileHandler(Editor MainEditor)
        {
            this.MainForm = MainEditor;
        }

        internal void OpenNewFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            ofd.Filter = "Textfiles (*.txt, *.ctxt, *.rtf)|*.txt;*.ctxt;*.rtf|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenFile(ofd.FileName.ToString());
            }
        }

        internal void OpenFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                if (FilePath.ToLower().EndsWith(".exe")
                    | FilePath.ToLower().EndsWith(".msi")
                    | FilePath.ToLower().EndsWith(".deb") 

                    | FilePath.ToLower().EndsWith(".7z") 
                    | FilePath.ToLower().EndsWith(".zip") 
                    | FilePath.ToLower().EndsWith(".rar") 
                    | FilePath.ToLower().EndsWith(".bz2") 
                    | FilePath.ToLower().EndsWith(".gz") 
                    | FilePath.ToLower().EndsWith(".tar") 
                    | FilePath.ToLower().EndsWith(".xz") 
                    | FilePath.ToLower().EndsWith(".wim") 
                    | FilePath.ToLower().EndsWith(".lnk")
                    | FilePath.ToLower().EndsWith(".dll")
                    | FilePath.ToLower().EndsWith(".arj")
                    | FilePath.ToLower().EndsWith(".cpio")
                    | FilePath.ToLower().EndsWith(".io")
                    | FilePath.ToLower().EndsWith(".lzh")
                    | FilePath.ToLower().EndsWith(".lha")
                    | FilePath.ToLower().EndsWith(".dmg")
                    | FilePath.ToLower().EndsWith(".iso")
                    | FilePath.ToLower().EndsWith(".udf")
                    | FilePath.ToLower().EndsWith(".vhd")
                    | FilePath.ToLower().EndsWith(".ace")
                    | FilePath.ToLower().EndsWith(".vdi")

                    | FilePath.ToLower().EndsWith(".mkv")
                    | FilePath.ToLower().EndsWith(".mp4")
                    | FilePath.ToLower().EndsWith(".mp3")
                    | FilePath.ToLower().EndsWith(".mpg")
                    | FilePath.ToLower().EndsWith(".webm")
                    | FilePath.ToLower().EndsWith(".wmv")
                    )
                {
                    ClearDocument();
                    HashThisFile(FilePath);
                }
                else
                {
                    MainForm.Document.Clear();
                    FileInfo fi = new FileInfo(FilePath);
                    MainForm.Text = fi.Name.ToString() + " - CryptotextEditor";

                    if (FilePath.ToLower().EndsWith(".ctxt") == true)
                    {
                        ctxtFile ctxtfile = new ctxtFile(FilePath);
//                      MessageBox.Show(ctxtfile.PassPhrase);

                        string ctxtInnerText = ctxtfile.ReadFile();

                        if (ctxtInnerText != null)
                        {
                            try
                            {
                                MainForm.Document.Rtf = ctxtInnerText;
                            }
                            catch
                            {
                                MainForm.Document.Text = ctxtInnerText;
                            }

                            if (ctxtfile.encName == ctxtFile.Encryption.CryptotextEditorAES
                                & ctxtfile.PassPhrase.Length < 1)
                            {
                                if (MainForm.toolStripAES.Visible == false)
                                {
                                    MainForm.showAesToolStrip();
                                }
                                MainForm.toolStripTextBoxAESPassphrase.Focus();
                            }
                        }
                        else
                        {
                            ClearDocument();
                        }
                        MainForm.MenuItemFileProperties.Enabled = true;
                        MainForm.mtsProperties.Enabled = true;
                    }
                    else
                    {
                        try
                        {
                            MainForm.Document.LoadFile(FilePath, RichTextBoxStreamType.RichText);
                        }
                        catch
                        {
                            MainForm.Document.LoadFile(FilePath, RichTextBoxStreamType.PlainText);
                        }
                        MainForm.MenuItemFileProperties.Enabled = false;
                        MainForm.mtsProperties.Enabled = false;
                    }

                    MainForm.Document.ClearUndo();
                    Settings.CurrentFileSaved = true;
                    Settings.CurrentFilePath = FilePath;
                    if (Settings.LastOpenedFile != FilePath)
                    {
                        MainForm.MenuItemFileLastOpened.Text = fi.Name.ToString();
                        Settings.LastOpenedFile = FilePath;
                    }
                }
            }
            else
            {
                MessageBox.Show("This file was not found.");
            }
        }

        internal void SaveOpendFile()
        {
            if (File.Exists(Settings.CurrentFilePath) == true)
            {
                SaveFile(Settings.CurrentFilePath);
            }
            else
            {
                SaveInDirectory();
            }
        }

        internal void SaveInDirectory()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            sfd.Filter = "CryptotextEditor file (*.ctxt)|*.ctxt|Textfile (*.rtf, *.txt)|*.rtf;*.txt|All files (*.*)|*.*";
            sfd.DefaultExt = ".ctxt";
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName.EndsWith(".ctxt") == true)
                {
                    ctxtproperties ctxtp = new ctxtproperties(sfd.FileName, false, MainForm);
                    ctxtp.ShowDialog();
                }
                else
                {
                    SaveFile(sfd.FileName.ToString());
                }
            }
        }

        internal void SaveFile(string FilePath)
        {
            if (FilePath.ToLower().EndsWith(".ctxt") == true)
            {
                ctxtFile ctxtfile = new ctxtFile(FilePath);

                if (ctxtfile.GetEncryption() == ctxtFile.Encryption.CryptotextEditorAES & ctxtFile.GetPassphrase(FilePath).Length < 2)
                {
                    ctxtproperties ctxtp = new ctxtproperties(FilePath, true, MainForm);
                    ctxtp.ShowDialog();
                }
                else
                {
                    ctxtfile.saveOpenedCtxt(MainForm.Document.Rtf);
                }
                MainForm.MenuItemFileProperties.Enabled = true;
                MainForm.mtsProperties.Enabled = true;
            }
            else
            {
                if (FilePath.ToLower().EndsWith(".txt") == true)
                    MainForm.Document.SaveFile(FilePath, RichTextBoxStreamType.PlainText);
                else
                    MainForm.Document.SaveFile(FilePath, RichTextBoxStreamType.RichText);

                MainForm.MenuItemFileProperties.Enabled = false;
                MainForm.mtsProperties.Enabled = false;
            }
            FileInfo fi = new FileInfo(FilePath);
            MainForm.Text = fi.Name.ToString() + " - CryptotextEditor";

            Settings.CurrentFileSaved = true;
            Settings.CurrentFilePath = FilePath;

            if (Settings.LastOpenedFile != FilePath)
            {
                MainForm.MenuItemFileLastOpened.Text = fi.Name.ToString();
                Settings.LastOpenedFile = FilePath;
            }
        }

        internal void AutoSave(int SaveNum)
        {
            string asFilePath;
            ctxtFile file;

            try
            {
                asFilePath = Settings.tmpPath + "\\~CryptotextEditortext32.tmp";
                file = new ctxtFile(asFilePath);
                if (SaveNum == 0 & Settings.AutoSave == true)
                {
                    file.SaveWithRTF = false;
                    file.WriteFile(MainForm.Document.Text);
                }
                else if (SaveNum == 1)
                {
                    MainForm.Document.Text = file.ReadFile();
                }
            }
            catch (UnauthorizedAccessException) 
            {
                MainForm.MenuItemFormatAutoSave.Checked = false;
            }
        }

        internal void ClearDocument()
        {
            MainForm.Text = "Unknown - CryptotextEditor";
            MainForm.Document.Clear();
            MainForm.Document.ClearUndo();
            Settings.CurrentFileSaved = true;
            Settings.CurrentFilePath = "";
            MainForm.MenuItemFileProperties.Enabled = false;
            MainForm.mtsProperties.Enabled = false;
        }

        internal void HashNewFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            ofd.Filter = "Archives (*.exe, *.zip, *.7z, *.rar)|*.exe;*.zip;*.rar;*.7z|Textfiles (*.txt, *.ctxt, *.rtf, ...)|*.txt;*.ctxt;*.rtf;*.doc;*.odt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ClearDocument();
                HashThisFile(ofd.FileName);
            }
        }

        internal void HashThisFile(string filePath)
        {
            HashFileForm hff = new HashFileForm(filePath, MainForm);
            hff.ShowDialog();
            /*
            FileInfo fi = new FileInfo(filePath);
            string firstLine = "File: " + fi.Name + "\n\n";
            string seconLine = "MD5 Hash:\n" + hashFile.md5(filePath) + "\n\n";
            string thirdLine = "SHA-1 Hash:\n" + hashFile.Sha1(filePath);
            MainForm.Document.Text = firstLine + seconLine + thirdLine;
            //*/
        }

        internal void hashFile(string filePath, string[] hashAlgorithms = null)
        {
            if (hashAlgorithms == null)
            {
                hashAlgorithms = new string[] { "md5", "sha1" };
            }

            FileInfo fi = new FileInfo(filePath);
            string hashingText = "File: " + fi.Name + "\n\n";

            foreach (string hash in hashAlgorithms)
            {
                if (hash == "md5")
                {
                    hashingText += "MD5: \n" + CryptotextEditorAPI.hashFile.md5(filePath) + "\n\n";
                }
                else if (hash.Contains("sha"))
                {
                    if (hash.Contains("256"))
                    {
                        hashingText += "SHA 256: \n" + CryptotextEditorAPI.hashFile.Sha256(filePath) + "\n\n";
                    }
                    else if (hash.Contains("384"))
                    {
                        hashingText += "SHA 384: \n" + CryptotextEditorAPI.hashFile.Sha384(filePath) + "\n\n";
                    }
                    else if (hash.Contains("512"))
                    {
                        hashingText += "SHA 512: \n" + CryptotextEditorAPI.hashFile.Sha512(filePath) + "\n\n";
                    }
                    else
                    {
                        hashingText += "SHA 1: \n" + CryptotextEditorAPI.hashFile.Sha1(filePath) + "\n\n";
                    }
                }
                else if(hash.Contains("ripemd"))
                {
                    hashingText += "RIPEMD160: \n" + CryptotextEditorAPI.hashFile.RIPEMD160(filePath) + "\n\n";
                }

                MainForm.Document.Text = hashingText;
            }
        }
    }
}
