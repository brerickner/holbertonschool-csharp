using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// Name space {InventoryLibrary}.
/// </summary>
namespace InventoryLibrary
{
    /// <summary>
    /// Public class {BaseClass} all classes will inherit from.
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// Property {id} of type {string}
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Property {date_created} of type {DateTime}
        /// </summary>
        public DateTime date_created { get; set; }

        /// <summary>
        /// Property {date_updated} of type {DateTime}
        /// </summary>
        public DateTime date_updated { get; set; }
    }
}
