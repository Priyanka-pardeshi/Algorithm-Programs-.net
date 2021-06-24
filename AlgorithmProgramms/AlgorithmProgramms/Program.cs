using System;

namespace AlgorithmProgramms
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Algorithms algorithms = new Algorithms();
            int[] inputInsertionSort = { 2, 4, 3, 18, 5 };
            //Insertion sort
            //worst case seanario for insertion sort is if we give input in revser order
            algorithms.InsertionSort(inputInsertionSort);

            //selection sort
            algorithms.selectionSort(inputInsertionSort);
            int[] temp=algorithms.quickSort(inputInsertionSort,0,inputInsertionSort.Length-1);
           
            Console.WriteLine("soreted using Quick sort");
            algorithms.PrintArray(temp);

            //Prime Number
            algorithms.PrimeNumber();
            Console.ReadKey();
        }
    }
}
