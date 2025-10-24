using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.Hosting;
using System.Windows.Forms;
using System.Xml;

namespace PasswordEncryption
{
    public partial class Form1 : Form
    {
        private const string KEY = "29C1EB633ECAB0CA0F52B588AE92EA31";
        public Form1()
        {
            InitializeComponent();
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            List<Item> items = new List<Item>
        {
            new Item { ID = 5, Name = "All Companies" },
            new Item { ID = 1, Name = "PIONEER ENGINEERING INTERNATIONAL - BAKU (020)" },
            new Item { ID = 2, Name = "ERBIL PIONEER (0F0)" },
            new Item { ID = 3, Name = "PIONEER ENGINEERING INTERNATIONAL LIMITED (Dubai Branch) (0G0)" },
            new Item { ID = 4, Name = "Energy Inspection Services LTD (0H0)" }
        };

            comboBox1.DataSource = items;          // Must set DataSource first
            comboBox1.DisplayMember = "Name";      // Field to show
            comboBox1.ValueMember = "ID";          // Hidden value
        }
        // Sample class
        
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int id = 0;
            txtEncPassword.Text = "";
            if (txtPassword.Text.Trim() == "")
                return;
            txtEncPassword.Text = Encription(txtPassword.Text);
                // Read ID (first column)
            
            if (comboBox1.SelectedIndex == -1 || comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select the Company from the dropdown.");
            }
            id = (int)comboBox1.SelectedValue;
            updateWebConfig(txtEncPassword.Text, id);
        }

        public void updateWebConfig(string sValue, int id)
        {
            string physicalPath = "";

            #region PrjPioneer1 Publish file
            if (id == 1 || id == 5)
            {
                physicalPath = "c:\\inetpub\\wwwroot\\PrjPioneer1\\Web.config";
                try
                {
                    ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = physicalPath
                    };

                    // Open the configuration file
                    Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

                    KeyValueConfigurationElement setting = config.AppSettings.Settings["Password"];
                    if (setting != null)
                    {
                        setting.Value = sValue;
                    }
                    else
                    {
                        //config.AppSettings.Settings.Add("YourKey", "NewValue");
                    }

                    // Save the changes
                    config.Save(ConfigurationSaveMode.Modified);

                    // Refresh the appSettings section to reflect changes
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception e)
                {

                }
            }
            #endregion

            #region PrjPioneer1ERB Publish file
            if (id == 2 || id == 5)
            {
                physicalPath = "c:\\inetpub\\wwwroot\\PrjPioneer1ERB\\Web.config";
                try
                {
                    ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = physicalPath
                    };

                    // Open the configuration file
                    Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

                    KeyValueConfigurationElement setting = config.AppSettings.Settings["Password"];
                    if (setting != null)
                    {
                        setting.Value = sValue;
                    }
                    else
                    {
                        //config.AppSettings.Settings.Add("YourKey", "NewValue");
                    }

                    // Save the changes
                    config.Save(ConfigurationSaveMode.Modified);

                    // Refresh the appSettings section to reflect changes
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception e)
                {
                    ShowPopup($"Error While updating the Web.Config with Path {physicalPath}", false);
                }
            }
            #endregion

            #region PrjPioneer10G0 Publish file
            if (id == 3 || id == 5)
            {
                physicalPath = "c:\\inetpub\\wwwroot\\PrjPioneer10G0\\Web.config";
                try
                {
                    ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = physicalPath
                    };

                    // Open the configuration file
                    Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

                    KeyValueConfigurationElement setting = config.AppSettings.Settings["Password"];
                    if (setting != null)
                    {
                        setting.Value = sValue;
                    }
                    else
                    {
                        //config.AppSettings.Settings.Add("YourKey", "NewValue");
                    }

                    // Save the changes
                    config.Save(ConfigurationSaveMode.Modified);

                    // Refresh the appSettings section to reflect changes
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception e)
                {
                    ShowPopup($"Error While updating the Web.Config with Path {physicalPath}", false);
                }
            }
            #endregion

            #region PrjPioneer10H0 Publish file
            if (id == 4 || id == 5)
            {
                physicalPath = "c:\\inetpub\\wwwroot\\PrjPioneer10H0\\Web.config";
                try
                {
                    ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = physicalPath
                    };

                    // Open the configuration file
                    Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

                    KeyValueConfigurationElement setting = config.AppSettings.Settings["Password"];
                    if (setting != null)
                    {
                        setting.Value = sValue;
                    }
                    else
                    {
                        //config.AppSettings.Settings.Add("YourKey", "NewValue");
                    }

                    // Save the changes
                    config.Save(ConfigurationSaveMode.Modified);

                    // Refresh the appSettings section to reflect changes
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception e)
                {
                    ShowPopup($"Error While updating the Web.Config with Path {physicalPath}", false);
                }
            }

            #endregion

            #region Pioneer Publish file
            if (id == 1 || id == 5)
            {
                physicalPath = "c:\\inetpub\\wwwroot\\Pioneer\\Web.config";
                try
                {
                    ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = physicalPath
                    };

                    // Open the configuration file
                    Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

                    KeyValueConfigurationElement setting = config.AppSettings.Settings["Password"];
                    if (setting != null)
                    {
                        setting.Value = sValue;
                    }
                    else
                    {
                        //config.AppSettings.Settings.Add("YourKey", "NewValue");
                    }

                    // Save the changes
                    config.Save(ConfigurationSaveMode.Modified);

                    // Refresh the appSettings section to reflect changes
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception e)
                {
                    ShowPopup($"Error While updating the Web.Config with Path {physicalPath}", false);
                }
            }

            #endregion

            #region PioneerERB Publish file
            if (id == 2 || id == 5)
            {
                physicalPath = "c:\\inetpub\\wwwroot\\PioneerERB\\Web.config";
                try
                {
                    ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = physicalPath
                    };

                    // Open the configuration file
                    Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

                    KeyValueConfigurationElement setting = config.AppSettings.Settings["Password"];
                    if (setting != null)
                    {
                        setting.Value = sValue;
                    }
                    else
                    {
                        //config.AppSettings.Settings.Add("YourKey", "NewValue");
                    }

                    // Save the changes
                    config.Save(ConfigurationSaveMode.Modified);

                    // Refresh the appSettings section to reflect changes
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception e)
                {
                    ShowPopup($"Error While updating the Web.Config with Path {physicalPath}", false);
                }
            }

            #endregion

            #region Pioneer0G0 Publish file
            if (id == 3 || id == 5)
            {
                physicalPath = "c:\\inetpub\\wwwroot\\Pioneer0G0\\Web.config";
                try
                {
                    ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = physicalPath
                    };

                    // Open the configuration file
                    Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

                    KeyValueConfigurationElement setting = config.AppSettings.Settings["Password"];
                    if (setting != null)
                    {
                        setting.Value = sValue;
                    }
                    else
                    {
                        //config.AppSettings.Settings.Add("YourKey", "NewValue");
                    }

                    // Save the changes
                    config.Save(ConfigurationSaveMode.Modified);

                    // Refresh the appSettings section to reflect changes
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception e)
                {
                    ShowPopup($"Error While updating the Web.Config with Path {physicalPath}", false);
                }
            }

            #endregion

            #region Pioneer0H0 Publish file
            if (id == 1 || id == 5)
            {
                physicalPath = "c:\\inetpub\\wwwroot\\Pioneer0H0\\Web.config";
                try
                {
                    ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = physicalPath
                    };

                    // Open the configuration file
                    Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

                    KeyValueConfigurationElement setting = config.AppSettings.Settings["Password"];
                    if (setting != null)
                    {
                        setting.Value = sValue;
                    }
                    else
                    {
                        //config.AppSettings.Settings.Add("YourKey", "NewValue");
                    }

                    // Save the changes
                    config.Save(ConfigurationSaveMode.Modified);

                    // Refresh the appSettings section to reflect changes
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception e)
                {
                    ShowPopup($"Error While updating the Web.Config with Path {physicalPath}", false);
                }
            }

            #endregion
            ShowPopup("All External Module CRM Passwords updated Successfully", true);

        }

        public string Encription(string plainText) //AES128Encrypt
        {
            byte[] iv = { (byte)0x8E, 0x12, 0x39, (byte)0x9C, 0x07, 0x72, 0x6F, 0x5A, (byte)0x8E, 0x12, 0x39, (byte)0x9C, 0x07, 0x72, 0x6F, 0x5A };

            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = GetSecretKeySpecFromHexString(KEY);
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, iv))
                {
                    byte[] encrypted = encryptor.TransformFinalBlock(Encoding.UTF8.GetBytes(plainText), 0, plainText.Length);
                    byte[] encryptedWithIV = CopyIVAndCipher(encrypted, iv);
                    string encryptedResult = Convert.ToBase64String(encryptedWithIV);
                    return encryptedResult;
                }
            }
        }
        private static byte[] GetSecretKeySpecFromHexString(string hexKey)
        {
            byte[] key = new byte[hexKey.Length / 2];
            for (int i = 0; i < hexKey.Length; i += 2)
            {
                key[i / 2] = Convert.ToByte(hexKey.Substring(i, 2), 16);
            }
            return key;
        }
        private static byte[] CopyIVAndCipher(byte[] cipherText, byte[] iv)
        {
            byte[] result = new byte[cipherText.Length + iv.Length];
            Array.Copy(iv, result, iv.Length);
            Array.Copy(cipherText, 0, result, iv.Length, cipherText.Length);
            return result;
        }

        public string Decrypt(string encryptedText)//AES128Decrypt
        {
            byte[] skeySpec = GetSecretKeySpecFromHexString(KEY);
            byte[] encryptedIVandTextAsBytes = Convert.FromBase64String(encryptedText);

            // First 16 bytes are always the IV
            byte[] iv = new byte[16];
            Array.Copy(encryptedIVandTextAsBytes, iv, 16);

            // The rest of the bytes are the ciphertext
            byte[] ciphertextByte = new byte[encryptedIVandTextAsBytes.Length - 16];
            Array.Copy(encryptedIVandTextAsBytes, 16, ciphertextByte, 0, ciphertextByte.Length);

            // Decrypt the message
            using (AesManaged aesAlg = new AesManaged())
            {
                //aesAlg.Key = skeySpec.GetEncoded();
                aesAlg.Key = skeySpec;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, iv))
                {
                    byte[] decryptedTextBytes = decryptor.TransformFinalBlock(ciphertextByte, 0, ciphertextByte.Length);
                    string decryptedResult = Encoding.UTF8.GetString(decryptedTextBytes);
                    return decryptedResult;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEncSQLPassword.Text = "";
            if (txtSQLPassword.Text.Trim() == "")
                return;
            txtEncSQLPassword.Text = Encription(txtSQLPassword.Text);
            updateSQLPwdWebConfig(txtEncSQLPassword.Text);
        }
        public void updateSQLPwdWebConfig(string EncSQLPassword)
        {
            string pathsValue = ConfigurationManager.AppSettings["WebConfigPaths"];
            if (string.IsNullOrEmpty(pathsValue))
            {
                Console.WriteLine("❌ No web.config paths found in app.config");
                ShowPopup("No web.config paths found in app.config", false);
                return;
            }

            List<string> configPaths = new List<string>(pathsValue.Split(';'));
            bool anyFailure = false;

            foreach (string rawPath in configPaths)
            {
                string physicalPath = rawPath.Trim();
                if (string.IsNullOrWhiteSpace(physicalPath))
                    continue;

                try
                {
                    if (!File.Exists(physicalPath))
                    {
                        Console.WriteLine($"❌ File not found: {physicalPath}");
                        anyFailure = true;
                        continue;
                    }

                    Console.WriteLine($"🔄 Updating: {physicalPath}");

                    // Backup
                    string backupPath = physicalPath + ".bak";
                    File.Copy(physicalPath, backupPath, true);

                    // Load XML
                    XmlDocument xml = new XmlDocument();
                    xml.Load(physicalPath);

                    // Select all connection strings starting with "ConStr"
                    XmlNodeList nodes = xml.SelectNodes("//connectionStrings/add[starts-with(@name,'ConStr')]");
                    if (nodes != null && nodes.Count > 0)
                    {
                        foreach (XmlNode node in nodes)
                        {
                            string connStr = node.Attributes["connectionString"].Value;

                            // **Manually replace or add Password**
                            var parts = connStr.Split(';');
                            bool passwordFound = false;
                            for (int i = 0; i < parts.Length; i++)
                            {
                                if (parts[i].TrimStart().StartsWith("Password=", StringComparison.OrdinalIgnoreCase))
                                {
                                    parts[i] = "Password=" + EncSQLPassword;
                                    passwordFound = true;
                                    break;
                                }
                            }

                            if (!passwordFound)
                                parts = Append(parts, "Password=" + EncSQLPassword);

                            node.Attributes["connectionString"].Value = string.Join(";", parts);
                        }

                        xml.Save(physicalPath);
                        Console.WriteLine($"✅ Password(s) updated successfully in {physicalPath}");
                    }
                    else
                    {
                        Console.WriteLine($"⚠️ No 'ConStr*' connection strings found in {physicalPath}");
                        anyFailure = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Error updating {physicalPath}: {ex.Message}");
                    anyFailure = true;
                }
            }

            if (anyFailure)
                ShowPopup("Password update completed with some errors. Check console for details.", false);
            else
                ShowPopup("All SQL Passwords updated successfully!", true);
        }

        // Helper to append a new part
        private string[] Append(string[] array, string value)
        {
            var list = new List<string>(array) { value };
            return list.ToArray();
        }

        public static void ShowPopup(string message, bool isSuccess)
        {
            MessageBoxIcon icon = isSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            string title = isSuccess ? "Success" : "Error";

            DialogResult result = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.OK,
                icon
            );

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
    public class Item
    {
        public int ID { get; set; }       // ValueMember
        public string Name { get; set; }  // DisplayMember
    }
}
