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
    public partial class Cadastro_Cliente : Form
    {
        public Cadastro_Cliente()
        {
            InitializeComponent();
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

                comando = new MySqlCommand("insert into cliente(cpf,nome,endereco,email,telefone) values (@cpf,@nome,@endereco,@email,@telefone)", conexao);
                comando.Parameters.AddWithValue("@cpf", txt_cpf.Text);
                comando.Parameters.AddWithValue("@nome", txt_nome.Text);
                comando.Parameters.AddWithValue("@endereco", txt_endereco.Text);
                comando.Parameters.AddWithValue("@email", txt_email.Text);
                comando.Parameters.AddWithValue("@telefone", txt_telefone.Text);

                // Executa o comando SQL
                comando.ExecuteNonQuery();

                // Fecha a conexão
                conexao.Close();

                // Apresentando a mensagem de cadastro com sucesso
                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Verifique os campos!");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_cpf.Clear();
            txt_email.Clear();
            txt_endereco.Clear();
            txt_nome.Clear();
            txt_telefone.Clear();
        }
    }
}
