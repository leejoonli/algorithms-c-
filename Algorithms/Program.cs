using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Sorting
    {
        static int[] Bubblesort(int[] args)
        {
            // initialize swapped as true
            bool init = true;

            // while loop
            while(init)
            {
                // swapped becomes false (innocent until proven guilty) because you haven't made a swap yet
                init = false;
                // iterate across data
                for(int i = 0; i < args.Length; i++)
                {
                    // conditional for if numbers need to be swapped
                    if (args[i] > args[i+1])
                    {
                        // swap the items
                        // need a temporary variable to store values for swapping
                        int temp = args[i];
                        args[i] = args[i + 1];
                        args[i + 1] = temp;
                        init = true;
                    }
                }
            }
            return args;
        }
        static int[] Insertionsort(int[] args)
        {
            // iterate across data
            for(int i = 0; i < args.Length; i++)
            {
                // need the current element to sort
                int current = args[i];
                // index of the last element of the 'sorted array' (sorted sub array)
                int j = i - 1;
                // while j is in bound of the array and the current element ot sort is less than the last item in the sorted sub array
                while(j> -1 && current < args[j])
                {
                    // iterate down until current is greater than args[j]
                    args[j + 1] = args[j];
                    j--;
                }
                // add current to the end of the sorted array
                args[j + 1] = current;
            }
            // return sorted array
            return args;
        }
        static int[] Quicksort(int[] args)
        {
            // base case: the array has one element or less
            if(args.Length <= 1)
            {
                return args;
            }
            // create the pivot, and take it out of the array (pivot is the element at the end of the array)
            // not sure if this works and currently don't know how to run this code in the terminal
            int pivot = args[args.Length - 1];
            args = args.Take(args.Length - 1).ToArray();
            // create the left partition, contains every element less than the value of pivot
            int[] left = Array.FindAll(args, i => i < pivot);
            // create the right partition, contains every element greater than the value of pivot
            int[] right = Array.FindAll(args, i => i > pivot);
            // return a new array, made up of recursively calling the quick sort with the left partition, followed by the pivot, followed by the quick sort of the right partition
            int[] final = Quicksort(left);
            int[] final_two = Quicksort(right);
            int[] recursive_final = new int[final.Length + final_two.Length + 1];
            for(int i = 0; i < final.Length; i++)
            {
                recursive_final.Append(final[i]);
            }
            recursive_final.Append(pivot);
            for(int i = 0; i < final_two.Length; i++)
            {
                recursive_final.Append(final_two[i]);
            }
            return recursive_final;
        }
    }
}
