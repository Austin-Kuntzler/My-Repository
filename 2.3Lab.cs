//Austin Kuntzler
//10/22/2019
//Takes an input to convert from the user and converts it to their choice conversion.


using System;

class MainClass {
  public static void Main (string[] args) // main functions has all of the write lines to tell the user what to do. and all of the readlines to be used in the functions
  {
    Console.WriteLine("Please choose which conversion you would like to do");
    Console.WriteLine("1:inches to centimeters");
    Console.WriteLine("2:Centimeters to inches");
    Console.WriteLine("3:inches to feet");
    Console.WriteLine("4:feet to inches");
    Console.WriteLine("5:gallons to liters");
    Console.WriteLine("6:liters to gallons");
    Console.WriteLine("7:ounce to liters");
    Console.WriteLine("8:liter to ounce");
    int input = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter how much you would like to convert");
    double conv = Convert.ToDouble(Console.ReadLine());

    switch(input) //chooses a conversion function to use based on input from the user
    {
      case 1:
        Console.WriteLine(intocm(conv)+"cm");
        break;
      case 2:
        Console.WriteLine(cmtoin(conv)+"inches");
        break;
      case 3:
        Console.WriteLine(intoft(conv)+"feet");
        break;
      case 4:
        Console.WriteLine(fttoin(conv)+"inches");
        break;
      case 5:
        Console.WriteLine(galtoliter(conv)+"liters");
        break;
      case 6:
        Console.WriteLine(litertogal(conv)+"gallons");
        break;
      case 7:
        Console.WriteLine(ouncetoliter(conv)+"liters");
        break;
      case 8:
        Console.WriteLine(litertoounce(conv)+"ounces");
        break;
      default:
        break;

    }


    

    
  }

// each of the functions below will do a conversion.
  static double intocm(double x)
  {
     double cm = x*2.54;
     return cm;
  }
  static double cmtoin(double x)
  {
     double inch=x/2.54;
     return inch;

  }
  static double intoft(double x)
  {
     double ft = x/12;
     return ft;

  }
  static double fttoin(double x)
  {
     double inch=x*12;
     return inch;

  }
  static double galtoliter(double x)
  {
     double liter= x*3.785;
     return liter;

  }
  static double litertogal(double x)
  {
     double gal = x/3.785;
     return gal;

  }
  static double ouncetoliter(double x)
  {
     double liter= x/33.814;
     return liter;

  }
  static double litertoounce(double x)
  {
     double ounce = x*33.814;
     return ounce;

  }
}
