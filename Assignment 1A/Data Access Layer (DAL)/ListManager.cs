using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Data_Access_Layer__DAL_
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
            return list.ConvertAll(c => c.ToString());
        }

        /// <summary>
        /// Tries to save the list of buildings into a file
        /// Returns the result of the method´s action with a boolean
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool BinarySerialization(string fileName)
        {
            using (Stream stream = File.Open(fileName, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();

                bformatter.Serialize(stream, list);
                return true;
            }
        }

        /// <summary>
        /// Tries to open a file and get all the buildings into the list
        /// Returns the result of the method´s action with a boolean
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool BinaryDeSerialization(string fileName)
        {
            using (Stream stream = File.Open(fileName, FileMode.Open))
            {
                var bformatter = new BinaryFormatter();
                list = (List<T>) bformatter.Deserialize(stream);
                return true;
            }
        }

        /// <summary>
        /// Tries to save the buildings data into an XML file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool XMLSerialize(string fileName)
        {
            bool bok = true;

            TextWriter writer = new StreamWriter(fileName);
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(String[]));
                serializer.Serialize(writer, ToStringArray());
            }
            catch
            {
                bok = false;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
            return bok;
        }
    }
}
