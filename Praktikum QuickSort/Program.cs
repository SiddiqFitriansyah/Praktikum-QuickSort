using System;

namespace Praktikum_QuickSort
{
    class Program
    {
        //Array of integer to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; //Number of compression
        private int new_count = 0; // Number of data movements

        //Number of elements in Array
        private int n;


        void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the Array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can be have maximum 20 elements \n");
            }
            Console.WriteLine("\n======================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n======================");

            //Get Array elements 
            for(int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        
        

    }
}
