using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema;

namespace Sistema
{

    public partial class MenuPrincipal : Form
    {
       

        public MenuPrincipal()

        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            label2.Text = Global.EmpresaLog;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuModuloContable menucontable = new MenuModuloContable();
            menucontable.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form menuFacturacion = new Menu.MenuFacturacion.MenuFacturacion();
            menuFacturacion.Show();
        }
    }
}
