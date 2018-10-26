using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer__DAL_
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-09
    /// </summary>
    [Serializable]
    public abstract class Building : Address
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        public String ID { get; set; }
        public LegalType LegalType { get; set; }
        public Image Image { get; set; }
        public abstract String GetBuildingCategory();
        public abstract String BuildingType { get; set; }

        /// <summary>
        /// Returns all the fields of the object to a string
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return ID + ", " + GetCountry() + ", " + City + ", " + Street + ", " + ZipCode + ", " + GetBuildingCategory() + ", " 
                + BuildingType + ", " + LegalType.ToString();
        }
    }
}
