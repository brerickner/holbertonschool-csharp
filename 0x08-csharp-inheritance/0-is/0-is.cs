using System;

    class Obj
    {
        /// <summary>
        /// Check if object is an int
        /// </summary>
        /// <param name="obj">the object</param>
        /// <returns>True if the object is an int, otherwise return False</returns>
        public static bool IsOfTypeInt(object obj)
        {
            return obj.GetType() == typeof(int);
        }
    }

