using System;
using System.Linq;
using InventoryLibrary;
using System.Collections.Generic;

namespace InventoryManager
{
    class Program
    {
        /// <summary>
        /// Console application.
        /// On start, loads all objects from path '../storage/inventory_managemer.json'.
        /// Prints an initial prompt of available commands and their usages.
        /// 
        /// Example command and usages:
        ///     Inventory Manager
        /// -------------------------
        /// {ClassNames} show all ClassNames of objects
        /// {All} show all objects
        /// {All [ClassName]} show all objects of a ClassName
        /// {Create [ClassName]} a new object
        /// {Show [ClassName object_id]} an object
        /// {Update [ClassName object_id]} an object
        /// {Delete [ClassName object_id]} an object
        /// {Exit}
        ///     
        /// </summary>
        static void Main()
        {
            JSONStorage vault = new JSONStorage();
           
            while (!false)
            {
                string prompt= "Enter commands now :) ";
                string usages = @"           Inventory Manager
                                    -------------------------
                            {ClassNames} show all ClassNames of objects
                            {All} show all objects
                            {All [ClassName]} show all objects of a ClassName
                            {Create [ClassName]} a new object
                            {Show [ClassName object_id]} an object
                            {Update [ClassName object_id]} an object
                            {Delete [ClassName object_id]} an object
                            {Exit}";
                Console.WriteLine(usages);
                Console.WriteLine("");
                Console.Write(prompt);
                string command = Console.ReadLine();
        
                string[] command_split = command.Split(' ');
                if (command_split.Length == 0)
                {
                    Console.WriteLine("Invalid command");
                    continue;
                }
                if (command_split[0] == "ClassNames")
                {
                    System.Console.WriteLine("ClassNames: ");
                }
                if (command_split[0] == "Exit")
                {
                    break;
                }
            }
        }
    }
}
