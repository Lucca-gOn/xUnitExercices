using Clima;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoUnitTest
{
    public class ConversaoTest
    {
        [Theory]
        [InlineData(0, 32)]
        [InlineData(100, 212)]
        [InlineData(-40, -40)]
        [InlineData(37, 98.6)]
        public void ConverterCelsiusParaFahrenheit(double celsius, double resultadoEsperado)
        {
            // Act
            var resultado = Conversão.ConverterCelsiusParaFahrenheit(celsius);

            // Assert
            Assert.Equal(resultadoEsperado, resultado, 1);
        }
    }
}
