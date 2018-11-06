using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Data_Access_Layer__DAL_;

namespace Business_Logics_Layer
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-10-14
    /// </summary>
    [Serializable]
    public class ListManager<T> : IListManager<T>
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        public List<T> list = new List<T>();
        public int Count { get => list.Count; }

        /// <summary>
        /// Adds an object to the list
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Checks if an object at a given index is nulll or not and returns this result as a boolean
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
            return list[index].Equals(null);
        }

        /// <summary>
        /// Removes all objects from the ist
        /// </summary>
        public void DeleteAll()
        {
            list.Clear();
        }

        /// <summary>
        /// Tries to remove an object at a given index
        /// Returns the result of the method´s action with a boolean
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteAt(int index)
        {
            if (!CheckIndex(index))
            {
                list.RemoveAt(index);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Tries to insert an object into the list at a given index
        /// Returns the result of the method´s action with a boolean
        /// </summary>
        /// <param name="index"></param>
        /// <param name="type"></param>
        /// <returns></returns>
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

        /// <summary>
        /// tries to edit an object at a given index
        /// Returns the result of the method´s action with a boolean
        /// </summary>
        /// <param name="index"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool EditAt(int index, T type)
        {
            if (!CheckIndex(index))
            {
                list[index] = type;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns an object at a given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetAt(int index)
        {
            return list[index];
        }

        /// <summary>
        /// Returns the buildings data into a string array 
        /// </summary>
        /// <returns></returns>
        public string[] ToStringArray()
        {
            return list.ConvertAll(c => c.ToString()).ToArray();
        }

        /// <summary>
        /// Returns the buildings data into a list of strings
        /// </summary>
        /// <returns></returns>
        public List<string> ToStringList()
        {
            try
            {
                return list.ConvertAll(c => c.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return null;
        }

        /// <summary>
        /// Tries to save a generic list into a file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public void BinarySerialization(string fileName)
        {
            Serial.BinarySerialization(fileName, list);
        }

        /// <summary>
        /// Tries to open a file and return its data in a generic list
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public void BinaryDeSerialization(string fileName)
        {
           list = Serial.BinaryDeSerialization<List<T>>(fileName);
        }

        /// <summary>
        /// Tries to save data into an XML file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public void XMLSerialize(string fileName)
        {
            Serial.XMLSerialize(fileName, list);
        }
    }
}
