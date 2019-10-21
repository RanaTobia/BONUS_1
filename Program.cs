using System;

namespace BONUS_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter! ");
            bool valid = true;

            while (valid == true)
            {
                Console.WriteLine("Enter a numerical grade:");
                //int i = int.Parse(Console.ReadLine());
                var inputAsString = Console.ReadLine();
                int i;
                if (int.TryParse(inputAsString, out i))
                {
                    if (i <= 100 && i >= 88)
                    {
                        Console.WriteLine("Letter Grade is: A");

                    }
                    else if (i <= 87 && i >= 80)
                    {
                        Console.WriteLine("Letter Grade is: B");
                    }
                    else if (i <= 79 && i >= 67)
                    {
                        Console.WriteLine("Letter Grade is: C");
                    }
                    else if (i <= 66 && i >= 60)
                    {
                        Console.WriteLine("Letter Grade: D");
                    }
                    else if (i <= 60 && i >= 0)
                    {
                        Console.WriteLine("Letter Grade: F");

                    }
                }

                else // when the user input is invalid 

                {
                    Console.WriteLine(" Please insert a valid number");
                }

                // to check if the user want tocontinue

                Console.WriteLine("Continue? (y/n): ");
                string input = Console.ReadLine();
                
                if (input == "y" || input == "y")   // if Yes continue
                {
                    valid = true;
                }
                else     //exit the program 
                {
                    Console.WriteLine("Good Bye");
                    valid = false;
                }
            }

                
        }
    }
}
    


