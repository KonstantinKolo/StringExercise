using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> firstNum = new List<double>();
            double sum = 0;
            int number = int.Parse($"{input[1]}");
            while (number > 0)
            {
                firstNum.Add(number % 10);
                number = number / 10;
            }
            firstNum.Reverse();
            if (input[0] >= 2 && input[0] <= 10)
            {
                while (firstNum.Count > 0)
                {
                    sum += firstNum[0] * Math.Pow(input[0],firstNum.Count-1);
                    firstNum.RemoveAt(0);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
