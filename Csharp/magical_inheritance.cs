//Program.cs

using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
       Storm z = new Storm("wind", false, "Zul'rajas");        
       Console.WriteLine(z.Announce());
       Pupil mk = new Pupil("Mezil-kree");
       Storm cast = mk.CastWindStorm();
       //also works
       //Console.WriteLine(mk.CastWindStorm().Announce());
       Console.WriteLine(cast.Announce());
       Mage g = new Mage("Gul'dan");
       Storm cast2 = g.CastRainStorm();
       Console.WriteLine(cast2.Announce());
       Archmage na = new Archmage("Nielas Aran");
       Storm cast3 = na.CastRainStorm();
       Storm cast4 = na.CastLightningStorm();
       Console.WriteLine(cast3.Announce());
       Console.WriteLine(cast4.Announce());
    }
  }
}

//Storm.cs

// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm
  {
    protected string strength;
    public string Essence
    { get; private set; }

    public bool IsStrong
    { get; private set; }

    public string Caster
    { get; private set; }

    public Storm(string essence, bool isStrong, string caster)
    {
      this.Essence = essence;
      this.Caster = caster;
      if (isStrong) {
        this.strength = "strong";
      } else {
        this.strength = "weak";
      }
    }

    public string Announce()
    {
      return $"{Caster} cast a {strength} {Essence} storm!";
    }

  }
}

//Pupil.cs

// Pupil.cs
using System;

namespace MagicalInheritance
{
  class Pupil
  {
    public string Title
    { get; set; }

    public Pupil(string title)
    {
      this.Title = title;
    }

    public Storm CastWindStorm()
    {
      Storm spell = new Storm("wind", false, this.Title);
      return spell;
    }
  }
}

//Mage.cs

// Mage.cs
using System;

namespace MagicalInheritance
{
  class Mage : Pupil
  {
    public Mage(string title) : base(title)
    {      
    }

    public virtual Storm CastRainStorm()
    {
      Storm spell = new Storm("rain", false, this.Title);
      return spell;
    }
    
  }
}

//Archmage.cs

// Archmage.cs
using System;

namespace MagicalInheritance
{
 class Archmage : Mage
 {
   public Archmage(string title) : base(title)
    {            
    }

    public override Storm CastRainStorm()
    {
      Storm spell = new Storm("rain", true, this.Title);
      return spell;
    }

    public Storm CastLightningStorm()
    {
      Storm spell = new Storm("lightning", true, this.Title);
      return spell;
    }

 }
}
/*
Zul'rajas cast a weak wind storm!
Mezil-kree cast a weak wind storm!
Gul'dan cast a weak rain storm!
Nielas Aran cast a strong rain storm!
Nielas Aran cast a strong lightning storm!
*/

/*

ierarchy: Archmage inherits from Mage, which inherits from Pupil. Each class has at least one method that uses the fourth class, Storm.

If you’d like more practice, try these optional challenges:

In Program.cs, store the Storm objects in an array instead of separate variables.
Add a string Origin property and a new constructor to the Pupil class. The constructor should have two parameters, one for Title and one for Origin. Add a similar constructor to Mage and Archmage. In other words, you should be able to run this code in Program.cs:
Pupil p = new Pupil("Mezil-kree", "Icecrown");
Mage m = new Mage("Gul'dan", "Draenor");
Archmage a = new Archmage("Nielas Aran", "Stormwind");
3. Define an abstract class Spell with Essence, IsStrong, and Caster properties and an abstract Announce() method. Make Storm inherit from Spell. A Spell.cs file is included in the workspace — find it by clicking the folder icon at the top of the text editor.
*/
