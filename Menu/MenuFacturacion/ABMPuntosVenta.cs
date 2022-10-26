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

namespace Sistema.Menu.MenuFacturacion
{
    public partial class ABMPuntosVenta : Form
    {
        public ABMPuntosVenta()
        {
            InitializeComponent();
        }

        public void listarPuntosDeVenta()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);

            string query = "select * from puntosDeVenta";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable(); //Esto es como una tabla virtual
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ABMPuntosVenta_Load(object sender, EventArgs e)
        {
            listarPuntosDeVenta();
        }

        public void AltaPuntoDeVenta(int numero)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "insert into puntosDeVenta values (@numero)";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@numero", numero);
            command.ExecuteNonQuery();
            MessageBox.Show("Se ha dado de alta un punto de venta.");
            
        }


        public Boolean puntoDeVentaExiste(int numero)
        {
            Boolean resultado = false;
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from puntosDeVenta where numero = @numero";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@numero", numero);

            SqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                resultado = true;
            }

            conexion.Close();

            return resultado;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int numeroEntero;
            if( int.TryParse(textBox2.Text, out numeroEntero) )
            {
                if ( puntoDeVentaExiste(numeroEntero) == false) 
                {
                    AltaPuntoDeVenta(numeroEntero);
                    listarPuntosDeVenta();
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Este punto de venta ya existe.");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String numero = dataGridView1.SelectedCells[1].Value.ToString();

            textBox2.Text = numero;
        }

        public void EliminarPuntoDeVenta(int numero)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "delete from puntosDeVenta where numero = @numero";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@numero", numero);
            command.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Registro eliminado con éxito.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String numero = textBox2.Text;

            if(numero != "")
            {
                int nNumero = Convert.ToInt32(numero);

                if (puntoDeVentaExiste(nNumero) == true)
                {
                    EliminarPuntoDeVenta(nNumero);
                    listarPuntosDeVenta();
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Este punto de venta no existe.");
                }
            }
            
        }

        public void ModificarPuntoDeVenta(int numero, int nuevoNumero)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();

            string query = "update puntosDeVenta set numero = @nuevoNumero where numero = @numero";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nuevoNumero", nuevoNumero);
            command.Parameters.AddWithValue("@numero", numero);
            command.ExecuteNonQuery();


            conexion.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sNumero = "";

            if (dataGridView1.SelectedCells[1].Value != null)
            {
               sNumero = dataGridView1.SelectedCells[1].Value.ToString();
            }
            
            
            if (sNumero != "")
            {
                int numero = Convert.ToInt32(sNumero);
                String sNuevoNumero = textBox2.Text;

                if (sNuevoNumero != "")
                {
                    int nuevoNumero = Convert.ToInt32(sNuevoNumero);

                    if (puntoDeVentaExiste(nuevoNumero) == true)
                    {
                        MessageBox.Show("El punto de venta ya existe");
                    }
                    else
                    {
                        ModificarPuntoDeVenta(numero, nuevoNumero);
                        listarPuntosDeVenta();
                        MessageBox.Show("Se ha modificado el registro.");
                    }
                }
            }

        }
    }
}
