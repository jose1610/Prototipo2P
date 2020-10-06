using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir ab = new Abrir();
            ab.MdiParent = this;
            ab.Show();
        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogos cat = new Catalogos();
            cat.MdiParent = this;
            cat.Show();
        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoPedido man = new MantenimientoPedido();
            man.MdiParent = this;
            man.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informe inf = new Informe();
            inf.MdiParent = this;
            inf.Show();
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Herramienta her = new Herramienta();
            her.MdiParent = this;
            her.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda ay = new Ayuda();
            ay.MdiParent = this;
            ay.Show();
        }
    }
}
