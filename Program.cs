using System;
using System.Text.RegularExpressions;

namespace RegularExpressionsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = "Серед автомобілів були номерні знаки: AB1234AO, AC5678AA, AA0000AO, BB1111BB, AA9999AO, AA1023AO, AA1041AO.";

            
            string pattern = @"AA\d{4}AO";

            
            MatchCollection matches = Regex.Matches(text, pattern);

            Console.WriteLine("Знайдені номерні знаки Рівненської області:");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
