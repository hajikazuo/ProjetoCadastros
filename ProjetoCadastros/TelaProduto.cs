
using MySql.Data.MySqlClient;
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
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();
        }

        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSQL;

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bd_cadastro;User=root;Pwd=0235");
                strSQL = "INSERT INTO `bd_cadastro`.`tb_produto` (`codigo`, `descricao`, `data_de_validade`, `preco`, `quantidade`) VALUES (@codigo, @descricao, @data_de_validade, @preco, @quantidade);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                comando.Parameters.AddWithValue("@data_de_validade", txtData.Text);
                comando.Parameters.AddWithValue("@preco", txtPreco.Text);
                comando.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
                lbFornecedor.Text = "Produto cadastrado";

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bd_cadastro;User=root;Pwd=0235");
                strSQL = strSQL = "UPDATE `bd_cadastro`.`tb_produto` SET `codigo` = @codigo, `descricao` = @descricao, `data_de_validade` = @data_de_validade, `preco` = @preco, `quantidade` = @quantidade WHERE(`id` = @id);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", txtId.Text);
                comando.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                comando.Parameters.AddWithValue("@data_de_validade", txtData.Text);
                comando.Parameters.AddWithValue("@preco", txtPreco.Text);
                comando.Parameters.AddWithValue("@quantidade", txtQuantidade.Text);
                lbFornecedor.Text = "Dados alterados";

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bd_cadastro;User=root;Pwd=0235");
                strSQL = "DELETE FROM `bd_cadastro`.`tb_produto` WHERE(`id` = @id);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", txtId.Text);
                lbFornecedor.Text = "Produto excluido";

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=bd_cadastro;User=root;Pwd=0235");
                strSQL = "SELECT * FROM bd_cadastro.tb_produto WHERE(`id` = @id);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", txtId.Text);


                conexao.Open();

                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    txtCodigo.Text = Convert.ToString(dr["codigo"]);
                    txtDescricao.Text = Convert.ToString(dr["descricao"]);
                    txtData.Text = Convert.ToString(dr["data_de_validade"]);
                    txtPreco.Text = Convert.ToString(dr["preco"]);
                    txtQuantidade.Text = Convert.ToString(dr["quantidade"]);
                }

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnAlimenticio_Click(object sender, EventArgs e)
        {
            TelaAlimenticio tela = new TelaAlimenticio();
            tela.Show();
        }
    }
    
    
}
