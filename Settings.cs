using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Security.Permissions;
using System.Security;
using System.Security.Principal;
using System.Security.AccessControl;

namespace CryptotextEditor
{
    internal class Settings
    {
        internal static System.Drawing.Size EditorSize = new System.Drawing.Size(600, 400);
        internal static string CurrentFilePath = "";
        internal static bool CurrentFileSaved = true;
        internal static bool WordWrap = true;
        internal static bool DetectUrls = true;
        internal static bool AutoSave = true;
        internal static string LastOpenedFile = "";
        internal static System.Drawing.Point editorLocation = new System.Drawing.Point(100, 100);
        internal static string editorLangPath = "lang\\english.xml";
        internal static bool editorToolBox = true;
        internal static readonly string tmpPath = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + "\\Cryptotext Editor";
        
        private static string settingsPath = tmpPath + "\\settings.xml";
        

        internal static void Load()
        {            
            if (!System.IO.File.Exists(settingsPath))
            {
                Save();
            }

            XmlDocument xFile = new XmlDocument();
            xFile.Load(settingsPath);

            int editorSizeWidth = 600;
            int editorSizeHeight = 400;
            int editorLocationX = 100;
            int editorLocationY = 100;

            try
            {
                editorSizeWidth = Convert.ToInt32(xFile.GetElementsByTagName("EditorSize").Item(0).Attributes.GetNamedItem("Width").InnerText);
                editorSizeHeight = Convert.ToInt32(xFile.GetElementsByTagName("EditorSize").Item(0).Attributes.GetNamedItem("Height").InnerText);
            }
            catch { }
            finally
            {
                EditorSize = new Size(editorSizeWidth, editorSizeHeight);
            }

            try
            {
                WordWrap = Convert.ToBoolean(xFile.GetElementsByTagName("WordWrap").Item(0).InnerText);
            }
            catch { }

            try
            {
                DetectUrls = Convert.ToBoolean(xFile.GetElementsByTagName("DetectUrls").Item(0).InnerText);
            }
            catch { }

            try
            {
                AutoSave = Convert.ToBoolean(xFile.GetElementsByTagName("AutoSave").Item(0).InnerText);
            }
            catch { }

            try
            {
                LastOpenedFile = xFile.GetElementsByTagName("LastOpenedFile").Item(0).InnerText;
            }
            catch { }

            try
            {
                editorLocationX = Convert.ToInt32(xFile.GetElementsByTagName("editorLocation").Item(0).Attributes.GetNamedItem("x").InnerText);
                editorLocationY = Convert.ToInt32(xFile.GetElementsByTagName("editorLocation").Item(0).Attributes.GetNamedItem("y").InnerText);
             
                if(Screen.PrimaryScreen.Bounds.Width < editorLocationX | editorLocationX < 0)
                {
                	editorLocationX = 0;
                }
                
				if(Screen.PrimaryScreen.Bounds.Height < editorLocationY | editorLocationY < 0)
                {
                	editorLocationY = 0;
                }
            }
            catch { }
            finally
            {            	
                editorLocation = new Point(editorLocationX, editorLocationY);
            }

            try
            {
                editorLangPath = xFile.GetElementsByTagName("editorLangPath").Item(0).InnerText;
            }
            catch { }

            try
            {
                editorToolBox = Convert.ToBoolean(xFile.GetElementsByTagName("editorToolBox").Item(0).InnerText);
            }
            catch { }
        }

        internal static void Save()
        {        	
            XmlTextWriter XMLobj;

            try
            {
                if(!System.IO.Directory.Exists(Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + "\\Cryptotext Editor"))
            		System.IO.Directory.CreateDirectory(Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + "\\Cryptotext Editor");
            	
                XMLobj = new XmlTextWriter(settingsPath, System.Text.Encoding.UTF8);
            }
            catch(UnauthorizedAccessException)
            {
            	return;
            }

        	XMLobj.Formatting = Formatting.Indented;

            XMLobj.WriteStartDocument();

            XMLobj.WriteStartElement("Settings");
            XMLobj.WriteAttributeString("program", "Cryptotext Editor");

            XMLobj.WriteStartElement("EditorSize");
            
            XMLobj.WriteAttributeString("Width", EditorSize.Width.ToString());
            XMLobj.WriteAttributeString("Height", EditorSize.Height.ToString());
            XMLobj.WriteValue(EditorSize.ToString());
            XMLobj.WriteEndElement();

            XMLobj.WriteStartElement("CurrentFilePath");
            XMLobj.WriteValue(CurrentFilePath);
            XMLobj.WriteEndElement();

            XMLobj.WriteStartElement("CurrentFileSaved");
            XMLobj.WriteValue(CurrentFileSaved.ToString());
            XMLobj.WriteEndElement();

            XMLobj.WriteStartElement("WordWrap");
            XMLobj.WriteValue(WordWrap.ToString());
            XMLobj.WriteEndElement();

            XMLobj.WriteStartElement("DetectUrls");
            XMLobj.WriteValue(DetectUrls.ToString());
            XMLobj.WriteEndElement();

            XMLobj.WriteStartElement("AutoSave");
            XMLobj.WriteValue(AutoSave.ToString());
            XMLobj.WriteEndElement();

            XMLobj.WriteStartElement("LastOpenedFile");
            XMLobj.WriteValue(LastOpenedFile);
            XMLobj.WriteEndElement();

            XMLobj.WriteStartElement("editorLocation");
            XMLobj.WriteAttributeString("x", editorLocation.X.ToString());
            XMLobj.WriteAttributeString("y", editorLocation.Y.ToString());
            XMLobj.WriteValue(editorLocation.ToString());
            XMLobj.WriteEndElement();

            XMLobj.WriteStartElement("editorLangPath");
            XMLobj.WriteValue(editorLangPath);
            XMLobj.WriteEndElement();

            XMLobj.WriteStartElement("editorToolBox");
            XMLobj.WriteValue(editorToolBox.ToString());
            XMLobj.WriteEndElement();

            XMLobj.WriteEndElement();

            XMLobj.WriteEndDocument();
            XMLobj.Close();
            
        }
    }
}
