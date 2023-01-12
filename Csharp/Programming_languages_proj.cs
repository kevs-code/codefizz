//Program.cs

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();
      foreach (var language in languages)
      {
        //Console.WriteLine(language.Prettify());
      }
      var see = languages.Select(x => $"Year :{x.Year}\nName: {x.Name}\nChief Developer: {x.ChiefDeveloper}\n");
      foreach (var x in see)
      {
        //Console.WriteLine(x);
      }

      var seeC = languages.Where(x => x.Name == "C#");
      foreach (var language in seeC)
      {
        //Console.WriteLine(language.Prettify());
      }
      var seeMS = languages.Where(x => x.ChiefDeveloper.Contains("Microsoft"));
      foreach (var language in seeMS)
      {
        //Console.WriteLine(language.Prettify());
      }

      var seeLisp = languages.Where(x => x.Predecessors.Contains("Lisp"));
      //Console.WriteLine(seeLisp.Count());
      var seeLang = languages.Where(x => x.Name.Contains("Script")).Select(x => x.Name);
      
      foreach (var name in seeLang)
      {
        //Console.WriteLine(name);
      }

      //Console.WriteLine(languages.Count()); //119 

      var near2KYears = languages.Where(x => x.Year > 1994 && x.Year < 2006);

      foreach (var year in near2KYears)
      {
        //Console.WriteLine(year.Prettify());
      }

      //Console.WriteLine(near2KYears.Count()); //66
      
      var way = near2KYears.Select(x => $"{x.Name} was invented in {x.Year}");
      
      foreach (var phrase in way)
      {
        //Console.WriteLine(phrase);
      }
      
      //Better than DRY foreach loops added following methods
      
      //prints all from IEnumerable<Language>
      //PrettyPrintAll(languages);

      //prints all query results from IEnumerable<Object>
      PrintAll(way);
    }
    
    public static void PrettyPrintAll(IEnumerable<Language> langs)
    {
      foreach(var i in langs)
      {
        Console.WriteLine(i.Prettify());
      }
    }

    public static void PrintAll(IEnumerable<Object> queries)
    {
      foreach(var i in queries)
      {
        Console.WriteLine(i);
      }
    }

  }
}

//Languages.cs

using System;

namespace ProgrammingLanguages
{
  public class Language
  {
    public static Language FromTsv(string tsvLine)
    {
      string[] values = tsvLine.Split('\t');
      Language lang = new Language(
        Convert.ToInt32(values[0]),
        Convert.ToString(values[1]),
        Convert.ToString(values[2]),
        Convert.ToString(values[3]));
      return lang;
    }

    public int Year
    { get; set; }

    public string Name
    { get; set; }

    public string ChiefDeveloper
    { get; set; }

    public string Predecessors
    { get; set; }

    public Language(int year, string name, string chiefDeveloper, string predecessors)
    {
      Year = year;
      Name = name;
      ChiefDeveloper = chiefDeveloper;
      Predecessors = predecessors;
    }

    public string Prettify()
    {
      return $"{Year}, {Name}, {ChiefDeveloper}, {Predecessors}";
    }    
  }
}
