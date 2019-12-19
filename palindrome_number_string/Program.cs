using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_number_string
{
    public class PalindromeNumber
    {
        int remainder, generateReverse = 0, givenNumber;
        public bool CheckPalindromeNumber(int number)
        {
            givenNumber = number;

            while (number > 0)
            {
                remainder = number % 10;
                generateReverse = (generateReverse * 10) + remainder;
                number = number / 10;
            }

            if (generateReverse == givenNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class PalindromeString
    {
        public bool CheckPalindromeString(string inputStr)
        {
            string revStr = "";

            for (int i = inputStr.Length - 1; i >= 0; i--)
            {
                revStr += inputStr[i].ToString();
            }

            if (revStr == inputStr)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PalindromeNumber pn = new PalindromeNumber();
            Console.Write("INPUT: Please enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            bool isPalindromeNumber = pn.CheckPalindromeNumber(inputNumber);
            Console.WriteLine();
            if (isPalindromeNumber)
            {
                Console.Write("OUTPUT: The given number is palindrome");
            }
            else
            {
                Console.Write("OUTPUT: The given number is NOT palindrome");
            }

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();

            PalindromeString ps = new PalindromeString();
            Console.Write("INPUT: Please enter a string: ");
            string inputString = Console.ReadLine();
            bool isPalindromeString = ps.CheckPalindromeString(inputString);
            Console.WriteLine();
            if (isPalindromeString)
            {
                Console.Write("OUTPUT: The given string is palindrome");
            }
            else
            {
                Console.Write("OUTPUT: The given string is NOT palindrome");
            }

            Console.ReadKey();
        }
    }
}
