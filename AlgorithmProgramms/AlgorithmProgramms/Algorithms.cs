using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProgramms
{
    class Algorithms
    {
        /// <summary>
        /// Performing an insertion sort-
        /// </summary>
        /// <param name="insertionList"> taking list as an parameter</param>
        public void InsertionSort(int[] insertionList)
        {
            int j, temp;
            for (int i = 1; i <= insertionList.Length - 1; i++)
            {
                temp = insertionList[i];
                j = i - 1;
                while (j >= 0 && insertionList[j] > temp)
                {
                    insertionList[j + 1] = insertionList[j];   //swap
                    j--;
                }
                insertionList[j + 1] = temp;
            }
            Console.WriteLine("List is sorted by Insertion sort");
            PrintArray(insertionList);
        }

        /// <summary>
        /// Selection Sort-assume first number is min and compare with remaning number, left hand side will sorted --after that list will be sorted
        /// </summary>
        /// <param name="selectionList"></param>
        public void selectionSort(int[] selectionList)
        {
            int i, j, min,temp;  //initiall minin index will be zero

            for (i = 0; i < selectionList.Length; i++)
            {
                //At first min value will be first value
                min = i;                   
                for (j = 0; j < selectionList.Length; j++)     
                {
                    if (selectionList[j]>selectionList[min])
                    {
                        min = j;
                        //swapped values if we found new min number
                        temp = selectionList[i]; 
                        selectionList[i] = selectionList[min];
                        selectionList[min] = temp;
                    }

                }
            }
            Console.WriteLine("List is sorted by Selection sort");
            PrintArray(selectionList);
        }

        /// <summary>
        /// Quick sort--In this method we consider last element as pivot and compare with other elements.
        /// </summary>
        /// <param name="quickList"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public int[] quickSort(int[] quickList,int start,int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(quickList, start, end);

                quickSort(quickList,start,i-1);
                quickSort(quickList, i + 1, end);
            }
           
            return quickList;
        }
        public int Partition(int[] quickList, int start, int end)
        {
            int temp;
            int pivot = quickList[end];

            int i = start - 1;

            for (int j = start; j <= end-1; j++)
            {
                if (quickList[j] <= pivot)
                {
                    i++;
                    temp = quickList[i];
                    quickList[i] = quickList[j];
                    quickList[j] = temp;
                }
            }
            temp = quickList[i + 1];
            quickList[i + 1] = quickList[end];
            quickList[end] = temp;

            return i+1;
           
        }



        public void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }



      
        
    }
}
