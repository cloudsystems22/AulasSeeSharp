using System;
using System.Globalization;

namespace ParsingString
{
    class Program
    {
        static void Main(string[] args)
        {

            Wage();
            HireDate();
            Console.ReadLine();
        }

        private static void HireDate()
        {
            string hireDateString = "12/08/2021";
            DateTime hireDate = DateTime.Parse(hireDateString);
            Console.WriteLine($"Parse date: {hireDate}");

            var cultureInfo = new CultureInfo("pt-BR");
            string birthDateString = "22 maio 1978";
            var birthDate = DateTime.Parse(birthDateString, cultureInfo);
            Console.WriteLine($"Date birth: {birthDate}");
        }

        private static void Wage()
        {
            Console.WriteLine("Enter wage:");
            string wage = Console.ReadLine();

            int wageValue;

            if (int.TryParse(wage, out wageValue))
                Console.WriteLine($"Parsing sucess: {wageValue}");
            else
                Console.WriteLine($"Parsing failed!");

        }
    }
}
