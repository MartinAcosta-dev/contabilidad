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

        

        public void listarClientes()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            string query = "select * from clientes";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable(); //Esto es como una tabla virtual
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[6].Width = dataGridView1.Columns[6].Width + 20;

            

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
            if( (razon.Text == "RazonSocial") || (razon.Text == "") ||              
                (nombre.Text == "Nombre") || (nombre.Text == "") ||
                (domicilio.Text == "Domicilio") || (domicilio.Text == "") ||
                (tel.Text == "Tel") || (tel.Text == "") ||
                (Clocalidad.Text == "CodigoLocalidad") || (Clocalidad.Text == "") ||
                (Cresponsable.Text == "CodigoResponsable") || (Cresponsable.Text == "") ||
                (CDocumento.Text == "Cod Documento") || (CDocumento.Text == "") ||
                (NDocumento.Text == "Nro Documento") || (NDocumento.Text == "") ||
                (ingresos.Text == "IngresosBrutos") || (ingresos.Text == "") )
                 
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
               String Vrazon= razon.Text ,
                    Vnombre= nombre.Text, 
                    Vdomicilio =domicilio.Text,
                    Vtel=tel.Text, 
                    VClocalidad=Clocalidad.Text, 
                    VCresponsable=Cresponsable.Text,
                    VCDocumento=CDocumento.Text,
                    VNDocumento=NDocumento.Text,
                    Vingresos=ingresos.Text;

               
                   

                    AltaCliente(Vrazon, Vnombre, Vdomicilio, Vtel, VClocalidad, VCresponsable, VCDocumento, VNDocumento, Vingresos);
                    MessageBox.Show("Se ha dado de alta un Cliente.");

                Vrazon = "";
                    Vnombre = "";
                Vdomicilio = "";
                Vtel = "";
                VClocalidad = "";
                VCresponsable = "";
                VCDocumento = "";
                VNDocumento = "";
                Vingresos = "";
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
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            MessageBox.Show(id.ToString());

            if (id.ToString() != "")
            {                           
                if((razon.Text == "RazonSocial") || (razon.Text == "") ||
                (nombre.Text == "Nombre") || (nombre.Text == "") ||
                (domicilio.Text == "Domicilio") || (domicilio.Text == "") ||
                (tel.Text == "Tel") || (tel.Text == "") ||
                (Clocalidad.Text == "CodigoLocalidad") || (Clocalidad.Text == "") ||
                (Cresponsable.Text == "CodigoResponsable") || (Cresponsable.Text == "") ||
                (CDocumento.Text == "Cod Documento") || (CDocumento.Text == "") ||
                (NDocumento.Text == "Nro Documento") || (NDocumento.Text == "") ||
                (ingresos.Text == "IngresosBrutos") || (ingresos.Text == ""))
                    {
                    String Vrazon = razon.Text,
                 Vnombre = nombre.Text,
                 Vdomicilio = domicilio.Text,
                 Vtel = tel.Text,
                 VClocalidad = Clocalidad.Text,
                 VCresponsable = Cresponsable.Text,
                 VCDocumento = CDocumento.Text,
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
                    VCresponsable = "";
                    VCDocumento = "";
                    VNDocumento = "";
                    Vingresos = "";
                }
                

              
            }
        }
    }
}
