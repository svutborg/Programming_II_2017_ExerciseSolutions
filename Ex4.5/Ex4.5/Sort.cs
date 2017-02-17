using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._5
{
    /// <summary>
    /// Bouble sort will iterate through the array N times where N is the number of elements in the array
    /// Each runthrough it will swap neightbours if they are in the wrong order
    /// </summary>
    static class Sort
    {
        public static void BoubleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {   // Outer loop
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {   // inner loop 
                    if (arr[j] > arr[j + 1])
                    {   // if the two neighbours are in the wrong order, swap them
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Selection sort will search through the array and move the lowest number to the beginnning of the array.
        /// Each iteration of the search a one element smaller array, since the prevoius search found the lowest number
        /// </summary>
        /// <param name="arr">The array to be sorted</param>
        public static void SelectionSort(int[] arr)
        {
            int min, temp;

            for (int i = 0; i < arr.Length; i++)
            {   // iterate through the array N times, where N is the number of elements in the array
                min = i; // Select the first element as the smallest one
                for (int j = i + 1; j < arr.Length; j++)
                {   // search every other element in the array and if a smaller one is found, select that one
                    if(arr[j]<arr[min])
                    {
                        min = j;
                    }
                }
                if(min != i)
                {   // Move the smallest element to the beginning of the array
                    temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            }
        }

        /// <summary>
        /// Quick Sort will deplay a divide and conquer strategy, by selecting a pivit number
        /// everything larger that that pivot number will be moved after it and everything smaller 
        /// ill be moved before in the array.
        /// It will then call it self recursively with the array fragments before and after the pivot number respectevely.
        /// </summary>
        /// <param name="arr">The array that needs sorting.</param>
        /// <param name="startIndex">Optional starting index. If nothing is provided, it will sort from the beginnning.</param>
        /// <param name="stopIndex">Optional stop index. If nothing is proveded, it will sort until the end of the array.</param>
        public static void QuickSort(int[] arr, int startIndex = 0, int stopIndex = 0)
        {
            int i, temp;
            int pivotIndex = startIndex; // Choose the pivot number as the first element in the array
            if (stopIndex == 0)
            {
                stopIndex = arr.Length - 1; // If the stop index was 0, this means that the entire array should be sorted
            }
            i = stopIndex; // Set token to keep track of the lasy un examined number in the array

            while (pivotIndex < i) // let pivot index and i converge until all numbers in the array has been examined
            {
                if (arr[i] < arr[pivotIndex]) // If the examined number is smaller than the pivot number it is moved to the lower end of the array
                {
                    temp = arr[i];
                    arr[i] = arr[pivotIndex + 1];
                    arr[pivotIndex + 1] = arr[pivotIndex];
                    arr[pivotIndex] = temp;
                    pivotIndex++;
                }
                else
                {
                    i--;
                }
            }

            if (pivotIndex - 1> startIndex) // if there is more to be sorted before the pivot, call it self with the lower end of the array
            {
                QuickSort(arr, startIndex, pivotIndex - 1);
            }
            if(pivotIndex + 1 < stopIndex) // if there is more to be sorted after the pivot, call it self with the upper end of the array
            {
                QuickSort(arr, pivotIndex + 1, stopIndex);
            }
        }
    }
}
