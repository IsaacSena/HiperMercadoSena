using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiperMercadoSena.Model
{
    internal class Conexao
    {
        public static string Conectar() 
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\isaac.smartins1\source\repos\HiperMercadoSena\HiperMercadoSena\Dados\bdMercado.mdf;Integrated Security=True";
        }
    }
}
