using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Lect14.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Neighbor> floorNeighbors = new List<Neighbor>()
            {
                new Neighbor(){FullName = "Ivanov", FlatNumber = 2, PhoneNumber = "375296544554"},
                new Neighbor(){FullName = "Petrov", FlatNumber = 3, PhoneNumber = "375258766748"},
                new Neighbor(){FullName = "Sidorov", FlatNumber = 4, PhoneNumber = "375333145498"}
            };

            Console.Write("Enter flat number, please: ");
            int flatnumber;

            while (!int.TryParse(Console.ReadLine(), out flatnumber))
            {
                Console.Write("Please, enter flat number again: ");
            }

            foreach (var neighbor in floorNeighbors)
            {
                if (neighbor.FlatNumber == flatnumber)
                {
                    Console.WriteLine($"{neighbor.FullName} - {neighbor.PhoneNumber}");
                    break;
                }
            }
        }
    }
}
