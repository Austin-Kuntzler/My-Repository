// Austin Kuntzler
//10/8/2019
//Reads the first number of each population total per city and then checks the frequency of that number  

using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) 
  {
    StreamReader population;
    string line;
    int num;
    double total;
    double [] array= new double[9]; //Creates a new array to be used for the numbers 1-9
    total=0;
    population = new StreamReader("population.txt"); //Begins reading from the population text file
    while(population.EndOfStream==false)
    {
      // This loop will add one to a number's corresponding spot in the array for use in the calculation later
      line = population.ReadLine();
      line = line.Substring(0,1);
      num = Convert.ToInt32(line);
      array[(num-1)]++;
      total=total+1;
    }
    Console.WriteLine("The total number of cities is "+total".");
    for(int i=0;i<9;i++)
    {
      //This loop will calculate the frequency of each number and display it for the user.
      Console.WriteLine((i+1)+" appears "+(array[i]/total*100)+"% of the time.");
    } 
  }
}
