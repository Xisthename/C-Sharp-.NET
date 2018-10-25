using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Access_Layer__DAL_
{
    /// <summary>
    /// TODO
    /// Fixa skiten varför den inte ger ett id på 3 stycken ibland
    /// </summary>
    public class IDManager
    {
        private static String stringID = "abcdefghijklmnopqrstuvwxyz1234567890"; // length = 36
        private const int lengthOfID = 3; // 36^3 = 46656 different ID combinations
        private static List<String> UniqueIDList = new List<string>();
        private static Random random = new Random();

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

        private static String RepetUntillUniqueID(String maybeUniqueID)
        {
            for (int i = 0; i < UniqueIDList.Count; i++)
            {
                //MessageBox.Show(maybeUniqueID + " : " + UniqueIDList[i]);

                if (maybeUniqueID.Equals(UniqueIDList[i]))
                {
                    //MessageBox.Show("trying again");
                    return null;
                }
            }
            return maybeUniqueID;
        }

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
