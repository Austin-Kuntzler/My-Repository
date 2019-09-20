// Austin Kuntzler
//9/19/2019
// Adds up users test scores and takes the average

using System;

class MainClass {
  public static void Main (string[] args) {
    string score;
    double scorenum,average,total,iterations; //defining variables
    int scoreint;
    total = 0;
    scorenum = 0;
    iterations = 0;
    

    while (scorenum!=-1)

    {
      Console.WriteLine("Please enter a score or enter -1 to stop");
      score = Console.ReadLine();
      scoreint =Convert.ToInt32(score); //used for the switch statement because it needs to have a integer
      switch(scoreint)
      {
        case -1:
          scorenum=scoreint; //ends the loop if the user enters a -1
          break;
        default:
    
          scorenum = Convert.ToDouble(score);
          total= total+ scorenum;
          iterations = iterations+1; //for each iteration adds 1 to the total iteration so that you can use it as the divisor for the average
          break;
      }
      
    }
   average = total/iterations;
   Console.WriteLine("Your average is "+average+"%"); //equation for an average
  }
}
