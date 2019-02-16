using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LearnLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            CheckStringPalindromeWithReverseFunction(input);
            CheckStringPalindromeWithoutReverseFunction(input);
        }

        public static void CheckStringPalindromeWithReverseFunction(string input)
        {
            char[] a = input.ToCharArray();
            Array.Reverse(a);
            string rev = new string(a);
            if (input.Equals(rev,StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Input string " + input + " is a palindrome");
            else
                Console.WriteLine("Input string " + input + " is Not a palindrome");
        }

        public static void CheckStringPalindromeWithoutReverseFunction(string input)
        {
            bool flag = true;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - (i + 1)])
                    flag = false;
                break;

            }

            if (flag)
                Console.WriteLine("Input string " + input + " is a palindrome");
            else
                Console.WriteLine("Input string " + input + " is Not a palindrome");
        }
    }
}
