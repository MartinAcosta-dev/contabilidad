using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class AñadirEmpleado : Form
    {
        public AñadirEmpleado()
        {
            InitializeComponent();
            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.practicasDataSet.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.documentos' Puede moverla o quitarla según sea necesario.
            this.documentosTableAdapter.Fill(this.practicasDataSet.documentos);
            // TODO: esta línea de código carga datos en la tabla 'cRUDDataSet1.Documentos' Puede moverla o quitarla según sea necesario.





        }

        private void CancelarEAñadir_Click(object sender, EventArgs e)
        {
            this.Close();
           
            
            //form1.Show();
            //PARA ABRIR EL MENU DENUEVO EN CASO QUE LO CIERRE
            ;
        }

        private void AñadirEConfirm_Click(object sender, EventArgs e)
        {


            //TOMAR DATOS FORM
            Menu1 form1 = new Menu1();

            //ID por cantidad de empleados

            String vID = "";
;            String vNombreE = nombreE.Text.ToString() ;
            String vApellidoE = apellidoE.Text.ToString();
            String vTdocumentoE = comboDocumentos.Text;
            String vNumeroE = numeroE.Text;
            long aux;

            //////////////////////////////////////////////////////VERIFICAR LONGITUD DE NUMERO DOC

            Global.conexion.Open();
            String query2 = "SELECT Longitud FROM Documentos WHERE Tipo=@vTdocumentoE";
            SqlCommand comando3 = new SqlCommand(query2, Global.conexion);
            comando3.Parameters.AddWithValue("@vTdocumentoE", vTdocumentoE);
            aux = Convert.ToInt32(comando3.ExecuteScalar());
            Global.conexion.Close();
            //ERROR TAMAÑO DE DOCUMENTO ///////////////////////ERROR TAMAÑO DE DOCUMENTO ///////////////////////ERROR TAMAÑO DE DOCUMENTO /////////////////////
            //if (vNumeroE.Length > 10) {
            //    Console.WriteLine("");
            //}else { 
            if (aux == vNumeroE.Length)
            {
                // IF VERIFICAR
                if ((vNombreE.All(char.IsLetter)) & (vApellidoE.All(char.IsLetter)))
                {
                    Console.WriteLine("Datos Correctos LETRAS");
                    if (vNumeroE.All(char.IsDigit))
                    {
                        Console.WriteLine("Datos Correctos DIGITOS");
                        //AGREGAR
                        String query = "INSERT INTO dbo.Empleados (Nombre,Apellido,TipoDoc,Ndoc) " +
                            "VALUES (@vnombreE,@vapellidoE,@vTdocumentoE,@vnumeroE)";

                        Global.conexion.Open();
                        SqlCommand comando = new SqlCommand(query, Global.conexion);
                        
                        comando.Parameters.AddWithValue("@vnombreE", vNombreE);
                        comando.Parameters.AddWithValue("@vapellidoE", vApellidoE);
                        comando.Parameters.AddWithValue("@vTdocumentoE", vTdocumentoE);
                        comando.Parameters.AddWithValue("@vnumeroE", Int64.Parse( vNumeroE));
                        comando.ExecuteNonQuery();
                        Global.conexion.Close();


                        //AUUDITORIA
                        Global.conexion.Open(); //BUSCA ID DEL AGREGADO XQ ES INCREMENTAL
                        query = "SELECT ID FROM Empleados WHERE NDoc=@ndoc";
                        SqlCommand auditoria = new SqlCommand(query, Global.conexion);
                        auditoria = new SqlCommand(query, Global.conexion);
                        auditoria.Parameters.AddWithValue("@ndoc", vNumeroE);
                        SqlDataReader R = auditoria.ExecuteReader();
                        
                        if (R.Read())
                        {
                            vID = R["ID"].ToString();
                        }
                        Global.conexion.Close();


                        Global.conexion.Open();
                        String Responsable = Global.UserLogged[3]; //Toma ID logeado
                        String Accion = "A";
                        String IP = Global.UserLogged[4];
                        String a = DateTime.Now.ToString("yyyy-MM-dd");
                        string b = DateTime.Now.ToString("hh:mm:ss");
                        //AGREGAR
                        query = "INSERT INTO dbo.AuditoriaEmpleados (Responsable,Accion,ID,Nombre,Apellido,TipoDoc,NDoc,Fecha,Hora,IP)" +
                           "VALUES (@Responsable,@Accion,@vID,@vNombreE,@vApellidoE,@vTDocumentoE,@vNDocumentoE,@Fecha,@Hora,@IP)";
                        auditoria = new SqlCommand(query, Global.conexion);
                        auditoria = new SqlCommand(query, Global.conexion);
                        auditoria.Parameters.AddWithValue("Responsable",Responsable);
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
                        //////////////////////////////////////////////////
                        MessageBox.Show("Añadido exitosamente");

                        //REFRESH TABLE 
                        this.documentosTableAdapter.Fill(this.practicasDataSet.documentos);
                        // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.Empleados' Puede moverla o quitarla según sea necesario.
                        this.empleadosTableAdapter.Fill(this.practicasDataSet.Empleados);

                        //CERRAR FORM 
                        this.Close();
                    }
                    else
                    { MessageBox.Show("ERROR: Campo Numero: deben ser solo digitos "); }
                }
                else { MessageBox.Show("ERROR: Campos Nombre y Apellido deben ser solo letras "); };

            }
            else
            {
                MessageBox.Show("ERROR: Longitud de Num de Documento: "+(aux) );
            }
                ///////////////////////////////////////////////
            











        }

        private void AñadirEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                
                if (dataGridView1.Visible == true)
                {
                    dataGridView1.Visible = false;
                    TablaDocumentos.Visible = true;
                }
                else
                {
                    dataGridView1.Visible = true;
                    TablaDocumentos.Visible = false;
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            String query = "Select * FROM Documentos";
            SqlDataAdapter adapter = new SqlDataAdapter(query,Global.conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            TablaDocumentos.DataSource = dt;


          
        }
    }
}
