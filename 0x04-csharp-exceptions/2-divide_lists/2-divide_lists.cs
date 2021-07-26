using System;
using System.Collections.Generic;
using System.Linq;


class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> results = new List<int>();
        int index = 0;
        for (; index < listLength; index++)
        {
            try
            {
                results.Add(list1[index] / list2[index]);
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("Cannot divide by zero");
                results.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                System.Console.WriteLine("Out of range");
            }
        }
    return (results);
    }
}
