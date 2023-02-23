using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input.Length * 5);
            foreach (char c in input)
            {
                sb.Append($"{(int)c:X4} ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
