using System;
using System.Collections.Generic;

class QuickSortAlgorithm
{
    enum ArrayPositions {left, center, right};

    static void Main()
    {
        short arrayLength = short.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] sortedArray = JoinArrays(QuickSort(array, ArrayPositions.left), QuickSort(array, ArrayPositions.center), QuickSort(array, ArrayPositions.right));
        for (int i = 0; i < sortedArray.Length; i++)
        {
            Console.WriteLine(sortedArray[i]);
        }
    }

    static int[] QuickSort(int[] array, ArrayPositions position)
    {
        if (array.Length == 0)
        {
            return array;
        }
        if (array.Length == 1)
        {
            if (position == ArrayPositions.center)
            {
                return array;
            }
            else
            {
                return new int[0];
            }
        }
        else if (array.Length == 2)
        {
            if (position == ArrayPositions.center)
            {
                if (array[0] > array[1])
                {
                    SwapElements(array, 0, 1);
                }
                return array;
            }
            else
            {
                return new int[0];
            }
        }
        else
        {
            int pivotValue = array[0];
            List<int> leftOutputValues = new List<int>();
            List<int> centerOutputValues = new List<int>();
            List<int> rightOutputValues = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < pivotValue)
                {
                    leftOutputValues.Add(array[i]);
                }
                else if (array[i] == pivotValue)
                {
                    centerOutputValues.Add(array[i]);
                }
                else if (array[i] > pivotValue)
                {
                    rightOutputValues.Add(array[i]);
                }
            }

            int[] outputArray = new int[0];
            if (position == ArrayPositions.left)
            {
                outputArray = leftOutputValues.ToArray();
            }
            else if (position == ArrayPositions.center)
            {
                outputArray = centerOutputValues.ToArray();
                return outputArray;
            }
            else if (position == ArrayPositions.right)
            {
                outputArray = rightOutputValues.ToArray();
            }

            return JoinArrays(QuickSort(outputArray, ArrayPositions.left), QuickSort(outputArray, ArrayPositions.center), QuickSort(outputArray, ArrayPositions.right));
        }
    }

    static void SwapElements(int[] array, int firstIndex, int secondIndex)
    {
        int temp = array[firstIndex];
        array[firstIndex] = array[secondIndex];
        array[secondIndex] = temp;
    }

    static int[] JoinArrays(int[] leftArray, int[] centerArray, int[] rightArray)
    {
        List<int> outputValues = new List<int>();
        outputValues.AddRange(leftArray);
        outputValues.AddRange(centerArray);
        outputValues.AddRange(rightArray);

        return outputValues.ToArray();
    }
}