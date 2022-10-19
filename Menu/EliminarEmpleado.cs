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
    public partial class EliminarEmpleado : Form
    {
        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.practicasDataSet.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.documentos' Puede moverla o quitarla según sea necesario.
            this.documentosTableAdapter.Fill(this.practicasDataSet.documentos);
            // TODO: esta línea de código carga datos en la tabla 'cRUDDataSet.Empleados' Puede moverla o quitarla según sea necesario.




        }

        private void CancelarEAñadir_Click(object sender, EventArgs e)
        {
            this.Close();
           
           // Form1 form1 = new Form1();
            //form1.Show();
            //PARA ABRIR EL MENU DENUEVO EN CASO QUE LO CIERRE
            ;
        }

        

        private void EliminarEConfirm_Click(object sender, EventArgs e)
        {
            int  vID = Int32.Parse(IDbuscarE.Text);

            //Auditoria     
            Global.conexion.Open(); //           
           String query = "SELECT * FROM Empleados WHERE ID=@vID";
            SqlCommand auditoria = new SqlCommand(query, Global.conexion);
            auditoria.Parameters.AddWithValue("@vID", vID);
            SqlDataReader R = auditoria.ExecuteReader();
           
            String nombre = "";
            String apellido = "";
            String tipodoc = "";
            String ndoc = "";
            if (R.Read())
            {                
                apellido = R["apellido"].ToString();
                nombre = R["nombre"].ToString();
                tipodoc = R["TipoDoc"].ToString();
                ndoc = R["Ndoc"].ToString();
            }
            R.Close();
            Global.conexion.Close();
            Global.conexion.Open();
            String Responsable = Global.UserLogged[3]; //Toma ID logeado
            String Accion = "E";
            String IP = Global.UserLogged[4];
            DateTime now = DateTime.Now;
            String a = DateTime.Now.ToString("yyyy-MM-dd");
            string b = DateTime.Now.ToString("hh:mm:ss");
            //AGREGAR
            query = "INSERT INTO dbo.AuditoriaEmpleados (Responsable,Accion,ID,Nombre,Apellido,TipoDoc,NDoc,Fecha,Hora,IP)" +
                          "VALUES (@Responsable,@Accion,@vID,@vNombreE,@vApellidoE,@vTDocumentoE,@vNDocumentoE,@Fecha,@Hora,@IP)";
            auditoria = new SqlCommand(query, Global.conexion);
            auditoria = new SqlCommand(query, Global.conexion);
            auditoria.Parameters.AddWithValue("Responsable", Responsable);
            auditoria.Parameters.AddWithValue("Accion", Accion);
            auditoria.Parameters.AddWithValue("@vID", vID);
            auditoria.Parameters.AddWithValue("@vNombrEe", nombre);
            auditoria.Parameters.AddWithValue("@vApellidoE", apellido);
            auditoria.Parameters.AddWithValue("@vTDocumentoE", tipodoc);
            auditoria.Parameters.AddWithValue("@vNDocumentoE", ndoc);
            auditoria.Parameters.AddWithValue("@Fecha", a);
            auditoria.Parameters.AddWithValue("@Hora", b);
            auditoria.Parameters.AddWithValue("@IP", IP);
            auditoria.ExecuteNonQuery();
            Global.conexion.Close();
            //////////////////////////////



            query = "DELETE FROM Empleados WHERE ID=@vID";
            Global.conexion.Open();
            SqlCommand comando = new SqlCommand(query, Global.conexion);
            comando.Parameters.AddWithValue("@vID", vID);            
            comando.ExecuteNonQuery();
            Global.conexion.Close();
            MessageBox.Show("Eliminado exitosamente");
            this.Close();
                
               
           



            
        }

        private void BuscarIdE_Click(object sender, EventArgs e)
        {
            //Mostrar Datos 
            //IF ES NUM BUSCAR/////////////////////////////////////
            
                string vID = (IDbuscarE.Text);
            if (vID.All(char.IsDigit))
            {
                //Llenar campos 
                string query = "SELECT * FROM Empleados WHERE ID=@vID";
                

                SqlCommand comando = new SqlCommand(query, Global.conexion);
            comando.Parameters.AddWithValue("@vID", vID);
                Global.conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                EliminarEconfirm.Visible = true;
                nombreEbuscar.Text = registro["Nombre"].ToString();
                apellidoE.Text = registro["Apellido"].ToString();
                comboDocumentos.Text = registro["TipoDoc"].ToString();
                numeroE.Text = registro["NDoc"].ToString();
                    //comando.ExecuteNonQuery();
                    Global.conexion.Close();

                nombreEbuscar.Visible = true;
                apellidoE.Visible = true;
                comboDocumentos.Visible = true;
                numeroE.Visible = true;
                // this.Close();
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }
    }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }



        //    private void FillByToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
                
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
        }

        private void EliminarEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                if (dataGridView1.Visible == true)
                {
                    dataGridView1.Visible = false;
                    dataGridView2.Visible = true;
                }
                else
                {
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = false;
                }
            }
        }
    }
}
