using System;


    class Obj
    {
        /// <summary>
        /// Checks if the object is an instance of a class that inherits from the
        /// specified class. The object must be a subclass and doesn't apply when
        /// object is an instance of the base class
        /// </summary>
        /// <param name="derivedType">The derived type</param>
        /// <param name="baseType">The base type</param>
        /// <returns>returns True if the object is an instance of a class that
        /// inherits from the specified class, otherwise return False</returns>
        public static bool IsOnlyASubclass(Type derivedType, Type baseType)
        {
            return derivedType.IsSubclassOf(baseType)
           && derivedType != baseType;
        }
    }


