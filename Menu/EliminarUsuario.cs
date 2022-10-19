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
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.practicasDataSet.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'cRUDDataSet.Usuarios' Puede moverla o quitarla según sea necesario.



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
           
            String vID = TipoDBuscar.Text;
            string query = "";
            //Auditoria     
            Global.conexion.Open(); //           
            query = "SELECT * FROM Usuarios WHERE ID=@vID";
            SqlCommand auditoria = new SqlCommand(query, Global.conexion);
            auditoria.Parameters.AddWithValue("@vID", vID);
            SqlDataReader R = auditoria.ExecuteReader();
            String username ="";
            String password = "";
            String nombre = "";
            String apellido = "";
            String tipouser = "";
            if (R.Read())
            {
                 username = R["username"].ToString();
                 password = R["password"].ToString();
                 nombre = R["nombre"].ToString();
                 apellido = R["apellido"].ToString();
                 tipouser = R["tipouser"].ToString();
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
            query = "INSERT INTO dbo.AuditoriaUsuarios (Responsable,Accion,ID,username,password,nombre,apellido,tipouser,Fecha,Hora,IP)" +
               "VALUES (@Responsable,@Accion,@ID,@varUsername,@vContraseña,@nombre,@apellido,@tipouser,@Fecha,@Hora,@IP)";
            //SqlCommand auditoria = new SqlCommand(query, conexion);
            auditoria = new SqlCommand(query, Global.conexion);
            auditoria.Parameters.AddWithValue("@Responsable", Responsable);
            auditoria.Parameters.AddWithValue("@Accion", Accion);
            auditoria.Parameters.AddWithValue("@ID", vID);
            auditoria.Parameters.AddWithValue("@varUsername", username);
            auditoria.Parameters.AddWithValue("@vContraseña", password);
            auditoria.Parameters.AddWithValue("@nombre", nombre);
            auditoria.Parameters.AddWithValue("@apellido", apellido);
            auditoria.Parameters.AddWithValue("@tipouser", tipouser);
            auditoria.Parameters.AddWithValue("@Fecha", a);
            auditoria.Parameters.AddWithValue("@Hora", b);
            auditoria.Parameters.AddWithValue("@IP", IP);
            auditoria.ExecuteNonQuery();
            Global.conexion.Close();
            //////////////////////////////



             query = "DELETE FROM Usuarios WHERE ID=@vID";
            
            SqlCommand comando = new SqlCommand(query, Global.conexion);
            Global.conexion.Open();

                comando = new SqlCommand(query, Global.conexion);
                comando.Parameters.AddWithValue("@vID", vID);
                comando.ExecuteNonQuery();
            Global.conexion.Close();

            MessageBox.Show("Eliminado exitosamente");
                this.Close();   
        }

        private void BuscarIdE_Click(object sender, EventArgs e)
        {
            //Mostrar Datos 
            String vID = TipoDBuscar.Text;
            if (vID.All(char.IsDigit))
            { 
            //Llenar campos 
            string query = "SELECT * FROM Usuarios WHERE ID=@vId";
               

                SqlCommand comando = new SqlCommand(query, Global.conexion);
            comando.Parameters.AddWithValue("@vID", vID);
                Global.conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            { 
                    TipoDBuscar.Enabled = false;
                    //comando.ExecuteNonQuery();
                    Global.conexion.Close();
                EliminarDconfirm.Visible = true;

            }
            else
            {
                MessageBox.Show("Documento no encontrado"); TipoDBuscar.Enabled = true;
                }
        }else
            {
                MessageBox.Show("ERROR: ID Debe ser DIGITO ");
            }
        }
    }
}
