using System;
using System.Linq;

namespace MethodAggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[]{ 1, 2, 3, 4, 5 };
            var sum = numbers.Aggregate(
                0,
                (total, num) =>
                {
                    Console.WriteLine("Total = {0} + {1}", total, num);
                    return total + num;
                }
            );
            Console.WriteLine($"Valor total = {sum}");

        }
    }
}
