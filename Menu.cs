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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            pmenu.Visible = false;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void anotarToolStripMenuItem_Click(object sender, EventArgs e)
        {
       

        }

        private void prepararToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void terminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void entregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto prod = new Produto();
            prod.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseClick_1(object sender, MouseEventArgs e)
        {
            Cadastro_Cliente novo_cliente = new Cadastro_Cliente();
            novo_cliente.ShowDialog();
        }

        private void panel2_MouseClick_1(object sender, MouseEventArgs e)
        {
            Application.Exit();

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            pmenu.Visible = true;

        }

        private void pmenu_MouseLeave(object sender, EventArgs e)
        {
            //pmenu.Visible = false;

        }

        private void pconf_MouseLeave(object sender, EventArgs e)
        {
           // pmenu.Enabled = true;
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            Pedido1 pedido = new Pedido1();
            pedido.ShowDialog();
        }

        private void pconf_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Teste");
        }

        private void psuporte_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Teste");
        }

        private void pajuda_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Teste");
        }

        private void psobre_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Teste");
        }

        private void pmenu_MouseHover(object sender, EventArgs e)
        {
            pmenu.Visible = false;
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            Consultar_reservas_mesa Consultar_mesa = new Consultar_reservas_mesa();
            Consultar_mesa.ShowDialog();
        }

        private void panel7_MouseClick(object sender, MouseEventArgs e)
        {
            Produto abrirProduto = new Produto();
            abrirProduto.ShowDialog();
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            Caixa abrirCaixa = new Caixa();
            abrirCaixa.ShowDialog();
        }

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirComanda Comanda = new AbrirComanda();
            Comanda.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pconfiguração_MouseClick(object sender, MouseEventArgs e)
        {
            CadastrarUsuario novoUser = new CadastrarUsuario();
            novoUser.ShowDialog();
        }

        private void psobre_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
