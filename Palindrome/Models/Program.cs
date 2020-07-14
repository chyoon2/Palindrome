using System;
using System.Collections.Generic;


namespace Palindrome
{
public class Program
  {
  public static void Main()
    {
      Words wordy = new Words();
      Console.WriteLine("enter a word");
      string word = Console.ReadLine();
      Console.WriteLine(wordy.IsPalindrome(word));
      
    }
  } 
}