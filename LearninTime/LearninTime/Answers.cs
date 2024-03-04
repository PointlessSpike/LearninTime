using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearninTime
{
    internal class Answers
    {
        public Answers()
        {
            //Output my date of birth to console
            DateTime myDob;

            myDob = new DateTime(1990, 7, 2);

            Console.WriteLine($"My date of birth is {myDob.ToShortDateString()}");

            //Output my age in years to the console
            DateTime currentDateTime;
            TimeSpan myAgeTimeSpan;
            double myAge;

            currentDateTime = DateTime.Now;
            myAgeTimeSpan = currentDateTime - myDob;
            myAge = (myAgeTimeSpan.TotalDays / 365);

            Console.WriteLine($"I am {myAge} years old");

            //The retirement age in the UK is 65. Calculate the maximum length of a mortgage while still paying it off before I retire.
            //Make it an integer!
            int yearsUntilRetirement;

            yearsUntilRetirement = (int)(65 - myAge);

            Console.WriteLine($"I can take out a mortgage of {yearsUntilRetirement} years");
        }
    }
}
