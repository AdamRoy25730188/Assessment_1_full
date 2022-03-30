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
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        public void Compile(List<int> results)
        {
            Console.WriteLine("Text contains: \n" + results[0] + "sentences, \n" + results[1] + "vowels, \n" + results[2] + "consonants, \n" + results[3] + "upper case letters, \n and " + results[4] + "lower case letters.");
        }
    }
}
