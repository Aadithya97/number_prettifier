// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace NumberPrettifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrettifyNumber(1000000));        // 1M
            Console.WriteLine(PrettifyNumber(2500000.34));     // 2.5M
            Console.WriteLine(PrettifyNumber(532));            // 532
            Console.WriteLine(PrettifyNumber(1123456789));     // 1.1B
            Console.WriteLine(PrettifyNumber(1000000000000));  // 1T
        }

        public static string PrettifyNumber(double number)
        {
            if (number < 1_000_000)
                return number.ToString();
            else if (number < 1_000_000_000)
                return $"{Math.Round(number / 1_000_000, 1)}M";
            else if (number < 1_000_000_000_000)
                return $"{Math.Round(number / 1_000_000_000, 1)}B";
            else
                return $"{Math.Round(number / 1_000_000_000_000, 1)}T";
        }
    }
}



// Without Math Libraries:
//
// public static string PrettifyNumber(double number)
// {
//     string sign = number < 0 ? "-" : "";
//     number = Math.Abs(number); 

//     if (number < 1_000_000)
//         return $"{sign}{number}";
//     else if (number < 1_000_000_000)
//     {
//         double prettyNumber = ((int)(number / 1_000_000 * 10)) / 10.0;
//         return $"{sign}{prettyNumber:g}M";
//     }
//     else if (number < 1_000_000_000_000)
//     {
//         double prettyNumber = ((int)(number / 1_000_000_000 * 10)) / 10.0;
//         return $"{sign}{prettyNumber:g}B";
//     }
//     else
//     {
//         double prettyNumber = ((int)(number / 1_000_000_000_000 * 10)) / 10.0;
//         return $"{sign}{prettyNumber:g}T";
//     }
// }