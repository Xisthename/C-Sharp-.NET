using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1A
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-09
    /// </summary>
    abstract class Building : ICloneable
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        public int Id { get; set; }
        public Address Address { get; set; }
        public LegalType LegalType { get; set; }
        public Image Image { get; set; }
        public abstract String GetBuildingCategory();
        public abstract String BuildingType { get; set; }

        /// <summary>
        /// Constructor that creates a new empty Address object
        /// </summary>
        public Building()
        {
            Address = new Address();
        }

        /// <summary>
        /// Used to clone the obect
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
