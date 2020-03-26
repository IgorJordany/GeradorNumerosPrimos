using System;

namespace PrincipiosPadroesAgeis
{
    class Program
    {
        static void Main(string[] args)
        {
            var folk = GeneratePrimesV2.GeneratePrimeNumbers(30);

            foreach (var folkinho in folk)
            {
                Console.WriteLine(folkinho);
            }
        }
    }
}
