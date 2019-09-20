// Austin Kuntzler
// 9/12/2019
//A program where a random number is generated that represents rock paper or scissors and then the user picks a number to play against them with.

using System;

class MainClass {
  public static void Main (string[] args) {
    string move;
    Random random = new Random(); //defining variables
    int win1,win2,movenum;
    Console.WriteLine("We're going to play rock paper scissors best three out of five");
    win1 = 0;
    win2 = 0; //used for a win state to end the game

    
    while (win1 < 3 && win2 < 3){ //continues the loop until a user reaches 3 wins
      Console.WriteLine("You have "+win1+" wins.");
      Console.WriteLine("Your opponent has "+win2+" wins.");
      int num = random.Next(1,3);
      Console.WriteLine("Rock:1  Paper:2  Scissors:3");
      move = Console.ReadLine();
      movenum = Convert.ToInt32(move);
      if(movenum==num){ // next lines of code are all the possible outcomes of a rock paper scissors game
        Console.WriteLine("You and your opponent picked the same thing you tie.");
      }
      else if(movenum==1){
        if(num==2){

          Console.WriteLine("Your opponent picked paper you lose.");
          win2 = win2 + 1; //adds 1 to the winners score


        }
        else if(num==3){
          Console.WriteLine("Your opponent picked scissors you win!");
          win1 = win1+1;
        }
      }
      else if(movenum==2){
        if(num==1){
          Console.WriteLine("Your opponent picked rock you win!");
          win1=win1+1;
        }
        else if(num==3){
          Console.WriteLine("Your oppoent picked scissors you lose.");
          win2=win2+1;
        }
      }
      else if(movenum==3){
        if(num==1){
          Console.WriteLine("Your opponent picked rock you lose.");
          win2=win2+1;
        
        }
        else if(num==2){
          Console.WriteLine("Your oppoenent picked paper you win!");
          win1=win1+1;
        }
      }
      if(win1==3){
        Console.WriteLine("You win!");

      }
      else if(win2==3){
        Console.WriteLine("You lose.");
      }
    } 
  }  
}
