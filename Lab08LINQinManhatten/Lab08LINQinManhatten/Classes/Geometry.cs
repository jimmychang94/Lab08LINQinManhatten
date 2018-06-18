using System;
using System.Collections.Generic;
using System.Text;
using Lab08LINQinManhatten.Classes;

namespace Lab08LINQinManhatten.Classes
{
    /// <summary>
    /// This class holds the information for each neighborhood's Geometry object.
    /// </summary>
    public class Geometry
    {
        /// <summary>
        /// This is the type that was written into the data.json
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// This is the coordinates of the point marked in the data.json marked.
        /// </summary>
        public double[] Coordinates { get; set; }
    }
}
