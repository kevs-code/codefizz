//Program.cs
using System;

namespace SavingInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      TodoList tdl = new TodoList();
      tdl.Add("Invite friends");
      tdl.Add("Buy decorations");
      tdl.Add("Party");
      tdl.Display();
      tdl.Reset();
      tdl.Display();
      PasswordManager pm = new PasswordManager("iluvpie", true);
      pm.Display();
      pm.Reset();
      pm.Display();

    }
  }
}

//Todo.cs

using System;

namespace SavingInterface
{
  class TodoList : IDisplayable, IResetable
  {
    public string[] Todos
    { get; private set; }

    private int nextOpenIndex;

    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

    public void Add(string todo)
    {
      Todos[nextOpenIndex] = todo;
      nextOpenIndex++;
    }

    public void Display()
    {
      foreach (string todo in Todos)
      {
        Console.WriteLine(todo);
      }
    }

    public void Reset()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

  }
}

//Password.cs

using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }

    public void Display()
    {
      if (Hidden == false)
      {
        Console.WriteLine(Password);
      } else {
        Console.WriteLine("*");
      }
    }

    public void Reset()
    {
      Password = "";
      Hidden = false;
    }

  }
}

//IDisplayable.cs

// Define IDisplayable in this file

using System;

namespace SavingInterface
{
  interface IDisplayable
  {
    void Display();
  }
}

//IResetable.cs

// Define IResetable in this file

using System;

namespace SavingInterface
{
  interface IResetable
  {
    void Reset();
  }
}

/*

13.
Well done! The Computron is a better computer thanks to your work. If you’d like extra practice, try these optional challenges:

Add a get-only property to IDisplayable called HeaderSymbol. This should be used in Display() as a header. For example, if the header symbol is -, then the apps should be displayed as:

Todos
--------
Eat
Sleep
Code

Password
-----------
***
If you add more than five to-dos to the TodoList, it throws an error! Extend the Add() method so that it doesn’t add any more than five items to the Todos array.

Currently a blank line is printed for each empty index in Todos. Change Display() in TodoList so that it prints [] instead of a blank line. You’ll need to use the static method String.IsNullOrEmpty().

Add a method ChangePassword() to PasswordManager. It should:

have two string parameters
if the first argument matches the existing Password, reset the Password to the second argument
return true if the password change was a success (the first argument matched the old password), and false otherwise
Extend the Password property in PasswordManager:

Change the set method so that it requires the password to be at least eight characters in length
*/

