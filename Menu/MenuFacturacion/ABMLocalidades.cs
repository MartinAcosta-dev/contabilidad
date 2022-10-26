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
    public partial class ABMLocalidades : Form
    {
        public ABMLocalidades()
        {
            InitializeComponent();
        }

        public int getCodProvincia(String palabra)
        {
            String sResultado = "";
            int resultado;
            int i = 0;

            while (palabra[i].ToString() != " ")
            {
                sResultado = sResultado + palabra[i].ToString();
                i++;
            }

            resultado = Convert.ToInt32(sResultado);

            return resultado;
        }

        public void AltaLocalidad(String nombre, int codPostal, int codProvincia)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "insert into localidades values (@nombre,@codPostal,@codProvincia)";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@codPostal", codPostal);
            command.Parameters.AddWithValue("@codProvincia", codProvincia);
            command.ExecuteNonQuery();

            conexion.Close();
        }

        public void listarLocalidades()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            string query = "select * from localidades";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable(); //Esto es como una tabla virtual
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[3].Width = 60;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                int codPostal;
                if (int.TryParse(textBox2.Text, out codPostal))
                {
                    String nombre = textBox1.Text;
                    int codProvincia = getCodProvincia(comboBox1.Text);

                    AltaLocalidad(nombre, codPostal, codProvincia);
                    MessageBox.Show("Se ha dado de alta una localidad");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "";
                    listarLocalidades();
                }

            }
            
        }

        public void LlenarComboProvincias()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from provincias";
            SqlCommand command = new SqlCommand(query, conexion);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                String item = "";

                int id = Convert.ToInt32(reader["id"]);
                String nombre = reader["nombre"].ToString();


                item = id.ToString() + " - " + nombre;

                comboBox1.Items.Add(item);
            }

            conexion.Close();
        }

        private void ABMLocalidades_Load(object sender, EventArgs e)
        {
            listarLocalidades();
            LlenarComboProvincias();
        }
    }
}
