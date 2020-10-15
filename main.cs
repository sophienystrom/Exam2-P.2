using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    
  Console.WriteLine("Give the length of side 1");
  double S1 = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Give the length of side 2");
  double S2 = Convert.ToDouble(Console.ReadLine());

  double hypotnuse = DetermineHypotnuse (S1, S2);

  Console.WriteLine("The length of the hypotnuse is: " + hypotnuse);

  }

  public static double DetermineHypotnuse(double S1, double S2){
  double hypotnuse = Math.Sqrt((S1 * S1) + (S2 * S2));
  return hypotnuse; 
  }
}