using System;

namespace PadLeft
{
    class Program
    {
        static void Main(string[] args)
        {

            caracteresWhite();
        }

        static void caracteresWhite()
        {

            string endereco = "RUA DR. JOÃO RIBEIRO 345";
            string cpf = "27028454878";
            string strBr = " ";
            int subsCpf = 0;
            char pad = ' ';
            char zero = '0';

            string line1 = $"20000000 {cpf} {endereco} FIM DA LINHA";
            string line2 = $"20000000 {subsCpf.ToString().PadLeft(14, zero)} {strBr.PadLeft(24, pad)} FIM DA LINHA";


            Console.WriteLine(line1);
            Console.WriteLine(line2);

        }
    }
}
