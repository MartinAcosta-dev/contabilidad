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
    public partial class EliminarDocumento : Form
    {
        public EliminarDocumento()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.documentos' Puede moverla o quitarla según sea necesario.
            this.documentosTableAdapter.Fill(this.practicasDataSet.documentos);
            // TODO: esta línea de código carga datos en la tabla 'cRUDDataSet.Documentos' Puede moverla o quitarla según sea necesario.


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
            //Verificar que no este usado por un empleado
            //////////////////////////////////////////////////////////////////
            String vTipoD = TipoDBuscar.Text.ToString();         
            //Llenar campos 
            string query = "SELECT * FROM Empleados WHERE TipoDoc=@vTipoD";

          
            SqlCommand comando = new SqlCommand(query, Global.conexion);

            comando.Parameters.AddWithValue("@vTipoD", vTipoD);
            Global.conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                MessageBox.Show("El documento se encuentra en uso por un Empleado");
                //comando.ExecuteNonQuery();
                Global.conexion.Close();
            }
            else
            {
                //Auditoria     
                 
                String Descripcion = "";
                String Longitud = "";
                query = "SELECT Descripcion,Longitud FROM Documentos WHERE Tipo=@vTipoD";
                SqlCommand auditoria = new SqlCommand(query, Global.conexion);
                auditoria.Parameters.AddWithValue("@vTipoD", vTipoD);
                SqlDataReader R = auditoria.ExecuteReader();
                if (R.Read())
                {
                    Descripcion = R["Descripcion"].ToString();
                    Longitud = R["Longitud"].ToString();
                }
                R.Close();

                Global.conexion.Close();
                Global.conexion.Open();
                String Responsable = Global.UserLogged[3]; //Toma ID logeado
                String Accion = "B";
                String IP = Global.UserLogged[4];
                DateTime now = DateTime.Now;
                String a = DateTime.Now.ToString("yyyy-MM-dd");
                string b = DateTime.Now.ToString("hh:mm:ss");
                //AGREGAR              
                query = "INSERT INTO dbo.AuditoriaDoc (Responsable,Accion,TipoDoc,Descripcion,Longitud,Fecha,Hora,IP)" +
                   "VALUES (@Responsable,@Accion,@vTipoD,@vDescripcionD,@vLongitudD,@Fecha,@Hora,@IP)";
                auditoria = new SqlCommand(query, Global.conexion);
                auditoria.Parameters.AddWithValue("@Responsable", Responsable);
                auditoria.Parameters.AddWithValue("@Accion", Accion);
                auditoria.Parameters.AddWithValue("@vTipoD", vTipoD);
                auditoria.Parameters.AddWithValue("@vDescripcionD", Descripcion);
                auditoria.Parameters.AddWithValue("@vLongitudD", Longitud);
                auditoria.Parameters.AddWithValue("@Fecha", a);
                auditoria.Parameters.AddWithValue("@Hora", b);
                auditoria.Parameters.AddWithValue("@IP", IP);
                auditoria.ExecuteNonQuery();
                Global.conexion.Close();
                //////////////////////////////


                //Eliminar
                query = "DELETE FROM Documentos WHERE Tipo=@vTipoD";
                Global.conexion.Open();
                //SqlConnection conexion = new SqlConnection("server=DESKTOP-SEBB2KQ;database=CRUD; integrated security=true");   
                comando = new SqlCommand(query, Global.conexion);
                comando.Parameters.AddWithValue("@vTipoD", vTipoD);
                comando.ExecuteNonQuery();
                Global.conexion.Close();


                this.documentosTableAdapter.Fill(this.practicasDataSet.documentos);
                // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.Empleados' Puede moverla o quitarla según sea necesario.
                //this.empleadosTableAdapter.Fill(this.practicasDataSet.Empleados);

                MessageBox.Show("Eliminado exitosamente");
                this.Close();
            }

            
        }

        private void BuscarIdE_Click(object sender, EventArgs e)
        {
            //Mostrar Datos 
            String vTipoD = TipoDBuscar.Text;
            if (vTipoD.All(char.IsDigit))
            { 
            //Llenar campos 
            string query = "SELECT * FROM Documentos WHERE Tipo=@vTipoD";
              

                SqlCommand comando = new SqlCommand(query, Global.conexion);
            comando.Parameters.AddWithValue("@vTipoD", vTipoD);
                Global.conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                DescripcionDBuscar.Text = registro["Descripcion"].ToString();
                LongitudDBuscar.Text = registro["Longitud"].ToString();
                    TipoDBuscar.Enabled = false;
                    //comando.ExecuteNonQuery();
                    Global.conexion.Close();
                EliminarDconfirm.Visible = true;
                DescripcionDBuscar.Visible = true;
                LongitudDBuscar.Visible = true;

                // this.Close();
            }
            else
            {
                MessageBox.Show("Documento no encontrado"); TipoDBuscar.Enabled = true;
                }
        }else
            {
                MessageBox.Show("ERROR: Tipo Debe ser DIGITO ");
            }
        }
    }
}
