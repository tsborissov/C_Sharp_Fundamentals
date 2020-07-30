using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] inputArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split().ToArray();

                switch (command[0])
                {
                    case "exchange": 
                        SplitAndExchangeArray(inputArray, int.Parse(command[1]));
                        break;

                    case "max":
                        int maxIndex = MaxEvenOddElement(inputArray, command[1]);

                        if (maxIndex != -1)
                        {
                            Console.WriteLine(maxIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }

                        break;

                    case "min":
                        int minIndex = MinEvenOddElement(inputArray, command[1]);

                        if (minIndex != -1)
                        {
                            Console.WriteLine(minIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }

                        break;

                    case "first": FirstEvenOddElelments(inputArray, int.Parse(command[1]), command[2]); break;

                    case "last": LastEvenOddElelments(inputArray, int.Parse(command[1]), command[2]); break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", inputArray)}]");
        }

        static void SplitAndExchangeArray(int[] array, int splitIndex)
        {
            if (splitIndex > array.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            // array -> 1 3 5 7 9
            // exchange 1
            // firstArray -> 5 7 9
            // secondArray -> 1 3
            // array -> 5 7 9 1 3

            int[] firstArray = new int[array.Length - splitIndex - 1];
            int[] secondArray = new int[splitIndex + 1];

            int firstArrayCounter = 0;
            for (int i = splitIndex + 1; i < array.Length; i++)
            {
                firstArray[firstArrayCounter] = array[i];
                firstArrayCounter++;
            }

            for (int i = 0; i <= splitIndex; i++)
            {
                secondArray[i] = array[i];
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                array[i] = firstArray[i];
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                array[firstArray.Length + i] = secondArray[i];
            }


            //int[] tempArray = new int[array.Length];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    int tempIndex = array.Length - 1 - splitIndex + i;

            //    if (tempIndex > array.Length - 1)
            //    {
            //        tempIndex -= array.Length;
            //    }

            //    tempArray[tempIndex] = array[i];
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = tempArray[i];
            //}

        }

        static int MaxEvenOddElement(int[] array, string oddEven)
        {
            int maxElementIndex = -1;
            int maxElementValue = int.MinValue;

            if (oddEven == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] >= maxElementValue)
                    {
                        maxElementIndex = i;
                        maxElementValue = array[i];
                    }
                }
            }
            else if (oddEven == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && array[i] >= maxElementValue)
                    {
                        maxElementIndex = i;
                        maxElementValue = array[i];
                    }
                }
            }

            return maxElementIndex;
        }

        static int MinEvenOddElement(int[] array, string oddEven)
        {
            int minElementIndex = -1;
            int minElementValue = int.MaxValue;

            if (oddEven == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] <= minElementValue)
                    {
                        minElementIndex = i;
                        minElementValue = array[i];
                    }
                }
            }
            else if (oddEven == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && array[i] <= minElementValue)
                    {
                        minElementIndex = i;
                        minElementValue = array[i];
                    }
                }
            }

            return minElementIndex;
        }

        static void FirstEvenOddElelments (int[] array, int numberOfElements, string evenOdd)
        {
            if (numberOfElements > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int elementsCounter = 0;
            string numbers = string.Empty;

            if (evenOdd == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        numbers += array[i] + " ";
                        elementsCounter++;

                        if (elementsCounter == numberOfElements)
                        {
                            break;
                        }
                    }
                }
            }
            else if (evenOdd == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        numbers += array[i] + " ";
                        elementsCounter++;

                        if (elementsCounter == numberOfElements)
                        {
                            break;
                        }
                    }
                }
            }

            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (elementsCounter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }

        static void LastEvenOddElelments(int[] array, int numberOfElements, string evenOdd)
        {

            if (numberOfElements > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int elementsCounter = 0;
            string numbers = string.Empty;

            if (evenOdd == "even")
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 == 0)
                    {
                        numbers += array[i] + " ";
                        elementsCounter++;

                        if (elementsCounter == numberOfElements)
                        {
                            break;
                        }
                    }
                }
            }
            else if (evenOdd == "odd")
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 != 0)
                    {
                        numbers += array[i] + " ";
                        elementsCounter++;

                        if (elementsCounter == numberOfElements)
                        {
                            break;
                        }
                    }
                }
            }

            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse();

            if (elementsCounter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }

        }
    }
}
