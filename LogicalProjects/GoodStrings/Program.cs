using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Good Strings***");
            Console.WriteLine();

            int? number = null;

            while (number == null)
            {
                Console.Write("Enter a number: ");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number.Value >= 1 && number.Value <= 19)
                    {
                        Console.WriteLine(goodStringsCount(number.Value));
                        Console.ReadLine();
                    }
                    else
                    {
                        number = null;
                        Console.WriteLine("Number out of valid range. Valid range: 1 <= n <= 9 ");
                    }
                }
                catch
                { Console.WriteLine("Invalid Number, try again..."); }
            }

        }

        public static int goodStringsCount(int len)
        {
            int count = 0;
            for (int i = 0; i < len-1; i++)
            {

                for (int j = 27 - len - i; j >= 0; j--)
                {
                    count += j;
                }
            }

            return count;
        }
    }
}
