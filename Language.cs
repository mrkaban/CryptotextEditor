using System.Xml;

namespace CryptotextEditor
{
    internal class Language
    {
        Editor editor;
        ctxtproperties ctxtPropWindow;

        internal Language(Editor e)
        {
            editor = e;
        }

        internal Language(ctxtproperties c)
        {
            ctxtPropWindow = c;
        }

        internal void changeLangEditor(string langName)
        {
            XmlDocument xFile = new XmlDocument();
            XmlNode nodeText;
            System.IO.FileInfo fi;

            try
            {
                xFile.Load(langName);

                fi = new System.IO.FileInfo(langName);
                Settings.editorLangPath = "lang\\" + fi.Name;
                
                nodeText = xFile.GetElementsByTagName("miFile").Item(0);
                editor.MenuItemFile.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFileNew").Item(0);
                editor.MenuItemFileNew.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.mtsNew.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFileOpen").Item(0);
                editor.MenuItemFileOpen.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.mtsOpen.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFileSave").Item(0);
                editor.MenuItemFileSave.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.mtsSave.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFileSaveAs").Item(0);
                editor.MenuItemFileSaveAs.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFileCtxtProperties").Item(0);
                editor.MenuItemFileProperties.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.mtsProperties.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFileHash").Item(0);
                editor.MenuItemHashFile.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFileClose").Item(0);
                editor.MenuItemFileClose.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEdit").Item(0);
                editor.MenuItemEdit.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEditUndo").Item(0);
                editor.MenuItemEditUndo.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.mtsUndo.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEditRedo").Item(0);
                editor.MenuItemEditRedo.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.mtsRedo.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEditCut").Item(0);
                editor.MenuItemEditCut.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.docMenuStripCut.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.mtsCut.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEditCopy").Item(0);
                editor.MenuItemEditCopy.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.docMenuStripCopy.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.mtsCopy.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEditPaste").Item(0);
                editor.MenuItemEditPaste.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.docMenuStripPaste.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.mtsPaste.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEditDelete").Item(0);
                editor.MenuItemEditDelete.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEditMarkupAll").Item(0);
                editor.MenuItemEditMarkupAll.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEditSearch").Item(0);
                editor.MenuItemEditSearch.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.mtsSearch.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEditText").Item(0);
                editor.MenuItemEditText.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.docMenuStripTextCase.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEditTextUp").Item(0);
                editor.MenuItemEditTextUppercase.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.docMenuStripTextCaseUp.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEditTextLow").Item(0);
                editor.MenuItemEditTextLowercase.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.docMenuStripTextCaseLower.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEditTextScentense").Item(0);
                editor.MenuItemEditTextSentenceCase.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.docMenuStripTextCaseSentence.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEditTimeDate").Item(0);
                editor.MenuItemEditTimeDate.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFormat").Item(0);
                editor.MenuItemFormat.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFormatWordWrap").Item(0);
                editor.MenuItemFormatWordWrap.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFormatDetectUrls").Item(0);
                editor.MenuItemFormatDetectUrls.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFormatFont").Item(0);
                editor.MenuItemFormatFont.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.docMenuStripFont.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.mtsFont.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFormatFontSize").Item(0);
                editor.docMenuStripFontSize.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFormatAlig").Item(0);
                editor.MenuItemFormatAlig.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFormatAligLeft").Item(0);
                editor.MenuItemFormatAligLeft.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFormatAligCenter").Item(0);
                editor.MenuItemFormatAligCenter.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFormatAligRight").Item(0);
                editor.MenuItemFormatAligRight.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFormatToolBox").Item(0);
                editor.MenuItemFormatToolbox.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miFormatReset").Item(0);
                editor.MenuItemFormatReset.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.docMenuStripDefault.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEncryption").Item(0);
                editor.MenuItemEncryption.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEncode").Item(0);
                editor.MenuItemEncryptionBase64encode.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.MenuItemEncryptionByteEncode.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.toolStripButtonAESencrypt.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.mtsBase64encode.Text = "Base64" + nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miDecode").Item(0);
                editor.MenuItemEncryptionBase64decode.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.MenuItemEncryptionByteDecode.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.toolStripButtonAESdecrypt.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
                editor.mtsBase64decode.Text = "Base64" + nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miLanguage").Item(0);
                editor.MenuItemLang.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("tsSearchFor").Item(0);
                editor.toolStripLabelSearchFor.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("tsSearch").Item(0);
                editor.toolStripButtonSearch.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("tsSearchMathCase").Item(0);
                editor.toolStripSearchBigSmallYes.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("labelPassphrase").Item(0);
                editor.toolStripLabelAesEnc.Text = "AES   " + nodeText.Attributes.GetNamedItem("string").Value.ToString() + ": ";

                nodeText = xFile.GetElementsByTagName("msgRestoreBackup").Item(0);
                editor.msgRestoreBackup = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("msgNotSaved").Item(0);
                editor.msgNotSaved = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("msgSaveQuestion").Item(0);
                editor.msgSaveQuestion = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("labelSave").Item(0);
                editor.labelSave = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                //nodeText = xFile.GetElementsByTagName("jsErrorMsg").Item(0);
                //CustomEncryptionScripts.jsErrorMsg = nodeText.Attributes.GetNamedItem("string").Value.ToString();
            }
            catch
            {
            }
        }

        internal void changeLangCtxtProperties(string langName)
        {
            XmlDocument xFile = new XmlDocument();
            XmlNode nodeText;

            try
            {
                xFile.Load(langName);

                nodeText = xFile.GetElementsByTagName("miFileCtxtProperties").Item(0);
                ctxtPropWindow.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("miEncryption").Item(0);
                ctxtPropWindow.groupBoxEnc.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("labelOtherSettings").Item(0);
                ctxtPropWindow.groupBoxOthers.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("labelSaveRTF").Item(0);
                ctxtPropWindow.checkBoxWithRTF.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("labelPassphrase").Item(0);
                ctxtPropWindow.labelPassword.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();

                nodeText = xFile.GetElementsByTagName("labelSavePassword").Item(0);
                ctxtPropWindow.checkBoxSavePassInFile.Text = nodeText.Attributes.GetNamedItem("string").Value.ToString();
            }
            finally
            {
            }
        }
    }
}