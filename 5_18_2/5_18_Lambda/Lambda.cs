// See https://aka.ms/new-console-template for more information
using System.Data;

namespace _Chap08__Lambda
{
    class Program {
        //delegate int MyOperation(int p1, string p2);
        //static void Main(string[] args)
        //{
        //    MyOperation op1 = delegate (int a, string s)
        //    {
        //        return a + int.Parse(s);
        //    };
        //    MyOperation op2 = (int a, string s) =>
        //    {
        //        return a + int.Parse(s) * 2;
        //    };
        //    MyOperation op3 = (a, s) =>
        //    {
        //        return a + int.Parse(s) * 3;
        //    };
        static void Main(string[] args)
        {
            Task t1 = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("print Async");
            });
            Console.WriteLine("print Sync");
            t1.Wait();
            Console.WriteLine("Main end");
        }
    }
}