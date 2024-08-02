using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public static class Inventario
    {
        private static readonly Dictionary<string, int> Produtos = new Dictionary<string, int>();

        public static void AdicionarProduto(string nome, int quantidade)
        {
            if (Produtos.ContainsKey(nome))
            {
                Produtos[nome] += quantidade;
            }
            else
            {
                Produtos[nome] = quantidade;
            }
        }

        public static int ObterQuantidade(string nome)
        {
            return Produtos.ContainsKey(nome) ? Produtos[nome] : 0;
        }
    }
}
