﻿using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;
        for (int i = 0; i < myLList.Count; i++)
        {
            count += 1;
        }
        return(count);
    }
}
