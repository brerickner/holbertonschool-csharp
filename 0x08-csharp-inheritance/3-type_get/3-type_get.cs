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
            TypeInfo theType = typeof(myObj).GetTypeInfo().DeclaredProperties;
            TypeInfo meths = typeof(myObj).GetTypeInfo().DeclaredMethods;
            
            IEnumerable<PropertyInfo> pList = theList.DeclaredProperties;
            IEnumerable<MethodInfo> mList = theList.DeclaredMethods;

            IEnumerable<theType> p = new List<theType>();
            IEnumerable<meths> m = new List<meths>();
            // Get the properties of 'myObj' class object.
            Console.WriteLine($"{myObj.GetType().Name} Properties:");
            // System.Console.WriteLine(theType);

            // System.Console.WriteLine(meths);
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

