using System;

namespace Praktikum_QuickSort
{
    class Program
    {
        //Array of integer to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; //Number of compression
        private int mov_count = 0; // Number of data movements

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
        //Swaps the element at index x with the element at index y

        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;

            //Partition the list into two parts:
            //One containing elements less that or equal to pivot
            //Other containing elements greater than pivot

            i = low + 1;
            j = high + 1;

            pivot = arr[low];

            while (i <= j)
            {
                //Search for an element greater than pivot 
                while ((arr[i] <= pivot) && (j >= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                //Search for an element less than or equal to pivot
                while ((arr[i] > pivot) && (j >= low))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;

                if (i < j) //If the greater  element is on the left of the element
                {

                    //Swap the element at index i whit the element at index j
                    swap(i, j);
                    mov_count++;
                }
            }
            //j now contains the index of the last element in the sorted list

            if (low < j)
            {
                //Move the pivot to its correct position in the list
                swap(low, j);
                mov_count++;
            }
            //Sort the list on the left of pivot using quick sort
            q_sort(low, j - 1);

            //Sort the list on the right of pivot using quick sort
            q_sort(j + 1, high);
        }
        void display()
        {
            Console.WriteLine("\n----------------------");
            Console.WriteLine("Sorted Array Elements");
            Console.WriteLine("------------------------");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("\nNumber of comparisons: " + cmp_count);
            Console.WriteLine("\nNumber of data movements: " + mov_count);

        }
    }
}
