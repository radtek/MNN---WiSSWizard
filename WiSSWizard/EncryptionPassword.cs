using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Actemium.Security;
using System.Xml.Serialization;

namespace Actemium.WiSSWizard
{
    public class EncryptionPassword
    {
        private FileHandling _fhEncr;


        string _encryptionPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\ConfigFiles\configPw.dat";
        private FileStream _fileStream = null;
        private StreamWriter _streamWriter;
        private ConfigClass _configClass;

        /// <summary>
        /// Default Actemium Encryption Key
        /// 
        /// This key may NEVER EVER change!!!!!!!
        /// </summary>

        public EncryptionPassword()
        {

        }

        public EncryptionPassword(ConfigClass configClass)
        {
            _configClass = configClass;
             _fhEncr = new FileHandling(_configClass);
        }

        public static string Key
        {
            get { return _encryptionKey; }
        } private const string _encryptionKey = @"85!aprexus3fabub=bre7re8ra3rAqaDRu_ruDuPracrUsupRu7ebec=u4R2cuk35pusAtudadrAdra3uYUbr&7ucememusechePraphaw#EsTegusEsp7s?ubrUchu@";


        public string FilePath
        {
            get
            {
                return _encryptionPath;
            }
        }

        public void CreateEncryptedKeyFile()
        {
            if(File.Exists(_encryptionPath))
            {
            File.Delete(_encryptionPath);
            }
            try
            {
                string folder = "";
                string[] splitPath = _encryptionPath.Split('\\');
                for (int i = 0; i < splitPath.Length - 1; i++)
                {
                    folder = folder + splitPath[i] + "\\";
                }
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);

                }
                _fileStream = new FileStream(_encryptionPath, FileMode.OpenOrCreate, FileAccess.Write);


            }
            catch (IOException)
            { }
            finally
            {
                if (_fileStream != null)
                {
                    _fileStream.Close();
                }
            }

        }

        public void AddKey(string username, string password)
        {
            List<string> pwRoles = new List<string>();
            pwRoles.Clear();
            string text = Encryption.Encrypt(username + "|" + password, Key);
            pwRoles.Add(text);
            try
            {
                if(!File.Exists(_encryptionPath))
                {
                    CreateEncryptedKeyFile();
                   // _fileStream = new FileStream(_encryptionPath, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    //_fileStream = new FileStream(_encryptionPath, FileMode.Append, FileAccess.Write);
                }

                if (GetKey(username) != null)
                {
                    foreach (string str in _fhEncr.ReadWholeFile(_encryptionPath))
                    {
                        string encrypted = Encryption.Decrypt(str, Key);
                        string[] split = encrypted.Split('|');
                        if (split[0] != username)
                        {
                            pwRoles.Add(str);
                        }
                    }
                    if (_fileStream != null) { _fileStream.Close(); }
                    File.Delete(_encryptionPath);
                    CreateEncryptedKeyFile();
                    _fileStream = new FileStream(_encryptionPath, FileMode.Append, FileAccess.Write);
                    _streamWriter = new StreamWriter(_fileStream);
                    _streamWriter.WriteLine(text);
                    foreach (string pwKey in pwRoles)
                    {
                        _streamWriter.WriteLine(pwKey);
                    }


                }
                else
                {
                    _fileStream = new FileStream(_encryptionPath, FileMode.Append, FileAccess.Write);
                    _streamWriter = new StreamWriter(_fileStream);
                    _streamWriter.WriteLine(text);
                }
            
            
            
            
            }
            catch (IOException)
            { }
            finally
            {
                if (_streamWriter != null) { _streamWriter.Close(); }
                if (_fileStream != null) { _fileStream.Close(); }
            }




        }


        public string GetKey(string username)
        {
            try
            {
                foreach (string str in _fhEncr.ReadWholeFile(_encryptionPath))
                {
                    string password = "";
                    string encrypted = Encryption.Decrypt(str, Key);
                    string[] split = encrypted.Split('|');
                    if (split[0] == username)
                    {
                        foreach (string st in split)
                        {
                            if (st == split[1])
                            {
                                password = password + st;
                            }
                            if (st != split[0] && st != split[1])
                            {
                                password = password + "|" + st;
                            }
                        }
                        return password;
                    }
                }
                return null;
            }
            catch (IOException)
            { return null; }
            finally
            {
                if (_streamWriter != null) { _streamWriter.Close(); }
                if (_fileStream != null) { _fileStream.Close(); }
            }
        }
    }
}