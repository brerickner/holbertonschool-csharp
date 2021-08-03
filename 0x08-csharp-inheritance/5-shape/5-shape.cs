using System;


    class Shape
    {
        /// <summary>
        /// Throw an exception for Not Implemented Exception
        /// </summary>
        /// <returns></returns>
        public virtual int Area()
        {
            throw new NotImplementedException("Area() is not implemented");
        }
    }

