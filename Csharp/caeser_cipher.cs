using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      Console.WriteLine("We need a secret message to encode...");
      string secretMsg = Console.ReadLine();
      secretMsg.ToLower();
      char[] msgArray = secretMsg.ToCharArray();
      char[] encryptedMsg = new char[secretMsg.Length];
      
      for (int i = 0; i < secretMsg.Length; i++) {
        char secretChar = secretMsg[i];
        int charIndex = (Array.IndexOf(alphabet, secretChar) + 3) % alphabet.Length;//modulo of Length prevent out of range overspill here for letters x y z
        char encryptedChar = alphabet[charIndex];
        encryptedMsg[i] = encryptedChar;
      }

      string cipherString = String.Join("", encryptedMsg);
      Console.WriteLine(cipherString);
    }
  }
}
