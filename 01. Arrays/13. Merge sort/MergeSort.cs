using System;

class MergeSort
{
    static void Main()
    {
        short arrayLength = short.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] sortedArray = JoinArrays(MergeArray(array, true), MergeArray(array, false));

        for (int i = 0; i < sortedArray.Length; i++)
        {
            Console.WriteLine(sortedArray[i]);
        }
    }

    static int[] MergeArray(int[] inputArray, bool giveFirstSubarray)
    {
        if (inputArray.Length == 1)
        {
            return inputArray;
        }

        int middle = inputArray.Length / 2;
        int[] outputArray;
        if (giveFirstSubarray)
        {
            outputArray = new int[middle];
            Array.Copy(inputArray, 0, outputArray, 0, middle);
        }
        else
        {
            outputArray = new int[inputArray.Length - middle];
            Array.Copy(inputArray, middle, outputArray, 0, inputArray.Length - middle);
        }

        if (outputArray.Length == 1)
        {
            return outputArray;
        }
        else
        {
            return JoinArrays(MergeArray(outputArray, true), MergeArray(outputArray, false));
        }
    }

    static int[] JoinArrays(int[] firstArray, int[] secondArray)
    {
        int[] outputArray = new int[firstArray.Length + secondArray.Length];
        firstArray.CopyTo(outputArray, 0);
        secondArray.CopyTo(outputArray, firstArray.Length);
        Array.Sort(outputArray);

        //for (int i = 0; i < outputArray.Length; i++)
        //{
        //    if (i / 2 > firstArray.Length - 1)
        //    {
        //        if (secondArray[i / 2] > outputArray[i-1])
        //        {
        //            outputArray[i] = secondArray[i / 2];
        //        }
        //        else
        //        {
        //            int temp = outputArray[i - 1];
        //            outputArray[i - 1] = secondArray[i / 2];
        //            outputArray[i] = temp;
        //        }

        //    }
        //    else if (i / 2 > secondArray.Length - 1)
        //    {
        //        if (firstArray[i / 2] > outputArray[i-1])
        //        {
        //            outputArray[i] = firstArray[i / 2];
        //        }
        //        else
        //        {
        //            int temp = outputArray[i - 1];
        //            outputArray[i - 1] = firstArray[i / 2];
        //            outputArray[i] = temp;
        //        }

        //    }
        //    else if (i % 2 == 0)
        //    {
        //        outputArray[i] = Math.Min(firstArray[i / 2], secondArray[i / 2]);
        //    }
        //    else
        //    {
        //        outputArray[i] = Math.Max(firstArray[i / 2], secondArray[i / 2]);
        //    }
        //}
        return outputArray;
    }
}