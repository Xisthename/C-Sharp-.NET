using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer__DAL_;

namespace Business_Logics_Layer
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-10
    /// </summary>
    public class BuildingManager : ListManager<Building>
    {
        private IDManager iDManager = new IDManager();

        public String GenerateID()
        {
            return iDManager.GenerateUniqueID();
        }

        public int GetIndexFromID(String id)
        {
            for (int i = 0; i < Count; i++)
            {
                if (GetAt(i).ID.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

        public Image GetImageAt(int index)
        {
            return GetAt(index).Image;
        }
    }
}