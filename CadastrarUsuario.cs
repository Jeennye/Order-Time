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
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void CadastrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_user.Clear();
            cb_nivel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string string_de_conexao = " Database=odertime; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

                MySqlConnection conexao;
                MySqlCommand comando;

                // Conexão do banco de dados
                conexao = new MySqlConnection(string_de_conexao);

                // Abre a conexão
                conexao.Open();

                comando = new MySqlCommand("insert into usuario(Nome,senha,Nivel) values (@Nome,@senha,@Nivel)", conexao);
                comando.Parameters.AddWithValue("@Nome", txt_user.Text);
                comando.Parameters.AddWithValue("@senha", txt_password.Text);
                comando.Parameters.AddWithValue("@Nivel", cb_nivel.Text);

                // Executa o comando SQL
                comando.ExecuteNonQuery();

                // Fecha a conexão
                conexao.Close();

                // Apresentando a mensagem de cadastro com sucesso
                MessageBox.Show("Usuario cadastrado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Verifique os campos!");
            }

        }
    }
}

