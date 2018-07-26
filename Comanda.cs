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
    public partial class Comanda : Form
    {
        public Comanda()
        {
            InitializeComponent();
        }
        public static ArrayList comanda = new ArrayList();

        private void Comanda_Load(object sender, EventArgs e)
        {
            string produto,preco;
            int codigo;
            double total;


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


                if (AbrirComanda.comanda == codigo)
                {

                    list_comanda.Items.Add("" + produto + " " + "R$ " + total);
                }





            }


            // Fecha a conexão
            conexao.Close();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void list_comanda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
