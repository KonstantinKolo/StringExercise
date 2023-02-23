using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Check(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = string.Join("", charArray);
            Console.WriteLine(input.Contains(reversed));
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Check(input);
        }
    }
}
