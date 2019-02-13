using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
        QuizAString:
            {
                string[] stringArray =
                {
                    "You will die in > 50 years",
                    "You will die in > 25 years",
                    "You will die in > 15 years",
                    "You will die in > 10 years",
                    "You will die in > 5 years"
                };
                Console.WriteLine("Choose your destiny! Pick a number between 1 and 5: ");
                var answer1 = Console.ReadLine();
                try
                {
                    Console.WriteLine(stringArray[Convert.ToInt32(answer1) - 1]);
                }
                catch (FormatException)
                {
                    goto Error1;
                }
                catch (IndexOutOfRangeException)
                {
                    goto Error1;
                }
                Console.ReadLine();
            }
        QuizAnInt:
            {
                int[] intArray = { 5, 2, 10, 200, 5000 };

                Console.Write("Now, choose another number between 1 and 5. Try to do it better this time: ");
                var answer2 = Console.ReadLine();
                StringBuilder stringtime = new StringBuilder();
                stringtime.Append("You have indicated you would like to live for at least ");

                try
                {
                    stringtime.Append(intArray[Convert.ToInt32(answer2) - 1]);
                }
                catch (FormatException)
                {
                    goto Error2;
                }
                catch (IndexOutOfRangeException)
                {
                    goto Error2;
                }
                stringtime.Append(" more years. Interesting.");
                Console.WriteLine(stringtime);
                Console.ReadLine();
            }
        QuizAnotherString:
            {
                List<string> stringList = new List<string>
                {
                    "Candy should cheer you up",
                    "Music should cheer you up",
                    "Good times should cheer you up",
                    "Toys should cheer you up",
                    "Honey should cheer you up"
                };
                Console.WriteLine("If you're feeling sad now, pick one last number between 1 and 5 for advice: ");
                var answer3 = Console.ReadLine();
                try
                {
                    Console.WriteLine(stringList[Convert.ToInt32(answer3) - 1]);
                }
                catch (FormatException)
                {
                    goto Error3;
                }
                catch (ArgumentOutOfRangeException)
                {
                    goto Error3;
                }
                Console.ReadLine();
            }
            return;



        Error1:
            {
                Console.WriteLine("NO! You must pick an integer between 1 and 5, inclusive!");
                goto QuizAString;
            }
        Error2:
            {
                Console.WriteLine("NO!! You must pick an integer between 1 and 5, inclusive!");
                goto QuizAnInt;
            }
        Error3:
            {
                Console.WriteLine("NO!!! You must pick an integer between 1 and 5, inclusive!");
                goto QuizAnotherString;
            }
        }
    }
}
