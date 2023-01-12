using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {"1 A.U. is roughly the distance from the earth to the sun?", "Does hair continue to grow normally after death?", "Homeopathy is the debunked belief that ridiculously diluted solutions can behave as cures.", "The grape cure is a genuine therapy?"};
      bool[] answers = {true, false, true, false};
      bool[] responses = new bool[questions.Length];
      if (answers.Length != responses.Length) {
        Console.WriteLine("WARNING answers incorrect length");
      }
      int askingIndex = 0;
      foreach(string question in questions)
      {
        string input;
        bool isBool;
        bool inputBool;
        Console.Write($"{questions[askingIndex]}\nTrue or false?\n");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);
        while (!isBool) {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }
        responses[askingIndex] = inputBool;
        askingIndex++;
      }
      int scoringIndex = 0;
      int score = 0;
      foreach (bool answer in answers)
      {
        bool response = responses[scoringIndex];
        Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");
        if (answer == response) {
          score++;
        }
        scoringIndex++;
      }
      Console.WriteLine($"You got {score} out of {answers.Length} correct!");

    }
  }
}

