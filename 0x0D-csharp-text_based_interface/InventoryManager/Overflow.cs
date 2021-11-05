using System;
using InventoryLibrary;
using System.Collections.Generic;

    /// <summary>
    /// Public class Overflow.
    /// </summary>
    public class Overflow
    {
        List<string> commands = new List<string>(){"ClassNames", "All", "Create", "Show", "Update","Delete", "Exit"};

        /// <summary>
        /// Public method GetAll.
        /// </summary>
        /// <param name="vault"></param>
        public void GetAll(JSONStorage vault)
        {
            System.Console.WriteLine("Come back later for more commands!");
        }
        /// <summary>
        /// Public method ClassNames.
        /// </summary>
        public void ClassNames(JSONStorage vault)
        {
            Console.WriteLine("ClassNames: ");
            foreach (KeyValuePair<string, object> s in vault.objects)
            {
                Console.WriteLine(s);
            }
        }
    }