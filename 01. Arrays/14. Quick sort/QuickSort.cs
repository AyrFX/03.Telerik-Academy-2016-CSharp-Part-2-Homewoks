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
            if (position == ArrayPositions.left)
            {
                int pivotIndex = (array.Length - 1) / 2;
                int pivotValue = array[pivotIndex];
                List <int> outputValues = new List<int>();
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == pivotIndex)
                    {
                        continue;
                    }
                    if (array[i] < pivotValue)
                    {
                        outputValues.Add(array[i]);
                    }
                }
                int[] outputArray = outputValues.ToArray();
                return JoinArrays(QuickSort(outputArray, ArrayPositions.left), QuickSort(outputArray, ArrayPositions.center), QuickSort(outputArray, ArrayPositions.right));
            }
            else if (position == ArrayPositions.center)
            {
                int pivotIndex = (array.Length - 1) / 2;
                int[] outputArray = new int[1];
                outputArray[0] = array[pivotIndex];
                return outputArray;
            }
            else
            {
                int pivotIndex = (array.Length - 1) / 2;
                int pivotValue = array[pivotIndex];
                List<int> outputValues = new List<int>();
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == pivotIndex)
                    {
                        continue;
                    }
                    if (array[i] >= pivotValue)
                    {
                        outputValues.Add(array[i]);
                    }
                }
                int[] outputArray = outputValues.ToArray();
                return JoinArrays(QuickSort(outputArray, ArrayPositions.left), QuickSort(outputArray, ArrayPositions.center), QuickSort(outputArray, ArrayPositions.right));
            }
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

        int emptyArrays = 0;
        if (leftArray.Length < 1)
        {
            emptyArrays++;
        }
        if (centerArray.Length < 1)
        {
            emptyArrays++;
        }
        if (rightArray.Length < 1)
        {
            emptyArrays++;
        }

        if (emptyArrays == 3)
        {
            return new int[0];
        }
        else if (emptyArrays == 2)
        {
            if (leftArray.Length > 0)
            {
                outputValues.AddRange(leftArray);
            }
            else if (centerArray.Length > 0)
            {
                outputValues.AddRange(centerArray);
            }
            else
            {
                outputValues.AddRange(rightArray);
            }
        }
        else if (emptyArrays == 1)
        {
            if (leftArray.Length < 1)
            {
                if (centerArray[0] < rightArray[0])
                {
                    outputValues.AddRange(centerArray);
                    outputValues.AddRange(rightArray);
                }
                else
                {
                    outputValues.AddRange(rightArray);
                    outputValues.AddRange(centerArray);
                }
            }
            else if (centerArray.Length < 1)
            {
                if (leftArray[0] < rightArray[0])
                {
                    outputValues.AddRange(leftArray);
                    outputValues.AddRange(rightArray);
                }
                else
                {
                    outputValues.AddRange(rightArray);
                    outputValues.AddRange(leftArray);
                }
            }
            else if (rightArray.Length < 1)
            {
                if (leftArray[0] < centerArray[0])
                {
                    outputValues.AddRange(leftArray);
                    outputValues.AddRange(centerArray);
                }
                else
                {
                    outputValues.AddRange(centerArray);
                    outputValues.AddRange(leftArray);
                }
            }
        }
        else
        {
            if (leftArray[0] <= centerArray[0] && leftArray[0] <= rightArray[0])
            {
                outputValues.AddRange(leftArray);
                if (centerArray[0] <= rightArray[0])
                {
                    outputValues.AddRange(centerArray);
                    outputValues.AddRange(rightArray);
                }
                else
                {
                    outputValues.AddRange(rightArray);
                    outputValues.AddRange(centerArray);
                }
            }
            else if (centerArray[0] <= leftArray[0] && centerArray[0] <= rightArray[0])
            {
                outputValues.AddRange(centerArray);
                if (leftArray[0] <= rightArray[0])
                {
                    outputValues.AddRange(leftArray);
                    outputValues.AddRange(rightArray);
                }
                else
                {
                    outputValues.AddRange(rightArray);
                    outputValues.AddRange(leftArray);
                }
            }
            else if (rightArray[0] <= leftArray[0] && rightArray[0] <= centerArray[0])
            {
                outputValues.AddRange(rightArray);
                if (leftArray[0] <= centerArray[0])
                {
                    outputValues.AddRange(leftArray);
                    outputValues.AddRange(centerArray);
                }
                else
                {
                    outputValues.AddRange(centerArray);
                    outputValues.AddRange(leftArray);
                }
            }
        }
        
        return outputValues.ToArray();
    }
}