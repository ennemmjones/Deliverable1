using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
           bool exitCondition = true;
            int count = 0;
            while (exitCondition) //sets condition to run additonal conversions
            {   // read inputs
                Console.Write("Please enter a measurement type (inch, foot, fidget spinners, or memes): ");
                string inputUnits = Console.ReadLine();
                Console.Write("Please enter an amount: ");
                double inputAmount = double.Parse(Console.ReadLine());
                // conditionals to check input units, run conversion, and return result
                if (inputUnits == "inch")
                {
                    double outputAmount = inputAmount * 3.5;
                    Console.WriteLine(outputAmount + " fidget spinners");
                }
                else if (inputUnits == "fidget spinners")
                {
                    double outputAmount = inputAmount / 3.5;
                    Console.WriteLine(outputAmount + " inches");
                }
                else if (inputUnits == "foot")
                {
                    double outputAmount = inputAmount * 5;
                    Console.WriteLine(outputAmount + " memes");
                }
                else if (inputUnits == "memes")
                {
                    double outputAmount = inputAmount / 5;
                    Console.WriteLine(outputAmount + " feet");
                }
                else
                {
                    Console.WriteLine("Measurement type was invalid!");
                }
                // Check if user wants to run again
                Console.Write("Would you like to run another conversion (type \"yes\" to continue)? ");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo == "yes")
                {
                    count++;
                }
                else
                {
                    exitCondition = false;  // sets condition to exit while statement
                }
            }
        }
    }
}
