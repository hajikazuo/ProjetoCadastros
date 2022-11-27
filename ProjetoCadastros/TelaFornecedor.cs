using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoCadastros
{
    public partial class TelaFornecedor : Form
    {
        public TelaFornecedor()
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
                strSQL = "INSERT INTO `bd_cadastro`.`tb_fornecedor` (`cnpj`, `razao_social`, `endereco`, `email`, `nome_fantasia`, `telefone`, `inscricao_estadual`) VALUES (@cnpj, @razao_social, @endereco, @email, @nome_fantasia, @telefone, @inscricao_estadual);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@cnpj", txtCnpj.Text);
                comando.Parameters.AddWithValue("@razao_social", txtRazao.Text);
                comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@nome_fantasia", txtNomeFantasia.Text);
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                comando.Parameters.AddWithValue("@inscricao_estadual", txtInscricao.Text);
                lbFornecedor.Text = "Fornecedor cadastrado";

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
                strSQL = "UPDATE `bd_cadastro`.`tb_fornecedor` SET `cnpj` = @cnpj, `razao_social` = @razao_social, `endereco` = @endereco, `email` = @email, `nome_fantasia` = @nome_fantasia, `telefone` = @telefone, `inscricao_estadual` = @inscricao_estadual WHERE(`id` = @id);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", txtId.Text);
                comando.Parameters.AddWithValue("@cnpj", txtCnpj.Text);
                comando.Parameters.AddWithValue("@razao_social", txtRazao.Text);
                comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@nome_fantasia", txtNomeFantasia.Text);
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                comando.Parameters.AddWithValue("@inscricao_estadual", txtInscricao.Text);
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
                strSQL = "DELETE FROM `bd_cadastro`.`tb_fornecedor` WHERE(`id` = @id);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", txtId.Text);
                lbFornecedor.Text = "Fornecedor excluido";


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
                strSQL = "SELECT * FROM bd_cadastro.tb_fornecedor WHERE(`id` = @id);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", txtId.Text);


                conexao.Open();

                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    txtCnpj.Text = Convert.ToString(dr["cnpj"]);
                    txtRazao.Text = Convert.ToString(dr["razao_social"]);
                    txtEndereco.Text = Convert.ToString(dr["endereco"]);
                    txtEmail.Text = Convert.ToString(dr["email"]);
                    txtNomeFantasia.Text = Convert.ToString(dr["nome_fantasia"]);
                    txtTelefone.Text = Convert.ToString(dr["telefone"]);
                    txtInscricao.Text = Convert.ToString(dr["inscricao_estadual"]);
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
    }
}
