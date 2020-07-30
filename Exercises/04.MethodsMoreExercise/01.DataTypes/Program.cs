using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            string dataTypeInput = Console.ReadLine();
            string dataInput = Console.ReadLine();

            Console.WriteLine(DataManipulation(dataTypeInput, dataInput));
        }

        static string DataManipulation(string type, string data)
        {
            string result = String.Empty;

            switch (type)
            {
                case "int": result = (int.Parse(data) * 2).ToString(); break;
                case "real": result = (double.Parse(data) * 1.5).ToString("0.00"); break;
                case "string": result = "$" + data + "$"; break;
            }

            return result;
        }
    }
}
