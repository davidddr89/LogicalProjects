using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***█Regex Matching█***");
            Console.WriteLine();


            string pattern = "";
            string test = "";

            while (pattern == "")
            {
                Console.Write("Enter the pattern: ");
                try
                {
                    pattern = Console.ReadLine();
                    if (!isValidString(pattern, true))
                    {
                        pattern = "";
                        Console.WriteLine("Invalid Pattern, try again...");
                    }
                }
                catch
                { Console.WriteLine("Invalid Pattern, try again..."); }
            }

            while (test == "")
            {
                Console.Write("Enter the test: ");
                try
                {
                    test = Console.ReadLine();
                    if (isValidString(test, false))
                    {
                        Console.WriteLine(regexmatching(pattern, test));
                        Console.ReadLine();
                    }
                    else
                    {
                        test = "";
                        Console.WriteLine("Invalid Test, try again...");
                    }
                }
                catch
                { Console.WriteLine("Invalid Test, try again..."); }
            }
        }

        public static bool isValidString(string txt, bool isPattern)
        {
            bool valid = true;
            if (txt.Length > 105 || txt.Length==0)
                return false;

            foreach (char character in txt)
            {
                if (!getValidCharacters(isPattern).Contains(character.ToString()))
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        public static List<string> getValidCharacters(bool isPattern)
        {
            List<string> validCharacters = new List<string>();
            for (int i = 97; i <= 122; i++)
            {
                char character = (char)i;
                validCharacters.Add(character.ToString());
            }
            if (isPattern)
            {
                validCharacters.Add("^");
                validCharacters.Add("$");
            }
            return validCharacters;
        }

        public static bool regexmatching(string pattern, string test)
        {
            if (!pattern.Contains("^") && !pattern.Contains("$"))
            {
                if (test.Contains(pattern.Replace("^", "").Replace("$", "")))
                    return true;
            }
            else
            {
                if (pattern.Substring(0, 1) == "^")
                {
                    if (test.Length >= pattern.Length - 1 && test.Substring(0, pattern.Length - 1) == pattern.Replace("^", ""))
                    {
                        return true;
                    }
                }

                if (pattern.EndsWith("$"))
                {
                    if (test.Length >= pattern.Length - 1 && test.EndsWith(pattern.Replace("$", "")))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
