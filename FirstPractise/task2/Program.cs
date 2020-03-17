using System;
using System.Collections;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            //object
            arrayList.Add(45); //true - box
            arrayList.Add(true); //true - box
            arrayList.Add("Hello!"); //false
            arrayList.Add(23.45); //true - box
        }
    }
}
