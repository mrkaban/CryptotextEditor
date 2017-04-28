/*using System;
using System.IO;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.JScript;

namespace CryptotextEditor
{
    internal class CustomEncryptionScripts
    {
        internal static string jsErrorMsg = "";
        private string jsCodeString;

        internal CustomEncryptionScripts(string javaFilePath)
        {
            if (File.Exists(javaFilePath) == true)
            {
                StreamReader sr = new StreamReader(javaFilePath, System.Text.Encoding.UTF8);
                jsCodeString = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        internal string encryptString(string sText)
        {
            return customScriptMethods(sText, "encryptString");
        }

        internal string decryptString(string sText)
        {
            return customScriptMethods(sText, "decryptString");
        }

        private string customScriptMethods(string sText, string methodName)
        {
            var jsCodeProvider = new JScriptCodeProvider();
            var parameters = new CompilerParameters()
            {
                GenerateInMemory = true,
                GenerateExecutable = true
            };

            var results = jsCodeProvider.CompileAssemblyFromSource(parameters, jsCodeString);

            if (results.Errors.HasErrors)
            {
                //Fehler aufgetreten
                MessageBox.Show(jsErrorMsg);
                return sText;
            }
            else if (results.Errors.HasWarnings)
            {
                //Warnungen aufgetreten
                MessageBox.Show(jsErrorMsg);
                return sText;
            }
            else
            {
                var assembly = results.CompiledAssembly;
                var compiledType = assembly.GetTypes().FirstOrDefault();
                if (compiledType != null)
                {
                    var sendStringMetodInfo = compiledType.GetMethod(methodName);
                    if (sendStringMetodInfo != null)
                    {
                        var instance = FormatterServices.GetUninitializedObject(compiledType);
                        string returnValue = (string)sendStringMetodInfo.Invoke(instance, new object[] { null, null });
                        return returnValue;
                    }
                    else
                    {
                        return sText;
                    }
                }
                else
                {
                    return sText;
                }
            }
        }
    }
}
*/