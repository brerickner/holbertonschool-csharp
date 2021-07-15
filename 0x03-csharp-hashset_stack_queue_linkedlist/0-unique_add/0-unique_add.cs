using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> hashy = new HashSet<int>(myList);
        int sum = 0;
        
        foreach (int i in hashy)
            sum += i;  
        return (sum);
    }
}
