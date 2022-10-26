using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Menu.MenuFacturacion
{
    public partial class MenuFacturacion : Form
    {
        public MenuFacturacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMVentas formVentas = new ABMVentas();
            AbrirFormHijo(formVentas);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AbrirFormHijo(object formHijo)
        {
            if(this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
                Form fh = formHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(fh);
                this.panel1.Tag = fh;
                fh.Show();

            }
            else
            {
                Form fh = formHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(fh);
                this.panel1.Tag = fh;
                fh.Show();
            }
        }


        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void puntosDeVentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ABMPuntosVenta formPuntosVenta = new ABMPuntosVenta();
            AbrirFormHijo(formPuntosVenta);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMProductos formProductos = new ABMProductos();
            AbrirFormHijo(formProductos);
        }

        private void tipoDeImpuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMTiposDeImpuesto formImpuestos = new ABMTiposDeImpuesto();
            AbrirFormHijo(formImpuestos);
        }

        private void MenuFacturacion_Load(object sender, EventArgs e)
        {
            ABMVentas formVentas = new ABMVentas();
            AbrirFormHijo(formVentas);
        }

        private void condicionesComercialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCondicionesComerciales formCondiciones = new ABMCondicionesComerciales();
            AbrirFormHijo(formCondiciones);
        }

        private void nuevaFamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMFamilias formFamilias = new ABMFamilias();
            AbrirFormHijo(formFamilias);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMClientes formClientes = new ABMClientes();
            AbrirFormHijo(formClientes);
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMLocalidades formLocalidades = new ABMLocalidades();
            AbrirFormHijo(formLocalidades);
        }
    }
}
