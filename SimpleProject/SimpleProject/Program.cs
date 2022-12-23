using System;

namespace SimpleProject
{
    class Program
    {
        static public int MultiplyTwoNumbers(int a, int b)
        {
            int res = a * b;
            return res;    
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello EPTA!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(MultiplyTwoNumbers(a, b));
        }
    }
}
