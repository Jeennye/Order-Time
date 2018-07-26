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
    public partial class Consultar_reservas_mesa : Form
    {
        public Consultar_reservas_mesa()
        {
            InitializeComponent();
        }
        public static int cont1, cont2, cont3, cont4, cont5, cont6, cont7, cont8, cont9, cont10, cont11, cont12, cont13, cont14, cont15;

        private void pl_11_MouseClick(object sender, MouseEventArgs e)
        {
            cont11 = 11;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }

        private void pl_12_MouseClick(object sender, MouseEventArgs e)
        {
            cont12 = 12;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }

        private void pl_13_MouseClick(object sender, MouseEventArgs e)
        {
            cont13 = 13;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }

        private void pl_14_MouseClick(object sender, MouseEventArgs e)
        {
            cont14 = 14;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }

        private void pl_15_MouseClick(object sender, MouseEventArgs e)
        {
            cont15 = 15;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_data.Clear();
            txt_hora.Text = "";
            pl_1.BackColor = System.Drawing.Color.YellowGreen;
            pl_2.BackColor = System.Drawing.Color.YellowGreen;
            pl_3.BackColor = System.Drawing.Color.YellowGreen;
            pl_4.BackColor = System.Drawing.Color.YellowGreen;
            pl_5.BackColor = System.Drawing.Color.YellowGreen;
            pl_6.BackColor = System.Drawing.Color.YellowGreen;
            pl_7.BackColor = System.Drawing.Color.YellowGreen;
            pl_8.BackColor = System.Drawing.Color.YellowGreen;
            pl_9.BackColor = System.Drawing.Color.YellowGreen;
            pl_10.BackColor = System.Drawing.Color.YellowGreen;
            pl_11.BackColor = System.Drawing.Color.YellowGreen;
            pl_12.BackColor = System.Drawing.Color.YellowGreen;
            pl_13.BackColor = System.Drawing.Color.YellowGreen;
            pl_14.BackColor = System.Drawing.Color.YellowGreen;
            pl_15.BackColor = System.Drawing.Color.YellowGreen;
            lbl_1.Text = "";
            lbl_2.Text = "";
            lbl_3.Text = "";
            lbl_4.Text = "";
            lbl_5.Text = "";
            lbl_6.Text = "";
            lbl_7.Text = "";
            lbl_8.Text = "";
            lbl_9.Text = "";
            lbl_10.Text = "";
            lbl_11.Text = "";
            lbl_12.Text = "";
            lbl_13.Text = "";
            lbl_14.Text = "";
            lbl_15.Text = "";
        }

        private void pl_10_MouseClick(object sender, MouseEventArgs e)
        {
            cont10 = 10;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }

        private void pl_9_MouseClick(object sender, MouseEventArgs e)
        {
            cont9 = 9;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }

        private void pl_8_MouseClick(object sender, MouseEventArgs e)
        {
            cont8 = 8;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }

        private void pl_7_MouseClick(object sender, MouseEventArgs e)
        {
            cont7 = 7;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }

        private void pl_6_MouseClick(object sender, MouseEventArgs e)
        {
            cont6 = 6;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }

        private void pl_5_MouseClick(object sender, MouseEventArgs e)
        {
            cont5 = 5;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }

        private void pl_4_MouseClick(object sender, MouseEventArgs e)
        {
            cont4 = 4;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }

        private void pl_3_MouseClick(object sender, MouseEventArgs e)
        {
            cont3 = 3;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            try
            {
                
                string data, hora,data1,hora1,cpf;
                int numero;
                data1 = txt_data.Text;
                hora1 = txt_hora.Text;
                
                string string_de_conexao = "Database=odertime; Data Source=127.0.0.1; Port=3306; User id=root; Password=;";

                MySqlConnection conexao;
                MySqlCommand comando;
                MySqlDataReader dr = null;

                // Conexão do banco de dados
                conexao = new MySqlConnection(string_de_conexao);

                // Abre a conexão
                conexao.Open();
                comando = new MySqlCommand("SELECT data_reserva,hora_reserva,numero,cpf FROM mesa", conexao);


                // Executa o comando SQL
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    data = dr["data_reserva"].ToString();
                    hora = dr["hora_reserva"].ToString();
                    numero = dr["numero"].GetHashCode();
                    cpf = dr["cpf"].ToString();

                    if (data1 == "0" || hora1 == "0")
                    {
                        MessageBox.Show("Escolha uma opção");
                    }
                    else if ((numero == 1) && (data == data1) && (hora == hora1))
                            {
                                lbl_1.Text = cpf;
                                pl_1.BackColor = System.Drawing.Color.DarkRed;
                                pl_1.Enabled = false;
                                numero = 0;
                            }

                     else if (numero == 2 && data == data1 && hora == hora1)
                            {
                                lbl_2.Text = cpf;

                                pl_2.BackColor = System.Drawing.Color.DarkRed;
                                pl_2.Enabled = false;

                            }
                            else if (numero == 3 && data == data1 && hora == hora1)
                            {
                                lbl_3.Text = cpf;
                                pl_3.Enabled = false;

                                pl_3.BackColor = System.Drawing.Color.DarkRed;
                            }
                            else if (numero == 4 && data == data1 && hora == hora1)
                            {
                                lbl_4.Text = cpf;
                                pl_4.Enabled = false;
                                pl_4.BackColor = System.Drawing.Color.DarkRed;
                            }
                            else if (numero == 5 && data == data1 && hora == hora1)
                            {
                                lbl_5.Text = cpf;
                                pl_5.Enabled = false;

                                pl_5.BackColor = System.Drawing.Color.DarkRed;
                            }
                            else if (numero == 6 && data == data1 && hora == hora1)
                            {
                                lbl_6.Text = cpf;
                                pl_6.Enabled = false;

                                pl_6.BackColor = System.Drawing.Color.DarkRed;
                            }
                            else if (numero == 7 && data == data1 && hora == hora1)
                            {
                                lbl_7.Text = cpf;
                                pl_7.Enabled = false;

                                pl_7.BackColor = System.Drawing.Color.DarkRed;
                            }
                            else if (numero == 8 && data == data1 && hora == hora1)
                            {
                                lbl_8.Text = cpf;
                                pl_8.Enabled = false;

                                pl_8.BackColor = System.Drawing.Color.DarkRed;
                            }
                            else if (numero == 9 && data == data1 && hora == hora1)
                            {
                                lbl_9.Text = cpf;
                                pl_9.Enabled = false;

                                pl_9.BackColor = System.Drawing.Color.DarkRed;
                            }
                            else if (numero == 10 && data == data1 && hora == hora1)
                            {
                                lbl_10.Text = cpf;
                                pl_10.Enabled = false;


                                pl_10.BackColor = System.Drawing.Color.DarkRed;
                            }
                            else if (numero == 11 && data == data1 && hora == hora1)
                            {
                                lbl_11.Text = cpf;
                                pl_11.Enabled = false;

                                pl_11.BackColor = System.Drawing.Color.DarkRed;
                            }
                            else if (numero == 12 && data == data1 && hora == hora1)
                            {
                                lbl_12.Text = cpf;
                                pl_12.Enabled = false;

                                pl_12.BackColor = System.Drawing.Color.DarkRed;
                            }
                            else if (numero == 13 && data == data1 && hora == hora1)
                            {
                                lbl_13.Text = cpf;
                                pl_13.Enabled = false;

                                pl_13.BackColor = System.Drawing.Color.DarkRed;
                            }
                            else if (numero == 14 && data == data1 && hora == hora1)
                            {
                                lbl_14.Text = cpf;
                                pl_14.Enabled = false;

                                pl_14.BackColor = System.Drawing.Color.DarkRed;
                            }
                            else if (numero == 15 && data == data1 && hora == hora1)
                            {
                                lbl_15.Text = cpf;
                                pl_15.Enabled = false;

                                pl_15.BackColor = System.Drawing.Color.DarkRed;
                            }
                           
                                else if (numero == 2 && data != data1 && hora == hora1)
                                {
                                    lbl_2.Text = "";
                                    pl_2.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_2.Enabled = true;
                                }
                                else if (numero == 2 && data == data1 && hora != hora1)
                                {
                                    lbl_2.Text = "";
                                    pl_2.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_2.Enabled = true;
                                }
                                else if (numero == 3 && data != data1 && hora == hora1)
                                {
                                    lbl_3.Text = "";
                                    pl_3.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_3.Enabled = true;
                                }
                                else if (numero == 3 && data == data1 && hora != hora1)
                                {
                                    lbl_3.Text = "";
                                    pl_3.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_3.Enabled = true;
                                }

                                else if (numero == 4 && data != data1 && hora == hora1)
                                {
                                    lbl_4.Text = "";
                                    pl_4.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_3.Enabled = true;
                                }
                                else if (numero == 4 && data == data1 && hora != hora1)
                                {
                                    lbl_4.Text = "";
                                    pl_4.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_4.Enabled = true;
                                }
                                else if (numero == 5 && data != data1 && hora == hora1)
                                {
                                    lbl_5.Text = "";
                                    pl_5.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_5.Enabled = true;
                                }
                                else if (numero == 5 && data == data1 && hora != hora1)
                                {
                                    lbl_5.Text = "";
                                    pl_5.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_5.Enabled = true;
                                }
                                else if (numero == 6 && data != data1 && hora == hora1)
                                {
                                    lbl_6.Text = "";
                                    pl_6.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_6.Enabled = true;
                                }
                                else if (numero == 6 && data == data1 && hora != hora1)
                                {
                                    lbl_6.Text = "";
                                    pl_6.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_6.Enabled = true;
                                }
                                else if (numero == 7 && data == data1 && hora != hora1)
                                {
                                    lbl_7.Text = "";
                                    pl_7.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_7.Enabled = true;
                                }
                                else if (numero == 7 && data != data1 && hora == hora1)
                                {
                                    lbl_7.Text = "";
                                    pl_7.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_7.Enabled = true;
                                }
                                else if (numero == 8 && data == data1 && hora != hora1)
                                {
                                    lbl_8.Text = "";
                                    pl_8.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_8.Enabled = true;
                                }
                                else if (numero == 8 && data != data1 && hora == hora1)
                                {
                                    lbl_8.Text = "";
                                    pl_8.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_8.Enabled = true;
                                }
                                else if (numero == 9 && data == data1 && hora != hora1)
                                {
                                    lbl_9.Text = "";
                                    pl_9.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_9.Enabled = true;
                                }
                                else if (numero == 9 && data != data1 && hora == hora1)
                                {
                                    lbl_9.Text = "";
                                    pl_9.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_9.Enabled = true;
                                }
                                else if (numero == 10 && data == data1 && hora != hora1)
                                {
                                    lbl_10.Text = "";
                                    pl_10.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_10.Enabled = true;
                                }
                                else if (numero == 10 && data != data1 && hora == hora1)
                                {
                                    lbl_10.Text = "";
                                    pl_10.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_10.Enabled = true;
                                }
                                else if (numero == 11 && data == data1 && hora != hora1)
                                {
                                    lbl_11.Text = "";
                                    pl_11.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_11.Enabled = true;
                                }
                                else if (numero == 11 && data != data1 && hora == hora1)
                                {
                                    lbl_11.Text = "";
                                    pl_11.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_11.Enabled = true;
                                }
                                else if (numero == 12 && data == data1 && hora != hora1)
                                {
                                    lbl_12.Text = "";
                                    pl_12.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_12.Enabled = true;
                                }
                                else if (numero == 12 && data != data1 && hora == hora1)
                                {
                                    lbl_12.Text = "";
                                    pl_12.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_12.Enabled = true;
                                }
                                else if (numero == 13 && data == data1 && hora != hora1)
                                {
                                    lbl_13.Text = "";
                                    pl_13.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_13.Enabled = true;
                                }
                                else if (numero == 13 && data != data1 && hora == hora1)
                                {
                                    lbl_13.Text = "";
                                    pl_13.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_13.Enabled = true;
                                }
                                else if (numero == 14 && data == data1 && hora != hora1)
                                {
                                    lbl_14.Text = "";
                                    pl_14.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_14.Enabled = true;
                                }
                                else if (numero == 14 && data != data1 && hora == hora1)
                                {
                                    lbl_14.Text = "";
                                    pl_14.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_14.Enabled = true;
                                }
                                else if (numero == 15 && data == data1 && hora != hora1)
                                {
                                    lbl_15.Text = "";
                                    pl_15.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_15.Enabled = true;
                                }
                                else if (numero == 15 && data != data1 && hora == hora1)
                                {
                                    lbl_15.Text = "";
                                    pl_15.BackColor = System.Drawing.Color.YellowGreen;
                                    pl_15.Enabled = true;
                                }

                }


                // Fecha a conexão
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Verifique a conexão com o Banco de Dados");
            }
        }

        private void Consultar_reservas_mesa_Load(object sender, EventArgs e)
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

        private void pl_1_MouseClick(object sender, MouseEventArgs e)
        {
            cont1 = 1;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }

        private void pl_2_MouseClick(object sender, MouseEventArgs e)
        {
            cont2 = 2;
            CadastrarMesa Cadastrar_mesa = new CadastrarMesa();
            Cadastrar_mesa.ShowDialog();
        }
    }
}
