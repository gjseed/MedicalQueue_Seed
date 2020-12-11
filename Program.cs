using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalQueue_Seed
{
    class Program
    {
        static void Main(string[] args)
        {
            ERQueue myQueue = new ERQueue(qt);
            Console.WriteLine("Options:");
            Console.WriteLine("(A)dd Patient");
            Console.WriteLine("(P)rocess Current Patient");
            Console.WriteLine("(L)ist All in Queue");
            Console.WriteLine("(Q)uit");
            Console.Write("\r\nSelect an option: ");
            ConsoleKeyInfo Choice = Console.ReadKey();
            if (Choice.Key == ConsoleKey.A)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Enter the name and the priority rank. Separated by a comma.");
                string input = Console.ReadLine();
                string[] partsofQueueItem = input.Split(',');
                Patient queueItem = new Patient(partsofQueueItem[0], Convert.ToInt32(partsofQueueItem[1]));
                myQueue.Add(queueItem);
                Console.Write("Total number of elements in the Queue are : ");
                Console.WriteLine(myQueue.Count);
            }
            else if (Choice.Key == ConsoleKey.P)
            {
                Console.WriteLine("\n");
                Patient queueItem = null;
                myQueue.Remove(queueItem);
            }
            else if (Choice.Key == ConsoleKey.L)
            {
                Console.WriteLine("\n");
                foreach (Patient obj in myQueue)
                {
                    Console.WriteLine(obj);
                }
            }
            else if (Choice.Key == ConsoleKey.Q)
            {
                return;
            }
        }
    }
}
