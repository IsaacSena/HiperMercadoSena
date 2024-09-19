using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiperMercadoSena.Model
{
    internal class Cliente
    {
        private static int codigoItensPedido;
        private static string categoriaProduto;
        private static string nomeProduto;
        private static decimal valorProduto;
        private static int quantidadeProduto;

        public static int CodigoItensPedido { get => codigoItensPedido; set => codigoItensPedido = value; }
        public static string CategoriaProduto { get => categoriaProduto; set => categoriaProduto = value; }
        public static string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public static decimal ValorProduto { get => valorProduto; set => valorProduto = value; }
        public static int QuantidadeProduto { get => quantidadeProduto; set => quantidadeProduto = value; }
    }
}
