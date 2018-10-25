using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Data_Access_Layer__DAL_
{
    [Serializable]
    public class ListManager<T> : IListManager<T>
    {
        private List<T> list = new List<T>();
        public int Count { get => list.Count; }

        public bool Add(T type)
        {
            try
            {
                list.Add(type);
                return true;
            }
            catch { }
            return false;
        }

        public bool CheckIndex(int index)
        {
            return list[index].Equals(null);
        }

        public void DeleteAll()
        {
            list.Clear();
        }

        public bool DeleteAt(int index)
        {
            if (!CheckIndex(index))
            {
                list.RemoveAt(index);
                return true;
            }
            return false;
        }

        public bool InsertAt(int index, T type)
        {
            try
            {
                list.Insert(index, type);
                return true;
            }
            catch { }
            return false;
        }

        public bool EditAt(int index, T type)
        {
            if (!CheckIndex(index))
            {
                list[index] = type;
                return true;
            }
            return false;
        }

        public T GetAt(int index)
        {
            return list[index];
        }

        public string[] ToStringArray()
        {
            String[] stringArray = new string[Count];

            for (int i = 0; i < Count; i++)
            {
                stringArray[i] = GetAt(i).ToString();
            }
            return stringArray;
        }

        public List<string> ToStringList()
        {
            List<String> list = new List<string>();
            list.AddRange(ToStringArray());
            return list;
        }



        public bool BinarySerialization(string fileName)
        {
            using (Stream stream = File.Open(fileName, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();

                bformatter.Serialize(stream, list);
                return true;
            }
        }

        public bool BinaryDeSerialization(string fileName)
        {
            using (Stream stream = File.Open(fileName, FileMode.Open))
            {
                var bformatter = new BinaryFormatter();
                list = (List<T>) bformatter.Deserialize(stream);
                return true;
            }
        }

        public bool XMLSerialize(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
