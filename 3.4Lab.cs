//Austin Kuntzler
//9/26/2019
//Takes input on how many rabbits and foxes there are and then does calculations based off of given birth and death rates to determine a population for each year.
using System;

class MainClass {
  public static void Main (string[] args)
   {
    double deathR,deathF,birthR,birthF,popR,popF; //assigning variables
    int years;
    Console.WriteLine("Please enter the population of rabbits");
    popR=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please enter the population of foxes"); //gathering input
    popF=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please enter how many years you want to watch the populations of rabbits and foxes");
    years = Convert.ToInt32(Console.ReadLine());
    birthR = .2;
    deathR = popF*.005; //equations for birth and death rates
    birthF = popR*.001;
    deathF = .2;

    for(int i=years;i>0;i--)
    {
      popR = popR + (popR*birthR)-(popR*deathR);
      popF = (popF)+(popF*birthF)-(popF*deathF); //equations for populations
      long totalR = (long)(popR); //rounds off the numbers so you dont have a part of an animal left
      long totalF = (long)(popF);
      Console.WriteLine("There are currently "+totalR+" rabbits and "+totalF+"foxes"); 
    }
  }
}
