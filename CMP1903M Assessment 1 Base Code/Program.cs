//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            // Declaring the text input variable and assigning a default value of "nothing".
            string input = "nothing";

            //Create 'Input' object
            Input i = new Input();

            //Get either manually entered text, or text from a file.
            Console.WriteLine("Do you want to enter the text via the keyboard? (Enter: 1)");
            Console.WriteLine("Do you want to read in the text from a file? (Enter: 2)");

            // Converting the input value from a string to int.
            Int32.TryParse(Console.ReadLine(), out int inputChoice);

            // Exacuting the correct sequence depending on the users choice of input.
            if (inputChoice == 1)
            {
                input = i.manualTextInput();
            }
            else if (inputChoice == 2)
            {
                Console.WriteLine("Please enter the exact file path of the .txt file: ");
                string filePath = Console.ReadLine();

                input = i.fileTextInput(filePath); 
            }
            else
            {
                Console.WriteLine("You must enter either 1 or 2 corresponding to the input choice!");
            }

            //Create an 'Analyse' object
            Analyse a = new Analyse();

            //Pass the text input to the 'analyseText' method
            parameters = a.analyseText(input);

            // Create a 'report' object
            Report report = new Report();

            //Report the results of the analysis
            report.outputConsole(parameters);

            //TO ADD: Get the frequency of individual letters?
         
      
        }
        
        
    
    }
}
