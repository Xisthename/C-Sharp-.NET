using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Access_Layer__DAL_
{
    public interface IGenerateID
    {
        String GenerateUniqueID();
        String CreateRandomID();
    }

    public class IDManager : IGenerateID
    {
        String stringID = "abcdefghijklmnopqrstuvwxyz1234567890"; // length = 36
        const int lengthOfID = 3; // 36^3 = 46656 different ID combinations
        public List<String> UniqueIDList = new List<string>();
        public Random random = new Random();

        public String GenerateUniqueID()
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

        private String RepetUntillUniqueID(String maybeUniqueID)
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

        public string CreateRandomID()
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
