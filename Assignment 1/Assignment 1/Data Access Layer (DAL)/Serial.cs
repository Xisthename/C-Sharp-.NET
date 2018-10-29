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
    /// 2018-10-29
    /// </summary>
    public class Serial
    {
        /// <summary>
        /// Tries to save a generic list into a file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <param name="list"></param>
        public static void BinarySerialization<T>(string fileName, List<T> list)
        {
            using (Stream stream = File.Open(fileName, FileMode.Create))
            {
                try
                {
                    var bformatter = new BinaryFormatter();
                    bformatter.Serialize(stream, list);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        /// <summary>
        /// Tries to open a file and return its data in a generic list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<T> BinaryDeSerialization<T>(string fileName)
        {
            using (Stream stream = File.Open(fileName, FileMode.Open))
            {
                try
                {
                    var bformatter = new BinaryFormatter();
                    return (List<T>) bformatter.Deserialize(stream);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                return null;
            }
        }

        /// <summary>
        /// Tries to save data into an XML file
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="stringArray"></param>
        public static void XMLSerialize<T>(string fileName, T type)
        {
            TextWriter writer = new StreamWriter(fileName);
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, type);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}
