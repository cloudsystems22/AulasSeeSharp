using System;

namespace RelationalPatterns
{
    class Program
    {
        static void Main(string[] args)
        { 
            var p = new Person { BirthYear = 1950 };
            Console.WriteLine($"Resultado: {p.Generation}");
        }
    }
}
