﻿using System;
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
        public Countries Country { get; set; }
        public String City { get; set; }
        public String Street { get; set; }
        public String ZipCode { get; set; }

        /// <summary>
        /// Returns the country to a string and adds spaces were it is necessary
        /// </summary>
        /// <returns></returns>
        public String GetCountry()
        {
            return Country.ToString().Replace("_", " ");
        }
    }
}
