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
    public partial class Pedido1 : Form
    {
        public Pedido1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Pedir")
            {
                this.Dispose();
                Pedido pedir = new Pedido();
                pedir.ShowDialog();
                

            }
            else if (comboBox1.Text == "Visualizar Pedidos")
            {
                Visualizar_Pedido visualizar_pedidos = new Visualizar_Pedido();
                visualizar_pedidos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Escolha uma opção");
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

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
