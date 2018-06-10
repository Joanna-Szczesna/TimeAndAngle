using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTimeAndAngle.Models
{
    public class Model
    {
        private static bool IsUserInputValid(String userTimeInput)
        {
            if (userTimeInput.IndexOf(':') != -1)
            {
                string[] words = userTimeInput.Split(':');
                if (words.Length == 2)
                {
                    int hours = 0;
                    int minutes = 0;
                    if (Int32.TryParse(words[0], out hours) && (Int32.TryParse(words[1], out minutes)))
                    {
                        if (hours <= 24 && hours >= 0 && minutes >= 0 & minutes <= 60)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static string CountAngle(String userTimeInput)
        {
            if (!IsUserInputValid(userTimeInput))
            {
                return "Podano nieprawidłową wartość";
            }

            string[] words = userTimeInput.Split(':');

            int hours = 0;
            int minutes = 0;
            int angle = 0;

            if (Int32.TryParse(words[0], out hours) && (Int32.TryParse(words[1], out minutes)))
            {
                hours = hours == 24 ? 0 : hours;
                hours = hours >= 12 ? hours -= 12 : hours;
                if ((double)minutes / 5.0 != (double)hours)
                {
                    if (minutes / 5 < hours)
                    {
                        angle = Math.Abs((minutes - hours * 5) * 6);
                    }
                    else
                    {
                        angle = (60 - minutes + hours * 5) * 6;
                    }
                }
            }
            else
            {
                Console.WriteLine("Podano nieprawidłową wartość");
            }
            return angle.ToString();
        }

        private static bool Assert(string input, string expected)
        {
            Console.Write(" " + input + "/" + expected + " ");
            return (input == expected);
        }

        private static bool Assert(bool input, bool expected)
        {
            return (input == expected);
        }

        private static void UserInputTestCases()
        {
            Console.WriteLine("--UserInputTestCases--");
            Console.Write("Case: 09:00 Result:"); Console.WriteLine(Assert(IsUserInputValid("09:00"), true));
            Console.Write("Case: 09:00:20 Result:"); Console.WriteLine(Assert(IsUserInputValid("09:00:20"), false));
            Console.Write("Case: 09 Result:"); Console.WriteLine(Assert(IsUserInputValid("09"), false));
            Console.Write("Case: 25:01 Result:"); Console.WriteLine(Assert(IsUserInputValid("25:01"), false));
            Console.Write("Case: 16:61 Result:"); Console.WriteLine(Assert(IsUserInputValid("16:61"), false));
            Console.Write("Case: -16:00 Result:"); Console.WriteLine(Assert(IsUserInputValid("-16:00"), false));
            Console.Write("Case: czas Result:"); Console.WriteLine(Assert(IsUserInputValid("czas"), false));
            Console.Write("Case: 12345 Result:"); Console.WriteLine(Assert(IsUserInputValid("12345"), false));
            Console.Write("Case: &#r Result:"); Console.WriteLine(Assert(IsUserInputValid("&#r"), false));
            Console.Write("Case: 8: Result:"); Console.WriteLine(Assert(IsUserInputValid("8:"), false));
            Console.Write("Case: 8:a Result:"); Console.WriteLine(Assert(IsUserInputValid("8:a"), false));
        }

        private static void TimeTestCases()
        {
            Console.WriteLine("--TimeTestCases--");
            Console.Write("Case: 09:00 Result:"); Console.WriteLine(Assert(CountAngle("09:00"), "270")); // 45*6
            Console.Write("Case: 09:15 Result:"); Console.WriteLine(Assert(CountAngle("09:15"), "180")); // 30*6
            Console.Write("Case: 09:30 Result:"); Console.WriteLine(Assert(CountAngle("09:30"), "90"));  // 15*6

            Console.Write("Case: 12:00 Result:"); Console.WriteLine(Assert(CountAngle("12:00"), "0"));   // 0*6
            Console.Write("Case: 12:01 Result:"); Console.WriteLine(Assert(CountAngle("12:01"), "354")); // 59*6
            Console.Write("Case: 12:05 Result:"); Console.WriteLine(Assert(CountAngle("12:05"), "330")); // 55*6
            Console.Write("Case: 12:05 Result:"); Console.WriteLine(Assert(CountAngle("12:15"), "270")); // 45*6
            Console.Write("Case: 12:30 Result:"); Console.WriteLine(Assert(CountAngle("12:30"), "180")); // 30*6
            Console.Write("Case: 12:30 Result:"); Console.WriteLine(Assert(CountAngle("12:45"), "90"));  // 15*6

            Console.Write("Case: 15:00 Result:"); Console.WriteLine(Assert(CountAngle("15:00"), "90"));  // 15*6
            Console.Write("Case: 15:15 Result:"); Console.WriteLine(Assert(CountAngle("15:15"), "0"));   // 0*6
            Console.Write("Case: 15:30 Result:"); Console.WriteLine(Assert(CountAngle("15:30"), "270")); // 45*6
            Console.Write("Case: 15:45 Result:"); Console.WriteLine(Assert(CountAngle("15:45"), "180")); // 30*6

            Console.Write("Case: 18:00 Result:"); Console.WriteLine(Assert(CountAngle("18:00"), "180")); // 30*6
            Console.Write("Case: 18:15 Result:"); Console.WriteLine(Assert(CountAngle("18:15"), "90"));  // 15*6
            Console.Write("Case: 18:30 Result:"); Console.WriteLine(Assert(CountAngle("18:30"), "0"));   // 0*6
            Console.Write("Case: 18:45 Result:"); Console.WriteLine(Assert(CountAngle("18:45"), "270")); // 315*6

            Console.Write("Case: 13:45 Result:"); Console.WriteLine(Assert(CountAngle("13:45"), "120")); // 20*6
            Console.Write("Case: 17:00 Result:"); Console.WriteLine(Assert(CountAngle("17:00"), "150")); // 25*6
            Console.Write("Case: 17:02 Result:"); Console.WriteLine(Assert(CountAngle("17:02"), "138")); // 23*6
            Console.Write("Case: 24:00 Result:"); Console.WriteLine(Assert(CountAngle("24:00"), "0"));   // 0*6
        }
    }
}
