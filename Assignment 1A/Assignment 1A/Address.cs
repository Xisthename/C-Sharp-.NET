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
    class Address
    {
        /// <summary>
        /// Delecering necessary instance variables
        /// </summary>
        Countries Country { get; set; }
        String City { get; set; }
        String Street { get; set; }
        int ZipCode { get; set; }

        /// <summary>
        /// Constructor that takes in parameters to declare instance variables
        /// </summary>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="zipCode"></param>
        public Address(Countries country, String city, String street, int zipCode)
        {
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.ZipCode = zipCode;
        }

        /// <summary>
        /// Returns all info about an address to a string
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return Country +  ", " + City + ", " + Street + ", " + ZipCode;
        }
    }
}
