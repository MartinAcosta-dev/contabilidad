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
    public partial class ABMProductos : Form
    {
        public ABMProductos()
        {
            InitializeComponent();
        }

        public void listarProductos()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            string query = "select * from productos";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable(); //Esto es como una tabla virtual
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[6].Width = dataGridView1.Columns[6].Width + 20;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Nombre")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Nombre";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Cant.")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Precio unitario")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Cant.";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Precio unitario";
                textBox4.ForeColor = Color.Gray;
            }
        }

        public void llenarComboCodFamilias()
        {
            comboBox1.Items.Add("4 - Hola");
        }

        public void llenarComboCodImpuestos()
        {
            int id = 0;
            String descripcion = "";
            String porcentaje = "";
            String item = "";

            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from tiposDeImpuesto";
            SqlCommand command = new SqlCommand(query, conexion);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                item = "";

                id = Convert.ToInt32(reader["id"]);
                descripcion = reader["descripcion"].ToString();
                porcentaje = reader["porcentaje"].ToString();

                item = id.ToString()+" - "+descripcion+" ("+porcentaje+")";

                comboBox2.Items.Add(item);
            }

            conexion.Close();
        }
        private void ABMProductos_Load(object sender, EventArgs e)
        {
            listarProductos();
            llenarComboCodFamilias();
            llenarComboCodImpuestos();
        }

        public int GetCodFamilia(String cadena)
        {
            int resultado = 0;
            String sResultado = "";

            int i = 0;
            String letra = "";

            while (letra != " ")
            {
                letra = cadena[i].ToString();
                sResultado = sResultado + cadena[i];
                i++;
            }

            resultado = Convert.ToInt32(sResultado);

            return resultado;
        }

        public int GetCodImpuesto(String cadena)
        {
            int resultado = 0;
            String sResultado = "";

            int i = 0;
            String letra = "";

            while ( letra != " " ) 
            {
                letra = cadena[i].ToString();
                sResultado = sResultado + cadena[i];
                i++;
            }

            resultado = Convert.ToInt32(sResultado);

            return resultado;
        }

        public void AltaProducto(String nombre, int cant, float precioUnitario, int codFamilia , int codImpuesto)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "insert into productos values (@nombre, @cant, @precioUnitario, @codFamilia, @codImpuesto)";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@cant", cant);
            command.Parameters.AddWithValue("@precioUnitario", precioUnitario);
            command.Parameters.AddWithValue("@codFamilia", codFamilia);
            command.Parameters.AddWithValue("@codImpuesto", codImpuesto);


            command.ExecuteNonQuery();
            MessageBox.Show("Se ha dado de alta un producto.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( (textBox1.Text == "Nombre") || (textBox1.Text == "") ||              
                (textBox3.Text == "Cant.") || (textBox3.Text == "") ||
                (textBox4.Text == "Precio unitario") || (textBox4.Text == "") ||
                (comboBox1.Text == "") || (comboBox2.Text == "") )
                 
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                float precioUnitario;
                int cant;

                if (float.TryParse(textBox4.Text, out precioUnitario) && (int.TryParse(textBox3.Text, out cant)))
                {
                    String nombre = textBox1.Text;
                    int codFamilia = GetCodFamilia(comboBox1.Text);
                    int codImpuesto = GetCodImpuesto(comboBox2.Text);

                    AltaProducto(nombre, cant, precioUnitario, codFamilia, codImpuesto);

                    textBox1.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    listarProductos();
                }
            }
        }
    }
}
