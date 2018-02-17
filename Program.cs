using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
   
     class FizzBuzz
     {
            static void Main()
            {
                for (int n = 1; n <= 3; n++)
                {
                    if (n % 15 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (n % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (n % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(n);
                    }
                }
                for (int m = 1; m <= 15; m++)
                {
                    if (m % 15 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (m % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (m % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(m);
                    }
                }
            }
        }
 }
    

