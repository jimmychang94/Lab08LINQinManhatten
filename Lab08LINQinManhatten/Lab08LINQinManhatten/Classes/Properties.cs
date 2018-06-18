using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08LINQinManhatten.Classes
{
    /// <summary>
    /// This holds the properties of the neighborhoods in the data.json file
    /// </summary>
    public class Properties
    {
        /// <summary>
        /// This is the zip code of the neighborhood
        /// </summary>
        public int ZipCode { get; set; }

        /// <summary>
        /// This is the city that the neighborhood is in
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// This is the state that the neighborhood is in
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// This is the address of the neighborhood
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// This is the borough of hte neighborhood
        /// </summary>
        public string Borough { get; set; }

        /// <summary>
        /// This is the name of the neighborhood
        /// </summary>
        public string Neighborhood { get; set; }

        /// <summary>
        /// This is the county of the neighborhood
        /// </summary>
        public string County { get; set; }
    }
}
