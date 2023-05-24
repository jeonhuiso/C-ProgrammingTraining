using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections;
namespace week10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("world");
            myAL.Add("!");

            Console.WriteLine("Count:   {0}", myAL.Count);
            Console.WriteLine("Capacity {0}", myAL.Capacity);
            Console.Write("Values: ");
            PrintValues(myAL);

        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
            {
                Console.Write(" {0}", obj);
            }
            Console.WriteLine();
        }
    }
}
