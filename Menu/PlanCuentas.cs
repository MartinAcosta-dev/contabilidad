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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Sistema
{
    public partial class PlanCuentas : Form
    {
        public PlanCuentas()
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
            
            Boolean resultado = false;

            //Conexion
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
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

        public void cargarRegistro(String codigo, String nombre, int tipo)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);

            conexion.Open();
            String query = "INSERT INTO PlanDeCuentas (codigo,Nombre,Tipo) VALUES (@Codigo,@Nombre,@Tipo)";
            SqlCommand comandoaux = new SqlCommand(query, conexion);
            comandoaux = new SqlCommand(query, conexion);
            comandoaux.Parameters.AddWithValue("@Codigo", codigo);
            comandoaux.Parameters.AddWithValue("@Nombre", nombre);
            comandoaux.Parameters.AddWithValue("@Tipo", tipo);
            comandoaux.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Registro agregado con éxito");
        }

        private void AñadirEConfirm_Click(object sender, EventArgs e)
        {
            //AñadirPlan AñadirPlan = new AñadirPlan();
            //AñadirPlan.ShowDialog();

            if( (textCod.Text == "") || (textNombre.Text == "") || (comboTipo.Text == ""))
            {
                MessageBox.Show("Complete todos los campos.");
            }
            else
            {
                String codigo = textCod.Text;
                String nombre = textNombre.Text;
                String sTipo = comboTipo.Text;
                int tipo;

                if(sTipo == "Titulo")
                {
                    tipo = 0;
                }
                else{
                    tipo = 1;
                }

                if (permitirCarga(codigo))
                {
                    cargarRegistro(codigo, nombre, tipo);
                    listarPlanDeCuentas();
                    textCod.Text = "";
                    textNombre.Text = "";
                    comboTipo.Text = "";             
                }
            }
            
            
        }

        public void listarPlanDeCuentas()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);

            string query = "select * from PlanDeCuentas order by codigo"; 
            SqlDataAdapter adaptador = new SqlDataAdapter(query,conexion);
            DataTable dt = new DataTable(); //Esto es como una tabla virtual
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Width = 160;
            dataGridView1.Columns[2].Width = 320;
        }

        private void PlanCuentas_Load(object sender, EventArgs e)
        {
            //Listar plan de cuentas
            listarPlanDeCuentas();
        }

        private void CancelarEAñadir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            listarPlanDeCuentas();
        }

        public Boolean permitirModificar(String codigo)
        {
            Boolean resultado;

            //Si el codigo tiene hijo devuelve false sino devuelve true
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from PlanDeCuentas where codigo LIKE @codigo+'.%'";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@codigo", codigo);
            SqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                //Tiene hijos.
                resultado = false;
                MessageBox.Show("No puede modificarse porque hay registros hijos.");
            }
            else
            {
                resultado = true;
            }

            conexion.Close();

            return resultado;
        }

        public Boolean permitirEliminar(String codigo)
        {
            Boolean resultado;

            //Si el codigo tiene hijo devuelve false sino devuelve true
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from PlanDeCuentas where codigo LIKE @codigo+'.%'";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@codigo", codigo);
            SqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                //Tiene hijos.
                resultado = false;
                MessageBox.Show("No puede eliminarse porque hay registros hijos.");
            }
            else
            {
                resultado = true;
            }

            conexion.Close();

            return resultado;
        }

        public void eliminarRegistro(String codigo)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "delete from PlanDeCuentas where codigo = @codigo";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@codigo", codigo);
            command.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Registro eliminado con éxito.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String codigo = dataGridView1.SelectedCells[0].Value.ToString();

            if (permitirEliminar(codigo))
            {
                eliminarRegistro(codigo);
                listarPlanDeCuentas();
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String codigo = dataGridView1.SelectedCells[0].Value.ToString();
            
            String nombre = dataGridView1.SelectedCells[2].Value.ToString();
            String tipo = dataGridView1.SelectedCells[3].Value.ToString();

            textCod.Text = codigo;
            textNombre.Text = nombre;
            if(tipo == "0")
            {
                comboTipo.Text = "Titulo";
            }
            else
            {
                comboTipo.Text = "Cuenta";
            }
        }

        public void modificarRegistro(String codigo, String nombre, int tipo, int numero)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);

            conexion.Open();
            String query = "UPDATE PlanDeCuentas SET codigo=@codigo, nombre=@nombre, tipo=@tipo where numero=@numero";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@codigo", codigo);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@tipo", tipo);
            command.Parameters.AddWithValue("@numero", numero);
            command.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se ha actualizado el registro");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            String codigonuevo = textCod.Text;
            String nombrenuevo = textNombre.Text;
            String sTiponuevo = comboTipo.Text;
            int tiponuevo;

            String sNumero = dataGridView1.SelectedCells[1].Value.ToString();
            int numero = Int32.Parse(sNumero);

            if ((codigonuevo == "") || (nombrenuevo == "") || (sTiponuevo == ""))
            { 
                MessageBox.Show("Complete los campos");
            }
            else
            {
                if (sTiponuevo == "Titulo")
                {
                    tiponuevo = 0;
                }
                else
                {
                    tiponuevo = 1;
                }

                //OBTENER DATOS DE LA TABLA PARA COMPARAR
                //Codigo
                String codigoviejo = "";
                String nombreviejo = "" ;
                String stipoviejo = "";
                int tipoviejo;

                conexion.Open();
                String query = "select * from PlanDeCuentas where numero = @numero";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@numero", numero);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    codigoviejo = reader["codigo"].ToString();
                    nombreviejo = reader["nombre"].ToString();
                    stipoviejo = reader["tipo"].ToString();
                }

                conexion.Close();

                if (stipoviejo == "0")
                {
                    tipoviejo = 0;
                }
                else
                {
                    tipoviejo = 1;
                }

                if(codigoviejo == codigonuevo)
                {
                    //Solo ver si tiene hijos
                    if (tiponuevo == tipoviejo)
                    {
                        modificarRegistro(codigoviejo, nombrenuevo, tiponuevo, numero);
                    }
                    else
                    if (permitirModificar(codigonuevo))
                    {
                        modificarRegistro(codigonuevo, nombrenuevo, tiponuevo, numero);
                    }
                }
                else
                {
                    if (permitirEliminar(codigoviejo))
                    {
                        if (permitirCarga(codigonuevo))
                        {
                            modificarRegistro(codigonuevo, nombrenuevo, tiponuevo, numero);
                        }
                    }
                }
  
                
            }

            listarPlanDeCuentas();
            textCod.Text = "";
            textNombre.Text = "";
            comboTipo.Text = "";
        }

        public void exportarPlanDeCuentas()
        {
            String query = "SELECT * FROM PlanDeCuentas order by codigo";
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));
            string PaginaHTML_Texto = Properties.Resources.Cuentas.ToString();
            //REEMPLAZA DATOS DE LA PLANTILLA PARA EMPRESA
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Empresa", Global.EmpresaLog);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Lista", "Plan de Cuentas");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", "Plan De Cuentas");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Numero", "1");
            string filas = string.Empty;
            string negrita = "";
            while (registro.Read())
            {
                //IF ES CUENTA PONER EN NEGRITA
                if (Convert.ToInt32(registro["Tipo"]) == 0)
                {
                 //cambiar html
                 negrita = "class='negrita'";
                }else { negrita = ""; }

                filas += "<tr>";
                filas += "<td "+negrita+">" + registro["Codigo"].ToString() + "</td>";
                filas += "<td "+negrita+">" + registro["Numero"].ToString() + "</td>";
                filas += "<td "+negrita+">" + registro["Nombre"].ToString() + "</td>";
                filas += "<td "+negrita+">" + registro["Tipo"].ToString() + "</td>";
                filas += "</tr>";
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                }
            }
            conexion.Close();
        //PDF
    }

        private void button3_Click(object sender, EventArgs e)
        {
            exportarPlanDeCuentas();
        }
    }
}
