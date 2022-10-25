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
    public partial class ABMCondicionesComerciales : Form
    {
        public ABMCondicionesComerciales()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void listarCondiciones()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            string query = "select * from condicionesComerciales";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable(); //Esto es como una tabla virtual
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void AltaCondicionComercial(String descripcion)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "insert into condicionesComerciales values (@descripcion)";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@descripcion", descripcion);
            command.ExecuteNonQuery();


            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                String descripcion = textBox1.Text;

                AltaCondicionComercial(descripcion);
                MessageBox.Show("Se ha dado de alta una condicion comercial");
                listarCondiciones();
                textBox1.Text = "";
            }
        }

        private void ABMCondicionesComerciales_Load(object sender, EventArgs e)
        {
            listarCondiciones();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            String descripcion = dataGridView1.SelectedCells[1].Value.ToString();

            textBox1.Text = descripcion;
        }

        public Boolean condicionExiste(String descripcion)
        {
            Boolean resultado = false;
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from condicionesComerciales where descripcion = @descripcion";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@descripcion", descripcion);

            SqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                resultado = true;
            }

            conexion.Close();

            return resultado;
        }

        public void EliminarCondicion(String descripcion)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "delete from condicionesComerciales where descripcion = @descripcion";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@descripcion", descripcion);
            command.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Registro eliminado con éxito.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String descripcion = textBox1.Text;

            if (descripcion != "")
            {

                if (condicionExiste(descripcion) == true)
                {
                    EliminarCondicion(descripcion);
                    listarCondiciones();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Esta condicion no existe.");
                }
            }
        }
    }
}
