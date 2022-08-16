using System;

namespace num8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Reverse(num));
        }
        public static string Reverse(string num)
        {
            char[] charArray = num.TocharArray();
            Array.Reverse (chararray);
            return new string(chararray);
            if (Reverse == num)
            {
               Console.WriteLine("it is the same");
            }
            else if(Reverse =! num)
            {
                Console.WriteLine("it is not the same");
            }
        }
    }
}
