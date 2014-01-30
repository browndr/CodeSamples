using System.IO;
using System;
using System.Text.RegularExpressions;

class Language
{
    static void Main()
    {
        // Read in every line in the file.
        using (StreamReader reader = new StreamReader("languages.txt"))
        {
            string line;
            line = reader.ReadLine();
            string[] input = line.Split(' ');
            int wordLength = Convert.ToInt32(input[0]);
            int dictionaryLength = Convert.ToInt32(input[1]);
            int numTestCases = Convert.ToInt32(input[2]);
            string[] dictionary = new string[dictionaryLength];

            for(int i = 0; i < dictionaryLength;i++){
                line = reader.ReadLine();
                dictionary[i] = line;
            }

            int caseNumber = 1;

            while ((line = reader.ReadLine()) != null)
            {
                line = line.Replace("(","[");
                line = line.Replace(")","]");
                Regex pattern = new Regex(line);
                int count = 0;
                foreach (string word in dictionary){
                    if (pattern.IsMatch(word)){
                        count ++;
                    }
                }

                Console.WriteLine("Case #" + caseNumber + ": " + count);
                caseNumber++;            
            }
        }
    }
}