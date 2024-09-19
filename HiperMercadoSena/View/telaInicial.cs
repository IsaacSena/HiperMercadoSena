using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiperMercadoSena.View
{
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaCliente telaCliente = new telaCliente();
            telaCliente.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaCadastroProduto telaCadastroProduto = new telaCadastroProduto();
            telaCadastroProduto.Show();
        }

        private void alterarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaAlterarProdutos telaAlterarProdutos = new telaAlterarProdutos();
            telaAlterarProdutos.Show();
        }
    }
}
