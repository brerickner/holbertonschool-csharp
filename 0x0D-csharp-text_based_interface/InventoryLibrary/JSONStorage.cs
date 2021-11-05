using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
// using System.Text;
// using System.Text.Json;

namespace InventoryLibrary
{
    /// <summary>
    /// Public class {JSONStorage}.
    /// Defines:
    ///    - Public property {objects}. Dict with keys '{Class}.{id}' and values are the objects.
    ///    - Public method {All}. Returns objects dictionary.
    ///    - Public method {New(Obj)}. Adds new key-value pair to {objects}
    ///      Key: {obj ClassName}.{obj id}, Value: {obj}
    ///    - Public method {Save}. Serializes {objects} to JSON and saves JSON file
    ///      to location: 'storage/inventory_manager.json'.
    ///    - Public method {Load}. Deserializes JSON file to {objects}.
    /// </summary>
    public class JSONStorage
    {
        /// <summary>
        /// Public property {objects}. Dictionary - Key: string 'Classname.id' Value: objects.
        /// </summary>
        public Dictionary<string, object> objects = new Dictionary<string, object>();
 
        /// <summary>
        /// Public method {All}. Returns {objects} type dictionary.
        /// </summary>
        /// <returns>{objects} - Type dictionary. Key:ClassName.id Value: this.objects </returns>
        public Dictionary<string, object> All()
        {
            return this.objects;
        }

        /// <summary>
        /// Public method {New(Obj)}. Takes parameter {obj} of type BaseClass.
        /// Adds new key-value pair to {objects}. Key: 'obj.GetType().Name'+'obj.id', Value: {obj}.
        /// </summary>
        /// <param name="obj">Object to add to {objects}</param>
        public void New(BaseClass obj)
        {
            string key = obj.GetType().Name + obj.id;
            Dictionary<string, object> vault = this.objects;
            
            vault.Add(key, obj);
        }

        /// <summary>
        /// Public method {Save}. Serializes {objects} to JSON and saves JSON file
        /// to location: '../storage/inventory_manager.json'. If it doesn't exist, create it.
        /// </summary>
        public void Save()
        {
            Dictionary<string, object> vault = this.objects;
            string path = "../storage/inventory_manager.json";
            string JSON = JsonConvert.SerializeObject(vault);
            
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            File.WriteAllText(path, JSON);
        }
    }
}