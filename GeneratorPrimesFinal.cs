/// <remark>
/// Esta classe gera números primos até um máximo especificado pelo usuário. O algoritmo usado é o Crivo de Eratóstenes. 
/// Dado um array de inteiros, começando em 2, encontra o primeiro inteiro não excluído e exclui todos os seus múltiplos.
/// Repete até que não existam mais múltiplos no array.
/// </remark>
using System;

namespace PrincipiosPadroesAgeis
{
    public class GeneratorPrimesFinal
    {
        private static bool[] crossedOut;
        private static int[] result;

        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            if (maxValue < 2)
                return new int[0];
            else
            {
                UncrossIntegersUpTo(maxValue);
                CrossOutMultiples();
                PutUncrossedIntegersIntoResult();
                return result;
            }
        }

        private static void UncrossIntegersUpTo(int maxValue)
        {
            crossedOut = new bool[maxValue + 1];
            for (int i = 2; i < crossedOut.Length; i++)
                crossedOut[i] = false;
        }

        private static void PutUncrossedIntegersIntoResult()
        {
            result = new int[NumberOfUncrossedIntegers()];
            for (int j = 0, i = 2; i < crossedOut.Length; i++)
            {
                if (NotCrossed(i))
                    result[j++] = i;
            }
        }

        private static bool NotCrossed(int i)
        {
            return crossedOut[i] == false;
        }

        private static int NumberOfUncrossedIntegers()
        {
            int count = 0;
            for (int i = 2; i < crossedOut.Length; i++)
            {
                if (NotCrossed(i))
                    count++;
            }
            return count;
        }

        private static void CrossOutMultiples()
        {
            int limit = DetermineInterationLimit();
            for (int i = 2; i <= limit; i++)
            {
                if (NotCrossed(i))
                    CrossOutMultiplesOf(i);
            }
        }

        private static void CrossOutMultiplesOf(int i)
        {
            for (int multiple = 2 * i; multiple < crossedOut.Length; multiple += i)          
            {
                crossedOut[multiple] = true;
            }
        }

        private static int DetermineInterationLimit()
        {
            double interationLimit = Math.Sqrt(crossedOut.Length);
            return (int) interationLimit;
        }
    }
}