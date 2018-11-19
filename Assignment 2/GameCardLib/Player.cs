using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-11-09
    /// </summary>
    public class Player : Hand
    {
        /// <summary>
        /// Delecering necessary variable
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Constructor that taks in a string and stores it in the instance variable name
        /// </summary>
        /// <param name="name"></param>
        public Player(string name)
        {
            Name = name;
        }
    }
}
