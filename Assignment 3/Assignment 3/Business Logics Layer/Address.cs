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
    public abstract class Address
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }

        /// <summary>
        /// Returns the country to a string and adds spaces were it is necessary
        /// </summary>
        /// <returns></returns>
        public string GetCountry()
        {
            return Country.ToString().Replace("_", " ");
        }
    }
}
