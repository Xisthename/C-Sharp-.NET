using System;
using System.Collections.Generic;
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
    public class CommercialBuilding : Building
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        public CommercialType CommercialType { get; set; }
        public override string BuildingType { get; set; }

        /// <summary>
        /// Returns the building´s category
        /// </summary>
        /// <returns></returns>
        public override String GetBuildingCategory()
        {
            return BuildingCategory.Commercial.ToString();
        }
    }
}
