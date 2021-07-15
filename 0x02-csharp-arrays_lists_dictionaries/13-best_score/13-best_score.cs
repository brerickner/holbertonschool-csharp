using System;
using System.Collections.Generic;
class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string freshKey = "None";
        int highScore = 0;
        if (myList.Count == 0 || myList == null)
            return ("None");
        foreach (KeyValuePair<string, int> newScore in myList)
        {
            if (newScore.Value >= highScore)
            {
                freshKey = newScore.Key;
                highScore = newScore.Value;
            }
        }
        return (freshKey);
    }
}
