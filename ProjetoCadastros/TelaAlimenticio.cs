using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProjetoCadastros
{
    public partial class TelaAlimenticio : Form
    {
        public TelaAlimenticio()
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
                strSQL = "INSERT INTO `bd_cadastro`.`tb_alimenticio` (`medida`, `tipo`) VALUES (@medida, @tipo);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@medida", txtMedida.Text);
                comando.Parameters.AddWithValue("@tipo", txtTipo.Text);
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
                strSQL = strSQL = "UPDATE `bd_cadastro`.`tb_alimenticio` SET `medida` = @medida, `tipo` = @tipo WHERE(`id` = @id);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@medida", txtMedida.Text);
                comando.Parameters.AddWithValue("@tipo", txtTipo.Text);
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
                strSQL = "DELETE FROM `bd_cadastro`.`tb_alimenticio` WHERE(`id` = @id);";
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
                strSQL = "SELECT * FROM bd_cadastro.tb_alimenticio WHERE(`id` = @id);";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@id", txtId.Text);


                conexao.Open();

                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    txtMedida.Text = Convert.ToString(dr["medida"]);
                    txtTipo.Text = Convert.ToString(dr["tipo"]);
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
