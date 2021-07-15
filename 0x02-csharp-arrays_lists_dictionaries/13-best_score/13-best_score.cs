using System;
using System.Collections.Generic;
class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string freshKey = "";
        int highScore = 0;
        foreach (KeyValuePair<string, int> newScore in myList)
        {
            if (newScore.Value > highScore)
            {
                highScore = newScore.Value;
                freshKey = newScore.Key;
            }
        }
        return (freshKey);
    }
}
