using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace letter_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word= "", rev = "";
            int len = 0;
            Console.WriteLine("Enter a word");
            word = Console.ReadLine();
            len = word.Length - 1;
            while (len >= 0)
            {
                rev = rev + word[len];
                len--;
            }
            Console.WriteLine("\nReverse of word is = " + rev);
            Console.ReadLine();
        }

    }
    }
