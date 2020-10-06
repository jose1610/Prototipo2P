using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class MantenimientoPedido : Form
    {
        String ped = "tbl_pedido";
        Controlador cn = new Controlador();

        public MantenimientoPedido()
        {
            InitializeComponent();
        }

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(ped);
            Dgv_registros.DataSource = dt;

        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            int cant;
            int emp;
            int bod;
            int prod;
            String fecha="";

            cant = int.Parse(txt_cantidad.Text);
            emp = int.Parse(txt_empleado.Text);
            bod = int.Parse(txt_bodega.Text);
            prod = int.Parse(txt_producto.Text);
            fecha = txt_fecha.Text;

            cn.insertar(cant,emp,bod,prod,fecha);
        }
    }
}
