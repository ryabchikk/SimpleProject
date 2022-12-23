using System;

namespace SimpleProject
{
    public class Program
    {
        public static int MultiplyTwoNumbers(int a, int b)
        {
            int res = a * b;
            return res;    
        }
        
        public static int SumTwoNumbers(int a,int b)
        {
            int res = a + b;
            return res;
        }

        public static int SubtractTwoNumbers(int a, int b)
        {
            int res = a - b;
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
