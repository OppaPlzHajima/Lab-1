using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Deliverable1;

namespace Deliverable1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
  
            
            decimal a;
            decimal b;
            decimal c;

           
                       
            Console.WriteLine("Hello, Welcome to the worlds greatest money converter");

            Console.WriteLine("Please Enter Your First Amount ($)");

            a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please Enter Your Second Amount ($)");

           b = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please Enter Your Third Amount ($)");

            c = Convert.ToDecimal(Console.ReadLine());

            var total = a + b + c;
            var total1 = Convert.ToInt32(total * 9.47m);
            var total2 = Convert.ToInt32(total* 108.47m);
            var total3 = Convert.ToDecimal(total* 31.28m);

            var avg = Convert.ToDecimal(total / 3);
            var  e = Convert.ToInt32(avg * 9.47m);
            var f = Convert.ToInt32(avg * 108.47m);
            var g = Convert.ToDecimal(avg * 31.28m);

            decimal [] numbers = new decimal[] { a, b, c };
            decimal min = numbers.Min();
            decimal max = numbers.Max();

            var min1 = Convert.ToInt32(min * 9.47m);
            var min2 = Convert.ToInt32(min * 108.47m);
            var min3 = Convert.ToDecimal(min * 31.28m);

            var max1 = Convert.ToInt32(max * 9.47m);
            var max2 = Convert.ToInt32(max * 108.47m);
            var max3 = Convert.ToDecimal(max * 31.28m);


            Console.WriteLine("YOUR TOTAL");
            Console.WriteLine("Your Total in US: {0:C}", total);
            Console.WriteLine("Your Total  in Swedish: " + total1 + " kr");
            Console.WriteLine("Your Total  in Japanese: ￥Yen￥" + total2);
            Console.WriteLine("Your Total  in Thai: {0:F} Baht", total3);

            Console.WriteLine("YOUR AVERAGE");
         Console.WriteLine("Your Average in US: {0:C}", avg);
         Console.WriteLine("Your Average in Swedish: " + e + " kr");
         Console.WriteLine("Your Average in Japanese: ￥Yen￥" + f );
         Console.WriteLine("Your Average in Thai: {0:F} ฿ Baht", g );

            Console.WriteLine("YOUR MINIMUM VALUE");
            Console.WriteLine("Your Minimum Value in US: {0:C}", min);
            Console.WriteLine("Your Minimum Value in Swedish: " + min1 + " kr");
            Console.WriteLine("Your Minimum Value in Japanese: ￥Yen￥" + min2);
            Console.WriteLine("Your Minimum Value in Thai: {0:F} ฿ Baht", min3);

            Console.WriteLine("YOUR MAXIMUM VALUE");
            Console.WriteLine("Your Maximum Value in US: {0:C}", max);
            Console.WriteLine("Your Maximum Value in Swedish: " + max1 + " kr");
            Console.WriteLine("Your Maximum Value in Japanese: ￥Yen￥" + max2);
            Console.WriteLine("Your Maximum Value in Thai: {0:F} ฿ Baht", max3);






        }
    }
}
