//Austin Kuntzler
//10/8/2019
//Reads a file full of population numbers adds up the total population and counts the amount of cities then outputs the numbers

using System;
using System.IO;

class MainClass {
  public static void Main (string[] args)

  {
    int total,num,city;
    total=0;
    StreamReader population;
    population = new StreamReader("population.txt"); //begins to read from the population text file
    city=0;

    while(population.EndOfStream==false) //this loop will read through each line of the text file and add up the numbers.
    {
      
      string lines=population.ReadLine(); 
      num=Convert.ToInt32(lines);
      total=total+num;
      city++;

    }
    Console.WriteLine("The total population is "+total+".");
    Console.WriteLine("There are "+city+" cities.");
    
  }
}
