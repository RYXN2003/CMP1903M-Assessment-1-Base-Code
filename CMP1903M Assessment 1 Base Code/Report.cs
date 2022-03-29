using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        public List<int> outputConsole(List<int> vs)
        {
            // Handles the writeline statements and inserts the correct int from the values list.
            Console.WriteLine("The Number of sentences is: {0}", vs[0]);
            Console.WriteLine("The Number of vowels is: {0}", vs[1]);
            Console.WriteLine("The Number of consonants is: {0}", vs[2]);
            Console.WriteLine("The Number of Upper case letters is: {0}", vs[3]);
            Console.WriteLine("The Number of Lower case letters is: {0}", vs[4]);

            return vs;
        }

    }
}
