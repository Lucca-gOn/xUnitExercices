using Livro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LivroUnitTest
{
    public class LivroUnit
    {
        [Fact]
        public void TestarAdicionarLivro()
        {
            // Arrange: Organizar 
            var retornoLivros = new GemLivros();
            var addlivro = new Livro.Livro { Titulo = "Senhor dos Anéis", Autor = "J.R.R. Tolkien" };

            // Act: Agir
            retornoLivros.AdicionarLivro(addlivro);

            // Assert: Provar
            var livros = retornoLivros.ObterLivros();
            Assert.Contains(addlivro, livros);
        }
    }
}

