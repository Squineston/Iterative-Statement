using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter an integer value between 1 and 100:");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please specify the series of integer numbers (Even or Odd):");
                string s = Console.ReadLine();

                if ((s == "Even" || s == "even") && (i >= 1 && i <=100))
                {
                    Console.WriteLine("You have selected the even series. The numbers between 0 and " + i + " are:");

                    int e = 0;
                    while (e <= i)
                    {
                        Console.WriteLine(e);
                        e+=2;
                    }
                }
                else if ((s == "Odd" || s == "odd") && (i >= 1 && i <= 100))
                {
                    Console.WriteLine("You have selected the odd series. The numbers between 0 and " + i + " are:");

                    int e = 1;
                    while (e <= i)
                    {
                        Console.WriteLine(e);
                        e += 2;
                    }
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                throw;
            }
        }
    }
}