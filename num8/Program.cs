using System;

namespace num8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            int length = int.Parse(Console.ReadLine());
            int[] myArray = new int[length];
            for (int i = 0; i <myArray. Length; i++)
            {
                Console.WriteLine("Enter your element of the array");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            int second = 0;
            for (int i = 0; i <myArray. Length; i++)
            {
                for (int j = i + 1; j <myArray. Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        second = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = second;
                    }
                }
                
            }
             Console.WriteLine(myArray[length - 2] + " is secondlength");
            

        }
    }
}
