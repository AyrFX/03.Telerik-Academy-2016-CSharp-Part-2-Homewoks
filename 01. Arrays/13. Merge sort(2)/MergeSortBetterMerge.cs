using System;

class MergeSortAlgorithm
{
    enum ArrayPositions { left, center, right };

    static void Main()
    {
        short arrayLength = short.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] sortedArray = JoinArrays(MergeSort(array, ArrayPositions.left), MergeSort(array, ArrayPositions.center), MergeSort(array, ArrayPositions.right));
        for (int i = 0; i < sortedArray.Length; i++)
        {
            Console.WriteLine(sortedArray[i]);
        }

        //int[] a = getSubarray(array, ArrayPositions.right);
        //for (int i = 0; i < a.Length; i++)
        //{
        //    Console.Write(a[i] + " ");
        //}
        //Console.WriteLine();
        //int[] a = new int[1] { 1 };
        //int[] b = new int[1] { 2 };
        //int[] c = new int[1] { 3 };
        //int[] result = JoinArrays(a, b, c);
        //for (int i = 0; i < result.Length; i++)
        //{
        //    Console.Write(result[i] + " ");
        //}
        //Console.WriteLine();
    }

    static int[] MergeSort(int[] array, ArrayPositions position)
    {
        if (array.Length == 1)
        {
            if (position == ArrayPositions.left)
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
            if (position == ArrayPositions.left)
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
                int leftEndIndex = (array.Length - 1) / 2;
                int[] outputArray = new int[leftEndIndex];
                int outputArrayLength = leftEndIndex;
                Array.Copy(array, 0, outputArray, 0, outputArrayLength);
                return JoinArrays(MergeSort(outputArray, ArrayPositions.left), MergeSort(outputArray, ArrayPositions.center), MergeSort(outputArray, ArrayPositions.right));
                //return outputArray;
            }
            else if (position == ArrayPositions.center)
            {
                int centerIndex = (array.Length - 1) / 2;
                int[] outputArray = new int[1];
                outputArray[0] = array[centerIndex];
                return JoinArrays(MergeSort(outputArray, ArrayPositions.left), MergeSort(outputArray, ArrayPositions.center), MergeSort(outputArray, ArrayPositions.right));
                //return outputArray;
            }
            else
            {
                int rightStartIndex = ((array.Length - 1) / 2) + 1;
                int outputArrayLength = array.Length - rightStartIndex;
                int[] outputArray = new int[outputArrayLength];
                Array.Copy(array, rightStartIndex, outputArray, 0, outputArrayLength);
                return JoinArrays(MergeSort(outputArray, ArrayPositions.left), MergeSort(outputArray, ArrayPositions.center), MergeSort(outputArray, ArrayPositions.right));
                //return outputArray;
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
        int[] outputArray = new int[leftArray.Length + centerArray.Length + rightArray.Length];
        if (leftArray.Length > 0)
        {
            Array.Copy(leftArray, 0, outputArray, 0, leftArray.Length);
        }
        if (centerArray.Length > 0)
        {
            Array.Copy(centerArray, 0, outputArray, leftArray.Length, leftArray.Length);
        }
        if (rightArray.Length > 0)
        {
            Array.Copy(rightArray, 0, outputArray, leftArray.Length + centerArray.Length, leftArray.Length);
        }
        return outputArray;
    }
}