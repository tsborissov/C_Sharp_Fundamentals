using System;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            string bigNumber = Console.ReadLine().TrimStart('0');

            int number = int.Parse(Console.ReadLine());

            if (number == 0 || bigNumber == "")
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();

            int result = 0;
            int portage = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                result = int.Parse(bigNumber[i].ToString()) * number + portage;

                if (result > 9)
                {
                    portage = result / 10;
                    result %= 10;
                }
                else
                {
                    portage = 0;
                }

                sb.Append(result);

            }

            if (portage != 0)
            {
                sb.Append(portage);
            }

            StringBuilder finalResult = new StringBuilder();

            for (int j = sb.Length - 1; j >= 0; j--)
            {
                finalResult.Append(sb[j]);
            }

            Console.WriteLine(finalResult);

        }
    }
}
