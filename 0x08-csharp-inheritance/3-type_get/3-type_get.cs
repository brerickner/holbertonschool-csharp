using System;
using System.Reflection;
using System.Collections.Generic;




    class Obj
    {
        /// <summary>
        /// Prints the names of the available properties and methods of an object
        /// </summary>
        /// <param name="myObj">the object</param>
        public static void Print(object myObj)
        {
            TypeInfo theType = typeof(object).GetTypeInfo();
            // TypeInfo meths = typeof(myObj).GetTypeInfo().DeclaredMethods;
            
            IEnumerable<PropertyInfo> pList = theType.DeclaredProperties;
            IEnumerable<MethodInfo> mList = theType.DeclaredMethods;

            // IEnumerable<theType> p = new List<theType>();
            // IEnumerable<meths> m = new List<meths>();
            // Get the properties of 'myObj' class object.
            Console.WriteLine($"{myObj.GetType().Name} Properties:");
            Console.WriteLine($"{myObj.GetType().Name} Methods:");

            // foreach ()
            // {
                    // Console.WriteLine(myPropertyInfo[i].Name);
            // }
            // Console.WriteLine($"{myObj.GetType().Name} Methods:");
            // for (int i = 0; i < myPropertyInfo.Length; i++)
            // {
            //     // Console.WriteLine(myPropertyInfo[i].Name);
            // }

        }

    }

