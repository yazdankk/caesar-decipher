using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace caesar_decipher
{
    internal class Program
    {
        static void Main()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("\n C A E S A R   D E C I P H E R\n");
            Console.WriteLine("enter string");
            string input = Console.ReadLine().ToUpper();
            for (int i = 1; i < 26; i++)
            {
                string ciphertext = "";
                for (int n = 0; n < input.Length; n++)
                {
                    char word = input[n];
                    int letterNum = (alphabet.IndexOf(word));
                    char letter = alphabet[(letterNum + i) % 26];
                    ciphertext += letter;
                }
                Console.WriteLine(ciphertext);
            }
        }
    }
}