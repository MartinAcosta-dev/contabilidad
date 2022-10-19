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

namespace Sistema
{

    public partial class MenuModuloContable : Form
    {
       

        public MenuModuloContable()

        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlanCuentas formPlanCuentas = new PlanCuentas();
            formPlanCuentas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void MenuModuloContable_Load(object sender, EventArgs e)
        {
            label2.Text = Global.EmpresaLog;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Asientos asientosForm = new Asientos();
            asientosForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuReportes formReportes = new MenuReportes();
            formReportes.Show();
            this.Close();
        }
    }
}
