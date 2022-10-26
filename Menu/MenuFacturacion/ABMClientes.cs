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

namespace Sistema.Menu.MenuFacturacion
{
    public partial class ABMClientes : Form
    {
        public ABMClientes()
        {
            InitializeComponent();
        }
       
        public int getCodigo(String palabra)
        {
            int resultado = 0;
            String sResultado = "";
            String letra = "";
            int i = 0;
            while (palabra[i].ToString() != " ")
            {
                letra = palabra[i].ToString();
                sResultado = sResultado + letra;
                i++;
            }


            resultado = Convert.ToInt32(sResultado);
            return resultado;
        }

        public int getCodTipoResponsable(String palabra)
        {
            int resultado = 0;
            String sResultado = "";
            String letra = "";
            int i = 0;
            while (palabra[i].ToString() != " ")
            {
                letra = palabra[i].ToString();
                sResultado = sResultado + letra;
                i++;
            }


            resultado = Convert.ToInt32(sResultado);
            return resultado;
        }

        public void listarClientes()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            string query = "select * from clientes";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable(); //Esto es como una tabla virtual
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[5].Width = 40;
            dataGridView1.Columns[6].Width = 40;
            dataGridView1.Columns[7].Width = 40;



        }
         
        public void AltaCliente(String Vrazon, String Vnombre, String Vdomicilio, String Vtel, String VClocalidad, String VCresponsable, String VCDocumento, String VNDocumento, String Vingresos)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "insert into clientes values (@Vrazon, @Vnombre, @Vdomicilio, @Vtel, @VClocalidad, @VCresponsable, @VCDocumento, @VNDocumento, @Vingresos)";
            SqlCommand command = new SqlCommand(query, conexion);

            command.Parameters.AddWithValue("@Vrazon", Vrazon);
            command.Parameters.AddWithValue("@Vnombre", Vnombre);
            command.Parameters.AddWithValue("@Vdomicilio", Vdomicilio);
            command.Parameters.AddWithValue("@Vtel", Vtel);
            command.Parameters.AddWithValue("@VClocalidad", VClocalidad);
            command.Parameters.AddWithValue("@VCresponsable", VCresponsable);
            command.Parameters.AddWithValue("@VCDocumento", VCDocumento);
            command.Parameters.AddWithValue("@VNDocumento", VNDocumento);
            command.Parameters.AddWithValue("@Vingresos", Vingresos);

            command.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( (razon.Text == "Razon Social") || (razon.Text == "") ||              
                (nombre.Text == "Nombre") || (nombre.Text == "") ||
                (domicilio.Text == "Domicilio") || (domicilio.Text == "") ||
                (tel.Text == "Tel") || (tel.Text == "") ||
                (comboBox2.Text == "") ||
                (comboBox1.Text == "") ||
                (comboBox3.Text == "") ||
                (NDocumento.Text == "Nro Documento") || (NDocumento.Text == "") ||
                (ingresos.Text == "Ingresos Brutos") || (ingresos.Text == "") )
                 
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                String Vrazon = razon.Text,
                       Vnombre = nombre.Text,
                       Vdomicilio = domicilio.Text,
                       Vtel = tel.Text,
                       VClocalidad = getCodigo(comboBox2.Text).ToString(),
                       VCresponsable = getCodigo(comboBox1.Text).ToString(),
                       VCDocumento= getCodigo(comboBox3.Text).ToString(),
                       VNDocumento=NDocumento.Text,
                       Vingresos=ingresos.Text;   

                AltaCliente(Vrazon, Vnombre, Vdomicilio, Vtel, VClocalidad, VCresponsable, VCDocumento, VNDocumento, Vingresos);
                MessageBox.Show("Se ha dado de alta un Cliente.");

                razon.Text = "";
                nombre.Text = "";
                domicilio.Text = "";
                tel.Text = "";
                VClocalidad = "";
                comboBox1.Text = "";
                VCDocumento = "";
                NDocumento.Text = "";
                ingresos.Text = "";
                listarClientes();
                
            }
        }

       

        public void EliminarCliente(int id)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "delete from clientes where id = @id";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            var confirmResult = MessageBox.Show("¿Realmente desea eliminar este cliente?", "Confirm", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                EliminarCliente(id);
                MessageBox.Show("Se ha eliminado el cliente con id: " + id.ToString());
                listarClientes();

            }
        }

        public void ModificarCliente(int id, String Vrazon, String Vnombre, String Vdomicilio, String Vtel, String VClocalidad, String VCresponsable, String VCDocumento, String VNDocumento, String Vingresos)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "update clientes set razonSocial = @Vrazon, nombreFantasia = @Vnombre, domicilio = @Vdomicilio, telefono = @Vtel, codLocalidad = @VClocalidad, codResponsable = @VCresponsable ,codDocumento = @VCDocumento ,nroDocumento = @VNDocumento,nroIngresosBrutos = @Vingresos,where id = @id";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Vrazon", Vrazon);
            command.Parameters.AddWithValue("@Vnombre", Vnombre);
            command.Parameters.AddWithValue("@Vdomicilio", Vdomicilio);
            command.Parameters.AddWithValue("@Vtel", Vtel);
            command.Parameters.AddWithValue("@VClocalidad", VClocalidad);
            command.Parameters.AddWithValue("@VCresponsable", VCresponsable);
            command.Parameters.AddWithValue("@VCDocumento", VCDocumento);
            command.Parameters.AddWithValue("@VNDocumento", VNDocumento);
            command.Parameters.AddWithValue("@Vingresos", Vingresos);

            command.ExecuteNonQuery();

            conexion.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void razon_Click(object sender, EventArgs e)
        {
            if(razon.Text == "Razon Social")
            {
                razon.Text = "";
                razon.ForeColor = Color.Black;
            }
            
        }

        private void razon_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void razon_Leave(object sender, EventArgs e)
        {
            if(razon.Text == "")
            {
                razon.Text = "Razon Social";
                razon.ForeColor = Color.Gray;
            }
        }

        private void nombre_Leave(object sender, EventArgs e)
        {
            if (nombre.Text == "")
            {
                nombre.Text = "Nombre";
                nombre.ForeColor = Color.Gray;
            }
        }

        private void domicilio_Leave(object sender, EventArgs e)
        {
            if (domicilio.Text == "")
            {
                domicilio.Text = "Domicilio";
                domicilio.ForeColor = Color.Gray;
            }
        }

        private void tel_Leave(object sender, EventArgs e)
        {
            if (tel.Text == "")
            {
                tel.Text = "Tel";
                tel.ForeColor = Color.Gray;
            }
        }


        private void NDocumento_Leave(object sender, EventArgs e)
        {
            if (NDocumento.Text == "")
            {
                NDocumento.Text = "Nro Documento";
                NDocumento.ForeColor = Color.Gray;
            }
        }

        private void ingresos_Leave(object sender, EventArgs e)
        {
            if (ingresos.Text == "")
            {
                ingresos.Text = "Ingresos Brutos";
                ingresos.ForeColor = Color.Gray;
            }
        }

        private void nombre_Click(object sender, EventArgs e)
        {
            if (nombre.Text == "Nombre")
            {
                nombre.Text = "";
                nombre.ForeColor = Color.Black;
            }
        }

        private void domicilio_Click(object sender, EventArgs e)
        {
            if (domicilio.Text == "Domicilio")
            {
                domicilio.Text = "";
                domicilio.ForeColor = Color.Black;
            }
        }

        private void tel_Click(object sender, EventArgs e)
        {
            if (tel.Text == "Tel")
            {
                tel.Text = "";
                tel.ForeColor = Color.Black;
            }
        }



        private void NDocumento_Click(object sender, EventArgs e)
        {
            if (NDocumento.Text == "Nro Documento")
            {
                NDocumento.Text = "";
                NDocumento.ForeColor = Color.Black;
            }
        }

        private void ingresos_Click(object sender, EventArgs e)
        {
            if (ingresos.Text == "Ingresos Brutos")
            {
                ingresos.Text = "";
                ingresos.ForeColor = Color.Black;
            }
        }

        public void llenarTiposResponsable()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from tiposResponsable";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                String id = reader["id"].ToString();
                String descripcion = reader["descripcion"].ToString();

                String item = id + " - " + descripcion;

                comboBox1.Items.Add(item);
            }
           

            conexion.Close();
        }

        public void llenarComboTiposDoc()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from tiposDocumento";
            SqlCommand command = new SqlCommand(query, conexion);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                String item = "";

                String id = reader["id"].ToString();
                String nombre = reader["descripcion"].ToString();


                item = id + " - " + nombre;

                comboBox3.Items.Add(item);
            }

            conexion.Close();
        }

        public void llenarComboLocalidades()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from localidades";
            SqlCommand command = new SqlCommand(query, conexion);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                String item = "";

                int id = Convert.ToInt32(reader["id"]);
                String nombre = reader["nombre"].ToString();


                item = id.ToString() + " - " + nombre;

                comboBox2.Items.Add(item);
            }

            conexion.Close();
        }

        private void ABMClientes_Load(object sender, EventArgs e)
        {
            listarClientes();
            llenarTiposResponsable();
            llenarComboLocalidades();
            llenarComboTiposDoc();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            String sId = "";

            if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                sId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }

            if (sId != "")
            {
                int id = Convert.ToInt32(sId);

                if (id.ToString() != "")
                {
                    if ((razon.Text == "RazonSocial") || (razon.Text == "") ||
                    (nombre.Text == "Nombre") || (nombre.Text == "") ||
                    (domicilio.Text == "Domicilio") || (domicilio.Text == "") ||
                    (tel.Text == "Tel") || (tel.Text == "") ||
                    (comboBox2.Text == "") ||

                    (comboBox3.Text == "") ||
                    (NDocumento.Text == "Nro Documento") || (NDocumento.Text == "") ||
                    (ingresos.Text == "IngresosBrutos") || (ingresos.Text == ""))
                    {
                        MessageBox.Show("Complete todos los campos.");
                    }
                    else
                    {
                        String Vrazon = razon.Text,
                        Vnombre = nombre.Text,
                        Vdomicilio = domicilio.Text,
                        Vtel = tel.Text,
                        VClocalidad = getCodigo(comboBox2.Text).ToString(),
                        VCresponsable = getCodigo(comboBox1.Text).ToString(),
                        VCDocumento = getCodigo(comboBox3.Text).ToString(),
                        VNDocumento = NDocumento.Text,
                        Vingresos = ingresos.Text;

                        //AHORA MODIFICAR

                        ModificarCliente(id, Vrazon, Vnombre, Vdomicilio, Vtel, VClocalidad, VCresponsable, VCDocumento, VNDocumento, Vingresos);
                        MessageBox.Show("Se ha modificado el cliente");
                        listarClientes();

                        Vrazon = "";
                        Vnombre = "";
                        Vdomicilio = "";
                        Vtel = "";
                        VClocalidad = "";

                        VCDocumento = "";
                        VNDocumento = "";
                        Vingresos = "";
                    }
                }

            }

        }
    }
}
