using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wu_PE06
{
    internal class Program
    {

        //PE6 GRADE: 80
        static void Main(string[] args)
        {
            Random rand = new Random();
            // Generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);
            // Counter the amount of tries
            int counter = 0;
            // User's guess
            int userInput;
            bool outOfLoop = false;
            Console.WriteLine(randomNumber);

            while (counter < 8)
            {
                Console.WriteLine("Enter a number: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                // Sees if the user's guess is either a negative number or larger than 100
                if (userInput < 0 || userInput > 100)
                {
                    Console.WriteLine("Invalid guess - try again");
                    counter++;
                }
                // Sees if user input is less than randomNumber and is greater than or equal to 0
                if (userInput < randomNumber && userInput >= 0)
                {
                    Console.WriteLine("Too low\n");
                    counter++;
                }
                //Sees if user input is greater than randomNumber and is less than or equal to 100
                if (userInput > randomNumber && userInput <= 100)
                {
                    Console.WriteLine("Too high\n");
                    counter++;
                }
                // If the user does not get the number within 8 guesses, print the random number.
                if (counter == 8 && userInput != randomNumber)
                {
                    Console.WriteLine("You ran out of turns. The number was " + randomNumber);;
                }

                // Stops the while loop if the user input is the same as randomNumber
                else if (userInput == randomNumber)
                {
                    counter++;
                    outOfLoop = true;
                    break;
                }
            }
            

            // Will tell the user how many guesses it took them to get the correct number
            if (outOfLoop == true)
            {
                Console.WriteLine("Correct! You won in " + counter + " turns");
            }
            
        }
    }
}
