using System;
using System.Collections.Generic;

namespace LeetSpeak.Objects
{
  public class LeetSpeak
  {
    public string TurnToLeet (string phrase)
    {
      char[] phraseNowArray = phrase.ToCharArray();
      for (int i = 1; i <= phrase.Length; i = i+1)
      {
        string letterAtSpot = string.Join("", phraseNowArray[i-1]);

        string check1 = "e";
        string check2 = "o";
        string check3 = "I";
        string check4 = "s";
        string check5 = " ";
        if ( i > 2 && letterAtSpot == check4 )
        {
          string previousLetterAtSpot = string.Join("", phraseNowArray[i-2]);
          if (previousLetterAtSpot != check5 )
          {
            char vals = 'z';
            phraseNowArray[i-1] = vals;
          }
        }
        else if (letterAtSpot == check3)
        {
          char vals = '1';
          phraseNowArray[i-1] = vals;
        }
        else if (letterAtSpot == check1)
        {
          char vals = '3';
          phraseNowArray[i-1] = vals;
        }
        else if (letterAtSpot == check2)
        {
          char vals = '0';
          phraseNowArray[i-1] = vals;
        }
      }
      string result = string.Join("", phraseNowArray);
      return result;
    }
  }
}
