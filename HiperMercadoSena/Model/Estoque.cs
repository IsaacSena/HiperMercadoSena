using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiperMercadoSena.Model
{
    internal class Estoque
    {
        private static int codigoEstoque;
        private static string categoriaEstoque;
        private static string nomeEstoque;
        private static decimal valorEstoque;
        private static int quantidadeEstoque;

        public static int CodigoEstoque { get => codigoEstoque; set => codigoEstoque = value; }
        public static string CategoriaEstoque { get => categoriaEstoque; set => categoriaEstoque = value; }
        public static string NomeEstoque { get => nomeEstoque; set => nomeEstoque = value; }
        public static decimal ValorEstoque { get => valorEstoque; set => valorEstoque = value; }
        public static int QuantidadeEstoque { get => quantidadeEstoque; set => quantidadeEstoque = value; }
    }
}
