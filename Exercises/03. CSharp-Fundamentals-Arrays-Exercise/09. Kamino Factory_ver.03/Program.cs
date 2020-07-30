using System;
using System.Linq;

namespace _09._Kamino_Factory_ver._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int sampleCounter = 0;
            int bestSubseqOfOnes = 1;
            int bestSample = 0;
            int bestIndex = length;
            int bestSum = 0;
            int[] bestSeq = new int[length];

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] array = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                sampleCounter++;

                int subseqOfOnes = 1;
                int startIndex = 0;
                int sequenceSum = 0;

                for (int i = 1; i < length; i++)
                {
                    if (array[i - 1] + array[i] == 2)
                    {
                        subseqOfOnes++;
                        startIndex = i - subseqOfOnes;
                    }
                }

                foreach (var item in array)
                {
                    sequenceSum += item;
                }


                if (subseqOfOnes > bestSubseqOfOnes)
                {
                    bestSubseqOfOnes = subseqOfOnes;
                    bestSample = sampleCounter;
                    bestIndex = startIndex;
                    bestSum = sequenceSum;
                    bestSeq = array.ToArray();
                }
                else if (subseqOfOnes == bestSubseqOfOnes)
                {
                    if (startIndex < bestIndex)
                    {
                        // bestSubseqOfOnes = subseqOfOnes;
                        bestSample = sampleCounter;
                        bestIndex = startIndex;
                        bestSum = sequenceSum;
                        bestSeq = array.ToArray();
                    }
                    else if (startIndex == bestIndex)
                    {
                        if (sequenceSum > bestSum)
                        {
                            // bestSubseqOfOnes = subseqOfOnes;
                            bestSample = sampleCounter;
                            // bestIndex = startIndex;
                            bestSum = sequenceSum;
                            bestSeq = array.ToArray();
                        }
                    }
                }
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestSeq));

        }
    }
}
