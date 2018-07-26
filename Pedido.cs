using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }
        public static string nome, valor1;
        public static double valor, total;

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Pedido1 abrirPedido = new Pedido1();
            abrirPedido.ShowDialog();
            
        }
        public void Cont()
        {
            
        }
        public void Pedido_Load(object sender, EventArgs e)
        {
                           
                
                string string_de_conexao = "Database=odertime; Data Source=127.0.0.1; Port=3306; User id=root; Password=;";
            // VARIÁVEL QUE REPRESENTA A CONEXÃO
            MySqlConnection conexao;

            // ADAPTADOR UTILIZADO PARA EXECUTAR A CONSULTA SQL
            MySqlDataAdapter da;

            // ARMAZENAR A TABELA DE DADOS EM MEMÓRIA
            DataTable dt;

            // CRIANDO UM NOVA CONEXÃO
            conexao = new MySqlConnection(string_de_conexao);

            // ABRINDO A CONEXÃO
            conexao.Open();

            // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
            string sql = "SELECT nome,tipo,valor FROM produto";

            // CRIANDO UM NOVA TABELA EM MEMÓRIA
            dt = new DataTable();

            // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
            da = new MySqlDataAdapter(sql, conexao);

            // PREENCHENDO A TABELA EM MEMÓRIA
            da.Fill(dt);

            // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
            dataGridView1.DataSource = dt;

            // FECHANDO A CONEXAO
            conexao.Close();


        }
        public void button1_Click(object sender, EventArgs e)
        {
            int qtd = Convert.ToInt32(txt_qtd.Text);
            list_pedido.Items.Add(nome);
            list_pedido.Items.Add(valor *qtd);
            
            total = total + valor;
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            list_pedido.Items.Remove(list_pedido.SelectedItem);
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list_pedido.Items.Remove(list_pedido.SelectedItem);
            
        }

        private void list_alimentos_MouseClick(object sender, MouseEventArgs e)
        {

            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nome = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString());
            valor1 = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["valor"].FormattedValue.ToString());
            valor = Convert.ToDouble(valor1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txt_mesa.Text == "")
                {
                    MessageBox.Show("Preencha o campo mesa");
                }
                else
                {
                    string string_de_conexao = " Database=odertime; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

                    MySqlConnection conexao;
                    MySqlCommand comando;


                    conexao = new MySqlConnection(string_de_conexao);

                    conexao.Open();
                    comando = new MySqlCommand("insert into pedido(Codigo_comanda,numero_mesa,produto,preco,status_pedido) values (@Codigo_comanda,@numero_mesa,@produto,@preco,@status_pedido)", conexao);
                    comando.Parameters.AddWithValue("@Codigo_comanda",textBox1.Text);
                    comando.Parameters.AddWithValue("@numero_mesa", txt_mesa.Text);

                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < list_pedido.Items.Count; i++)
                    {

                        sb.Append(list_pedido.Items[i].ToString());
                        sb.Append("-");
                        Comanda.comanda.Add(sb.ToString());
                    }
                    

                    comando.Parameters.AddWithValue("@produto", sb.ToString());
                    comando.Parameters.AddWithValue("@preco", total);
                    comando.Parameters.AddWithValue("@status_pedido", "S");

                    
                    comando.ExecuteNonQuery();

                    conexao.Close();

                    MessageBox.Show("Pedido registrado com sucesso!");

                }
            }

            catch
            {
                MessageBox.Show("Verifique o pedido");
            }
        }
    }
}
