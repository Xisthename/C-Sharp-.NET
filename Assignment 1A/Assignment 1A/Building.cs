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
    abstract class Building : ICloneable
    {
        public int Id { get; set; }
        public Address Address { get; set; }
        public LegalType LegalType { get; set; }
        public abstract String GetBuildingCategory();
        public abstract String BuildingType { get; set; }

        /// <summary>
        /// Constructor that takes in parameters to declare instance variables
        /// </summary>
        /// <param name="id"></param>
        /// <param name="address"></param>
        /// <param name=""></param>
        /// <param name="legalType"></param>
        public Building(int id, Address address, LegalType legalType)
        {
            this.Id = id;
            this.Address = address;
            this.LegalType = legalType;
        }

        public Building()
        {
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
