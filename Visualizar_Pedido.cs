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
    public partial class Visualizar_Pedido : Form
    {
        public Visualizar_Pedido()
        {
            InitializeComponent();
        }

        private void Visualizar_Pedido_Load(object sender, EventArgs e)
        {
            string string_de_conexao = "Database=odertime; Data Source=127.0.0.1; Port=3306; User id=root; Password=;";
            MySqlConnection conexao;
            MySqlDataAdapter da;
            DataTable dt;
            conexao = new MySqlConnection(string_de_conexao);
            conexao.Open();
            string sql = "SELECT * FROM Pedido";
            dt = new DataTable();
            da = new MySqlDataAdapter(sql, conexao);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conexao.Close();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
