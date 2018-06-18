using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab08LINQinManhatten.Classes
{
    /// <summary>
    /// This class holds the object that is parsed from the data.json file
    /// </summary>
    public class Manhatten
    {
        /// <summary>
        /// This is a list of all the neighborhoods
        /// </summary>
        public List<Features> Features { get; set; }
        /// <summary>
        /// This is a string of type that is parsed from the data.json file
        /// </summary>
        public string Type { get; set; }
    }
}
