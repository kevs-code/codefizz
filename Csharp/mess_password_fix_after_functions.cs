using System;
using System.Text.RegularExpressions;
namespace PasswordChecker
{
  class Program
  {
    public void strength(string password, string pattern)  
    {  
      if (Regex.IsMatch(password, pattern)) {
        score += 1;
      } 
    } 
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "[A-Z]";
      string lowercase = "[a-z]";
      string digit = "[0-9]";
      string specialChars = @"[\W\S\D]";//dubious/[^\\w\\s]/
      //use @ with regex
      //string whiteSpace = [^ \t\r\n\f\v];[^\s]
      Console.WriteLine("Enter a password, to make it strong let's follow:\nis at least 8 characters long\nhas lowercase letters\nhas uppercase letters\nhas numerical digits\nhas symbols, like #, ?, !");
      string password = Console.ReadLine();
      int score = 0;   
      if (password.Length >= minLength) {
        score += 1;
      }

      Console.WriteLine(score);
      Program pr = new Program();
      pr.strength(password, uppercase);
      Console.WriteLine(score);
      //string pattern = uppercase;
      /*
      //return Regex.IsMatch(value, pattern);
      //Match m = Regex.Match(input, pattern);
      //Console.WriteLine("Found '{0}' at position {1}.", m.Value, m.Index);
      */
      /*
      if (Regex.IsMatch(password, pattern)) {
        score += 1;
      }
      pattern = lowercase;
      if (Regex.IsMatch(password, pattern)) {
        score += 1;
      }
      */
    }
  }
}

