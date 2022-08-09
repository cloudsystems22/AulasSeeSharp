using System;
using System.Globalization;

namespace ConsoleAppFormats
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 7342587.5891;

            Console.WriteLine("\n--------- Exibindo Moeda na cultura atual ---------------\n");
            // N exibe o valor monetário sem a moeda
            Console.WriteLine(valor.ToString("N", CultureInfo.CurrentCulture));
            // N2 exibe o valor monetário sem a moeda
            Console.WriteLine(valor.ToString("N2", CultureInfo.CurrentCulture));
            //Para a EUA
            Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("en-US")).Replace(",", ""));

            Console.WriteLine(valor.ToString("C", CultureInfo.CurrentCulture));
            // C2 exibe a moeda até dois digitos
            Console.WriteLine(valor.ToString("C2", CultureInfo.CurrentCulture));
            // C3 exibe a moeda até 3 digitos
            Console.WriteLine(valor.ToString("C3", CultureInfo.CurrentCulture));
            // C4 exibe a moeda até 4 digitos
            Console.WriteLine(valor.ToString("C4", CultureInfo.CurrentCulture));
            // C5 exibe a moeda até 5 digitos
            Console.WriteLine(valor.ToString("C5", CultureInfo.CurrentCulture));
            //Para o Japão
            Console.WriteLine("\n--------- Exibe a moeda para o Japão ---------------\n");
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            //Para a Suécia
            Console.WriteLine("\n--------- Exibe a moeda para a Suécia---------------\n");
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("se-SE")));
            //Para a Argentina
            Console.WriteLine("\n--------- Exibe a moeda para a Argentina  --------------\n");
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("es-AG")));

            //Para a EUA
            Console.WriteLine("\n--------- Exibe a moeda para os EUA  --------------\n");
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

        }
    }
}
