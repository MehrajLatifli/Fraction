using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp
{



    class Fraction
    {

        public Fraction(float n1, float d1, char op, float n2, float d2)
        {
            N1 = n1;

            D1 = d1;

            Op = op;

            N2 = n2;

            D2 = d2;

        }


        public Fraction()
        {

        }
        public float N1 { get; set; }
        public float N2 { get; set; }

        public float D1 { get; set; }
        public float D2 { get; set; }

        public char Op { get; set; }


        public void show()
        {
            if (Op == '+')
            {

                Console.Write($" Cavab: {(N1 / D1) + (N2 / D2)}");
            }
            if (Op == '-')
            {

                Console.Write($" Cavab: {(N1 / D1) - (N2 / D2)}");
            }
            if (Op == '*')
            {

                Console.Write($" Cavab: {(N1 / D1) * (N2 / D2)}");
            }
            if (Op == '/')
            {
                if (N2 != 0)
                {
                    Console.Write($" Cavab: {(N1 / D1) / (N2 / D2)}");
                }
                if (N2 / D2 == 0)
                {
                    Console.Write($" Sıfıra bölmək olmaz. ");
                }
            }
        }


    }












    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write(" Birinci ədədin surətini daxil edin: ");
            float numerator1 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write(" Birinci ədədin məxrəcini daxil edin: ");
            float denominator1 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write(" Operatoru daxil edin: ");
            char op = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Console.Write(" İkinci ədədin surətini daxil edin: ");
            float numerator2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write(" İkinci ədədin məxrəcini daxil edin: ");
            float denominator2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            Fraction f = new Fraction(numerator1, denominator1, op, numerator2, denominator2);
            f.show();


            Console.ReadKey();
        }
    }
}
