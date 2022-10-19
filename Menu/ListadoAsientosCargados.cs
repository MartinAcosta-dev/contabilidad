using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{

    public partial class ListadoAsientosCargados : Form
    {
       

        public ListadoAsientosCargados()

        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ListarAsientos(DataGridView datagrid)
        {
            datagrid.RowCount = 1;
            datagrid.ColumnCount = 12;
            datagrid.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);

            int fila = 0;

            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from asientosTemp";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();



            while (reader.Read())
            {
                datagrid.RowCount = datagrid.RowCount + 1;

                datagrid.Rows[fila].Cells[0].Value = reader["fechacont"].ToString();
                datagrid.Rows[fila].Cells[1].Value = reader["nroAsiento"].ToString();
                datagrid.Rows[fila].Cells[2].Value = reader["tipo"].ToString();
                datagrid.Rows[fila].Cells[3].Value = reader["nroRenglon"].ToString();
                datagrid.Rows[fila].Cells[4].Value = reader["nroCuenta"].ToString();
                datagrid.Rows[fila].Cells[5].Value = reader["nombreCuenta"].ToString();
                datagrid.Rows[fila].Cells[6].Value = reader["FechaOp"].ToString();
                datagrid.Rows[fila].Cells[7].Value = reader["fechaVto"].ToString();
                datagrid.Rows[fila].Cells[8].Value = reader["comprobante"].ToString();
                datagrid.Rows[fila].Cells[9].Value = reader["debehaber"].ToString();
                datagrid.Rows[fila].Cells[10].Value = reader["importe"].ToString();
                datagrid.Rows[fila].Cells[11].Value = reader["leyenda"].ToString();

                fila++;

            }

            conexion.Close();

        }

        private void ListadoAsientosCargados_Load(object sender, EventArgs e)
        {
            ListarAsientos(dataGridView1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarAsientos(dataGridView1);
        }
    }
}
