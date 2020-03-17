using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            short sValue = 1;
            object obj = sValue;
            System.SByte result = (System.SByte)(short)obj;

            Console.WriteLine(result);
            Console.WriteLine(result.GetType());
            Console.ReadKey();
        }
    }
}
