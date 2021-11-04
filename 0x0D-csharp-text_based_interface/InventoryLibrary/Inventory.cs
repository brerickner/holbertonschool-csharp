using System;
using System.Collections.Generic;
using System.Reflection;


namespace InventoryLibrary
{
    /// <summary>
    /// Public class {Inventory} inherits from BaseClass.
    /// Defines:
    ///    - Public property {user_id} from {User} id. Required.
    ///    - Public property {item_id} from {Item} id. Required.
    ///    - Public property [quantity}. Required.
    /// </summary>
    public class Inventory : BaseClass
    {
        /// <summary>
        /// Public property {user_id} from {User} id. Required.
        /// </summary>
        public string user_id { get; set; }

        /// <summary>
        /// Public property {item_id} from {Item} id. Required.
        /// </summary>
        public string item_id { get; set; }

        /// <summary>
        /// Public property {quantity}. Required.
        /// </summary>
        public int quantity { get; set; }

        /// <summary>
        /// Public constructor {Inventory} with all Inventory properties as parameters.
        /// </summary>
        /// <param name="user_id">Type string. {User} id. Required.</param>
        /// <param name="item_id">Type string. {Item} id. Required.</param>
        /// <param name="quantity">Type int. Defaults to 1. Cannot be less than zero. Required.</param>
        public Inventory(string user_id, string item_id, int quantity = 1)
        {
            this.user_id = user_id;
            this.item_id = item_id;
            if (quantity < 0)
            {
                this.quantity = 1;
                throw new ArgumentException("Quantity cannot be negative. Quantity set to 1 by default.");
            }
            else
            {
                this.quantity = quantity;
            }
        }
    }
}