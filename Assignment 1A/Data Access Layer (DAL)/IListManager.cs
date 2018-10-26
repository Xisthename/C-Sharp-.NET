using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer__DAL_
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-10-14
    /// </summary>

    /// <summary>
    /// Delecering a general interface with variables and methods
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IListManager<T>
    {
        int Count { get; }

        bool Add(T type);
        bool InsertAt(int index, T type);
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
