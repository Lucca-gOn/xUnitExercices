using Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTest
{
    public class InventarioUnitTest
    {
        [Fact]
        public void AdicionarNovoProduto()
        {
            // Arrange
            string nome = "ProdutoA";
            int quantidade = 10;

            // Act
            Inventario.Inventario.AdicionarProduto(nome, quantidade);

            // Assert
            Assert.Equal(quantidade, Inventario.Inventario.ObterQuantidade(nome));
        }

        [Fact]
        public void AdicionarProdutoExistenteQuantidadeIncrementada()
        {
            // Arrange
            string nome = "ProdutoA";
            int quantidadeInicial = 10;
            int quantidadeAdicionar = 5;
            Inventario.Inventario.AdicionarProduto(nome, quantidadeInicial);

            // Act
            Inventario.Inventario.AdicionarProduto(nome, quantidadeAdicionar);

            // Assert
            Assert.Equal(quantidadeInicial + quantidadeAdicionar, Inventario.Inventario.ObterQuantidade(nome));
        }

        [Fact]
        public void ObterQuantidadeProdutoNaoExistenteRetornaZero()
        {
            // Act
            int quantidade = Inventario.Inventario.ObterQuantidade("Produto não existente");

            // Assert
            Assert.Equal(0, quantidade);
        }
    }
}
