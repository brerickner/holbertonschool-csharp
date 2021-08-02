using System;

    class Obj
    {
        /// <summary>
        /// Checks if object is an instance of class that inherited from Array
        /// </summary>
        /// <param name="obj">The object</param>
        /// <returns>True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False</returns>
        public static bool IsInstanceOfArray(object obj)
        {
            return obj.GetType() == typeof(Array) || obj is Array;
        }
    }

