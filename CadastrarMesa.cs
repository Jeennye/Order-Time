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
    public partial class CadastrarMesa : Form
    {
        public CadastrarMesa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string dia = DateTime.Now.Day.ToString();
                string mes = DateTime.Now.Month.ToString();
                string ano = DateTime.Now.Year.ToString();
                string HoraAtual = DateTime.Now.Hour.ToString();
                string MinutoAtual = DateTime.Now.Minute.ToString();
                string SegundoAtual = DateTime.Now.Second.ToString();
                string protocolo = (ano + mes + dia + HoraAtual + MinutoAtual+SegundoAtual);
               

                string string_de_conexao = " Database=odertime; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

                MySqlConnection conexao;
                MySqlCommand comando;
                

                conexao = new MySqlConnection(string_de_conexao);

                conexao.Open();
                comando = new MySqlCommand("insert into mesa(protocolo,cpf,numero,data_reserva,hora_reserva) values (@protocolo,@cpf,@numero,@data_reserva,@hora_reserva)", conexao);
                comando.Parameters.AddWithValue("@protocolo", protocolo);
                comando.Parameters.AddWithValue("@cpf", txt_cpf.Text);
                comando.Parameters.AddWithValue("@numero", txt_numero.Text);
                comando.Parameters.AddWithValue("@data_reserva", txt_data.Text);
                comando.Parameters.AddWithValue("@hora_reserva", cb_hora.Text);

                comando.ExecuteNonQuery();

                conexao.Close();

                MessageBox.Show("Mesa reservada com sucesso!");
                    
                
            }

            catch
            {
                MessageBox.Show("Verifique os campos!");
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_cpf.Clear();
            txt_data.Clear();
            cb_hora.Text = "";
            txt_numero.Clear();
        }

        private void CadastrarMesa_Load(object sender, EventArgs e)
        {
            if (Consultar_reservas_mesa.cont1 == 1)
            {
                txt_numero.Text = "1";
                Consultar_reservas_mesa.cont1 = 0;
            }
            else if (Consultar_reservas_mesa.cont2 == 2)
            {
                txt_numero.Text = "2";
                Consultar_reservas_mesa.cont2 = 0;
            }
            else if (Consultar_reservas_mesa.cont3 == 3)
            {
                txt_numero.Text = "3";
                Consultar_reservas_mesa.cont3 = 0;
            }
            else if (Consultar_reservas_mesa.cont4 == 4)
            {
                txt_numero.Text = "4";
                Consultar_reservas_mesa.cont4 = 0;
            }
            else if (Consultar_reservas_mesa.cont5 == 5)
            {
                txt_numero.Text = "5";
                Consultar_reservas_mesa.cont5 = 0;
            }
            else if (Consultar_reservas_mesa.cont6 == 6)
            {
                txt_numero.Text = "6";
                Consultar_reservas_mesa.cont6 = 0;
            }
            else if (Consultar_reservas_mesa.cont7 == 7)
            {
                txt_numero.Text = "7";
                Consultar_reservas_mesa.cont7 = 0;
            }
            else if (Consultar_reservas_mesa.cont8 == 8)
            {
                txt_numero.Text = "8";
                Consultar_reservas_mesa.cont8 = 0;
            }
            else if (Consultar_reservas_mesa.cont9 == 9)
            {
                txt_numero.Text = "9";
                Consultar_reservas_mesa.cont9 = 0;
            }
            else if (Consultar_reservas_mesa.cont10 == 10)
            {
                txt_numero.Text = "10";
                Consultar_reservas_mesa.cont10 = 0;
            }
            else if (Consultar_reservas_mesa.cont11 == 11)
            {
                txt_numero.Text = "11";
                Consultar_reservas_mesa.cont11 = 0;
            }
            else if (Consultar_reservas_mesa.cont12 == 12)
            {
                txt_numero.Text = "12";
                Consultar_reservas_mesa.cont12 = 0;
            }
            else if (Consultar_reservas_mesa.cont13 == 13)
            {
                txt_numero.Text = "13";
                Consultar_reservas_mesa.cont13 = 0;
            }
            else if (Consultar_reservas_mesa.cont14 == 14)
            {
                txt_numero.Text = "14";
                Consultar_reservas_mesa.cont14 = 0;
            }
            else if (Consultar_reservas_mesa.cont15 == 15)
            {
                txt_numero.Text = "15";
                Consultar_reservas_mesa.cont15 = 0;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
