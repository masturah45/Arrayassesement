using System;

namespace num2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of your array");
            int length = int.Parse(Console.ReadLine());
            int[] myArray = new int [length];
            for (int i = 0; i <myArray. Length; i++)
            {
                Console.WriteLine("Enter your element of the array");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            int largest = 0;
            for (int j = 0; j <myArray. Length; j++)
            {
               if(myArray[j] > largest) 
               largest = myArray[j];
            }
            int smallest = 0;
            for (int k = 0; k <myArray. Length; k++)
            {
                if (myArray[k] < smallest)
                {
                    smallest = myArray[k];
                }
            }

            for (int h = smallest; h < largest; h++)
            {
                Console.WriteLine(h);
            }
        }
    }
}
