using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Business_Logics_Layer
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-09
    /// </summary>
    [Serializable]
    [XmlInclude(typeof(ResidentialBuilding))]
    [XmlInclude(typeof(CommercialBuilding))]
    [XmlInclude(typeof(Bitmap))]
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
