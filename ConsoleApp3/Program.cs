using System;
namespace Run;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a range: ");
            Console.WriteLine("From:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("To:");
            int y = Convert.ToInt32(Console.ReadLine());
            
            while (x >= y)
            {
                Console.WriteLine("Invalid Range, try again");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
            }
            
            while (x < y) 
            {
                int middle = (x + y) / 2;
                Console.WriteLine("Is your number greater than " + middle +
                                  "?\nif your number is greater than " + middle +
                                  ", then type 'yes', otherwise type 'no'");
                string response = Console.ReadLine();
                while (!response.Trim().ToLower().Equals("yes") && !response.Trim().ToLower().Equals("no"))
                {
                    Console.WriteLine("Invalid input, please type 'yes' or 'no'.");
                    response = Console.ReadLine();
                }
                
                if (response.ToLower().Equals("yes"))
                {
                    x = middle + 1;
                }
                else
                {
                    y = middle;
                }
            }
            Console.WriteLine("Your number is " + x);
            Console.WriteLine("Do u want to continue? \nif yes then type '1', otherwise type any integer");
            int game = int.Parse(Console.ReadLine());
            if (game != 1)
            {
                Console.WriteLine("Game over thanks for playing with me");
                Console.WriteLine(game);
                break;
            }
        }
    }
}