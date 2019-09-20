//Austin Kuntzler
//9/19/2019
// Takes an input for a childs age then prints out are we there an amount of times equal to their age.

using System;

class MainClass {
  public static void Main (string[] args) {
    int agenum,iteration; //defining variables
    string age;
    iteration=0;
    Console.WriteLine("Please enter the child's age");
    age = Console.ReadLine();
    agenum = Convert.ToInt32(age);
    while(iteration!=agenum) //repeats loop until the number of iterations is the same as the child's age.
    {
      Console.WriteLine("Are we there yet?");
      iteration=iteration+1;
    }
  }
}
