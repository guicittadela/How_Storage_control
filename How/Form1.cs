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
        public dbEstoque()
        {
            InitializeComponent();
        }
        private MySqlConnectionStringBuilder conexaoBanco() //função que cria a conexão com o banco de dados
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "storage";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void limparCampos() //função linkada com o botão de limpar
        {
            tbId.Clear();
            tbName.Clear();
            tbRef.Clear();
            tbQtd.Clear();
            tbCor.Clear();
            tbTamanho.Clear();
            tbRetirar.Clear();
        }

        private void button1_Click(object sender, EventArgs e) //botão que limpa os dados inseridos nos TextBox
        {
            limparCampos();
            btnAdicionar.Enabled = true;
            atualizarGrid();
        }

        private void atualizarGrid()   //função criada para atualizar o datagrid, fazendo com que os dados que aparecem no software estejam atualizado
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //faz a conexão com o banco de dados
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            btnAdcionar.Enabled = true;
            try
            {
                realizaConexacoBD.Open(); //caso a conexão seja realizada, executa o comando sql abaixo

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM `produto` WHERE `ativoProduto` = 1 "; //comando para listar todos os produtos em que a coluna 'ativoProduto' seja '1'
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgStorage.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgStorage.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA

                    row.Cells[0].Value = reader.GetInt32(0);//ID DO PRODUTO
                    row.Cells[1].Value = reader.GetString(1);//NOME DO PRODUTO
                    row.Cells[2].Value = reader.GetInt32(2);//REF DO PRODUTO
                    row.Cells[3].Value = reader.GetInt32(3);//QUANTIDADE DE PRODUTO
                    row.Cells[4].Value = reader.GetString(4); //COR DO PRODUTO
                    row.Cells[5].Value = reader.GetString(5);//TAMANHO DO PRODUTO
                    dgStorage.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex) // ´caso n seja possível realizar a conexão, emite um alerta com a mensagem abaixo
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados. Verifique a conexão!");
                Console.WriteLine(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e) //quando o formulário for carregado, chama a função 
        {
            atualizarGrid();

        }


       


        private void btnAdicionar_Click(object sender, EventArgs e) //função para cadastrar um porduto no bd
        {
            
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco(); //realiza conexão com o banco de dados
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //manda para o banco de dados um comando sql 'INSERT', e adiciona um produto com os dados preenchidos em suas respectivas TextBox
                comandoMySql.CommandText = "INSERT INTO `produto` ( `nomeProduto`, `refProduto`, `qtdProduto`, `corProduto`, `tamanhoProduto`) " +
                    "VALUES('" + tbName.Text + "', '" + tbRef.Text + "','" + tbQtd.Text + "','" + tbCor.Text + "','" + tbTamanho.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); //caso funcione exibe a mensagem abaixo, limpa os campos das TextBox e atualiza o grid
                MessageBox.Show("Inserido com sucesso");
                atualizarGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

       

        private void dgStorage_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            dgStorage.Rows[e.RowIndex].Cells["columnEditar"].ToolTipText = "Clique aqui para editar."; //exibe um aviso quando o mouse é posicionado sobre a coluna 'Editar'
            
        }

        private void dgStorage_CellContentClick(object sender, DataGridViewCellEventArgs e) //evento de clique no DataGrid
        {
            
            Console.WriteLine(sender.ToString());
            Console.WriteLine(e);
            if (dgStorage.Rows[e.RowIndex].Cells["columnEditar"].Value != null) //caso o usuário clique sobre a coluna editar, preenche os textbox com as células da linha selecionada
            {   
                dgStorage.CurrentRow.Selected = true;
                
                tbName.Text = dgStorage.Rows[e.RowIndex].Cells["columnNome"].FormattedValue.ToString();
                tbRef.Text = dgStorage.Rows[e.RowIndex].Cells["columnRef"].FormattedValue.ToString();
                tbQtd.Text = dgStorage.Rows[e.RowIndex].Cells["columnQtd"].FormattedValue.ToString();
                tbId.Text = dgStorage.Rows[e.RowIndex].Cells["columnId"].FormattedValue.ToString();
                tbCor.Text = dgStorage.Rows[e.RowIndex].Cells["columnCor"].FormattedValue.ToString();
                tbTamanho.Text = dgStorage.Rows[e.RowIndex].Cells["columnTamanho"].FormattedValue.ToString();
                btnAdicionar.Enabled = false; //desabilitamos o botão de adicionar para evitar que seja criado uma nova inserção no banco de dados. O botão é habilitado quando o form é recarregado

            }

             
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            atualizarGrid();
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Cria um comando SQL e atualiza os dados
                comandoMySql.CommandText = "UPDATE produto SET nomeProduto= '" + tbName.Text + "', " +
                    "refProduto = '" + tbRef.Text + "', " +
                    "qtdProduto = '" + tbQtd.Text + "', " +
                    "corProduto = '" + tbCor.Text + "', " +
                    "tamanhoProduto = '" + tbTamanho.Text + "' " +
                    " WHERE idProduto = " + tbId.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
                btnAdicionar.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

       
        private void button2_Click(object sender, EventArgs e)//botão de apagar item do estoque
        {   
            btnAdicionar.Enabled = true;
            {   
                MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
                MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
                try
                {
                    realizaConexacoBD.Open(); //Abre a conexão com o banco

                    MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL que altera o id do produto selecionado para 0, não o exibindo mais no data grid
                    comandoMySql.CommandText = "UPDATE produto SET ativoProduto = 0 WHERE idProduto = " + tbId.Text + "";
                    comandoMySql.ExecuteNonQuery();

                    realizaConexacoBD.Close(); // Fecho a conexão com o banco
                    MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                    atualizarGrid();
                    limparCampos();
                    
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Não foi possivel abrir a conexão! ");
                    Console.WriteLine(ex.Message);
                }
                
            }
        }

        string qtdResultado = "0"; //variável criada para o botão de retirar/adicionar

        private void retirarProduto() //função criada para realizar conexão com o DB e retirar uma quantidade de produtos
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE produto SET qtdProduto= '" + qtdResultado + "' " +
                    " WHERE idProduto = " + tbId.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco

                atualizarGrid();
                limparCampos();
                qtdResultado = ""; //limpa a váriavel
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);

            }
        }
        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            //mesma lógica do botão retirar, porém somando

            qtdResultado = (int.Parse(tbQtd.Text) + int.Parse(tbRetirar.Text)).ToString();

            if (MessageBox.Show("Tem certeza que deseja adicionar " + tbRetirar.Text + " produtos?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

            }
            else
            {
                retirarProduto();
                MessageBox.Show("Adicionado com sucesso");//Exibo mensagem de aviso
                qtdResultado = "0";
            }
        }
        private void btnRetirar_Click(object sender, EventArgs e) //evento que retira quantidades x de produtos

        {   //emite um alerta, caso a resposta seja negativa nada acontece, e caso seja positva executa a ação
            if (MessageBox.Show("Tem certeza que deseja retirar " + tbRetirar.Text + " produtos?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

            }

            else
            {              //quantidade em estoque      valor a ser retirado
                qtdResultado = (int.Parse(tbQtd.Text) - int.Parse(tbRetirar.Text)).ToString(); //armazenamos os dados na variável, e ralizamos uma subtração entre a quantidade em estoque e a quantidade a ser retirada

                if (int.Parse(qtdResultado) < 0)
                { //caso não haja quantidades suficiente, emite um alerta e n realiza a operação
                    MessageBox.Show("Quantidade insuficiente em estoque");
                }
                else if (int.Parse(qtdResultado) < 10)
                {//caso sobre menos de 10 peças em estoque, emite um alerta avisando que o estoque está baixo, chama a função retirarProduto() e exibe um alerta  
                    MessageBox.Show("Atenção estoque baixo");
                    retirarProduto();
                    MessageBox.Show("Retirado com sucesso"); //Exibo mensagem de aviso
                }

                else
                {
                    //e caso o estoque remanescente seja maior que 10, apenas chama a função e emite o alerta positivo
                    retirarProduto();
                    MessageBox.Show("Retirado com sucesso"); //Exibo mensagem de aviso
                    qtdResultado = "0"; //reset na variável
                }

                btnAdicionar.Enabled = true; //habilita o botão adicionar
            }
        }

        

        private void tbName_KeyPress(object sender, KeyPressEventArgs e) //função que pesquisa itens no BD conforme o usuário digita dados no TextBox tbName e tbRef
        {
            string searchQuery = tbName.Text;
            MySqlConnectionStringBuilder conectionDB = conexaoBanco();
            MySqlConnection doConection = new MySqlConnection(conectionDB.ToString());
            try
            {
                doConection.Open();

                MySqlCommand commandMysql = doConection.CreateCommand();
                commandMysql.CommandText = "SELECT * FROM produto WHERE nomeProduto LIKE '" + searchQuery + "%' AND ativoProduto = 1";
                MySqlDataReader reader = commandMysql.ExecuteReader();

                dgStorage.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgStorage.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0); //id
                    row.Cells[1].Value = reader.GetString(1); //prouto
                    row.Cells[2].Value = reader.GetString(2); //sexo
                    row.Cells[3].Value = reader.GetString(3); //tamanho
                    row.Cells[4].Value = reader.GetString(4); //cor
                    row.Cells[5].Value = reader.GetString(5); //quantidade
                    dgStorage.Rows.Add(row); //Add linha na tabela
                }
                doConection.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar");
                Console.WriteLine(ex.Message);
            }
        }

        private void tbRef_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchQuery = tbRef.Text;
            MySqlConnectionStringBuilder conectionDB = conexaoBanco();
            MySqlConnection doConection = new MySqlConnection(conectionDB.ToString());
            try
            {
                doConection.Open();

                MySqlCommand commandMysql = doConection.CreateCommand();
                commandMysql.CommandText = "SELECT * FROM produto WHERE refProduto LIKE '" + searchQuery + "%' AND ativoProduto = 1";
                MySqlDataReader reader = commandMysql.ExecuteReader();

                dgStorage.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgStorage.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0); //id
                    row.Cells[1].Value = reader.GetString(1); //prouto
                    row.Cells[2].Value = reader.GetString(2); //sexo
                    row.Cells[3].Value = reader.GetString(3); //tamanho
                    row.Cells[4].Value = reader.GetString(4); //cor
                    row.Cells[5].Value = reader.GetString(5); //quantidade
                    dgStorage.Rows.Add(row); //Add linha na tabela
                }
                doConection.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados.Verifique a conexão!");
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
