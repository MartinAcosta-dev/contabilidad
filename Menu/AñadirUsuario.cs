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
    public partial class AñadirUsuario : Form
    {
        public AñadirUsuario()

        {
            InitializeComponent();
            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Global.UserLogged[2] == "ADMINISTRADOR")
            {
                TiposUsuario.Items.Add("ADMINISTRADOR");
            }
            
        }

        private void CancelarEAñadir_Click(object sender, EventArgs e)
        {
            this.Close();                   
        }

        private void AñadirEConfirm_Click(object sender, EventArgs e)
        {
            //Toma TIPO 
            String varUsername = nombreusuariotxt.Text.ToString();      
            
                //BUSCA SI EXISTE
                string query = "SELECT * FROM Usuarios WHERE username=@varUsername";
            
            SqlCommand comando = new SqlCommand(query, Global.conexion);
                comando.Parameters.AddWithValue("@varUsername", varUsername);
            Global.conexion.Open();
                SqlDataReader registro = comando.ExecuteReader();

                //SI NO EXISTE DOC
                if (!registro.Read())
                {
                //AGREGAR DOC
                    
                    String vContraseña = Contraseñatxt.Text.ToString();
                    String vTipoU = TiposUsuario.Text.ToString();
                    String vNombreU = NombreUtxt.Text;
                    String vApellidoU = ApellidoUtxt.Text;
                 if ((vTipoU!="AUDITOR") && (vTipoU != "SUPERVISOR") && (vTipoU != "ADMINISTRADOR") && 
                    (vTipoU != "OPERARIO") )
                {
                    MessageBox.Show("Elija un tipo de usuario");
                } else { 
                    

                        //AGREGAR
                        query = "INSERT INTO dbo.Usuarios (username,password,nombre,apellido,tipouser)" +
                           "VALUES (@varUsername,@vContraseña,@vNombreU,@vApellidoU,@vTipoU)";
                        SqlCommand comandoaux = new SqlCommand(query, Global.conexion);
                        comandoaux = new SqlCommand(query, Global.conexion);
                        comandoaux.Parameters.AddWithValue("@varUsername", varUsername);
                        comandoaux.Parameters.AddWithValue("@vContraseña", vContraseña);
                        comandoaux.Parameters.AddWithValue("@vNombreU", vNombreU);
                        comandoaux.Parameters.AddWithValue("@vApellidoU", vApellidoU);
                        comandoaux.Parameters.AddWithValue("@vTipoU", vTipoU);                        
                        comandoaux.ExecuteNonQuery(); Global.conexion.Close();

                    //Auditoria
                    //close datareader
                    Global.conexion.Open(); //BUSCA ID DEL AGREGADO XQ ES INCREMENTAL
                query = "SELECT ID FROM Usuarios WHERE username=@varUsername";
                SqlCommand auditoria = new SqlCommand(query, Global.conexion);
                auditoria = new SqlCommand (query, Global.conexion);
                auditoria.Parameters.AddWithValue("@varUsername", varUsername);
                SqlDataReader R = auditoria.ExecuteReader();
                String vID="" ;
                if (R.Read())
                {
                vID = R["ID"].ToString();
                }
                    Global.conexion.Close();


                    Global.conexion.Open ();
                String Responsable = Global.UserLogged[3]; //Toma ID logeado
                String Accion = "A";
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
                auditoria.Parameters.AddWithValue("@varUsername", varUsername);
                auditoria.Parameters.AddWithValue("@vContraseña", vContraseña);
                auditoria.Parameters.AddWithValue("@nombre", vNombreU);
                auditoria.Parameters.AddWithValue("@apellido", vApellidoU);
                auditoria.Parameters.AddWithValue("@tipouser", vTipoU);
                auditoria.Parameters.AddWithValue("@Fecha", a);
                auditoria.Parameters.AddWithValue("@Hora", b);
                auditoria.Parameters.AddWithValue("@IP", IP);
                auditoria.ExecuteNonQuery();
                    Global.conexion.Close();
                    //////////////////////////////


                    Global.conexion.Close();
                        MessageBox.Show("Añadido exitosamente");
                //REFRESH                   
                this.Close();
              
                
                
                
                
                    
                  
                }
            }
            else //SI EXISTE DOC
                {
                    MessageBox.Show("Este Usuario ya se encuentra registrado");
                Global.conexion.Close();
                }
                
            
            



















        }

        
    }
}
