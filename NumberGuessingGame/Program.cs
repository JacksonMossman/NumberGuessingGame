using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {            
            int guess = 0;
            int max = 11;
            int min = 0;
            int failcount = 0;
            bool correct = false;
            Random random = new Random();
            //COLLECT MAX
            Console.WriteLine("pick a maximum");
            //COLLECT MIN
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pick a minimum");
            min = Convert.ToInt32(Console.ReadLine());
            //GET NUMBER
            Console.WriteLine("Please choose a number ");
            Console.ReadKey();

            while (correct == false)
            {
                string choice = "";
                guess = random.Next(min, max);
                Console.WriteLine("the guess is " + random.Next(min,max));
                Console.WriteLine("Is the number greater or less than the guess");
                Console.WriteLine("1: guess > number");
                Console.WriteLine("2: guess < number");
                Console.WriteLine("3: Correct");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    max = guess + 1;                   
                    correct = false;
                }
                //guess is to low
                else if (choice == "2")
                {
                    min = guess + 1;                    
                    correct = false;
                }
                else if (choice == "3")
                {
                    correct = true;
                }
                //user lies
                else if (max == min)
                {
                    Console.WriteLine("i know what you did");
                    failcount++;
                    guess = random.Next(min, max);
                    if (failcount == 1 )
                    {
                        Console.WriteLine("You are why my children are cold at night");   
                    }
                    else if (failcount == 2)
                    {
                        Console.WriteLine("they cry every night they dont have socks");
                    }
                    else if (failcount == 3)
                    {
                        Console.WriteLine("they look at me like they dont even know me anymore");
                    }
                }

            }
            Console.WriteLine("your number is " + guess + " Loser");
            Console.ReadKey();

        }
        //void Game()
        //{
        //    int number = 0;
        //    int guess = 0;
        //    int max = 11;
        //    int min = 0;
        //    Random random = new Random();
        //    Console.WriteLine("Please choose a number 1-10");
        //    number = Convert.ToInt32(Console.ReadLine());
        //    Convert.ToInt32(number);

        //    if (number < 0 || number > 10)
        //    {
        //        Console.WriteLine("Invalid Number");
        //    }
        //    while (guess != number)
        //    {
        //        string choice = "";
        //        Console.WriteLine("the guess is " + guess);
        //        Console.WriteLine("Is the number greater or less than the guess");
        //        Console.WriteLine("1: guess > number");
        //        Console.WriteLine("2: guess < number");
        //        choice = Console.ReadLine();
        //        if (choice == "1" && guess > number)
        //        {
        //            guess = random.Next(min, guess + 1);
        //        }
        //        //guess is to low
        //        else if (choice == "2" && guess < number)
        //        {
        //            guess = random.Next(guess + 1, max);
        //        }
        //        //user lies
        //        else
        //        {
        //            Console.WriteLine("i know what you did");
        //            guess = random.Next(min, max);
        //        }

        //    }
        //    Console.WriteLine("your number is " + guess + " Loser");
        //    Console.ReadKey();
        //}

    }
}
