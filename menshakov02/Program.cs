using System;

namespace menshakov02
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = CreateArray(20, -200, 200);
            Console.WriteLine($"Numbers from first array: {string.Join(", ", firstArray)}");
            var firstTaskResult = DoTaskOne(firstArray);
            Console.WriteLine($"Amount of numbers between -100 and 100 is {firstTaskResult}\n\n");

            var secondArray = CreateArray(20, -2000, 2000);
            Console.WriteLine($"Numbers from second array: {string.Join(", ", secondArray)}");
            var secondTaskResult = DoTaskTwo(secondArray);
            Console.WriteLine($"Numbers from second array which are less than 888: {string.Join(", ", secondTaskResult)}");
            DoTaskTwo(secondArray);
        }

        static int DoTaskOne(int[] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item >= -100 && item <=100)
                {
                    count++;
                }
            }
            return count;
        }

        static int[] DoTaskTwo(int[] array)
        {
            int size = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 888)
                {
                    size++;
                }
            }

            var resultArray = new int[size];

            for (int i = 0, j = 0; j < resultArray.Length; i++)
            {
                if (array[i] <= 888)
                {
                    resultArray[j++] = array[i];
                }
            }

            return resultArray;
        }

        static int[] CreateArray(int size, int lowerBound, int upperBound)
        {
            var array = new int[size];
            var randomNumber = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = randomNumber.Next(lowerBound,upperBound);
            }
            return array;
        }
    }
}