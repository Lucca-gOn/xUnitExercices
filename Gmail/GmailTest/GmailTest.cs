using Gmail;
using Xunit;

namespace GmailUnitTest
{
    public class GmailUnit
    {
        [Theory]
        [InlineData("email@dominio.com", true)]
        [InlineData("email@dominio", false)]
        [InlineData("email.com", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        [InlineData("email@dominio.com.br", true)]
        [InlineData("email@dominio..com", false)]
        [InlineData("@dominio.com", false)]
        [InlineData("email@.com", false)]
        [InlineData("invalid@domain@com", false)] //falhar
        public void EmailTest(string email, bool resultadoEsperado)
        {
            // Act
            var resultado = Email.ValidarEmail(email);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
