using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1A
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-09
    /// </summary>
    class CommercialBuilding : Building
    {
        public CommercialType CommercialType { get; set; }
        public override string BuildingType { get; set; }

        public override String GetBuildingCategory()
        {
            return BuildingCategory.Commercial.ToString();
        }
    }
}
