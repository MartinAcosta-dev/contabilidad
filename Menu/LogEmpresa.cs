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

    public partial class LogEmpresa : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-8VUNRM4\\SQLEXPRESS;database=Practicas; integrated security=true;MultipleActiveResultSets=True");

        public LogEmpresa()
        {
            InitializeComponent();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            Global.EmpresaLog = ComboEmpresas.Text;
            Login Login = new Login();
            Login.ShowDialog();
            this.Hide();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void añadirEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void añadirEmpresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AñadirEmpresa AEmpresa = new AñadirEmpresa();
            AEmpresa.ShowDialog();
        }

        private void eliminarEmpresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        public void listarEmpresas() //Llena el combobox del login de empresas con los nombres de empresas
        {
            ComboEmpresas.Items.Clear(); 

            Global.conexion.Open();
            String query = "Select * from empresas";
            SqlCommand comando = new SqlCommand(query, Global.conexion);
            SqlDataReader registro = comando.ExecuteReader();


            while (registro.Read())
            {
                ComboEmpresas.Items.Add(registro["nombre"].ToString());
            }

            Global.conexion.Close();

        }

        private void LogEmpresa_Load(object sender, EventArgs e)
        {
            listarEmpresas();
        }

        private void MenuEmpresas_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ComboEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listarEmpresas();
        }

        private void añadirEmpresaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void configEmpresasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void añadirEmpresaToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            AñadirEmpresa AEmpresa = new AñadirEmpresa();
            AEmpresa.ShowDialog();
        }
    }
       
    
}
