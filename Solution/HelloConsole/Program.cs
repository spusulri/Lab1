using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args) //array of strings with arguments
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //instead of type String, you can also use it as "var"
            //initializes nameStr as an empty String instead
            // string nameString; 
            //it's important to initialize a variable
            string nameStr = String.Empty;
            string ageStr = String.Empty;
            switch (args.Length)
            {

                case 0:
                    {
                        nameStr = PromptName(); //prompts name and age, if there's nothing in there
                        ageStr = PromptAge();//and once that's done, it breaks and comes out
                        break;
                    }
                case 1:
                    {
                        if (IsNum(args[0])) //is args[0] a number?
                        {
                            nameStr = PromptName(); //if it's a number then, prompt for the name and take the 
                            //the first input as the age
                            ageStr = args[0];
                        }
                        else
                        {
                            nameStr = args[0]; //if not a number, prompt for age and take the first input as a name
                            ageStr = PromptAge();
                        }

                        break;
                    }
                case 2:
                    {
                        if (IsNum(args[0]) && IsNum(args[1])) //if both 0 and 1 are numbers, then
                            //the first one can be in the name, and the second can be the age.
                        {
                            nameStr = args[0];
                            ageStr = args[1];
                        }
                        else
                        if (IsNum(args[0])) //if both are not numbers, then, check if the first arg is a number
                        {
                            ageStr = args[0]; //if first input is a number, then assign it to ageStr, and the second one
                            //can be the name
                            nameStr = args[1];
                        }
                        else
                            if (IsNum(args[1])) //if the second one is the number
                        {
                            nameStr = args[0];//then the first one is the name and the second input is the age
                            ageStr = args[1];
                        }
                        else
                        {
                            throw new ArgumentException(String.Format("Neiter {0} or {1} are numbers", args[0], args[1]));
                        }
                        break;
                    }
                default:
                    throw new ArgumentException(String.Format("Wrong number of Errors"));
            }

            Console.WriteLine(String.Format("{0} your age is {1}", nameStr, ageStr));
            // Really your parents Named you a 'Number'?
            if (IsNum(nameStr))
            {
                DoNameIsANumber(nameStr, ageStr);

            }
            Console.ReadKey();
        }



        private static bool IsNum(string v)
        {
            return int.TryParse(v, out int n); //if you want to convert String to 
            //int or float or whatever, use TryParse that is in each of those type classes.Try
            //Parse is a static variable most likely under class int. 
            //Or you can use a Convert class method if you'd like. 
            //TryParse returns a boolean value
            //

        }

        private static string PromptAge()
        {
            bool ageCaptured = false;
            string ageStr = string.Empty;
            do
            {
                Console.Write("Enter your Age: ");
                ageStr = Console.ReadLine();
                ageCaptured = IsNum(ageStr);
                if (!ageCaptured ) //don't use < 0, !ageCaptured on the other hand, makes sure there's a result in IsNum
                {
                    Console.WriteLine("Invalid Age");
                }
            } while (!ageCaptured);
            return ageStr;
        }

        private static string PromptName()
        {
            Console.Write("What Is your Name: ");
            return Console.ReadLine();
        }

        private static void DoNameIsANumber(string nameStr, string ageStr)
        {
            if (nameStr == "99")
            {
                Console.WriteLine("I think your Boss Maxwell Smart is Great! I also Have crush on you!");
                Console.WriteLine("Look at this video https://www.youtube.com/watch?v=I6UQW64hxMI");
                if (int.Parse(ageStr) > 29)
                {
                    Console.WriteLine("You really don't look a day over 29");

                }
            }
            else
            {
                Console.WriteLine("Your Parents were Mathematicians! ");

            }
        }
    }
}