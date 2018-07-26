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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
           Carregar_dados();
        }

        public void Carregar_dados()
        {
            

        }
        private void Produto_Load(object sender, EventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txt_valor.Text);
            try
            {
                   string string_de_conexao = " Database=odertime; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

                    MySqlConnection conexao;
                    MySqlCommand comando;


                    conexao = new MySqlConnection(string_de_conexao);

                    conexao.Open();
                    comando = new MySqlCommand("insert into Produto(codigo,nome,tipo,descricao,valor,data_validade) values (@codigo,@nome,@tipo,@descricao,@valor,@data_validade)", conexao);
                    comando.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                    comando.Parameters.AddWithValue("@nome", txt_nome.Text);
                    comando.Parameters.AddWithValue("@tipo", cb_tipo.Text);
                    comando.Parameters.AddWithValue("@descricao",txt_descricao.Text );
                    comando.Parameters.AddWithValue("@valor", valor);
                    comando.Parameters.AddWithValue("@data_validade",txt_data.Text );
                    

                    comando.ExecuteNonQuery();

                    conexao.Close();

                    MessageBox.Show("Produto registrado com sucesso!");

                
            }

            catch
            {
                MessageBox.Show("Verifique os campos");
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
