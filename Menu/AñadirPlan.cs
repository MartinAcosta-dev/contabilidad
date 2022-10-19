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
    public partial class AñadirPlan : Form
    {
        public AñadirPlan()

        {
            InitializeComponent();


        }

        //A PARTIR DE ACA ARRANCAN LAS FUNCIONES 

        public String obtenerCodigoPadre(String codigo) //TOMA UN CODIGO DE REGISTRO Y DEVUELVE EL CODIGO DEL PADRE 
        {
            String resultado = "";
            int cantidadUltimosDigitos = 0;
            int n = codigo.Length - 1;

            while (!codigo[n].Equals('.'))
            {
                cantidadUltimosDigitos++;
                n--;
            }

            for (int i = 0; i < codigo.Length - cantidadUltimosDigitos - 1; i++)
            {
                resultado = resultado + codigo[i];
            }

            return resultado;
        }


        public Boolean registroExiste(String codigo) //Toma el codigo por parametro y se fija si ya existe en la BB.DD, devuelve true si existe y sino false
        {
            //Conexion
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);


            Boolean resultado = false;
            
            
            //ESTE CODIGO LO ENCONTRE POR AHI ASI QUE HAY QUE ADAPTARLO xd



            string query = "SELECT * FROM PlanDeCuentas WHERE codigo = @codigo";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@codigo", codigo);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (!registro.Read())
            {
                resultado = false; //Falso porque no existe
            }
            else 
            { 
                resultado = true; //True porque existe
            }
            conexion.Close();

            return resultado;
        }


        public Boolean permitirCarga(String codigo) //Te devuelve el true si puede cargar el registro en el plan de cuentas y false si no
        { 
            
            Boolean resultado = false;


            if (registroExiste(codigo))
            {
                resultado = false;
                MessageBox.Show("El codigo ya esta asociado a otro título o cuenta");
            }
            else
            {
                //Ahora ver si tiene un punto o no, si no tiene punto entonces se carga, sino hay que ver si existe padre
                if (!codigo.Contains("."))
                {
                    resultado = true;
                }
                else
                {

                    String CodigoPadre = obtenerCodigoPadre(codigo);
                    if (registroExiste(CodigoPadre))
                    {
                        resultado = true;
                    }
                    else
                    {
                        resultado = false;
                        MessageBox.Show("No existe un título de agrupamiento");
                    }
                }
            }

            return resultado;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CancelarEAñadir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AñadirEConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);

            String codigo = codigotxt.Text;
            String Nombre = Nombretxt.Text;
            String sTipo = tipotxt.Text;
            int tipo;
                    
            //Nivel ponele q vaya

            if (sTipo == "Cuenta")
            {
                 tipo = 1;
            }
            else
            {
                 tipo = 0;
            }

            if ((sTipo != "Titulo") && (sTipo != "Cuenta"))
            {
                MessageBox.Show("Elija un Tipo");
            }
            else
            {
                if (permitirCarga(codigo))
                {
                    //AGREGAR
                    conexion.Open();
                    String query = "INSERT INTO PlanDeCuentas (codigo,Nombre,Tipo) VALUES (@Codigo,@Nombre,@Tipo)";
                    SqlCommand comandoaux = new SqlCommand(query, conexion);
                    comandoaux = new SqlCommand(query, conexion);
                    comandoaux.Parameters.AddWithValue("@Codigo", codigo);
                    comandoaux.Parameters.AddWithValue("@Nombre", Nombre);
                    comandoaux.Parameters.AddWithValue("@Tipo", tipo);
                    comandoaux.ExecuteNonQuery();
                    

                    //Auditoria
                    //close datareader
                    //    Global.conexion.Open(); //BUSCA ID DEL AGREGADO XQ ES INCREMENTAL
                    //query = "SELECT ID FROM Usuarios WHERE username=@varUsername";
                    //SqlCommand auditoria = new SqlCommand(query, Global.conexion);
                    //auditoria = new SqlCommand (query, Global.conexion);
                    //auditoria.Parameters.AddWithValue("@varUsername", varUsername);
                    //SqlDataReader R = auditoria.ExecuteReader();
                    //String vID="" ;
                    //if (R.Read())
                    //{
                    //vID = R["ID"].ToString();
                    //}
                    //    Global.conexion.Close();


                    //    Global.conexion.Open ();
                    //String Responsable = Global.UserLogged[3]; //Toma ID logeado
                    //String Accion = "A";
                    //String IP = Global.UserLogged[4];
                    //DateTime now = DateTime.Now;
                    //String a = DateTime.Now.ToString("yyyy-MM-dd");
                    //string b = DateTime.Now.ToString("hh:mm:ss");
                    ////AGREGAR
                    //query = "INSERT INTO dbo.AuditoriaUsuarios (Responsable,Accion,ID,username,password,nombre,apellido,tipouser,Fecha,Hora,IP)" +
                    //   "VALUES (@Responsable,@Accion,@ID,@varUsername,@vContraseña,@nombre,@apellido,@tipouser,@Fecha,@Hora,@IP)";
                    ////SqlCommand auditoria = new SqlCommand(query, conexion);
                    //auditoria = new SqlCommand(query, Global.conexion);
                    //auditoria.Parameters.AddWithValue("@Responsable", Responsable);
                    //auditoria.Parameters.AddWithValue("@Accion", Accion);
                    //auditoria.Parameters.AddWithValue("@ID", vID);
                    //auditoria.Parameters.AddWithValue("@varUsername", varUsername);
                    //auditoria.Parameters.AddWithValue("@vContraseña", vContraseña);
                    //auditoria.Parameters.AddWithValue("@nombre", vNombreU);
                    //auditoria.Parameters.AddWithValue("@apellido", vApellidoU);
                    //auditoria.Parameters.AddWithValue("@tipouser", vTipoU);
                    //auditoria.Parameters.AddWithValue("@Fecha", a);
                    //auditoria.Parameters.AddWithValue("@Hora", b);
                    //auditoria.Parameters.AddWithValue("@IP", IP);
                    //auditoria.ExecuteNonQuery();
                    //    Global.conexion.Close();
                    //////////////////////////////
                    ///

                    conexion.Close();
                    MessageBox.Show("Añadido exitosamente");
                   
                    this.Close();
                }

            }
        }//btnAñadir




    }//form
}//sistema
