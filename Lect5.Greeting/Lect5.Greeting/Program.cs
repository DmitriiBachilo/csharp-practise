using System;

namespace Lect5.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.TimeOfDay.Hours;

            if (hour > 9 && hour < 12)
            {
                Console.WriteLine("Good morning, guys");
            }
            if (hour > 12 && hour < 15)
            {
                Console.WriteLine("Good day, guys");
            }
            if (hour > 9 && hour < 22)
            {
                Console.WriteLine("Good evening, guys");
            }

            Console.WriteLine(DateTime.Now.TimeOfDay);
            Console.ReadKey();
        }
    }
}
