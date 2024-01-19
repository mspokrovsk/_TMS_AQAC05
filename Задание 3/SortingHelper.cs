using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Задание_3
{
    public class SortingHelper
    {
        public static SortingDelegate GetSortingDelegate(SortingType sortingType) //метод, который возвращает SortingDelegate
        {
        switch (sortingType)
            {
            case SortingType.BubbleSort:
                return BubbleSort;
            case SortingType.QuickSort:
                return QuickSort;
            default:
                throw new ArgumentException("Invalid sorting type");
            }
        }

    public static int[] BubbleSort(int[] inputArray)
        {
            // Реализация алгоритма сортировки пузырьком
            int n = inputArray.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        // меняем элементы местами
                        int temp = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = temp;
                    }
                }
            }
            return inputArray;
        }

    public static int[] QuickSort(int[] inputArray)
        {
            QuickSort(inputArray, 0, inputArray.Length - 1);
            return inputArray;
        }

        public static void QuickSort(int[] inputArray, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(inputArray, left, right);
                QuickSort(inputArray, left, pivot - 1);
                QuickSort(inputArray, pivot + 1, right);
            }
        }

        internal static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
