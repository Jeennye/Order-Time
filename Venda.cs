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

namespace WindowsFormsApplication1
{
    public partial class Venda : Form
    {
        public Venda()
        {
            InitializeComponent();
        }
        public static double total, total2;
        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
            Caixa Voltar_caixa = new Caixa();
            Voltar_caixa.ShowDialog();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            List_formadepagamento.Items.Add("Dinheiro");
            List_formadepagamento.Items.Add("Pelo aplicativo");
            List_formadepagamento.Items.Add("Cartão");

            string produto, preco;
            int codigo;
           


            string string_de_conexao = "Database=odertime; Data Source=127.0.0.1; Port=3306; User id=root; Password=;";

            MySqlConnection conexao;

            MySqlCommand comando;

            MySqlDataReader dr = null;

            // Conexão do banco de dados
            conexao = new MySqlConnection(string_de_conexao);


            // Abre a conexão
            conexao.Open();
            comando = new MySqlCommand("SELECT Codigo_comanda,produto,preco FROM pedido", conexao);


            // Executa o comando SQL
            dr = comando.ExecuteReader();



            while (dr.Read())
            {
                codigo = dr["Codigo_comanda"].GetHashCode();
                produto = dr["produto"].ToString();
                preco = dr["preco"].ToString();
                total = Convert.ToDouble(preco);


                if (Caixa.comanda == codigo)
                {

                    List_Comanda.Items.Add("" + produto + "" + "R$" + total);
                    total2 = total2 + total;
                    lbl_Total.Text = Convert.ToString(total2);

                    



                }


                

            }


            // Fecha a conexão
            conexao.Close();

           

        }

        private void Venda_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void List_formadepagamento_Click(object sender, EventArgs e)
        {

        }

        private void txt_dinheiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dinheiro = Convert.ToDouble(txt_dinheiro.Text);

            double troco;
            

            lbl_Total.Text = Convert.ToString(total);
            troco = dinheiro - total2;
            textBox1.Text = Convert.ToString(troco);
        }
    }
}
