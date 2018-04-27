using System;
namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int x;
                Console.Write("Please Enter your name? ");
                string name = Console.ReadLine();
                Console.Write("Enter a number between 1 and 100: ");

                if (int.TryParse(Console.ReadLine(), out x))
                {
                    if (x % 2 != 0 && x >= 2 && x < 25)
                    {
                        Console.WriteLine($"output:{name.ToUpper()}: ,{x} Even and Less than 25");
                    }
                    else if (x % 2 == 0 && x >= 26 && x < 60)
                    {
                        Console.WriteLine($"output:{name.ToUpper()}: ,{x} Even and less than 60");
                    }
                    else if (x >= 60)
                    {
                        if (x % 2 == 0)
                        {
                            Console.WriteLine($"{name.ToUpper()}: ,you number is Even");
                        }
                        else if (x % 2 == 1)
                        {
                            Console.WriteLine($"{name.ToUpper()}: ,you number is  Odd");
                        }
                    }
                    Console.WriteLine("Continue(y/n)");

                    string input3 = Console.ReadLine();
                    if (input3.ToLower() == "y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("pleass enter an inter number");
                }
            }
            Console.WriteLine("Thank You and Bye");
        }
    }
}