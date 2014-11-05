using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClipboardRing
{
    public class ConfigMgr
    {
        private string workDir;

        private static ConfigMgr instance = new ConfigMgr();

        private SortedList<ConfigItems, String> itemMap;

        public ConfigMgr()
        {
            init();
        }

        private void init()
        {
            workDir = Application.StartupPath;
            if (!workDir.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                workDir = workDir + Path.DirectorySeparatorChar;
            }
            workDir =workDir + "Configures\\";
            if (!Directory.Exists(workDir))
            {
                Directory.CreateDirectory(workDir);
            }

            itemMap = new SortedList<ConfigItems, String>();
            itemMap.Add(ConfigItems.DataItems, @"dataitems.dat");
        }

        public static ConfigMgr GetInstance()
        {
            return instance;
        }

        public bool Save(ConfigItems item, Object val)
        {
            if (itemMap.ContainsKey(item))
            {
                string pathVal = itemMap[item];
                return saveAsFile(pathVal, val);
            }
            return false;
        }

        private bool saveAsFile(string pathVal, Object val)
        {
            try
            {
                string filePath = workDir + pathVal;
                using (Stream stream = File.Create(filePath))
                {

                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, val);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Object Read(ConfigItems item)
        {
            if (itemMap.ContainsKey(item))
            {
                string pathVal = itemMap[item];
                return readFromFile(pathVal);
            }
            return null;
        }

        private object readFromFile(string pathVal)
        {
            try
            {
                string filePath = workDir + pathVal;
                using (Stream stream = File.Open(filePath, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    return formatter.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }

    public enum ConfigItems
    { 
        DataItems
    }
}
