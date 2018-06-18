using System;
using System.Collections.Generic;
using System.Text;
using Lab08LINQinManhatten.Classes;

namespace Lab08LINQinManhatten.Classes
{
    /// <summary>
    /// This is the features that holds a specific neighborhood
    /// </summary>
    public class Features
    {
        /// <summary>
        /// This is a type that comes with the data.json file
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// This holds the coordinates of the neighborhood
        /// </summary>
        public Geometry Geometry { get; set; }

        /// <summary>
        /// This holds other properties of the neighborhood like the name and its zip code.
        /// </summary>
        public Properties Properties { get; set; }
    }
}
