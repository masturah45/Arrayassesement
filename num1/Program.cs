using System;

namespace num1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the first array");
            int length = int.Parse(Console.ReadLine());
            int[] myArray = new int [length];
            for (int i = 0; i <myArray. Length; i++)
            {
                Console.WriteLine("Enter the first number of the array");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <myArray. Length; i++)
            {
                Console.WriteLine("Enter the second number of the array");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <myArray. Length; i++)
            {
               bool iscounted = false;
               for (int j = i + 1; j <myArray. Length; j++)
               {
                    if (myArray[i] == myArray[j])
                    {
                        iscounted = true;
                        break;
                    }
               }
               int currentlength = 0;
               if (!iscounted)
               {
                    for (int k = 0; k <myArray. Length; k++)
                    {
                        if (myArray[i] == myArray[k])
                        {
                           currentlength++; 
                        }
                    }
               }
               Console.WriteLine(myArray[i] + " occurs " + currentlength + " times " );
            }
            

                
                    
                
            
        }
    }
}
