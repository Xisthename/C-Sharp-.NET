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
    public abstract class Address
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        public Countries Country { get; set; }
        public String City { get; set; }
        public String Street { get; set; }
        public String ZipCode { get; set; }

        /// <summary>
        /// Returns the country to a string and fixes spaces
        /// </summary>
        /// <returns></returns>
        public String GetCountry()
        {
            return Country.ToString().Replace("_", " ");
        }
    }
}
