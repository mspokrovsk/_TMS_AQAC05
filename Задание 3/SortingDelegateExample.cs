using System;

namespace Задание_3
{
    public enum SortingType
    {
        BubbleSort,
        QuickSort
    }

    public delegate int[] SortingDelegate(int[] inputArray);

}
