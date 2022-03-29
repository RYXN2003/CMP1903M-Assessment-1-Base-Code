using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text
        //Calculates and returns an analysis of the text
        //Returns: list of integers
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }

            // Stops the program from reading past the point of the asterix.
            if (input.Contains("*"))
            {
                input = input.Substring(0, input.IndexOf("*"));
               
            }

            // Calculating the amount of sentences in 'input'.
            for (int i = 0; i<input.Length; i++)
            {
                if (input[i] == '.' || input[i] == '?' || input[i]== '!')
                {
                    values[0]++;
                }
            }

            // Converting 'input' to lower case characters.
            string lower = input.ToLower();

            // Removing all punctuation form 'input'.
            var removeList = new string[] { ".", "?", "@", ",", "'", ";", " " };
            foreach (var rl in removeList)
            {
                lower = lower.Replace(rl, string.Empty);
            }

            // Calculating the amount of vowels and consenants in 'input'.
            foreach (char c in lower)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    values[1]++;
                    
                }
                else if (c != 'a' || c != 'e' || c != 'i' || c != 'o' || c != 'u')
                {
                    values[2]++;
                   
                }
                else
                {
                    Console.WriteLine("Please type a valid sentence!!");
                }
                
            }

            // Calculating the amount of upper and lower case characters in 'input'.
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    values[3]++;
                }
                else if (char.IsLower(input[i]))
                {
                    values[4]++;
                }
            }

            // returning the list of values to the main program.
            return values;
        }
    }
}
