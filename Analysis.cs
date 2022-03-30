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

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> AnalyseText(string input)
        {

            //Initialise all the values in the list to '0'
            List<int> values = new List<int>();

            char[] character = input.ToCharArray();
            Console.WriteLine("crunching numbers");

            //seperates string into single characters for analysis

            //List of integers to hold the first five measurements:

            //1. Number of sentences

            int sentenceCount = 0;
            //loop repeats until all sentences have been counted
            foreach (char x in input) if (x == '.')
            {
                sentenceCount = +1;
            }


            values.Add(sentenceCount);

            //2. Number of vowels

            int vowelCount = 0;
            foreach (char a in character)
            {
                vowelCount += 1;
            }
            foreach (char e in character)
            {
                vowelCount += 1;
            }
            foreach (char i in character)
            {
                vowelCount += 1;
            }
            foreach (char o in character)
            {
                vowelCount += 1;
            }
            foreach (char u in character)
            {
                vowelCount += 1;
            }

            values.Add(vowelCount);

            //3. Number of consonants

            int consonantsCount = 0;
            foreach (char b in character)
            {
                consonantsCount += 1;
            }
            foreach (char c in character)
            {
                consonantsCount += 1;
            }
            foreach (char d in character)
            {
                consonantsCount += 1;
            }
            foreach (char f in character)
            {
                consonantsCount += 1;
            }
            foreach (char g in character)
            {
                consonantsCount += 1;
            }
            foreach (char h in character)
            {
                consonantsCount += 1;
            }
            foreach (char j in character)
            {
                consonantsCount += 1;
            }
            foreach (char k in character)
            {
                consonantsCount += 1;
            }
            foreach (char l in character)
            {
                consonantsCount += 1;
            }
            foreach (char m in character)
            {
                consonantsCount += 1;
            }
            foreach (char n in character)
            {
                consonantsCount += 1;
            }
            foreach (char p in character)
            {
                consonantsCount += 1;
            }
            foreach (char q in character)
            {
                consonantsCount += 1;
            }
            foreach (char r in character)
            {
                consonantsCount += 1;
            }
            foreach (char s in character)
            {
                consonantsCount += 1;
            }
            foreach (char t in character)
            {
                consonantsCount += 1;
            }
            foreach (char v in character)
            {
                consonantsCount += 1;
            }
            foreach (char w in character)
            {
                consonantsCount += 1;
            }
            foreach (char x in character)
            {
                consonantsCount += 1;
            }
            foreach (char y in character)
            {
                consonantsCount += 1;
            }
            foreach (char z in character)
            {
                consonantsCount += 1;
            }

            values.Add(consonantsCount);

            //4. Number of upper case letters

            int upperCaseCount = 0;
            for (int length = 0; length < character.Length; length = +1)
            {
                if (char.IsUpper(character[length]) == true)
                {
                    upperCaseCount += 1;
                }
            }

            values.Add(upperCaseCount);

            //5. Number of lower case letters

            int lowerCaseCount = 0;
            for (int length = 0; length < character.Length; length = +1)
            {
                if (char.IsLower(character[length]) == true)
                {
                    lowerCaseCount += 1;
                }

            }
            values.Add(lowerCaseCount);

            return values;
        }
    }
}
