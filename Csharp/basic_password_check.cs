using System;
using System.Text.RegularExpressions;
namespace PasswordChecker
{
  class Program
  {
    /*
      revise and add function to replace DRY below ...
      //return Regex.IsMatch(value, pattern);
      //Match m = Regex.Match(input, pattern);
      //Console.WriteLine("Found '{0}' at position {1}.", m.Value, m.Index);
    */
    public static void Main(string[] args)
    {
      int minLength = 8;
      //use @ with regex for e.g., escape chars
      string uppercase = "[A-Z]";
      string lowercase = "[a-z]";
      string digit = "[0-9]";//these 3 work without @ dubious/[^\\w\\s]
      string specialChars = "[^A-Za-z0-9 ]";//see below ... too
      //string specialChars = @"[\W\S\D]";//why allows 0-9?
      //string whiteSpace = [^ \t\r\n\f\v];[^\s]
      //string specialChars = @"^[a-zA-Z0-9 ]*$";is opposite with anchors^$
      
      Console.WriteLine("Enter a password, to make it strong let's follow:\nis at least 8 characters long\nhas lowercase letters\nhas uppercase letters\nhas numerical digits\nhas symbols, like #, ?, !");
      string password = Console.ReadLine();
      int score = 0;   
      if (password.Length >= minLength) {
        score += 1;
      } 
      string pattern = uppercase;

      if (Regex.IsMatch(password, pattern)) {
        score += 1;
      }
      pattern = lowercase;
      if (Regex.IsMatch(password, pattern)) {
        score += 1;
      }
      pattern = digit;
      if (Regex.IsMatch(password, pattern)) {
        score += 1;
      }
      pattern = specialChars;
      if (Regex.IsMatch(password, pattern)) {
        score += 1;
      }
      switch(score) {
        case 1:
          Console.WriteLine("password is weak");
          break;
        case 2:
          Console.WriteLine("password is medium");
          break;
        case 3:
          Console.WriteLine("password is strong");
          break;
        case 4:
          Console.WriteLine("password is extremely strong");
          break;//using fallthrough doesn't work or good practice
        case 5:
          Console.WriteLine("password is extremely strong");
          break;
        default:
          Console.WriteLine("try again!");
          break;
      }
      Console.WriteLine("score was : " + score);
    }
  }
}

