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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
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



        private void ModificarEConfirm_Click(object sender, EventArgs e)
        {
            String vID = idtxt.Text;
            String vUsuario = usuariotxt.Text;
            String vPass = passtxt.Text;
            String vNombre = nombretxt.Text;
            String vApellido = apellidotxt.Text;
           
  
                if (vID.All(char.IsDigit))
                {
                    string query = "UPDATE Usuarios SET username=@vUsuario,password=@vPass,nombre=@vNombre,apellido=@vApellido WHERE ID=@vID";

                Global.conexion.Open();
                    SqlCommand comando = new SqlCommand(query, Global.conexion);
                    comando.Parameters.AddWithValue("@vID", vID);
                    comando.Parameters.AddWithValue("@vUsuario", vUsuario);
                    comando.Parameters.AddWithValue("@vPass", vPass);
                    comando.Parameters.AddWithValue("@vNombre", vNombre);
                    comando.Parameters.AddWithValue("@vApellido", vApellido);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Modificado con exito ");
                Global.conexion.Close();

                //Auditoria     
                Global.conexion.Open(); //           
                query = "SELECT * FROM Usuarios WHERE ID=@vID";
                SqlCommand auditoria = new SqlCommand(query, Global.conexion);
                auditoria.Parameters.AddWithValue("@vID", vID);
                SqlDataReader R = auditoria.ExecuteReader();
                String tipouser = "";          
                if (R.Read())
                {                  
                 tipouser = R["tipouser"].ToString();
                }
                R.Close();
                Global.conexion.Close();
                Global.conexion.Open();
                String Responsable = Global.UserLogged[3]; //Toma ID logeado
                String Accion = "M";
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
                auditoria.Parameters.AddWithValue("@varUsername", vUsuario);
                auditoria.Parameters.AddWithValue("@vContraseña", vPass);
                auditoria.Parameters.AddWithValue("@nombre", vNombre);
                auditoria.Parameters.AddWithValue("@apellido", vApellido);
                auditoria.Parameters.AddWithValue("@tipouser", tipouser);
                auditoria.Parameters.AddWithValue("@Fecha", a);
                auditoria.Parameters.AddWithValue("@Hora", b);
                auditoria.Parameters.AddWithValue("@IP", IP);
                auditoria.ExecuteNonQuery();
                Global.conexion.Close();
                //////////////////////////////







              
               

            }
            else
                { MessageBox.Show("ERROR:Campo ID: deben ser solo digitos "); }
          


            
        }

        private void BuscarIdE_Click(object sender, EventArgs e)
        {
            //Mostrar Datos 
            String vID = idtxt.Text;

            if (vID.All(char.IsDigit)) { 
                //Llenar campos 
                string query = "SELECT * FROM Usuarios WHERE ID=@vID";
                

                SqlCommand comando = new SqlCommand(query, Global.conexion);
            comando.Parameters.AddWithValue("@vID", vID);
                Global.conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            { 
                usuariotxt.Text = registro["username"].ToString();
                passtxt.Text = registro["password"].ToString();
                nombretxt.Text = registro["nombre"].ToString();
                apellidotxt.Text = registro["apellido"].ToString();


                    Global.conexion.Close();
                ModificarDConfirm.Visible = true;
                usuariotxt.Visible = true;
                passtxt.Visible = true;
                nombretxt.Visible = true;
                apellidotxt.Visible = true;
               
                // this.Close();
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }
    } else MessageBox.Show("Ingrese un numero");
        }

        private void usuariosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
