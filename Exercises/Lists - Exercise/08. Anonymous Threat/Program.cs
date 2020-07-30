using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> inputList = Console.ReadLine().Split().ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] commandWithParams = input.Split().ToArray();

                string command = commandWithParams[0];

                switch (command)
                {
                    case "merge":
                        int startIndex = int.Parse(commandWithParams[1]);
                        int endIndex = int.Parse(commandWithParams[2]);

                        MergeList(inputList, startIndex, endIndex);

                        break;


                    case "divide":
                        int index = int.Parse(commandWithParams[1]);
                        int partitions = int.Parse(commandWithParams[2]);

                        DivideElement(inputList, index, partitions);

                        break;
                }
            }

            Console.WriteLine(string.Join(" ", inputList));
        }

        static void MergeList(List<string> inputList, int startIndex, int endIndex)
        {
            string mergedElemens = string.Empty;

            if (startIndex < 0)
            {
                startIndex = 0;
            }
            else if (startIndex >= inputList.Count)
            {
                startIndex = inputList.Count - 1;
            }

            if (endIndex > inputList.Count - 1)
            {
                endIndex = inputList.Count - 1;
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                mergedElemens += inputList[i];
            }

            int countToRemove = endIndex - startIndex + 1;

            inputList.RemoveRange(startIndex, countToRemove);
            inputList.Insert(startIndex, mergedElemens);

        }

        static void DivideElement(List<string> inputList, int index, int partitions)
        {
            if (index < 0)
            {
                index = 0;
            }

            if (index > inputList.Count - 1)
            {
                index = inputList.Count - 1;
            }

            string currentElement = inputList[index];

            int currentElementLength = currentElement.Length;

            List<string> newElements = new List<string>();

            int newElementSize = currentElementLength / partitions;

            int currentElementIndex = 0;

            for (int i = 0; i < partitions; i++)
            {
                string tempString = string.Empty;
                for (int j = 0; j < newElementSize; j++)
                {
                    tempString += currentElement[currentElementIndex];
                    currentElementIndex++;
                }

                newElements.Add(tempString);
            }

            if (currentElementIndex < currentElementLength)
            {
                string lastElement = string.Empty;

                for (int i = currentElementIndex - newElementSize; i < currentElementLength; i++)
                {
                    lastElement += currentElement[i];
                }

                newElements.RemoveAt(newElements.Count - 1);

                newElements.Add(lastElement);
            }

            inputList.RemoveAt(index);

            inputList.InsertRange(index, newElements);
        }
    }
}
