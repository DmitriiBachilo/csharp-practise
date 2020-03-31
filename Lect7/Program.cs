using System;

namespace Lect7
{
    class Program
    {
        static void Main(string[] args)
        { 
            Task_1() //Создать пустой массив
            Task_2() // Создать одном массив из трех эл
            Task_3() // Найти мас знач(не испл класс Array)
        }

        static void Task_1()
        {
            string[] array = new string[] {};
        }

        static void Task_2()
        {
            object[] array2 = new Object[3] {32, 'A', "Hello"};
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(array2[i]);
            }
            int val = Convert.ToInt32(array2[0]);
            val += 10;
            array2[0] = val;
            string str = Convert.ToString(array2[2]);
            str += " guys!";
            array2[2] = str;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }
        static void Task_3()
        {
            int[] array3 = new int[13] ;
            Random rand = new Random();
            int max = int.MinValue;
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = rand.Next();
                if (array3[i] > max)
                {
                    max = array3[i];
                }
            }

            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine("Random array element: [{0}] = {1}", i, array3[i]);
            }

        }
    }
}
