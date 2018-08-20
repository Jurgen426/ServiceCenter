using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ServiceCenter.DataStorage
{
    class FileStorage
    {
        private XmlSerializer serializer;
        private string filePath;

        public FileStorage()
        {
            serializer = new XmlSerializer();
            filePath = ".";
        }
        public FileStorage(string filePath)
        {
            serializer = new XmlSerializer();
            this.filePath = filePath;
        }

        public T LoadData<T>(string key)
        { 
                var data = File.ReadAllBytes(Path.Combine(filePath, key));
                return serializer.Deserialize<T>(data);
        }

        public void SaveData<T>(string key, T data)
        {
            byte[] array = (byte[])serializer.Serialize(data);
            File.WriteAllBytes(Path.Combine(filePath, key), array);
        }

        public bool ChekExistingFile(string fileName)
        {
            string curFile = Path.Combine(filePath, fileName);
            if (File.Exists(curFile))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
