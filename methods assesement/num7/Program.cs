using System;

namespace num7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            string number = Console.ReadLine();
            Console.WriteLine(Reverse(number));
        }
        public static string Reverse(String number)
        {
            char[] chararray = number.ToCharArray();
            Array.Reverse(chararray);
            return new string (chararray);
        }
    }
}
