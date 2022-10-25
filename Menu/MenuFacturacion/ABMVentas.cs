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
    public partial class ABMVentas : Form
    {
        public ABMVentas()
        {
            InitializeComponent();
        }

        public void listarProductos()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from productos";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                String id = reader["id"].ToString();
                String nombre = reader["nombre"].ToString();
                comboBox1.Items.Add(id + " - " + nombre);
            }


            conexion.Close();
        }

        public void ActualizarSubtotal()
        {
            float subtotal = 0;

            for(int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                subtotal = subtotal + float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }

            labelSubtotal.Text = Global.getImporteString(subtotal);
        }

        public Boolean productoExisteEnTabla(int idProducto, ref int pos)
        {
            Boolean resultado = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                String idProductoEnTabla = dataGridView1.Rows[i].Cells[0].Value.ToString();

                if (idProducto.ToString() == idProductoEnTabla)
                {
                    resultado = true;
                    pos = i;
                }
            }

            return resultado;
        }

        public void AgregarProducto(int idProducto, int cantidad)
        {
            int pos = 0;


            //Ver si existe el nro de renglon que se carga
            if (productoExisteEnTabla(idProducto, ref pos))
            {

                int filaAModificar = pos;

                dataGridView1.Rows[filaAModificar].Cells[0].Value = idProducto;
                dataGridView1.Rows[filaAModificar].Cells[1].Value = cantidad;
                

            }
            else
            {
                dataGridView1.ColumnCount = 9;


                dataGridView1.RowCount = dataGridView1.RowCount + 1;
                int fila = dataGridView1.RowCount - 1;

                //HACER QUERY Y LLENAR CAMPOS


                dataGridView1.Rows[fila].Cells[0].Value = idProducto;
               

                

            }

            ActualizarSubtotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarProducto(1,2);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelTotalProductoCant.Text = "Hola";
        }

        public void listarClientes()
        {

        }

        public void listarCondicionesComerciales()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from condicionesComerciales";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                String id = reader["id"].ToString();
                String descripcion = reader["descripcion"].ToString();

                comboBox5.Items.Add(id + " - " + descripcion);

            }

            conexion.Close();
        }

        private void ABMVentas_Load(object sender, EventArgs e)
        {
            listarProductos();
            listarClientes();
            listarCondicionesComerciales();
        }
    }
}
