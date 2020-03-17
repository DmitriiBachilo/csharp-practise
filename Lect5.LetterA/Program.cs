using System;

namespace Lect5.LetterA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a message: ");
            string str = Console.ReadLine();
            int count = 0;
            foreach (char ch in str)
            {
                if (ch == 'a')
                {
                    count++;
                }
            }

            Console.WriteLine("Количество букв 'а' в данном слове: " + count);
            Console.ReadKey();
        }
    }
}
