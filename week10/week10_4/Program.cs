using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> testDictonary =
                new Dictionary<string, double>();

            testDictonary.Add("pi", 3.141592);
            testDictonary.Add("e", 2.71828);
            testDictonary.Add("kong", 2);

            foreach(KeyValuePair<string,double> kvp in testDictonary)
            {
                Console.WriteLine("Key : " + kvp.Key + ", Value : " + kvp.Value);
            }
            Console.WriteLine("Kong : " + testDictonary["kong"]);
        }
    }
}
