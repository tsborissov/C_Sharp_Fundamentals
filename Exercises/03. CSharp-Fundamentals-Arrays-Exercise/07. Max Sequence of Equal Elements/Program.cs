using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestSeqStart = 0;
            int bestSeqEnd = 0;
            int bestSeqCounter = 0;


            for (int i = 0; i < arr.Length - 1; i++)
            {
                int seqeunceCounter = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        seqeunceCounter++;
                    }
                    else
                    {
                        break;
                    }

                    if (seqeunceCounter > bestSeqCounter)
                    {
                        bestSeqCounter = seqeunceCounter;
                        bestSeqStart = i;
                        bestSeqEnd = j;
                    }
                }

            }

            for (int k = bestSeqStart; k <= bestSeqEnd; k++)
            {
                Console.Write(arr[k] + " ");
            }
            

        }
    }
}
