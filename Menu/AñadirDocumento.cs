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
    public partial class AñadirDocumento : Form
    {
        public  AñadirDocumento()

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

        private void AñadirEConfirm_Click(object sender, EventArgs e)
        {
            //Toma TIPO 
            String vTipoD = TipoD.Text;
            //Verifica NUM
            if (vTipoD.All(char.IsDigit))
            {
                //BUSCA SI EXISTE
                string query = "SELECT * FROM Documentos WHERE Tipo=@vTipoD";
                
                SqlCommand comando = new SqlCommand(query, Global.conexion);
                comando.Parameters.AddWithValue("@vTipoD", vTipoD);
                Global.conexion.Open();
                SqlDataReader registro = comando.ExecuteReader();

                //SI NO EXISTE DOC
                if (!registro.Read())
                {
                    //AGREGAR DOC
                    String vDescripcionD = DescripcionD.Text.ToString();
                    string vLongitudD = (LongitudD.Text);

                    if (vLongitudD.All(char.IsDigit)) //VERIFICA DATOS
                    {

                        //AGREGAR
                        query = "INSERT INTO dbo.Documentos (Tipo,Descripcion,Longitud)" +
                           "VALUES (@vTipoD,@vDescripcionD,@vLongitudD)";

                        SqlCommand comandoaux = new SqlCommand(query, Global.conexion);
                        comandoaux = new SqlCommand(query, Global.conexion);
                        comandoaux.Parameters.AddWithValue("@vTipoD", vTipoD);
                        comandoaux.Parameters.AddWithValue("@vDescripcionD", vDescripcionD);
                        comandoaux.Parameters.AddWithValue("@vLongitudD", vLongitudD);
                        comandoaux.ExecuteNonQuery();
                        Global.conexion.Close();

                        //Auditoria
                        Global.conexion.Open();
                        String Responsable = Global.UserLogged[3]; //Toma ID logeado
                        String Accion = "A";
                        String IP = Global.UserLogged[4];
                        DateTime now = DateTime.Now;
                        String a = DateTime.Now.ToString("yyyy-MM-dd");
                        string b = DateTime.Now.ToString("hh:mm:ss"); 
                        //AGREGAR
                        query = "INSERT INTO dbo.AuditoriaDoc (Responsable,Accion,TipoDoc,Descripcion,Longitud,Fecha,Hora,IP)" +
                           "VALUES (@Responsable,@Accion,@vTipoD,@vDescripcionD,@vLongitudD,@Fecha,@Hora,@IP)";
                        SqlCommand auditoria = new SqlCommand(query, Global.conexion);
                        auditoria = new SqlCommand(query, Global.conexion);
                        auditoria.Parameters.AddWithValue("@vTipoD", vTipoD);
                        auditoria.Parameters.AddWithValue("@vDescripcionD", vDescripcionD);
                        auditoria.Parameters.AddWithValue("@vLongitudD", vLongitudD);
                        auditoria.Parameters.AddWithValue("@Responsable", Responsable);
                        auditoria.Parameters.AddWithValue("@Accion", Accion);
                        auditoria.Parameters.AddWithValue("@Fecha", a);
                        auditoria.Parameters.AddWithValue("@Hora", b);
                        auditoria.Parameters.AddWithValue("@IP", IP);
                        auditoria.ExecuteNonQuery();
                        Global.conexion.Close();
                        //////////////////////////////
                        MessageBox.Show("Añadido exitosamente");
                        //REFRESH                   
                        this.Close(); //CERRAR FORM 
                        ;
                      
                      
                    }
                    else
                    { MessageBox.Show("ERROR:Campo Cantidad Digitos: deben ser solo digitos "); }
                }
                else //SI EXISTE DOC
                {
                    MessageBox.Show("Este Documento ya se encuentra en la lista");
                    DescripcionD.Text = registro["Descripcion"].ToString();
                    LongitudD.Text = registro["Longitud"].ToString();
                    Global.conexion.Close();
                }
                
            }
            else { MessageBox.Show("ERROR:Campo Cantidad Digitos: deben ser solo digitos "); }



















        }
    }
}
