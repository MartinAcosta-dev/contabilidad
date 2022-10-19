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
    public partial class ModificarEmpleado : Form
    {
        public ModificarEmpleado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.practicasDataSet.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.documentos' Puede moverla o quitarla según sea necesario.
            this.documentosTableAdapter.Fill(this.practicasDataSet.documentos);





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
            String vNombreE = nombreEbuscar.Text.ToString();
            String vApellidoE = apellidoE.Text.ToString();
            String vTdocumentoE = comboDocumentos.Text;
            String vNumeroE = numeroE.Text;
            int  vID = Int32.Parse(IDbuscarE.Text);
            


            if ((vNombreE.All(char.IsLetter)) & (vApellidoE.All(char.IsLetter)))
            {
                
                if (vNumeroE.All(char.IsDigit))
                {
                    string query = "UPDATE Empleados SET Nombre=@vnombreE,Apellido=@vapellidoE,TipoDoc=@vTDocumentoE,NDoc=@vNumeroE WHERE ID=@vID";

                    Global.conexion.Open();
                    SqlCommand comando = new SqlCommand(query, Global.conexion);
                    comando.Parameters.AddWithValue("@vID", vID);
                    comando.Parameters.AddWithValue("@vnombreE", vNombreE);
                    comando.Parameters.AddWithValue("@vapellidoE", vApellidoE);
                    comando.Parameters.AddWithValue("@vTdocumentoE", vTdocumentoE);
                    comando.Parameters.AddWithValue("@vnumeroE", vNumeroE);

                    //////////////////////////////////////////////////////VERIFICAR LONGITUD DE NUMERO DOC

                   
                    String query2 = "SELECT Longitud FROM Documentos WHERE Tipo=@vTdocumentoE";
                    SqlCommand comando3 = new SqlCommand(query2, Global.conexion);
                    comando3.Parameters.AddWithValue("@vTdocumentoE", vTdocumentoE);
                    int aux = Convert.ToInt32(comando3.ExecuteScalar());



                    comando.ExecuteNonQuery();
                    Global.conexion.Close();

                    //Auditoria     
                    Global.conexion.Open(); //           
                    
                    SqlCommand auditoria = new SqlCommand(query, Global.conexion);               
                    String Responsable = Global.UserLogged[3]; //Toma ID logeado
                    String Accion = "M";
                    String IP = Global.UserLogged[4];
                    DateTime now = DateTime.Now;
                    String a = DateTime.Now.ToString("yyyy-MM-dd");
                    string b = DateTime.Now.ToString("hh:mm:ss");
                    //AGREGAR
                    query = "INSERT INTO dbo.AuditoriaEmpleados (Responsable,Accion,ID,Nombre,Apellido,TipoDoc,NDoc,Fecha,Hora,IP)" +
                                  "VALUES (@Responsable,@Accion,@vID,@vNombreE,@vApellidoE,@vTDocumentoE,@vNDocumentoE,@Fecha,@Hora,@IP)";
                    auditoria = new SqlCommand(query, Global.conexion);
                   // auditoria = new SqlCommand(query, Global.conexion);
                    auditoria.Parameters.AddWithValue("Responsable", Responsable);
                    auditoria.Parameters.AddWithValue("Accion", Accion);
                    auditoria.Parameters.AddWithValue("@vID", vID);
                    auditoria.Parameters.AddWithValue("@vNombrEe", vNombreE);
                    auditoria.Parameters.AddWithValue("@vApellidoE", vApellidoE);
                    auditoria.Parameters.AddWithValue("@vTDocumentoE", vTdocumentoE);
                    auditoria.Parameters.AddWithValue("@vNDocumentoE", vNumeroE);
                    auditoria.Parameters.AddWithValue("@Fecha", a);
                    auditoria.Parameters.AddWithValue("@Hora", b);
                    auditoria.Parameters.AddWithValue("@IP", IP);
                    auditoria.ExecuteNonQuery();
                    Global.conexion.Close();
                    //////////////////////////////


                    MessageBox.Show("Modificado exitosamente");
                    this.Close();
                }
                else
                { MessageBox.Show("ERROR:Campo Numero: deben ser solo digitos "); }
            }
            else { MessageBox.Show("ERROR: Campos Nombre y Apellido deben ser solo letras "); };



            
        }

        private void BuscarIdE_Click(object sender, EventArgs e)
        {
            //Mostrar Datos 

            string vID = (IDbuscarE.Text);
            if (vID.All(char.IsDigit)) { 
                //Llenar campos 
                string query = "SELECT * FROM Empleados WHERE ID=@vID";
                

                SqlCommand comando = new SqlCommand(query, Global.conexion);
            comando.Parameters.AddWithValue("@vID", vID);
                Global.conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                IDbuscarE.Enabled = false;
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
                MessageBox.Show("Empleado no encontrado"); IDbuscarE.Enabled = true;
                }
    }
            else
            {
                MessageBox.Show("Ingrese solo digitos");
            }
        }

        private void ModificarEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                if (dataModificar.Visible == true)
                {
                    dataModificar.Visible = false;
                    dataDoc.Visible = true;
                }
                else
                {
                    dataModificar.Visible = true;
                    dataDoc.Visible = false;
                }
            }
        }
    }
}
