using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Utility
{
        /* 
       
        /// <summary>
        /// ini文件读写类
        /// </summary>
        public class IniUtil
        {
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

            [DllImport("kernel32")]
            private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retval, int size, string filePath);

            [DllImport("kernel32")]
            private static extern long GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);
            /// <summary>
            /// 读取 指定节下的键的值
            /// </summary>
            /// <param name="path"></param>
            /// <param name="section"></param>
            /// <param name="key"></param>
            /// <returns></returns>
            public static string ReadIniValue(string path, string section, string key)
            {
                StringBuilder sb = new StringBuilder(255);
                GetPrivateProfileString(section, key, "", sb, 255, path);
                return sb.ToString();
            }
            /// <summary>
            /// 读取指定节的所有键
            /// </summary>
            /// <param name="path"></param>
            /// <param name="section"></param>
            /// <param name="list"></param>
            public static void ReadSections(string path, string section, System.Collections.Specialized.StringDictionary keys)
            {
                Byte[] buffer = new Byte[16384];
                long bufLen = GetPrivateProfileString(section, null, null, buffer, buffer.GetUpperBound(0), path);
                //对Section进行解析 
                GetStringsFromBuffer(buffer, bufLen, keys);
            }
            /// <summary>
            /// 读取指定节下的所有键值对
            /// </summary>
            /// <param name="path"></param>
            /// <param name="section"></param>
            /// <param name="values"></param>
            public static void ReadSections(string path, string section, System.Collections.Specialized.NameValueCollection values)
            {
                System.Collections.Specialized.StringDictionary keys = new StringDictionary();
                //System.Collections.Specialized.StringCollection keys = new System.Collections.Specialized.StringCollection();
                ReadSections(path, section, keys);
                values.Clear();
                foreach (string key in keys)
                {
                    values.Add(key, ReadIniValue(path, section, key));
                }
            }
            private static void GetStringsFromBuffer(Byte[] buffer, long bufLen, System.Collections.Specialized.StringDictionary Strings)
            {
                Strings.Clear();
                if (bufLen != 0)
                {
                    int start = 0;
                    for (int i = 0; i < bufLen; i++)
                    {
                        if ((buffer[i] == 0) && ((i - start) > 0))
                        {
                            String s = Encoding.GetEncoding(0).GetString(buffer, start, i - start);
                            Strings.Add(s, "");
                            start = i + 1;
                        }
                    }
                }
            }
            /// <summary>
            /// 写指定节的键值
            /// </summary>
            /// <param name="path"></param>
            /// <param name="section"></param>
            /// <param name="key"></param>
            /// <param name="keyValue"></param>
            public static void WriteIniValue(string path, string section, string key, string keyValue)
            {
                WritePrivateProfileString(section, key, keyValue, path);
            }
        }

        */

        
        public class IniOperation
        {
            public Dictionary<string, string> configData;
            string fullFileName = "";

            public void Config(string _fileName)
            {
                configData=new Dictionary<string,string>();

                //fullFileName = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + _fileName;
                
                //fullFileName = "ResidentFlash\\Debug\\config.ini";

                fullFileName = "Application\\Debug\\config.ini";
                bool hasCfgFile = File.Exists(fullFileName);
                if (hasCfgFile == false)
                {
                    StreamWriter write = new StreamWriter(File.Create(fullFileName), Encoding.Default);
                    write.Close();
                }
                StreamReader reader = new StreamReader(fullFileName, Encoding.Default);
                string line;
                int idx=0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith(";") || string.IsNullOrEmpty(line))
                    {
                        configData.Add(";" + idx++, line);
                    }
                    else
                    {
                        string[] key_value = line.Split('=');
                        if (key_value.Length >= 2)
                        {
                            configData.Add(key_value[0], key_value[1]);
                        }
                        else
                            configData.Add(";" + idx++, line);
                    }
                }
                reader.Close();
            }

            public string get(string key)
            {
                if (configData.Count <= 0) 
                    return null;
                else if (configData.ContainsKey(key)) 
                    return configData[key].ToString();
                else return null;
            }

            public void set(string key, string value)
            {
                if (configData.ContainsKey(key)) configData[key] = value;
                else configData.Add(key, value);
            }

            public void save()
            {
                StreamWriter write = new StreamWriter(fullFileName, false, Encoding.Default);
                IDictionaryEnumerator enu = configData.GetEnumerator();
                while(enu.MoveNext())
                {
                    if (enu.Key.ToString().StartsWith(";"))
                        write.WriteLine(enu.Value);
                    else
                        write.WriteLine(enu.Key + "=" + enu.Value);
                }
                write.Close();
            }
        }
}
