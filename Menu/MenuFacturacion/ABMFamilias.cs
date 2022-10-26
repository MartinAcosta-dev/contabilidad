﻿using System;
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
    public partial class ABMFamilias : Form
    {
        public ABMFamilias()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void listarFamilias()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            string query = "select * from familias";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable(); //Esto es como una tabla virtual
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void AltaFamilia(String nombre)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "insert into familias values (@nombre)";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.ExecuteNonQuery();


            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                String nombre = textBox1.Text;

                AltaFamilia(nombre);
                MessageBox.Show("Se ha dado de alta una familia");
                listarFamilias();
                textBox1.Text = "";
            }
        }

        private void ABMCondicionesComerciales_Load(object sender, EventArgs e)
        {
            listarFamilias();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            String descripcion = dataGridView1.SelectedCells[1].Value.ToString();

            textBox1.Text = descripcion;
        }

        public Boolean condicionExiste(String nombre)
        {
            Boolean resultado = false;
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from familias where nombre = @nombre";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nombre", nombre);

            SqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                resultado = true;
            }

            conexion.Close();

            return resultado;
        }

        public void EliminarFamilia(String nombre)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "delete from familias where descripcion = @nombre";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Registro eliminado con éxito.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;

            if (nombre != "")
            {

                if (condicionExiste(nombre) == true)
                {
                    EliminarFamilia(nombre);
                    listarFamilias();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Esta Familia no existe.");
                }
            }
        }
    }
}
