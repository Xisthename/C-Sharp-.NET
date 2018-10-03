using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Access_Layer__DAL_
{
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

        public bool EditAt(int index, T type)
        {
            if (!CheckIndex(index))
            {
                list[index] = type;
                return true;
            }
            return false;
        }

        public T GetAt(int id)
        {
            return list[id];
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

        public bool BinaryDeSerialization(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool BinarySerialization(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool XMLSerialize(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
