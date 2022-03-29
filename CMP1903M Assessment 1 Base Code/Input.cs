using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";

        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine("Please enter a sentence ending with an asterix (e.g. I went to the shop yesterday.*)");
            text = Console.ReadLine();

            if (text == (null))
            {
                Console.WriteLine("You must enter a valid sentence!");
                manualTextInput();
            }

            return text;
        }


        //Gets text input from a .txt file
        public string fileTextInput(string filePath)
        {
            string fileInput = File.ReadAllText(filePath);

            return fileInput;
        }

    }
}
