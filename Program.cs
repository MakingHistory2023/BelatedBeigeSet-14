using System;
using System.Globalization;

class Program
{
  static void Main() 
  {
    string initial = "";
    int dSale = 0;
    int eSale = 0;
    int fSale = 0;
    int total = 0;
    while (initial != "z")
    {
      Console.WriteLine("Enter a salesperson initial");
      initial = Console.ReadLine().ToLower();
      if(initial =="d" || initial =="e" || initial =="f")
      {
        Console.WriteLine("Enter the amount of sale");
        int amount = Convert.ToInt32(Console.ReadLine());
        if(initial == "d")
        dSale += amount;
        else if(initial =="e")
        eSale += amount;
        else if(initial =="f")
        fSale += amount;
        }else{
        if(initial != "z")
        {
          Console.WriteLine("Error Invalid initials entered");
          }
        }
      }
    total = dSale + eSale + fSale;
    Console.WriteLine("Danielle sold: {0}", dSale.ToString("C",CultureInfo.GetCultureInfo("en-US")));
    Console.WriteLine("Edward sold: {0}",eSale.ToString("C",CultureInfo.GetCultureInfo("en-US")));
    Console.WriteLine("Francis sold: {0}",fSale.ToString("C",CultureInfo.GetCultureInfo("en-US")));
    Console.WriteLine("Total sales were: {0}", total.ToString("C",CultureInfo.GetCultureInfo("en-US")));
    if(dSale > eSale && dSale >fSale){
      Console.WriteLine("Danielle sold the most");
      }
    else if(eSale > dSale && eSale > fSale)
    {
      Console.WriteLine("Edward sold the most");
      }
    else if(fSale > dSale && fSale > eSale)
    {
      Console.WriteLine("Francis sold the most");
      }
    else{
      Console.WriteLine("There was a tie");
      }
    }
  }