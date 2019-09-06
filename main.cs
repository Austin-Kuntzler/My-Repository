using System;
class MainClass 
{
 
  static void Main ()

  {
    int moneyN,math,Q,D,N,P,R; // Assigning Variables
    double fee,vouch,total;
    string moneyS;


    Console.WriteLine("Please input your money in cents");
    moneyS = Console.ReadLine(); //takes an amount in cents from the user 
    moneyN = int.Parse(moneyS);
    math = moneyN;
    Q = math/25; // divides by the value of a quarter to determine how many there are
    R = math%25; //grabs amount of cents left over to be used in the next calculation
    
    D = R/10; //repeat same process until only pennies are left
    R = R%10;
    
    N = R/5;
    R = R%5;
    
    P=R;
    Console.WriteLine("Quarters: "+Q+"  Dimes: "+D+"  Nickles: "+N+"  Pennies: "+P);

    fee = moneyN*.109; //calculates the 10.9% fee
    vouch = moneyN - fee;

    total = moneyN; //Chaning the total amount you entered into a dollar amount
    total = total/100;


    vouch = Convert.ToInt32(vouch); //rounds off after subtracting the fee for a nice number

    vouch = Convert.ToDouble(vouch); //Converting the amount after the fee to dollars
    vouch = vouch/100;

    Console.WriteLine("The total was $"+total+" and after the fee you get $"+vouch);

  


   
    

  }
}