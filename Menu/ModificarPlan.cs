using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class ModificarPlan : Form
    {
        public ModificarPlan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void CancelarEAñadir_Click(object sender, EventArgs e)
        {
            this.Close();
         
        }



        private void ModificarEConfirm_Click(object sender, EventArgs e)
        {
            String Numero = Numerocuenta.Text;
            String nombre = nombretxt.Text;
            String codigo = codigotxt.Text;
            String tipo = Tipotxt.Text;
            String tipoaux = "";

            string query = "SELECT * FROM PlanCuentas WHERE Numero=@Numero";
            SqlCommand comando = new SqlCommand(query, Global.conexion);
            Global.conexion.Open();
            comando.Parameters.AddWithValue("@Numero", Numero);           
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
               tipoaux = registro["Tipo"].ToString();
            }

            if ((tipoaux.Equals ('0')) && (tipo.Equals('1')))
            {
                query = "SELECT * FROM PlanCuentas WHERE Codigo LIKE '@Codigo%'";
                comando = new SqlCommand(query, Global.conexion);
                Global.conexion.Open();
                comando.Parameters.AddWithValue("@Codigo", codigo);
                registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    MessageBox.Show("");
                }
            }

        }

        private void BuscarIdE_Click(object sender, EventArgs e)
        {
            //Mostrar Datos 
            String numCuenta = Numerocuenta.Text;

            if (numCuenta.All(char.IsDigit)) 
            {
                //Llenar campos
                
                Global.conexion.Open();
                string query = "SELECT * FROM PlanCuentas WHERE Numero=@numCuenta";
                SqlCommand comando = new SqlCommand(query, Global.conexion);
                comando.Parameters.AddWithValue("@numCuenta", numCuenta);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                { 
                
                    codigotxt.Text = registro["Codigo"].ToString();
                    nombretxt.Text = registro["Nombre"].ToString();
                    Tipotxt.Text = registro["Tipo"].ToString();

                    //comando.ExecuteNonQuery();
                    
                    ModificarDConfirm.Visible = true;
                    nombretxt.Visible = true;
                    codigotxt.Visible = true;
                    Tipotxt.Visible = true; 
               
                    // this.Close();
                }
                else
                {
                    MessageBox.Show("Empleado no encontrado");
                }

                Global.conexion.Close();
            } 
            else MessageBox.Show("Ingrese un numero");

            
        }
    }
}
