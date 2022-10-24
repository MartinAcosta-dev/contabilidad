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
    public partial class ABMTiposDeImpuesto : Form
    {
        public ABMTiposDeImpuesto()
        {
            InitializeComponent();
        }

        public void listarTiposDeImpuesto()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            string query = "select * from tiposDeImpuesto";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable(); //Esto es como una tabla virtual
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        public void AltaTipoDeImpuesto(String descripcion, String porcentaje)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "insert into tiposDeImpuesto values(@descripcion, @porcentaje)";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@descripcion", descripcion);
            command.Parameters.AddWithValue("@porcentaje", porcentaje);
            command.ExecuteNonQuery();

            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(textBox1.Text =="")
            {
                MessageBox.Show("Complete todos los campos.");
            }
            else
            {
                String descripcion = textBox1.Text;
                String porcentaje = Global.getImporteString(float.Parse(numericUpDown1.Value.ToString()));

                AltaTipoDeImpuesto(descripcion, porcentaje);
                MessageBox.Show("Se ha dado de alta el tipo de impuesto.");
                textBox1.Text = "";
                numericUpDown1.Value = 0;

                listarTiposDeImpuesto();
            }
        }

        private void ABMTiposDeImpuesto_Load(object sender, EventArgs e)
        {
            listarTiposDeImpuesto();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String descripcion = dataGridView1.SelectedCells[1].Value.ToString();
            String porcentaje = dataGridView1.SelectedCells[2].Value.ToString();

            if(descripcion != "" && porcentaje != "")
            {
                textBox1.Text = descripcion;
                numericUpDown1.Value = decimal.Parse(porcentaje);
            }
            
        }

        public void EliminarTipoDeImpuesto(int id)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "delete from tiposDeImpuesto where id = @id";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            EliminarTipoDeImpuesto(id);
            MessageBox.Show("Se ha eliminado el tipo de impuesto");

            textBox1.Text = "";
            numericUpDown1.Value = decimal.Parse("0.00");
            listarTiposDeImpuesto();
        }

        public void modificarTipoDeImpuesto(int id, String descripcion, String porcentaje)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "update tiposDeImpuesto set descripcion = @descripcion, porcentaje = @porcentaje where id = @id";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@descripcion", descripcion);
            command.Parameters.AddWithValue("@porcentaje", porcentaje);
            command.ExecuteNonQuery();

            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            String descripcion = textBox1.Text;
            String porcentaje = Global.getImporteString(float.Parse(numericUpDown1.Value.ToString()));
            if (descripcion == "" || porcentaje == "")
            {
                MessageBox.Show("Complete los campos a modificar");
            }
            else
            {
                modificarTipoDeImpuesto(id, descripcion, porcentaje);
                MessageBox.Show("Se ha modificado el tipo de impuesto");

                textBox1.Text = "";
                numericUpDown1.Value = decimal.Parse("0.00");
                listarTiposDeImpuesto();
            }

        }
    }
}
