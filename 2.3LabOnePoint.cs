// Austin Kuntzler 
// 10/24/19
//Takes a radius from the user and outputs the area of the circle

using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Please enter the radius of your circle");
    double r=Convert.ToDouble(Console.ReadLine()); //takes input
    Console.WriteLine("The area is "+area(r)); //calls area function.
  }
  static double area(double r) //defining the function that will calculate the area of a circle using the formula.
  {
    double pi = 3.14;
    double area = pi*r*r; //Formula for a circle
    return area;

  }
}
