using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Test Cases ...
      Console.WriteLine(areaOfRectangle(4, 5));
      Console.WriteLine(areaOfCircle(4));
      Console.WriteLine(areaOfTriangle(10, 9));
      double eastWing = areaOfCircle(375)/2;
      double westWing = areaOfTriangle(750, 500);
      double mainFloor = areaOfRectangle(2500, 1500);
      double totalArea = eastWing + westWing + mainFloor;
      double totalCost = totalArea * 180;
      Console.WriteLine($"Total base cost in pesos to refloor Teotihuacan is: {Math.Round(totalCost, 2)} at 180 pesos per square meter for {Math.Round(totalArea)} meters square.");
    }
    
    public static double areaOfRectangle(double length, double width)
    {
      return length * width;
    }

    public static double areaOfCircle(double radius)
    {
      return Math.PI * Math.Pow(radius, 2);
    }

    public static double areaOfTriangle(double bottom, double height)
    {
      return 0.5 * bottom * height; 
    }


  }
}

