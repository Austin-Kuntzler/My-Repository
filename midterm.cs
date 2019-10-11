// Austin Kuntzler 
//10/10/2019
//This program simulates the game of Hi Ho cherry-O against a computer player.
using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Random rand = new Random();
    int spin,i;
    int [] array=new int[2]; // an array used to differentiate between the two players
    i=0; // i will be used for turn taking

    while(array[0]<10&&array[1]<10)

    {
      if(i%2==0)
      {
        Console.WriteLine("Press enter to spin.");
        Console.ReadLine();

      }
      
      spin = rand.Next(1,8); //generates a random number between 1 and 7 which will be used to represent a spinner.

      if(i%2==0)
      { //tells who spun on any given turn and the outcome of the spin.
        Console.WriteLine("You spun a "+spin);

      }
      else if(i%2==1)
      {
        Console.WriteLine("Your opponent spun a "+spin);

      }
      switch(spin)
      { // each switch statement represents one of the outcomes of the spinner
        case 1:
          array[i%2]++;
          Console.WriteLine("Plus one cherry");
          break;
        case 2:
           
          for(int x=0;x<2;x++)
          {
            array[i%2]++;
           
          }
          Console.WriteLine("Plus two cherries");
          break;
        case 3:
          for(int x=0;x<3;x++)
          {
            array[i%2]++;
          }
          Console.WriteLine("Plus three cherries");
          break;
        case 4:
          for(int x=0;x<4;x++)
          {
            array[i%2]++;
          }
          Console.WriteLine("Plus four cherries");
          break;
        case 7:
          array[i%2]=0;
          Console.WriteLine("Return all cherries to the tree");
          break;

        default:
          if (array[i%2]>=2)
          { //this if statements makes sure that the player loses up to two cherries so that they don't go into the negatives.
            Console.WriteLine("Lose up to two cherries");
            for(int x=0;x<2;x++)
            {
              array[i%2]--;
            }
          }
          else if(array[i%2]==1)
          {
            Console.WriteLine("Lose up to two cherries");
            array[i%2]--;
          }
          else if(array[i%2]==0)
          {
            Console.WriteLine("No cherries left to return to the tree the turn is skipped");
          }
          break;
      }
      i++; //changes whose turn it is at then end of each itteration of the loop.



      //displays the scores of each player with a line break to make it a little easier to read.
      Console.WriteLine(); 
      Console.WriteLine("Score:");
      Console.WriteLine("You:"+array[0]);
      Console.WriteLine("Opponent:"+array[1]);
      Console.WriteLine();
    }
    if(array[0]>=10)
    { //determines who was the winner at the end of a loop
      Console.WriteLine("You win!");

    }
    else if(array[1]>=10)
    {
      Console.WriteLine("You lose.");
    }

  }
}

/*Press enter to spin.

You spun a 7
Return all cherries to the tree

Score:
You:0
Opponent:0

Your opponent spun a 5
No cherries left to return to the tree the turn is skipped

Score:
You:0
Opponent:0

Press enter to spin.

You spun a 3
Plus three cherries

Score:
You:3
Opponent:0

Your opponent spun a 4
Plus four cherries

Score:
You:3
Opponent:4

Press enter to spin.

You spun a 1
Plus one cherry

Score:
You:4
Opponent:4

Your opponent spun a 6
Lose up to two cherries

Score:
You:4
Opponent:2

Press enter to spin.

You spun a 2
Plus two cherries

Score:
You:6
Opponent:2

Your opponent spun a 7
Return all cherries to the tree

Score:
You:6
Opponent:0

Press enter to spin.

You spun a 7
Return all cherries to the tree

Score:
You:0
Opponent:0

Your opponent spun a 4
Plus four cherries

Score:
You:0
Opponent:4

Press enter to spin.

You spun a 6
No cherries left to return to the tree the turn is skipped

Score:
You:0
Opponent:4

Your opponent spun a 4
Plus four cherries

Score:
You:0
Opponent:8

Press enter to spin.

You spun a 7
Return all cherries to the tree

Score:
You:0
Opponent:8

Your opponent spun a 2
Plus two cherries

Score:
You:0
Opponent:10

You lose.*/
