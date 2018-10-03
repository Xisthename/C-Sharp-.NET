using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer__DAL_
{
    interface IListManager<T>
    {
        int Count { get; }

        bool Add(T type);
        bool EditAt(int id, T type);
        bool CheckIndex(int id);
        void DeleteAll();
        bool DeleteAt(int id);
        T GetAt(int id);
        String[] ToStringArray();
        List<String> ToStringList();
        bool BinarySerialization(String fileName);
        bool BinaryDeSerialization(String fileName);
        bool XMLSerialize(String fileName);
    }
}
