using System;
using System.Collections.Generic;
class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        if (list1 == null || list2 == null)
            return (null);

        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);

     // Creating a new HashSet that contains
        // the Intersection of both the HashSet mySet1 & mySet2
        HashSet<int> hashy = new HashSet<int>(set1);
        
        hashy.SymmetricExceptWith(set2);
        List<int> newList = new List<int>(hashy);
        newList.Sort();
        return (newList);
    }
}
