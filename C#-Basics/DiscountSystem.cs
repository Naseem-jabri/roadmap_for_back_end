using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFirstProject
{
    public class DiscountSystem
    {
        public static void RunDisc()
        {
          
        
            Console.WriteLine("Enter product price");
           
            double price = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i <= 3; i++)
            {
                price = price * 0.9;
                Console.WriteLine($"Discount #{i} has been applied; the price is now: {price}");


                if(price < 50)
                {
                    Console.WriteLine("No further discounts can be applied.");
                    break;
                }
            }



        }

    }
}


