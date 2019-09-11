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
                else if (max == min )
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
        
//|Jackson Mossman|
//|:---           |
//|s198037|
//|Number Guessing Game Assessment|
//|Goal:To guess the users number through random guessing and elimination|

//**Inputs Info:
//User will input minimum Number and maximum Number
//User will choose if the guess is higher lower or corrrect
//**User must hold number in thier head

//#Output Info:
//Outputs random numbers everytime users gives input of higher and lower



//##System Architecture
//Contained in only Program.Cs
//Runs in a single loop of the game then ends the game

//##Program.Cs


//Name:Min(int)
//Description:holds the minimum value for Guessing

//Name:Max(int)
//Description:Holds a maximum value for Guessing

//Name:Guess(int)
//Description:Holds value of current Guess used to overwrite min and max values

//Name:fail_count(int)
//Description:holds how many times they have made a invalid range

//Name:Correct(bool)
//Description:Breaks while loop when set to true



//#--Know Bugs
//- will sometime Output the same value previous guess



    }
}
