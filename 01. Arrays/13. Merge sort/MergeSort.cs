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

        int firstArrayCurrentIndex = 0, secondArrayCurrentIndex = 0, outputArrayCounter = 0;
        while (outputArrayCounter < outputArray.Length)
        {
            if (firstArrayCurrentIndex >= firstArray.Length)
            {
                outputArray[outputArrayCounter] = secondArray[secondArrayCurrentIndex];
                secondArrayCurrentIndex++;
            }
            else if (secondArrayCurrentIndex >= secondArray.Length)
            {
                outputArray[outputArrayCounter] = firstArray[firstArrayCurrentIndex];
                firstArrayCurrentIndex++;
            }
            else
            {
                if (firstArray[firstArrayCurrentIndex] < secondArray[secondArrayCurrentIndex])
                {
                    outputArray[outputArrayCounter] = firstArray[firstArrayCurrentIndex];
                    firstArrayCurrentIndex++;
                }
                else
                {
                    outputArray[outputArrayCounter] = secondArray[secondArrayCurrentIndex];
                    secondArrayCurrentIndex++;
                }
            }
            outputArrayCounter++;
        }
        return outputArray;
    }
}