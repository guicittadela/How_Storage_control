using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace How
{
    public partial class dbEstoque : Form

    {
        
        string qtdResultado = "";
        

        public dbEstoque()
        {
            InitializeComponent();
        }
        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "storage";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void limparCampos()
        {
            tbId.Clear();
            tbName.Clear();
            tbRef.Clear();
            tbQtd.Clear();
            tbCor.Clear();
            tbTamanho.Clear();
            tbRetirar.Clear();
        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM produto";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgStorage.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgStorage.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME DO PRODUTO
                    row.Cells[2].Value = reader.GetInt32(2);//REF
                    row.Cells[3].Value = reader.GetInt32(3);//QUANTIDADE
                    row.Cells[4].Value = reader.GetString(4); //COR
                    row.Cells[5].Value = reader.GetString(5);//TAMANHO
                    dgStorage.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "INSERT INTO `produto` ( `nomeProduto`, `refProduto`, `qtdProduto`, `corProduto`, `tamanhoProduto`) " +
                    "VALUES('" + tbName.Text + "', '" + tbRef.Text + "','" + tbQtd.Text + "','" + tbCor.Text + "','" + tbTamanho.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Parabéns\nInserido com sucesso");
                atualizarGrid();
                //limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void dgStorage_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgStorage.Rows[e.RowIndex].Cells["columnRetirar"].ToolTipText = "Clique aqui para retirar.";
            dgStorage.Rows[e.RowIndex].Cells["columnEditar"].ToolTipText = "Clique aqui para editar.";
        }

        private void dgStorage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgStorage.Rows[e.RowIndex].Cells["columnEditar"].Value != null)
            {
                dgStorage.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                tbName.Text = dgStorage.Rows[e.RowIndex].Cells["columnNome"].FormattedValue.ToString();
                tbRef.Text = dgStorage.Rows[e.RowIndex].Cells["columnRef"].FormattedValue.ToString();
                tbQtd.Text = dgStorage.Rows[e.RowIndex].Cells["columnQtd"].FormattedValue.ToString();
                tbId.Text = dgStorage.Rows[e.RowIndex].Cells["columnId"].FormattedValue.ToString();
                tbCor.Text = dgStorage.Rows[e.RowIndex].Cells["columnCor"].FormattedValue.ToString();
                tbTamanho.Text = dgStorage.Rows[e.RowIndex].Cells["columnTamanho"].FormattedValue.ToString();
                        
            }

             if(dgStorage.Rows[e.RowIndex].Cells["columnRetirar"].Value != null)
            {

                btnRetirar.Enabled = true;
                labelRetirar.Enabled = true;
                tbRetirar.Enabled = true;

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE produto SET nomeProduto= '" + tbName.Text + "', " +
                    "refProduto = '" + tbRef.Text + "', " +
                    "qtdProduto = '" + tbQtd.Text + "', " +
                    "corProduto = '" + tbCor.Text + "', " +
                    "tamanhoProduto = '" + tbTamanho.Text + "' " +
                    " WHERE idProduto = " + tbId.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Sucesso\nAtualizado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            qtdResultado = (int.Parse(tbQtd.Text) - int.Parse(tbRetirar.Text)).ToString();

            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE produto SET nomeProduto= '" + tbName.Text + "', " +
                    "refProduto = '" + tbRef.Text + "', " +
                    "qtdProduto = '" + qtdResultado + "', " +
                    "corProduto = '" + tbCor.Text + "', " +
                    "tamanhoProduto = '" + tbTamanho.Text + "' " +
                    " WHERE idProduto = " + tbId.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Retirado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
                qtdResultado = "";
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
