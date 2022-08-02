using System;

namespace question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Length Of The Array.");
            int num = int.Parse(Console.ReadLine());
            int [] myArray = new int[num];
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Enter The Element Of The Array.");
                myArray[i] =  int.Parse(Console.ReadLine());
            }
            int swap = 0;
            for(int i = 0; i < myArray.Length; i++)
            {
                for(int j = i + 1; j < myArray.Length; j++)
                {
                    if(myArray[i] < myArray[j])
                    {
                        swap = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = swap;
                    }
                }
            }
            Console.WriteLine($"The Largest Number Is, {myArray[0]}");
            Console.WriteLine($"The Smallest Number Is, {myArray[myArray.Length - 1]}");
        }
    }
}
