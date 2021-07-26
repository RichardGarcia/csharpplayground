using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("second commit");
            


            String StringVariable01 = "Buddy Zabala";
            Console.WriteLine(StringVariable01);


            Console.WriteLine($" String interpolation?? -->  { StringVariable01}");


            string name = "Markus";
            var date = DateTime.Now;

            // Composite formatting:
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
            // String interpolation:
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
            // Both calls produce the same output that is similar to:
            // Hello, Mark! Today is Wednesday, it's 19:40 now.


            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            Console.ReadKey();

        }
    }
}
