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
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }
        public static int comanda;

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comanda = Convert.ToInt32(txt_comanda.Text);
            Venda VeComanda = new Venda();
            VeComanda.ShowDialog();
        }
    }
}
