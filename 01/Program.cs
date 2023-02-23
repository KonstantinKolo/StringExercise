using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> answer = new List<int>();
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int number = input[1];
            if (input[0] >= 2 && input[0] <= 10)
            {
                while (number > 0)
                {
                    answer.Add(number % input[0]);
                    number = number / input[0];
                }
            }
            answer.Reverse();
            Console.WriteLine(string.Join("",answer));
        }
    }
}
