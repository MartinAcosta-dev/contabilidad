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

namespace Sistema
{
    public partial class Asientos : Form
    {
        public Asientos()
        {
            InitializeComponent();

        }

        public String getFechaCierreEj()
        {
            String resultado = "";

            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);

            conexion.Open();
            String query = "Select * from infoEmpresa";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                resultado = lector["fechaCierre"].ToString();
            }

            conexion.Close();

            return resultado;
        }

        public void cargarCuentas()
        {
            int nroCuenta;
            String nombreCuenta;
            int tipo;
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from plandecuentas";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                nroCuenta = Convert.ToInt32(reader["numero"]);
                nombreCuenta = reader["nombre"].ToString();
                tipo = Convert.ToInt32(reader["tipo"]);

                if (tipo == 1) {
                    comboBox2.Items.Add(nroCuenta.ToString() + " - " + nombreCuenta);
                }
            }
            conexion.Close();
            //comboBox2
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = false;
            cargarCuentas();
            label16.Text = getFechaCierreEj();
            label17.Text = getultimaEmision();
            button7.Enabled = false;
            button9.Enabled = false;

        }

        private string getultimaEmision()
        {
            String resultado = "";
            //AGREGAR
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "SELECT * FROM ultimaEmision";
            SqlCommand comandoaux = new SqlCommand(query, conexion);
            comandoaux = new SqlCommand(query, conexion);
            SqlDataReader reader = comandoaux.ExecuteReader();
            if (reader.Read())
            {
                resultado = reader["fechaUltimaEmision"].ToString();
            }


            conexion.Close();
            return resultado;
        }

        private void CancelarEAñadir_Click(object sender, EventArgs e)
        {
            MenuModuloContable menumodulocontableForm = new MenuModuloContable();
            menumodulocontableForm.Show();
            this.Close();


            //form1.Show();
            //PARA ABRIR EL MENU DENUEVO EN CASO QUE LO CIERRE
            ;
        }

        private void AñadirEConfirm_Click(object sender, EventArgs e)
        {








        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public Boolean permitirCargaDeAsiento()
        {
            Boolean resultado;

            if (label15.Text == "0")
            {
                resultado = true;
            }
            else
            {
                resultado = false;
                MessageBox.Show("No se cumple la partida doble.");
            }

            return resultado;
        }

        public void ActualizarUltimoNroAsientoEmitido()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from ultimoNroAsiento";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                int viejoNro = Convert.ToInt32(lector["numero"]);
                int nuevoNro = viejoNro + 1;

                query = "update ultimoNroAsiento set numero = @nuevoNumero";
                command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@nuevoNumero", nuevoNro);
                command.ExecuteNonQuery();

            }

            conexion.Close();
        }

        public void cargarAsiento(String fechaCont, int nroAsiento, int nTipo, int nroRenglon, int nroCuenta, String nombreCuenta, String fechaOp, String fechaVto, String comprobante, String leyenda, float importe, int destino)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "insert into asientosTemp (fechaCont, nroAsiento, tipo, nroRenglon, nroCuenta, nombreCuenta, fechaOp, fechaVto, comprobante, debehaber, importe, leyenda) "
                + "VALUES (@fechaCont , @nroAsiento , @nTipo , @nroRenglon, @nroCuenta, @nombreCuenta , @fechaOp , @fechaVto , @comprobante , @destino, @importe, @leyenda )";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@fechaCont", fechaCont);
            command.Parameters.AddWithValue("@nroAsiento", nroAsiento);
            command.Parameters.AddWithValue("@nTipo", nTipo);
            command.Parameters.AddWithValue("@nroRenglon", nroRenglon);
            command.Parameters.AddWithValue("@nroCuenta", nroCuenta);
            command.Parameters.AddWithValue("@nombreCuenta", nombreCuenta);
            command.Parameters.AddWithValue("@fechaOp", fechaOp);
            command.Parameters.AddWithValue("@fechaVto", fechaVto);
            command.Parameters.AddWithValue("@comprobante", comprobante);
            command.Parameters.AddWithValue("@leyenda", leyenda);
            command.Parameters.AddWithValue("@importe", importe);
            command.Parameters.AddWithValue("@destino", destino);
            command.ExecuteNonQuery();

            conexion.Close();
        }

        public void RegistrarAsiento(int nroAsiento)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from asientosTemp where nroAsiento = @nroAsiento";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nroAsiento", nroAsiento);

            SqlDataReader lector = command.ExecuteReader();

            while (lector.Read())
            {
                String fechaCont = lector["fechaCont"].ToString();
                int tipo = Convert.ToInt32(lector["tipo"]);
                int nroRenglon = Convert.ToInt32(lector["nroRenglon"]);
                int nroCuenta = Convert.ToInt32(lector["nroCuenta"]);
                String nombreCuenta = lector["nombreCuenta"].ToString();
                String fechaOp = lector["fechaOp"].ToString();
                String fechaVto = lector["fechaVto"].ToString();
                String comprobante = lector["comprobante"].ToString();
                int debehaber = Convert.ToInt32(lector["debehaber"]);
                float importe = float.Parse(lector["importe"].ToString());
                String leyenda = lector["leyenda"].ToString();

                String query2 = "insert into libroMayor (fechaCont, nroAsiento, tipo, nroRenglon, nroCuenta, nombreCuenta, fechaOp, fechaVto, comprobante, debehaber, importe, leyenda) "
                + "VALUES (@fechaCont , @nroAsiento , @nTipo , @nroRenglon, @nroCuenta, @nombreCuenta , @fechaOp , @fechaVto , @comprobante , @destino, @importe, @leyenda )";

                SqlCommand command2 = new SqlCommand(query2, conexion);
                command2.Parameters.AddWithValue("@fechaCont", fechaCont);
                command2.Parameters.AddWithValue("@nroAsiento", nroAsiento);
                command2.Parameters.AddWithValue("@nTipo", tipo);
                command2.Parameters.AddWithValue("@nroRenglon", nroRenglon);
                command2.Parameters.AddWithValue("@nroCuenta", nroCuenta);
                command2.Parameters.AddWithValue("@nombreCuenta", nombreCuenta);
                command2.Parameters.AddWithValue("@fechaOp", fechaOp);
                command2.Parameters.AddWithValue("@fechaVto", fechaVto);
                command2.Parameters.AddWithValue("@comprobante", comprobante);
                command2.Parameters.AddWithValue("@destino", debehaber);
                command2.Parameters.AddWithValue("@importe", importe);
                command2.Parameters.AddWithValue("@leyenda", leyenda);

                command2.ExecuteNonQuery();

            }

            //AHORA ELIMINAMOS DE LOS ASIENTOS TEMPORALES
            String query3 = "delete from asientosTemp where nroAsiento = @nroAsiento";
            SqlCommand command3 = new SqlCommand(query3, conexion);
            command3.Parameters.AddWithValue("@nroAsiento", nroAsiento);
            command3.ExecuteNonQuery();

            conexion.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {


            if (permitirCargaDeAsiento() && (comboBox1.Text != ""))
            {
                String fechaCont = dateTimePicker1.Text;
                int nroAsiento = Convert.ToInt32(textBox4.Text);
                String sTipo = comboBox1.Text;
                int nTipo = 0;

                if (sTipo == "Apertura")
                {
                    nTipo = 1;
                }
                else
                {
                    if (sTipo == "Normal")
                    {
                        nTipo = 2;
                    }
                    else
                    {
                        if (sTipo == "Cierre")
                        {
                            nTipo = 3;
                        }
                    }
                }



                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    String sNroRenglon = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    int nroRenglon = Convert.ToInt32(sNroRenglon);
                    String sNroCuenta = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    int nroCuenta = Convert.ToInt32(sNroCuenta);
                    String nombreCuenta = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    String fechaOp = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    String fechaVto = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    String comprobante = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    String leyenda = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    float importe = 0;
                    int destino;
                    if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "0")
                    {
                        importe = float.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                        destino = 1;
                    }
                    else
                    {
                        importe = float.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                        destino = 0;
                    }

                    //Por cada renglon cargar un registro del asiento
                    cargarAsiento(fechaCont, nroAsiento, nTipo, nroRenglon, nroCuenta, nombreCuenta, fechaOp, fechaVto, comprobante, leyenda, importe, destino);

                }

                //Ahora hay que ver si quiere registrar el asiento.
                var confirmResult = MessageBox.Show("Se ha cargado el asiento. ¿Desea registrarlo?", "Registrar asiento", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    RegistrarAsiento(nroAsiento);
                    MessageBox.Show("Se ha registrado el asiento");
                }


                //Usamos cancelarAsiento() para limpiar el formulario
                cancelarAsiento();
                ActualizarUltimoNroAsientoEmitido();
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        public int getNuevoNro()
        {
            int resultado = 0;

            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from ultimoNroAsiento";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader lector = command.ExecuteReader();

            if (lector.Read())
            {
                int ultimoNumero = Convert.ToInt32(lector["numero"]);

                resultado = ultimoNumero + 1;


            }

            conexion.Close();

            return resultado;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Conseguir nuevo numero de asiento (viendo el ultimo emitido en asientosTemp);
            //Poner en readOnly el box de nroDeAsiento
            cancelarAsiento();
            textBox4.Enabled = false;
            button8.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;

            button7.Enabled = true;
            button9.Enabled = true;



            textBox4.Text = getNuevoNro().ToString();
            textBox5.Text = "1";


        }

        public Boolean habilitarCargaDeRenglon()
        {
            Boolean resultado = false;


            DateTime fechaVto = DateTime.Parse(dateTimePicker2.Text);
            DateTime fechaCierreEjercicio = DateTime.Parse(label16.Text);

            if ((textBox5.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && ((radioButton1.Checked) || (radioButton2.Checked)))
            {
                resultado = true;

                if (fechaVto <= fechaCierreEjercicio)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                   // MessageBox.Show("La fecha de vencimiento ingresada es mayor a la del cierre de ejercicio.");
                }
            }
            else
            {
                resultado = false;
                MessageBox.Show("Complete todos los campos del renglon.");
            }
            resultado = true;
            return resultado;
        }

        public void ActualizarPartidaDoble()
        {
            float valorDebe = 0;
            float valorHaber = 0;


            if (dataGridView1.RowCount != 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    String sImporteDebe = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    float importeDebe = float.Parse(sImporteDebe);
                    valorDebe = valorDebe + importeDebe;


                    String sImporteHaber = dataGridView1.Rows[i].Cells[8].Value.ToString();
                    float importeHaber = float.Parse(sImporteHaber);
                    valorHaber = valorHaber + importeHaber;

                }

                label13.Text = valorDebe.ToString();
                label14.Text = valorHaber.ToString();

                float valorSaldo = valorDebe - valorHaber;

                label15.Text = valorSaldo.ToString();
            }
        }

        public Boolean nroRenglonExiste(String nroRenglon, ref int pos)
        {
            Boolean resultado = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                String nroRenglonEnTabla = dataGridView1.Rows[i].Cells[0].Value.ToString();

                if (nroRenglon == nroRenglonEnTabla)
                {
                    resultado = true;
                    pos = i;
                }
            }

            return resultado;
        }

        public void agregarRenglon(String nroRenglon, int nroCuenta, String nombreEmpresa, String comprobante, String fechaOp, String fechaVto, float importe, String leyenda, int destino)
        {
            int pos = 0;


            //Ver si existe el nro de renglon que se carga
            if (nroRenglonExiste(nroRenglon, ref pos))
            {

                int filaAModificar = pos;

                dataGridView1.Rows[filaAModificar].Cells[0].Value = nroRenglon;
                dataGridView1.Rows[filaAModificar].Cells[1].Value = nroCuenta;
                dataGridView1.Rows[filaAModificar].Cells[2].Value = nombreEmpresa;
                dataGridView1.Rows[filaAModificar].Cells[3].Value = comprobante;
                dataGridView1.Rows[filaAModificar].Cells[4].Value = fechaOp;
                dataGridView1.Rows[filaAModificar].Cells[5].Value = fechaVto;
                dataGridView1.Rows[filaAModificar].Cells[6].Value = leyenda;

                if (destino == 0)
                {
                    dataGridView1.Rows[filaAModificar].Cells[7].Value = importe;
                    dataGridView1.Rows[filaAModificar].Cells[8].Value = 0;

                }
                else
                {
                    dataGridView1.Rows[filaAModificar].Cells[7].Value = 0;
                    dataGridView1.Rows[filaAModificar].Cells[8].Value = importe;

                }

            }
            else
            {
                dataGridView1.ColumnCount = 9;


                dataGridView1.RowCount = dataGridView1.RowCount + 1;
                int fila = dataGridView1.RowCount - 1;


                dataGridView1.Rows[fila].Cells[0].Value = nroRenglon;
                dataGridView1.Rows[fila].Cells[1].Value = nroCuenta;
                dataGridView1.Rows[fila].Cells[2].Value = nombreEmpresa;
                dataGridView1.Rows[fila].Cells[3].Value = comprobante;
                dataGridView1.Rows[fila].Cells[4].Value = fechaOp;
                dataGridView1.Rows[fila].Cells[5].Value = fechaVto;
                dataGridView1.Rows[fila].Cells[6].Value = leyenda;

                if (destino == 0)
                {
                    dataGridView1.Rows[fila].Cells[7].Value = importe;
                    dataGridView1.Rows[fila].Cells[8].Value = 0;

                }
                else
                {
                    dataGridView1.Rows[fila].Cells[7].Value = 0;
                    dataGridView1.Rows[fila].Cells[8].Value = importe;

                }

                textBox5.Text = (dataGridView1.RowCount + 1).ToString();

            }

            ActualizarPartidaDoble();
        }

        public int getNumeroCuenta(String cuenta) 
        {
            String resultado = "";
            String letra = "";
            int i = 0;

            while (letra != " ") {
                letra = cuenta[i].ToString();
                resultado = resultado + letra;

                i++;
            }

            return Convert.ToInt32(resultado);
        }

        public String getNombreCuenta(String cuenta) 
        {
            String resultado = "";

            int pos = cuenta.IndexOf("-") + 2;

            for (int i = pos; i < cuenta.Length; i++) 
            {
                resultado = resultado + cuenta[i].ToString();

            }

            return resultado;
        }
        public Boolean esCuenta(int nroCuenta)
        {
            Boolean resultado = false;
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from plandecuentas where Numero = @nroCuenta ";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nroCuenta", nroCuenta);

            SqlDataReader lector = command.ExecuteReader();

            int tipo = 0;

            if (lector.Read())
            {
                tipo = Convert.ToInt32(lector["Tipo"]);
            }
            else
            {
                MessageBox.Show("No se ha encontrado la cuenta");
            }

            if (tipo == 1)
            {
                resultado = true;
            }

            conexion.Close();

            return resultado;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (habilitarCargaDeRenglon())
            {
                String nroRenglon = textBox5.Text; //FALTA TOMAR EL NUMERO Y NOMBRE DE LA EMPRESA
                String cuenta = comboBox2.Text;
                int nroCuenta = getNumeroCuenta(cuenta);
                String nombreEmpresa = getNombreCuenta(cuenta);
                String comprobante = textBox2.Text;
                String fechaOp = dateTimePicker1.Text;
                String fechaVto = dateTimePicker2.Text;
                float importe = (float)numericUpDown4.Value;
                String leyenda = textBox3.Text;
                int destino;

                if (radioButton1.Checked)
                {
                    destino = 0;
                }
                else
                {
                    destino = 1;
                }

                if (esCuenta(nroCuenta) == false)
                {
                    MessageBox.Show("Ha insertado una cuenta no imputable.");
                }
                else
                {
                    agregarRenglon(nroRenglon, nroCuenta, nombreEmpresa, comprobante, fechaOp, fechaVto, importe, leyenda, destino);
                    //limpiar
                    textBox2.Text = "";
                    textBox3.Text = "";
                    numericUpDown4.Value = Convert.ToDecimal("0.00");
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    comboBox2.Text = "";
                }

            }

            

        }

       

       

        public void cancelarAsiento()
        {
            button8.Enabled = true;
            button6.Enabled = true;

            button9.Enabled = false;
            button7.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = false;
            button11.Enabled = false;

            textBox4.Text = "";
            textBox4.Enabled = false;
            comboBox1.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            numericUpDown4.Value = 0;
            textBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dataGridView1.Rows.Clear();

            label13.Text = "0.00";
            label14.Text = "0.00";
            label15.Text = "0.00";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cancelarAsiento();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void retomarAsiento(long nroAsiento)
        {
            //Limpiamos la tabla de renglones
            dataGridView1.Rows.Clear();

            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from asientosTemp where nroAsiento = @nroAsiento";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nroAsiento", nroAsiento);
            SqlDataReader reader = command.ExecuteReader();  

            if (!reader.Read())
            {
                MessageBox.Show("No se encuentra asiento con este numero.");
            }
            else
            {
                button5.Enabled = true;
                button1.Enabled = true;

                String fechaCont = reader["fechaCont"].ToString();

                int nTipo = Convert.ToInt32(reader["tipo"]);
                String sTipo;
                if (nTipo == 1)
                {
                    sTipo = "Apertura";
                }
                else
                {
                    if (nTipo == 2)
                    {
                        sTipo = "Normal";
                    }
                    else
                    {
                        sTipo = "Cierre";
                    }
                }

                dateTimePicker1.Text = fechaCont;
                comboBox1.Text = sTipo;

                //AGREGAR PRIMER FILA

                //Buscamos los datos
                String nroRenglon = reader["nroRenglon"].ToString();
                int nroCuenta = Convert.ToInt32(reader["nroCuenta"]);
                String nombreCuenta = reader["nombreCuenta"].ToString();
                String comprobante = reader["comprobante"].ToString();
                String fechaOp = reader["fechaOp"].ToString();
                String fechaVto = reader["fechaVto"].ToString();
                float importe = float.Parse(reader["importe"].ToString());
                String leyenda = reader["leyenda"].ToString();
                int destino = Convert.ToInt32(reader["debehaber"]);

                agregarRenglon(nroRenglon, nroCuenta, nombreCuenta, comprobante, fechaOp, fechaVto, importe, leyenda, destino);


                


                //AGREGAR CON UN WHILE LAS QUE RESTAN

                while (reader.Read())
                {
                     nroRenglon = reader["nroRenglon"].ToString();
                     nroCuenta = Convert.ToInt32(reader["nroCuenta"]);
                     nombreCuenta = reader["nombreCuenta"].ToString();
                     comprobante = reader["comprobante"].ToString();
                     fechaOp = reader["fechaOp"].ToString();
                     fechaVto = reader["fechaVto"].ToString();
                     importe = float.Parse(reader["importe"].ToString());
                     leyenda = reader["leyenda"].ToString();
                     destino = Convert.ToInt32(reader["debehaber"]);

                     agregarRenglon(nroRenglon, nroCuenta, nombreCuenta, comprobante, fechaOp, fechaVto, importe, leyenda, destino);

                }

                textBox4.Enabled = false;
            }

            

            conexion.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            textBox4.ReadOnly = false;


            button6.Enabled = false;
            button8.Enabled = false;

            button9.Enabled = true;

           
       
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                long nroAsiento;
                if((textBox4.Text != "") && long.TryParse(textBox4.Text, out nroAsiento))
                {
                    retomarAsiento(nroAsiento);

                    if(dataGridView1.RowCount != 0)
                    {
                        button11.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un numero de asiento a retomar.");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String nroRenglon = dataGridView1.SelectedCells[0].Value.ToString();
            String nroCuenta = dataGridView1.SelectedCells[1].Value.ToString();
            String nombreCuenta = dataGridView1.SelectedCells[2].Value.ToString();
            String comprobante = dataGridView1.SelectedCells[3].Value.ToString();
            String fechaOp = dataGridView1.SelectedCells[4].Value.ToString();
            String fechaVto = dataGridView1.SelectedCells[5].Value.ToString(); 
            String leyenda = dataGridView1.SelectedCells[6].Value.ToString();
            String importe;

            if(dataGridView1.SelectedCells[7].Value.ToString() != "0")
            {
                importe = dataGridView1.SelectedCells[7].Value.ToString();
                radioButton1.Checked = true;

            }
            else
            {
                importe = dataGridView1.SelectedCells[8].Value.ToString();
                radioButton2.Checked = true;
            }

            textBox5.Text = nroRenglon;
            comboBox2.Text = nroCuenta + " - " + nombreCuenta;
            textBox2.Text = comprobante;
            dateTimePicker2.Text = fechaVto;
            numericUpDown4.Value = Convert.ToDecimal(importe);
            textBox3.Text = leyenda;



        }

        public Boolean existeRenglonEnBBD(int nroAsiento, int nroRenglon)
        {
            Boolean resultado = false;

            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from asientosTemp where nroAsiento = @nroAsiento and nroRenglon = @nroRenglon";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nroAsiento", nroAsiento);
            command.Parameters.AddWithValue("@nroRenglon", nroRenglon);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            conexion.Close(); 
            
            return resultado;
        }

        public Boolean numeroRenglonExisteEnTabla(int nroRenglon)
        {
            Boolean resultado = false;
            Boolean bCorte = false;
            int i = 0;

            while( (bCorte == false) && (i < dataGridView1.RowCount))
            {
                int nroRenglonTabla = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

                if (nroRenglon == nroRenglonTabla)
                {
                    resultado = true;
                    bCorte = true;
                }

                i++;
            }


            return resultado;
        }

        public void ActualizarAsiento(String fechaCont, int nroAsiento, int nTipo, int nroRenglon, int nroCuenta, String nombreCuenta,String fechaOp, String fechaVto, String comprobante, String leyenda,float importe,int destino)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);

            conexion.Open();
            String query = "UPDATE asientosTemp set fechaCont = @fechaCont, tipo = @tipo, nroCuenta = @nroCuenta, nombreCuenta = @nombreCuenta ,fechaOp = @fechaOp, fechaVto = @fechaVto, comprobante = @comprobante, leyenda = @leyenda, importe = @importe, debehaber = @destino where nroAsiento = @nroAsiento and nroRenglon = @nroRenglon";

            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@fechaCont", fechaCont);
            command.Parameters.AddWithValue("@nroAsiento", nroAsiento);
            command.Parameters.AddWithValue("@tipo", nTipo);
            command.Parameters.AddWithValue("@nroRenglon", nroRenglon);
            command.Parameters.AddWithValue("@nroCuenta", nroCuenta);
            command.Parameters.AddWithValue("@nombreCuenta", nombreCuenta);
            command.Parameters.AddWithValue("@comprobante", comprobante);
            command.Parameters.AddWithValue("@fechaOp", fechaCont);
            command.Parameters.AddWithValue("@fechaVto", fechaVto);
            command.Parameters.AddWithValue("@importe", importe);
            command.Parameters.AddWithValue("@leyenda", leyenda);
            command.Parameters.AddWithValue("@destino", destino);


            command.ExecuteNonQuery();


            conexion.Close();
        }

        public void eliminarRenglon(int nroAsiento, int nroRenglon)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "delete from asientosTemp where nroAsiento = @nroAsiento and nroRenglon = @nroRenglon";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nroAsiento", nroAsiento);
            command.Parameters.AddWithValue("@nroRenglon", nroRenglon);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public void eliminarRenglonesEliminados(int nroAsiento) //Elimina los registros de la base que no esten en la tabla de la pantalla al actualizar asiento
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from asientosTemp where nroAsiento = @nroAsiento";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nroAsiento", nroAsiento);
            SqlDataReader lector = command.ExecuteReader();

            while (lector.Read())
            {
                int nroRenglon = Convert.ToInt32(lector["nroRenglon"].ToString());

                if (numeroRenglonExisteEnTabla(nroRenglon) == false)
                {
                    eliminarRenglon(nroAsiento, nroRenglon);
                }
                
            }

            conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (permitirCargaDeAsiento())
            {
                String fechaCont = dateTimePicker1.Text;
                int nroAsiento = Convert.ToInt32(textBox4.Text);
                String sTipo = comboBox1.Text;
                int nTipo = 0;

                if (sTipo == "Apertura")
                {
                    nTipo = 1;
                }
                else
                {
                    if (sTipo == "Normal")
                    {
                        nTipo = 2;
                    }
                    else
                    {
                        if (sTipo == "Cierre")
                        {
                            nTipo = 3;
                        }
                    }
                }



                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    String sNroRenglon = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    int nroRenglon = Convert.ToInt32(sNroRenglon);
                    String sNroCuenta = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    int nroCuenta = Convert.ToInt32(sNroCuenta);
                    String nombreCuenta = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    String fechaOp = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    String fechaVto = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    String comprobante = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    String leyenda = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    float importe = 0;
                    int destino;

                    if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "0")
                    {
                        importe = float.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                        destino = 1;
                    }
                    else
                    {
                        importe = float.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                        destino = 0;
                    }

                    //Por cada renglon, ver si existe. SI existe entonces hay que actualizar, sino hay que cargar.
                    
                    if(existeRenglonEnBBD(nroAsiento, nroRenglon))
                    {
                        ActualizarAsiento(fechaCont, nroAsiento, nTipo, nroRenglon, nroCuenta, nombreCuenta, fechaOp, fechaVto, comprobante, leyenda, importe, destino);
                    }
                    else
                    {
                        cargarAsiento(fechaCont, nroAsiento, nTipo, nroRenglon, nroCuenta, nombreCuenta, fechaOp, fechaVto, comprobante, leyenda, importe, destino);
                    }

                }

                //Si elimina renglones del asiento hay que actualizar en la base de datos
                eliminarRenglonesEliminados(nroAsiento);

                

                //Ahora hay que ver si quiere registrar el asiento.
                var confirmResult = MessageBox.Show("Se ha actualizado el asiento. ¿Desea registrarlo?", "Registrar asiento", MessageBoxButtons.YesNo);
                
                if (confirmResult == DialogResult.Yes)
                {
                    RegistrarAsiento(nroAsiento);
                    MessageBox.Show("Se ha registrado el asiento.");
                }

                //Usamos cancelarAsiento() para limpiar el formulario
                cancelarAsiento();

            }
        }

        private void button4_Enter(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registrar asiento");
        }

        public void eliminarAsiento(int nroAsiento)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);

            conexion.Open();
            String query = "delete from asientosTemp where nroAsiento = @nroAsiento";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nroAsiento", nroAsiento);

            command.ExecuteNonQuery();

            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nroAsiento = Convert.ToInt32(textBox4.Text);
            

            var confirmResult = MessageBox.Show("¿Realmente desea eliminar este asiento?", "Confirm", MessageBoxButtons.YesNo);

            if(confirmResult == DialogResult.Yes)
            {
                eliminarAsiento(nroAsiento);
                MessageBox.Show("Se ha eliminado el asiento numero " + nroAsiento.ToString());
                cancelarAsiento();
   
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }

            ActualizarPartidaDoble();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RegistrarEntreFechas formFechas = new RegistrarEntreFechas();
            formFechas.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int nroAsiento = Convert.ToInt32(textBox4.Text);

            var confirmResult = MessageBox.Show("¿Desea registrar este asiento?", "Registrar asiento", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                RegistrarAsiento(nroAsiento);
                MessageBox.Show("Se ha registrado el asiento.");
                cancelarAsiento();
            }
        }

        
         

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Ingrese un asiento");
            }
            else
            {
                String numAsiento = textBox4.Text.ToString();
                string filas;

                String fechaCont = dateTimePicker1.Text;
                int nroAsiento = Convert.ToInt32(textBox4.Text);
                String sTipo = comboBox1.Text;
                //CONFIG ARCHIVO PDF 
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                string PaginaHTML_Texto = Properties.Resources.AsientoSolo.ToString();
                //REEMPLAZA DATOS DE LA PLANTILLA PARA EMPRESA
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Empresa", Global.EmpresaLog);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Lista", "Asiento Nro: "+numAsiento);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHACONT", fechaCont);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NROASIENTO", nroAsiento.ToString());
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TIPO", sTipo);
                filas = string.Empty;

                String sNroRenglon ;
                int nroRenglon ;
                String sNroCuenta ;
                int nroCuenta ;
                String nombreCuenta;
                String fechaOp;
                String fechaVto ;
                String comprobante;
                String leyenda ;
                float importe,total=0;
                int destino;
                String debe, haber;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    
                     sNroRenglon = dataGridView1.Rows[i].Cells[0].Value.ToString();
                     nroRenglon = Convert.ToInt32(sNroRenglon);
                     sNroCuenta = dataGridView1.Rows[i].Cells[1].Value.ToString();
                     nroCuenta = Convert.ToInt32(sNroCuenta);
                     nombreCuenta = dataGridView1.Rows[i].Cells[2].Value.ToString();
                     fechaOp = dataGridView1.Rows[i].Cells[4].Value.ToString();
                     fechaVto = dataGridView1.Rows[i].Cells[5].Value.ToString();
                     comprobante = dataGridView1.Rows[i].Cells[3].Value.ToString();
                     leyenda = dataGridView1.Rows[i].Cells[6].Value.ToString();
                     importe = 0;
                    
                    if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "0") //debito si esta  en 0, importe lo toma col haber
                    {
                        importe = float.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                        destino = 1;
                    }
                    else
                    {
                        importe = float.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                        destino = 0;
                    }
                   
                    if (destino == 0)
                    {
                        total = total + importe;
                        debe = importe.ToString();
                        haber = "0,00";
                    }
                    else
                    {
                        total = total - importe;
                        haber = importe.ToString();
                        debe = "0,00";
                    }
                   

                    //Rellenar campos
                    
                    
                    filas += "<tr>";
                    filas += "<td>" + sNroRenglon + "</td>";
                    filas += "<td>" + sNroCuenta + "</td>";
                    filas += "<td>" + nombreCuenta + "</td>";
                    filas += "<td>" + comprobante + "</td>";
                    filas += "<td>" + fechaOp + "</td>";
                    filas += "<td>" + fechaVto + "</td>";
                    filas += "<td>" + leyenda + "</td>";
                    filas += "<td>" + Global.getImporteString(float.Parse(debe)) + "</td>";
                    filas += "<td>" + Global.getImporteString(float.Parse(haber)) + "</td>";
                    filas += "<td>" + Global.getImporteString(total) + "</td>";
                    filas += "</tr>";
                   

                } //FIN FOR                
               
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        //Creamos un nuevo documento y lo definimos como PDF
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase());
                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }
                        pdfDoc.Close();
                        stream.Close();
                    }
                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            ListadoAsientosCargados formListado = new ListadoAsientosCargados();
            formListado.Show();
        }
    }
}       
        
    

