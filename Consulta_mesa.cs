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
    public partial class Consulta_mesa : Form
    {
        public Consulta_mesa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cb_mesa.Text == "Consultar reservas")
            {
                this.Dispose();
                Consultar_reservas_mesa consulta_reserva = new Consultar_reservas_mesa();
                consulta_reserva.ShowDialog();
                
            }
            else if( cb_mesa.Text == "Reservar")
            {
                this.Dispose();
                Mesa Reservar_mesa = new Mesa();
                Reservar_mesa.ShowDialog();
                
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
    }
}
