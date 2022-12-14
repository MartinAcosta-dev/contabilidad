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

        public void corregirPreciosUnitarios()
        {
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value != null)
                {
                    dataGridView1.Rows[i].Cells[4].Value = Global.getImporteString(float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()));

                }
            }
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

            corregirPreciosUnitarios();

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
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from familias";
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

        public void llenarComboCodImpuestos()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from tiposDeImpuesto";
            SqlCommand command = new SqlCommand(query, conexion);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                String item = "";

                int id = Convert.ToInt32(reader["id"]);
                String descripcion = reader["descripcion"].ToString();
                String porcentaje = reader["porcentaje"].ToString();

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

        public void AltaProducto(String nombre, int cant, float precioUnitario, int codFamilia , int codImpuesto, int cantImpInternos)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "insert into productos values (@nombre, @codFamilia, @cant , @precioUnitario, @codImpuesto, @cantImpInternos)";
            SqlCommand command = new SqlCommand(query, conexion);

            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@cant", cant);
            command.Parameters.AddWithValue("@precioUnitario", precioUnitario);
            command.Parameters.AddWithValue("@codFamilia", codFamilia);
            command.Parameters.AddWithValue("@codImpuesto", codImpuesto);
            command.Parameters.AddWithValue("@cantImpInternos", cantImpInternos);

            command.ExecuteNonQuery();
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

                    AltaProducto(nombre, cant, float.Parse(Global.getImporteString(precioUnitario)), codFamilia, codImpuesto, 0);
                    MessageBox.Show("Se ha dado de alta un producto.");

                    textBox1.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    listarProductos();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            String id = dataGridView1.SelectedCells[0].Value.ToString();
            String nombre = dataGridView1.SelectedCells[1].Value.ToString();
            String codFamilia = dataGridView1.SelectedCells[2].Value.ToString();
            String cantidad = dataGridView1.SelectedCells[3].Value.ToString();
            String precioUnitario = dataGridView1.SelectedCells[4].Value.ToString();
            String codImpuesto = dataGridView1.SelectedCells[5].Value.ToString();
            String cantImpuestosInternos = dataGridView1.SelectedCells[6].Value.ToString();
            Boolean bEncontrado = false;
            Boolean bCorte = false;
            String familia;

            if (id != "")
            {
                textBox1.Text = nombre;
                textBox3.Text = cantidad;
                textBox4.Text = precioUnitario;

                int i = 0;

                while ((bEncontrado == false) && (bCorte == false))
                {
                    familia = GetCodFamilia(comboBox1.Items[i].ToString()).ToString();

                    if (familia == codFamilia)
                    {
                        comboBox1.Text = comboBox1.Items[i].ToString();
                        bEncontrado = true;
                    }
                    else
                    {
                        i++;
                    }

                    if (i == comboBox1.Items.Count - 1)
                    {
                        bCorte = true;
                    }

                }

                //Combo 2
                int j = 0;

                bEncontrado = false;
                bCorte = false;

                while ((bEncontrado == false) && (bCorte == false))
                {
                    familia = GetCodImpuesto(comboBox2.Items[j].ToString()).ToString();

                    if (familia == codFamilia)
                    {
                        comboBox2.Text = comboBox2.Items[j].ToString();
                        bEncontrado = true;
                    }
                    else
                    {
                        j++;
                    }

                    if (j == comboBox2.Items.Count - 1) 
                    {
                        bCorte = true;
                    }

                }

            }

        }

        public void EliminarProducto(int id)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "delete from productos where id = @id";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                
                var confirmResult = MessageBox.Show("¿Realmente desea eliminar este producto?", "Confirm", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    EliminarProducto(id);
                    MessageBox.Show("Se ha eliminado el producto con id: " + id.ToString());
                    listarProductos();

                }
            }
       
        }

        public void ModificarProducto(int id, String nombre, int codFamilia, int cant, float precioUnitario, int codImpuesto, int cantImpuestosInternos)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "update productos set nombre = @nombre, codFamilia = @codFamilia, cantidad = @cantidad, precioUnitario = @precioUnitario, codImpuesto = @codImpuesto, cantImpuestosInternos = @cantImpuestosInternos where id = @id";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@codFamilia", codFamilia);
            command.Parameters.AddWithValue("@cantidad", cant);
            command.Parameters.AddWithValue("@precioUnitario", precioUnitario);
            command.Parameters.AddWithValue("@codImpuesto", codImpuesto);
            command.Parameters.AddWithValue("@cantImpuestosInternos", cantImpuestosInternos);

            command.ExecuteNonQuery();

            conexion.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sId = "";

            if(dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                sId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }

            if (sId != "")
            {
                int id = Convert.ToInt32(sId);

                String sNuevoNombre = textBox1.Text;
                int nuevaCantidad;
                float nuevoPrecioUnitario;

                if(int.TryParse(textBox3.Text , out nuevaCantidad) && float.TryParse(textBox4.Text, out nuevoPrecioUnitario) ){
                    if(comboBox1.Text != "" && comboBox2.Text != "")
                    {
                        String sNuevoCodFamilia = comboBox1.Text;
                        String sNuevoCodImpuesto = comboBox2.Text;

                        int nuevoCodFamilia = GetCodFamilia(sNuevoCodFamilia);
                        int nuevoCodImpuesto = GetCodImpuesto(sNuevoCodImpuesto);

                        //AHORA MODIFICAR

                        ModificarProducto(id, sNuevoNombre, nuevoCodFamilia, nuevaCantidad, nuevoPrecioUnitario, nuevoCodImpuesto, 0);
                        MessageBox.Show("Se ha modificado el producto");
                        listarProductos();
                        textBox1.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                    }
                }

              
            }
        }
    }
}
