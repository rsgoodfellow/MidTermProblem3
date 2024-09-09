using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermProblem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 57; //declares and initializes variable
            int guess = 0; //declares and initializes variable
            Console.WriteLine("Guess the number between 1 and 100: "); //text asking for user input
            while (guess != num) //while loop that will continue as long as the users guess is not equal to 57
            {
                guess = Convert.ToInt32(Console.ReadLine()); //converts user input into a variable
                if (guess > num) //if condition if the guess is too high
                {
                    Console.WriteLine("Too high!"); //displays text saying the users guess is too high
                }
                else //else condition if the guess is too low
                {
                    Console.WriteLine("Too low!");  //displays text saying the users guess is too low
                }
            }
            Console.WriteLine("Correct!"); //displays victory text

            Console.Read(); //allows user to read program
        }
    }
}
