using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace WhiteSpaceTreatment
{
    class Program
    {

        public static void IsMachRegex()
        {
            var regex = @"^[\w\p{L}\p{M}\W-[`;<=>@\[\]_{|}¦\\]]{1,5}$";

            var temp = Regex.IsMatch("TEST", regex);
            if (temp)
            {
                Console.Write("match");
            }
            else Console.Write(" not match");
        }

        public static void IsWhiteSpace()
        {
            string OldString = "SH DOVE ANTIBAC 400	    ML";
            Console.WriteLine("The old string is: " + OldString);
            string NewString = String.Concat(OldString.Where(c => !Char.IsWhiteSpace(c)));
            Console.WriteLine("The new string is: " + NewString);
        }

        public static void LimitWhiteSpace()
        {
            string OldString = "SH    DOVE     ANTIBAC    400            ML    ";
            const string reduceMultiSpace = @"[ ]{2,}";
            string NewString = Regex.Replace(OldString.Replace("\t", " "), reduceMultiSpace, " ");
            Console.WriteLine("The new string is: " + NewString);
        }

        static void Main(string[] args)
        {
            LimitWhiteSpace();
            Console.WriteLine("Hello World!");
        }
    }
}
