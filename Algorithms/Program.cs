using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Sorting
    {
        static Array Bubblesort(int[] args)
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
        static Array Insertionsort(int[] args)
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
    }
}
