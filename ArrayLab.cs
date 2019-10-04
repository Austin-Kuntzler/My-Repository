// Austin Kuntzler
//10/3/2019
//A program that puts 100 numbers between 1-20 into an array then tells you how many of each number there are and how many are even and how many are odd.

using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int [] array= new int[100]; 
    int []num= new int[20]; //defining arrays and variables
    int even,odd;
    Random rand=new Random(); 
    even=0;
    odd=0;
    

    for (int i=0;i<100;i++) //loops through the 100 long array and puts a number between 1 and 20 into each slot
    {
      array[i]=rand.Next(1,21);
    }
    for(int i=0;i<100;i++)
    {
      int pos = array[i]-1; //adds to the total for each number EX: finds out how many 1's 2's 3's etc. you have
      num[pos]++;
     
     
      if(array[i]%2==0)
      {
        even++; // determines whether a number is even or odd

      }
      else if(array[i]%2==1)
      {
        odd++;

      } 
    }
  
    Console.WriteLine("There are "+even+" even numbers.");
    Console.WriteLine("There are "+odd+" odd numbers");

    for(int i=0;i<20;i++)
    {
      int position=i+1;
      Console.WriteLine("");
      Console.Write(position+": ");
      for(int z=0;z<num[i];z++)
      {
        Console.Write("*"); //writes a * for the total amount of a number you have
      }
    }
  }
}
