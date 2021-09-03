using System;

namespace ConsoleApp1
{
    class Program
    {

        // GlobalVariables
        static string GlobalvarName = "Buddy Zabala (Global)";

        static string GlobalvarName222 = "Buddy Zabala (Globalvar name222)";
        static string GlobalvarName333 = "Buddy Zabala (Globalvar name333)";

        static void Main(string[] args)
        {



            
            int numA = 11;


            if (numA == 10)
            {

                

                Console.WriteLine(numA + "is equal to 10");

                Console.WriteLine($"Thid id Global varname ---> GlobalvarName");


            } 
                else 
                {

                Console.WriteLine(numA + "not equal to 10");


                Console.WriteLine(GlobalvarName222);
            }
            

            Console.WriteLine(GlobalvarName);
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


            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());


            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));


            //Faranheieht to Celcius

            float Far = (350 - 32) * 5 / 9;
            //(400°F − 32) × 5 / 9 = 204.444°C

            Console.WriteLine($"400 Deg FAR is { Far} Celcius");




            static void CallingGlobalVar() {

                Console.WriteLine(GlobalvarName222);
                
            }


            static void SayHi() {


                

                Console.WriteLine( "This is from say Hi Method.. :) ");

                Console.WriteLine($"This is Global varible name inside SayhiMethod -->  {GlobalvarName}");



                Console.WriteLine(GlobalvarName222);

                Console.WriteLine(GlobalvarName333);
            }


            SayHi();


            Console.WriteLine($"This is Global varible name -->  {GlobalvarName}");

            Console.ReadKey();

        }
    }
}
