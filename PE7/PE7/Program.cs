using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For the final story
            string resultStory = " ";

            //User's mad libs story choice
            int storyChoice = 0;
            
            //Amount of words in the mad libs story
            int numLibs = 0;

            //A counter to go into the next line
            int counter = 0;

            //Reads lines from the mad libs story
            string line = null;
            StreamReader input;
            
            //opens the text file and counts how many mad libs there are (how many lines)
            input = new StreamReader(("C:\\Templates\\MadLibsTemplate.txt"));
             
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }
            //Closes
            input.Close();

            //Makes as many spaces there are in the mad libs
            string[] madLibs = new string[numLibs];

            //Reads the mad libs and puts it into an array
            input = new StreamReader("C:\\Templates\\MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                //Sets array element to the current mad libs line
                madLibs[counter] = line;

                //Replaces "\\n" tag with "\n"
                madLibs[counter] = madLibs[counter].Replace("\\n", "\n");

                ++counter;
            }
            //Closes
            input.Close();

            //Asks the player if they want to play
            string playConfirmation;
            Console.WriteLine("Do you want to play?\n");

            //Converts their answer into lower case so it isn't case sensitive
            playConfirmation = Console.ReadLine().ToLower();

            //Check's if the player enters a valid answer
            while (playConfirmation != "yes" && playConfirmation != "no")
            {
                Console.WriteLine("Try again!\nDo you want to play?\n");
                playConfirmation = Console.ReadLine().ToLower();
            }
            //Runs the game if player answers yes
            if (playConfirmation.Equals("yes"))
            {
                //Asks the player to pick a story
                Console.WriteLine("Pick a number from 1-6 for a story: ");
                storyChoice = Convert.ToInt32(Console.ReadLine());

                string[] words = madLibs[storyChoice - 1].Split(' ');
                //Goes through the mad libs story
                for (int i = 0; i < words.Length; i++)
                {
                    //Checks if something contains "{"
                    if (words[i][0] == '{')
                        {
                            //Replaces "{", "}", "_" to spaces
                            words[i] = words[i].Replace("{", " ").Replace("}", " ").Replace("_", " ");

                            //Prompts player to input things into the story
                            Console.Write("Input a {0}: ", words[i]);
                            resultStory += Console.ReadLine() + " ";
                        }
                    //if it doesn't have a "{", it will go onto the next word in the story and put it in the final
                    else
                        {
                            resultStory += words[i] + " ";
                        }
                }
                //Writes out the final story
                Console.WriteLine(resultStory);
            }
            //Exits program if player says no
            if (playConfirmation.Equals("no"))
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
