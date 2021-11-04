using System;
using System.Collections.Generic;
using System.Reflection;

namespace InventoryLibrary
{
    /// <summary>
    /// Public class {Item} inherits from BaseClass..
    /// Defines:
    ///    - Public {name} string. Required.
    ///    - Public {description} string. Optional.
    ///    - Public {price} float, limit 2 decimals. Optional.
    ///    - Public {tags} list of strings. Optional.
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary> Public {name} string. Required. </summary>
        public string name { get; set; }
        
        /// <summary>Public {description} string. Optional.</summary>
        public string description { get; set; }

        /// <summary>Public {price} float, limit 2 decimals. Optional.</summary>
        public float price { get; set; }

        /// <summary>Public {tags} list of strings. Optional.</summary>
        public List<string> tags { get; set; }

        /// <summary>
        /// Constructor {Item} with all Item properties as parameters.
        /// </summary>
        /// <param name="name">string required</param>
        /// <param name="description">string defaults to null</param>
        /// <param name="price">float defaults to 0.0f</param>
        /// <param name="tags">List of strings defaults to null</param>
        public Item(string name, string description = null, float price = 0.00f, List<string> tags = null)
        {
            this.name = name;
            this.description = description;
            Decimal decValue = (decimal)(Math.Round(price, 2));
            this.price = (float)Math.Round(price, 2);
            this.tags = tags;
        }
    }
}
