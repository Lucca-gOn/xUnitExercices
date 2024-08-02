using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{

    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
    }

    public class GemLivros
    {
        private List<Livro> livros = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public List<Livro> ObterLivros()
        {
            return livros;
        }
    }

}
