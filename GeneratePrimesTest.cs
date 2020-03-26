using Xunit;

namespace PrincipiosPadroesAgeis
{
    public class GeneratePrimesTest
    {
        [Fact]
        public void Array_deve_ser_nulo_quando_entrada_for_zero()
        {
            int[] nullArray = GeneratorPrimesFinal.GeneratePrimeNumbers(0);
            Assert.Equal(nullArray.Length, 0);
        }

        [Fact]
        public void Menor_numero_primo()
        {
            int[] minArray = GeneratorPrimesFinal.GeneratePrimeNumbers(2);
            Assert.Equal(minArray.Length, 1);
            Assert.Equal(minArray[0], 2);
        }

        [Fact]
        public void Deve_encontrar_numeros_primos_ate_thres()
        {
            int[] threeArray = GeneratorPrimesFinal.GeneratePrimeNumbers(3);
            Assert.Equal(threeArray.Length, 2);
            Assert.Equal(threeArray[0], 2);
            Assert.Equal(threeArray[1], 3);
        }

        [Fact]
        public void Deve_encontrar_numeros_primos_ate_cem()
        {
            int[] centArray = GeneratorPrimesFinal.GeneratePrimeNumbers(100);
            Assert.Equal(centArray.Length, 25);
            Assert.Equal(centArray[24], 97);
        }
    }
}