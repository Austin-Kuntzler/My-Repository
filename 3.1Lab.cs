using System;

public class test {
  public int order()
  {
    
    Console.WriteLine("1:Burger");
    Console.WriteLine("2:Taco");
    Console.WriteLine("3:Drink");
    Console.WriteLine("4:Burrito");
    Console.WriteLine("5:Fried Chicken");
    Console.WriteLine("Please choose what you would like to order");
    string input=Console.ReadLine();
    int a=Convert.ToInt32(input);
    return a;
  }
  public static void Main () 
  {
    test pizza = new test();
   int choice=pizza.order();
   if (choice==1)
   {
     Console.WriteLine("You have ordered a burger");
   }
   else if(choice==2)
   {
     Console.WriteLine("You have ordered a taco");

   }
   else if(choice==3)
   {
     Console.WriteLine("You have ordered a drink");

   }
   else if(choice==4)
   {
     Console.WriteLine("You have ordered a burrito");

   }
   else if(choice==5)
   {
     Console.WriteLine("You have ordered fried chicken");

   }
   
  }
}
