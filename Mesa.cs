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
    public partial class Mesa : Form
    {
        public Mesa()
        {
            InitializeComponent();
        }
        public static int cont1, cont2, cont3, cont4, cont5, cont6, cont7, cont8, cont9, cont10, cont11, cont12, cont13, cont14, cont15;
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {

            this.Dispose();
        }

        private void Mesa_Load(object sender, EventArgs e)
        {
            try
            {
                string cpf;
                int numero;
                string string_de_conexao = "Database=odertime; Data Source=127.0.0.1; Port=3306; User id=root; Password=;";

                MySqlConnection conexao;
                MySqlCommand comando;
                MySqlDataReader dr = null;

                // Conexão do banco de dados
                conexao = new MySqlConnection(string_de_conexao);

                // Abre a conexão
                conexao.Open();
                comando = new MySqlCommand("SELECT cpf,numero FROM mesa", conexao);


                // Executa o comando SQL
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    cpf = dr["cpf"].ToString();
                    numero = dr["numero"].GetHashCode();
                    if (numero == 1)
                    {
                      lbl_mesa1.Text = cpf;


                      pl_1.BackColor = System.Drawing.Color.DarkRed;
                     }
                    else if (numero == 2)
                    {
                      lbl_2.Text = cpf;


                      pl_2.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 3)
                    {
                        lbl_3.Text = cpf;


                      pl_3.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 4)
                    {
                        lbl_4.Text = cpf;


                     pl_4.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 5)
                    {
                        lbl_5.Text = cpf;


                     pl_5.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 6)
                    {
                        lbl_6.Text = cpf;


                        pl_6.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 7)
                    {
                        lbl_7.Text = cpf;


                     pl_7.BackColor = System.Drawing.Color.DarkRed;
                    }
                else if (numero == 8)
                {
                        lbl_8.Text = cpf;


                    pl_8.BackColor = System.Drawing.Color.DarkRed;
                }
                else if (numero == 9)
                {
                        lbl_9.Text = cpf;


                    pl_9.BackColor = System.Drawing.Color.DarkRed;
                }
                else if (numero == 10)
                {
                        lbl_10.Text = cpf;


                    pl_10.BackColor = System.Drawing.Color.DarkRed;
                }
                else if (numero == 11)
                {
                        lbl_11.Text = cpf;


                    pl_11.BackColor = System.Drawing.Color.DarkRed;
                }
                else if (numero == 12)
                {
                        lbl_12.Text = cpf;


                    pl_12.BackColor = System.Drawing.Color.DarkRed;
                }
                else if (numero == 13)
                {
                        lbl_13.Text = cpf;


                    pl_13.BackColor = System.Drawing.Color.DarkRed;
                }
                else if (numero == 14)
                {
                        lbl_14.Text = cpf;


                    pl_14.BackColor = System.Drawing.Color.DarkRed;
                }
                else if (numero == 15)
                {
                        lbl_15.Text = cpf;


                    pl_15.BackColor = System.Drawing.Color.DarkRed;
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

        private void pl_1_MouseClick(object sender, MouseEventArgs e)
        {
            cont1 = 1;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }

        private void pl_2_MouseClick(object sender, MouseEventArgs e)
        {
            cont2 = 2;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }

        private void pl_3_MouseClick(object sender, MouseEventArgs e)
        {
            cont3 = 3;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }

        private void pl_4_MouseClick(object sender, MouseEventArgs e)
        {
            cont4 = 4;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }

        private void pl_5_MouseClick(object sender, MouseEventArgs e)
        {
            cont5 = 5;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }

        private void pl_6_MouseClick(object sender, MouseEventArgs e)
        {
            cont6 = 6;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }

        private void pl_7_MouseClick(object sender, MouseEventArgs e)
        {
            cont7 = 7;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }

        private void pl_8_MouseClick(object sender, MouseEventArgs e)
        {
            cont8 = 8;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }

        private void pl_9_MouseClick(object sender, MouseEventArgs e)
        {
            cont9 = 9;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }

        private void pl_10_MouseClick(object sender, MouseEventArgs e)
        {
            cont10 = 10;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }

        private void pl_11_MouseClick(object sender, MouseEventArgs e)
        {
            cont11 = 11;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }
    
        private void pl_12_MouseClick(object sender, MouseEventArgs e)
        {
            cont12 = 12;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }

        private void pl_13_MouseClick(object sender, MouseEventArgs e)
        {
            cont13 = 13;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }

        private void pl_14_MouseClick(object sender, MouseEventArgs e)
        {
            cont14 = 14;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }

        private void pl_15_MouseClick(object sender, MouseEventArgs e)
        {
            cont15 = 15;
            CadastrarMesa cadMesa = new CadastrarMesa();
            cadMesa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf;
                int numero;
                string string_de_conexao = "Database=odertime; Data Source=127.0.0.1; Port=3306; User id=root; Password=;";

                MySqlConnection conexao;
                MySqlCommand comando;
                MySqlDataReader dr = null;

                // Conexão do banco de dados
                conexao = new MySqlConnection(string_de_conexao);

                // Abre a conexão
                conexao.Open();
                comando = new MySqlCommand("SELECT cpf,numero FROM mesa", conexao);


                // Executa o comando SQL
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    cpf = dr["cpf"].ToString();
                    numero = dr["numero"].GetHashCode();
                    if (numero == 1)
                    {
                        lbl_mesa1.Text = cpf;


                        pl_1.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 2)
                    {
                        lbl_2.Text = cpf;


                        pl_2.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 3)
                    {
                        lbl_3.Text = cpf;


                        pl_3.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 4)
                    {
                        lbl_4.Text = cpf;


                        pl_4.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 5)
                    {
                        lbl_5.Text = cpf;


                        pl_5.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 6)
                    {
                        lbl_6.Text = cpf;


                        pl_6.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 7)
                    {
                        lbl_7.Text = cpf;


                        pl_7.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 8)
                    {
                        lbl_8.Text = cpf;


                        pl_8.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 9)
                    {
                        lbl_9.Text = cpf;


                        pl_9.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 10)
                    {
                        lbl_10.Text = cpf;


                        pl_10.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 11)
                    {
                        lbl_11.Text = cpf;


                        pl_11.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 12)
                    {
                        lbl_12.Text = cpf;


                        pl_12.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 13)
                    {
                        lbl_13.Text = cpf;


                        pl_13.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 14)
                    {
                        lbl_14.Text = cpf;


                        pl_14.BackColor = System.Drawing.Color.DarkRed;
                    }
                    else if (numero == 15)
                    {
                        lbl_15.Text = cpf;


                        pl_15.BackColor = System.Drawing.Color.DarkRed;
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

        private void pl_1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
