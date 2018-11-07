using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public abstract class Building : Address
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        public string BuildingID { get; set; }
        public abstract string GetBuildingCategory();
        public abstract string BuildingType { get; set; }
        public string LegalType { get; set; }

        /// <summary>
        /// Returns all the fields of the object to a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return BuildingID + ", " + GetCountry() + ", " + City + ", " + Street + ", " + ZipCode + ", " + GetBuildingCategory() + ", " 
                + BuildingType + ", " + LegalType.ToString();
        }
    }
}
