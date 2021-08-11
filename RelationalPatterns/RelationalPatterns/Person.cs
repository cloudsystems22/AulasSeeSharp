using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationalPatterns
{
    enum Generation { BabyBoomer, GenX, Millenial, GenZ, GenA }

    class Person
    {
        public int BirthYear { get; set; }

        public Generation Generation =>
            BirthYear switch
            {
                (>= 1946) and (<= 1964) => Generation.BabyBoomer,
                (>= 1965) and (<= 1980) => Generation.GenX,
                (>= 1981) and (<= 1996) => Generation.Millenial,
                (>= 1997) and (<= 2012) => Generation.GenZ,
                _ => Generation.GenA
            };

    }
}
