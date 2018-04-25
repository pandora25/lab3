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
                Console.WriteLine("Please Enter your name?");
                string name = Console.ReadLine();
                Console.WriteLine("enter a number between 1 and 100: ");
               
                bool z = int.TryParse(Console.ReadLine(), out x);

                if (z)
                {
                    if (x % 2 != 0 && x >= 75)
                    {
                        Console.WriteLine($"output:{name.ToUpper()}: ,{x} Odd and greater than 75");
                    }
                    else if (x % 2 == 0 && x >= 50)
                    {
                        Console.WriteLine($"output:{name.ToUpper()}: ,{x} Even and less than 50");                
                    }
                    else if (x < 50)
                    {
                        if (x % 2 == 0)
                        {
                            Console.WriteLine($"{name.ToUpper()}: ,you number is {x} less than 50 and Even");
                        }
                        else
                        {
                            Console.WriteLine($"{name.ToUpper()}: ,you number is {x} less than 50 and Odd");
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
                    Console.WriteLine("pls enter an inter number");
                }
            }
            Console.WriteLine("thank you and bye");
        }
    }
}
