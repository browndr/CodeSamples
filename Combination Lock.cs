using System.IO;
using System;

class Program
{
    static void Main()
    {
        // Read in every line in the file.
        using (StreamReader reader = new StreamReader("input.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
                string[] inputs = line.Split(' ');
                int dialSize = Convert.ToInt32(inputs[0]);
                int firstNum = Convert.ToInt32(inputs[1]);
                int secondNum = Convert.ToInt32(inputs[2]);
                int thirdNum = Convert.ToInt32(inputs[3]);
                int totalTurn = 0;
                
                totalTurn += 3 * dialSize;
                totalTurn += firstNum;
                
                if (secondNum > firstNum){
                    totalTurn += firstNum + (dialSize - secondNum);
                }
                else{
                    totalTurn += firstNum - secondNum;
                }
                
                if (thirdNum < secondNum){
                    totalTurn += thirdNum + (dialSize - secondNum);
                }
                else{
                    totalTurn += thirdNum - secondNum;
                }
                
                Console.WriteLine(totalTurn);
            }
        }
    }
}
