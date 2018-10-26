using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Access_Layer__DAL_
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-28
    /// </summary>
    public class IDManager
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        private static String stringID = "abcdefghijklmnopqrstuvwxyz1234567890"; // length = 36
        private const int lengthOfID = 3; // 36^3 = 46656 different kind of ID combinations
        private static List<String> UniqueIDList = new List<string>();
        private static Random random = new Random();

        /// <summary>
        /// Used to create an Unique ID that is returned
        /// </summary>
        /// <returns></returns>
        public static String GenerateUniqueID()
        {
            String newUniqueID;

            while (true)
            {
                newUniqueID = RepetUntillUniqueID(CreateRandomID());

                if (newUniqueID != null)
                {
                    break;
                }
            }
            UniqueIDList.Add(newUniqueID);
            return newUniqueID;
        }

        /// <summary>
        /// Takes in a random ID and checks if it is an Unique ID
        /// returns null if the random ID is not an Unique ID
        /// returns the random ID if it is in fact an Unique ID
        /// </summary>
        /// <param name="maybeUniqueID"></param>
        /// <returns></returns>
        private static String RepetUntillUniqueID(String maybeUniqueID)
        {
            for (int i = 0; i < UniqueIDList.Count; i++)
            {
                if (maybeUniqueID.Equals(UniqueIDList[i]))
                {
                    return null;
                }
            }
            return maybeUniqueID;
        }

        /// <summary>
        /// Creates a random ID
        /// </summary>
        /// <returns></returns>
        public static string CreateRandomID()
        {
            String randomID = "";

            for (int i = 0; i < lengthOfID; i++)
            {
                char n = stringID[random.Next(stringID.Length)];
                randomID += n;
            }
            return randomID;
        }
    }
}
