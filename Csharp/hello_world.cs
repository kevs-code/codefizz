using System;

namespace HelloWorld
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello Monkey!");    
     }
  }
}
 
//user input run program file.cs with dotnet run

using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}

//comments same as java

using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      // asks age and returns age in sentence
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}

//csharp promotional

/*
HELLO WORLD
C# in the Wild
You’ve seen some examples of C# code in action, but learning a programming language is more than just memorizing commands: it’s understanding how it differs from other technologies, joining its community, and applying it to real-life problems. Here’s what you need to know:

C# technologies are fast: A software company called Raygun built their application using Node.js, a framework for JavaScript. When their app started to slow down, they switched to .NET, a framework for C#. Their performance skyrocketed. As CEO John Daniel puts it, “using the same size server, we were able to go from 1,000 requests per second…with Node.js, to 20,000 requests per second with .NET Core.” In other words, they increased throughput by 2,000%.

The C# community is big: In 2019, Github ranked C# as the fifth most popular programming language and StackOverflow ranked it seventh.

C# is employable: Thanks to good design and the popularity of frameworks supporting the language, C# can get you access to a lot of great jobs. Search on any job site and you’ll find companies looking for C# and .NET developers to build chat applications, financial trading programs, medical record systems, and beyond. In the 2019 HackerRank Developer Skills Report, expertise in two C#-compatible frameworks, ASP.NET and .NET Core, were among the top ten most sought-after by managers.

*/
/*
review

Review
Congrats! You finished your first lesson in C#. In this lesson you learned:

C# is used to make interactive websites, mobile apps, video games, augmented and virtual reality (AR and VR), back-end services, and desktop applications
.NET generally refers to the family of programs and commands that let you make applications with C#
C# and .NET jobs are out there! Build video games with Unity, build websites with ASP.NET…The skills you learn on Codecademy can open new doors
The command Console.WriteLine() prints text to the console
The command Console.ReadLine() captures user input in the console
Comments are lines of code that are ignored by your computer; they’re intended to be read by developers instead. Make them with // or /* and */

//.NET apps can be written in c#


