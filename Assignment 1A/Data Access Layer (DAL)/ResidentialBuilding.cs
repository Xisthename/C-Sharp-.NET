using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer__DAL_
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-09
    /// </summary>
    public class ResidentialBuilding : Building
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        public ResidentialType ResidentialType { get; set; }
        public override string BuildingType { get; set; }

        /// <summary>
        /// Returns the building´s category
        /// </summary>
        /// <returns></returns>
        public override String GetBuildingCategory()
        {
            return BuildingCategory.Residential.ToString();
        }
    }
}
