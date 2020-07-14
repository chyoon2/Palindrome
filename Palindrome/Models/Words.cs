using System;
using System.Collections.Generic;


namespace Palindrome
{
  public class Words
  {
    public bool IsPalindrome(string word)
      {
        char[] letters = word.ToCharArray();
        Array.Reverse(letters);
        string reversedWord = new string(letters);
        if (reversedWord == word)
        {
          return true;
        }
        else 
        {
          return false;
        }
      }
  }
}


  // public bool IsPalindrome(string word)
  // {
  //  char[] wordArray = word.ToCharArray();
  //  Array.Reverse(wordArray);
  //  string reversedWord = String.Join("", wordArray);
  //  if (reversedWord == wordInput)
  // {
  //  return true;
  //  }
  // else
  // {
  //  return false;  
  //  }
  // }