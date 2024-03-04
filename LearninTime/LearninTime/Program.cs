//Output my date of birth to console
using System.Timers;

DateTime myDob;

//Your code here


Console.WriteLine($"My date of birth is {myDob.ToShortDateString()}");

//Output my age in years to the console
DateTime currentDateTime;
TimeSpan myAgeTimeSpan;
double myAge;

//Your code here


Console.WriteLine($"I am {myAge} years old");

//The retirement age in the UK is 65. Calculate the maximum length of a mortgage while still paying it off before I retire.
//Make it an integer!
int yearsUntilRetirement;

//Your code here


Console.WriteLine($"I can take out a mortgage of {yearsUntilRetirement} years");



void TimerElapsed(object sender, ElapsedEventArgs e)
{
    Console.WriteLine("Timer expired!");
}

// Set the timer for 5 seconds
double timerDuration = 5000; // milliseconds
Console.WriteLine($"Timer set for {timerDuration / 1000} seconds.");

// Create a new timer instance
Timer timer = new Timer(timerDuration);

// Subscribe to the Elapsed event
timer.Elapsed += TimerElapsed;

// Start the timer
timer.Start();

// Perform some other tasks while waiting for the timer to expire
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Task {i + 1} in progress...");
    System.Threading.Thread.Sleep(1000); // Sleep for 1 second
}

// Dispose the timer
timer.Dispose();
Console.WriteLine("Timer disposed.");