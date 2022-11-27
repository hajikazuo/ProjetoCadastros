using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastros
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            TelaFornecedor tela = new TelaFornecedor();
            tela.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            TelaProduto tela = new TelaProduto();
            tela.Show();
        }
    }
}
