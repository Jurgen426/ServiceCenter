using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
using System.IO;

namespace ServiceCenter.DataStorage
{
    class XmlSerializer
    {
        public object Serialize<T>(T data)
        {
            using (var memory = new MemoryStream())
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                serializer.Serialize(memory, data);
                return memory.ToArray();
            }

        }

        public T Deserialize<T>(object data)
        {
            var array = (byte[])data;
            using (var memory = new MemoryStream(array, 0, array.Length))
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(memory);
            }
        }
    }
}
