using System;

namespace num5
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1; int count = 1; int num = 1;
            Console.WriteLine("enter the length of the array");
            int length = int.Parse(Console.ReadLine());
            int[]myArray = new int [length];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Enter the element of the array");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <myArray. Length - 1; i++)
            {
                
                
                    if (myArray[i] == myArray[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    if (max < count)
                    {
                        count = max;
                        num = myArray[i];
                    }
                 
                
            }
            for (int k = 1; k <=count; k++)
            {
                Console.WriteLine(num);
            }
        }
    }
}
