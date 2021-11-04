using System;
using System.Collections.Generic;
using System.Reflection;


namespace InventoryLibrary
{
    /// <summary>
    /// Public class {User} inherits from BaseClass..
    /// Defines:
    ///    - Public propert {name} string. Required.
    /// </summary>
    public class User : BaseClass
    {
        /// <summary> Public {name} string. Required. </summary>
        public string name { get; set; }
        
      
        /// <summary>
        /// Constructor {User} with all User properties as parameters.
        /// </summary>
        /// <param name="name">string required</param>

        public User(string name)
        {
            this.name = name;
        }
    }
}
