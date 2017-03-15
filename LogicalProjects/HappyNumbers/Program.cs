using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Happy Numbers***");
            Console.WriteLine();

            int? number = null;

            while (number == null)
            {
                Console.Write("Enter a number: ");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number.Value >= 1 && number.Value <= 230)
                    {
                        Console.WriteLine(Program.isHappyNumber(number.Value));
                        Console.ReadLine();
                    }
                    else
                    {
                        number = null;
                        Console.WriteLine("Number out of valid range. Valid range: 1 <= n <= 231-1 ");
                    }
                }
                catch
                { Console.WriteLine("Invalid Number, try again..."); }
            }

        }

        public static bool isHappyNumber(int number)
        {
            List<int> blackList = new List<int>();

            while (true)
            {
                if (number == 1)
                    return true;

                if (blackList.Contains(number))
                    return false;

                blackList.Add(number);

                string textDigits = number.ToString();
                number = 0;

                foreach (char digit in textDigits)
                {
                    string digitString = digit.ToString();
                    number += (int)Math.Pow(Convert.ToInt32(digitString), 2);
                }
            }
        }
    }
}
