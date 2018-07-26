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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                string user, pass;
                string string_de_conexao = "Database=odertime; Data Source=127.0.0.1; Port=3306; User id=root; Password=;";

                MySqlConnection conexao;
                MySqlCommand comando;
                MySqlDataReader dr = null;

                // Conexão do banco de dados
                conexao = new MySqlConnection(string_de_conexao);

                // Abre a conexão
                conexao.Open();
                comando = new MySqlCommand("SELECT Nome,senha FROM usuario", conexao);


                // Executa o comando SQL
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    user = dr["Nome"].ToString();
                    pass = dr["senha"].ToString();
                
                    
                    if (txt_user.Text == user && txt_password.Text == pass)
                    {
                       
                            Menu form_menu = new Menu();
                            form_menu.Show();
                            this.Visible = false;
                    }
                    else if (txt_password.Text != pass)
                    {
                        lbl_senha.Text = "*Senha Incorreta";
                    }
                    
                    else if (txt_user.Text != user)
                    {
                        lbl_usuario.Text = "*Usuario Incorreto";
                        
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
