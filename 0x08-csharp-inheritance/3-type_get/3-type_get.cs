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
            TypeInfo typeList = myObj.GetType().GetTypeInfo();
            // TypeInfo meths = typeof(myObj).GetTypeInfo().DeclaredMethods;
            
            IEnumerable<PropertyInfo> pList = typeList.GetProperties();
            IEnumerable<MethodInfo> mList = typeList.GetMethods();

            // IEnumerable<typeList> p = new List<typeList>();
            // IEnumerable<meths> m = new List<meths>();

            Console.WriteLine($"{myObj.GetType().Name} Properties:");
            foreach (PropertyInfo p in pList)
            {
                System.Console.WriteLine(p.Name);
            }
            Console.WriteLine($"{myObj.GetType().Name} Methods:");
            foreach (MethodInfo m in mList)
            {
                System.Console.WriteLine(m.Name);
            }

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

