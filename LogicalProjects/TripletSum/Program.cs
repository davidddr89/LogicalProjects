using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripletSum
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Triplet Sum***");

            int? number = null;
            while (number == null)
            {
                Console.Write("Enter a number: ");
                try
                {
                    number = Convert.ToInt16(Console.ReadLine());
                    if (number <= 1 || number > 3000)
                    {
                        Console.WriteLine("Invalid Range, try again. Range:(1 <= number <= 3000)");
                        number = null;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }

            int? arraySize = null;
            while (arraySize == null)
            {
                Console.Write("Enter the size of array: ");
                try
                {
                    arraySize = Convert.ToInt16(Console.ReadLine());
                    if (arraySize < 3 || arraySize > 1000)
                    {
                        Console.WriteLine("Invalid Range, try again. Range:(1 <= number <= 3000)");
                        arraySize = null;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }

            Console.WriteLine("Enter values of arrray. ");
            string input = "";
            int index = 0;

            int[] array = new int[arraySize.Value];

            for (int i = 0; i < arraySize; i++)
            {
                int? value = null;
                while (value == null)
                {
                    Console.Write("value of array[{0}]: ", i);
                    try
                    {
                        value = Convert.ToInt16(Console.ReadLine());
                        if (value < 1 || value > 1000)
                        {
                            Console.WriteLine("Invalid Range, try again. Range:(1 <= number <= 1000)");
                            value = null;
                            
                        }
                        if(value!=null)
                        array[i] = value.Value;
                    }
                    catch
                    {

                    }
                }
            }

            Console.WriteLine(tripletSum(number.Value, array));
            Console.ReadLine();

        }

        public static bool tripletSum(int number, int[] array)
        {
            bool isTripletSum = false;

            for (int i = 0; i < array.Length - 2; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    for (int k = j + 1; k < array.Length; k++)
                    {
                        if (array[i] + array[j] + array[k] == number)
                        {
                            isTripletSum = true;
                            i = j = k = array.Length;
                        }
                    }
                }
            }

            return isTripletSum;
        }


    }
}
