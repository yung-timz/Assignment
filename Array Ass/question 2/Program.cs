using System;

namespace question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of 1 array: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr1 = new int[length];

            for (int a = 0; a < arr1.Length; a++)
            {
                Console.WriteLine("enter element {0} ", a);
                arr1[a] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("enter the lenght of 2 array");

            string arraySum = " ";

            if (length != int.Parse(Console.ReadLine())) Console.WriteLine("Arrays have different lengths.");
            else
            {
                int[] arr2 = new int[length];

                for (int b = 0; b < arr2.Length; b++)
                {
                    Console.WriteLine("enter element {0}: ", b);
                    arr2[b] = int.Parse(Console.ReadLine());
                }

                for (int b = 0; b < arr2.Length; b++)
                {
                    
                    if (arr1[b] != arr2[b])
                    {
                        Console.WriteLine("\nArrays are different.");
                        arraySum = "false";
                        break;
                    }
                }

                Console.WriteLine("\nArrays are the same.");
            }

        }
    }
}
