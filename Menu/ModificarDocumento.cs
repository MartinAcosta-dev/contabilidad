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
    public partial class ModificarDocumento : Form
    {
        public ModificarDocumento()
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



        private void ModificarEConfirm_Click(object sender, EventArgs e)
        {
            String vTipoD = TipoBuscarD.Text;
            String vDescripcionD = DescripcionDbuscar.Text;
            String vLongitudD = LongitudDbuscar.Text;
           
  
                if (vTipoD.All(char.IsDigit))
                {
                    string query = "UPDATE Documentos SET Tipo=@vTipoD,Descripcion=@vDescripcionD,Longitud=@vLongitudD WHERE Tipo=@vTipoD";
              
                SqlCommand comando = new SqlCommand(query, Global.conexion);
                Global.conexion.Open();
                comando.Parameters.AddWithValue("@vTipoD", vTipoD);
                    comando.Parameters.AddWithValue("@vDescripcionD", vDescripcionD);
                    comando.Parameters.AddWithValue("@vLongitudD", vLongitudD);
                if (vLongitudD.All(char.IsDigit)) { 
                    comando.ExecuteNonQuery();
                    Global.conexion.Close();

                    //Auditoria
                    Global.conexion.Open();
                    String Responsable = Global.UserLogged[3]; //Toma ID logeado
                    String Accion = "M";
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















                    MessageBox.Show("Modificado exitosamente");
                    this.Close();
                }else
                { MessageBox.Show("ERROR:Campo Longitud: deben ser solo digitos "); }
            }
            else
                { MessageBox.Show("ERROR:Campo Tipo: deben ser solo digitos "); }
          


            
        }

        private void BuscarIdE_Click(object sender, EventArgs e)
        {
            //Mostrar Datos 
            String vTipoD = TipoBuscarD.Text;

            if (vTipoD.All(char.IsDigit)) { 
                //Llenar campos 
                string query = "SELECT * FROM Documentos WHERE Tipo=@vTipoD";
                

                SqlCommand comando = new SqlCommand(query, Global.conexion);
                comando.Parameters.AddWithValue("@vTipoD", vTipoD);
                Global.conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            { 
                DescripcionDbuscar.Text = registro["Descripcion"].ToString();
                LongitudDbuscar.Text = registro["Longitud"].ToString();

                    //comando.ExecuteNonQuery();
                    Global.conexion.Close();
                ModificarDConfirm.Visible = true;
                DescripcionDbuscar.Visible = true;
                LongitudDbuscar.Visible = true;
               
                // this.Close();
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }
    } else MessageBox.Show("Ingrese un numero");
        }
    }
}
