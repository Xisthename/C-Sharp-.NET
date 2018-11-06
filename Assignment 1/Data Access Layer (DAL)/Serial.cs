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
        /// Tries to save data into a file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <param name="type"></param>
        public static void BinarySerialization<T>(string fileName, T type)
        {
            using (Stream stream = File.Open(fileName, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, type);
            }
        }

        /// <summary>
        /// Tries to open a file and return its data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static T BinaryDeSerialization<T>(string fileName)
        {
            using (Stream stream = File.Open(fileName, FileMode.Open))
            {
                var bformatter = new BinaryFormatter();
                return (T) bformatter.Deserialize(stream);
            }
        }


        /// <summary>
        /// Tries to save data into an XML file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <param name="type"></param>
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
