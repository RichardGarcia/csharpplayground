using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Clear all!!!");




            //Call Method with Parameter(s ) / Arguments samples

            Add(2,3);



            Console.WriteLine("Salamat https://www.youtube.com/c/SDPTSolutions!!!");
            Console.ReadKey();

        }

        static void Add(int Num1, int num2) {
            int sum = Num1 + num2;
            Console.WriteLine($"{Num1} + {num2} = {sum}");


            newMethod();

        }




        static void newMethod()
        {
            Console.WriteLine("New Method");
        }


    }





}
