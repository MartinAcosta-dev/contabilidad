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

   

        public int getCodigo(String palabra)
        {
            int resultado = 0;
            String sResultado = "";
            String letra = "";
            int i = 0;
            while (palabra[i].ToString() != " ")
            {
                letra = palabra[i].ToString();
                sResultado = sResultado + letra;
                i++;
            }


            resultado = Convert.ToInt32(sResultado);
            return resultado;
        }

        public void ActivarBotonDeEmision()
        {
            if((comboBox2.Text != "") && (comboBox3.Text != "") && (comboBox4.Text != "") && (comboBox5.Text != ""))
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        public void ActualizarPrecioTotalEnTabla()
        {
            float nuevoTotal = 0;

            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                nuevoTotal = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) * float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                dataGridView1.Rows[i].Cells[4].Value = Global.getImporteString(nuevoTotal);
            }
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

        public void ReiniciarFormulario()
        {
            comboBox1.Text = "";
            numericUpDown1.Value = 1;
            labelTotalProductoCant.Text = "0,00";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            dataGridView1.Rows.Clear();
            ActualizarSubtotal();
            ActivarBotonDeEmision();

        }

        public void ActualizarSubtotal()
        {
            //Recorrer tabla y sumar los totales para mostrar en el label
            float subtotal = 0;

            for(int i = 0; i < dataGridView1.RowCount ; i++)
            {
                subtotal = subtotal + float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }

            labelSubtotal.Text = Global.getImporteString(subtotal);
        }

        public Boolean productoExisteEnTabla(int idProducto, ref int pos)
        {
            Boolean resultado = false;

            if(dataGridView1.RowCount > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    String idProductoEnTabla = dataGridView1.Rows[i].Cells[0].Value.ToString();

                    if (idProducto.ToString() == idProductoEnTabla)
                    {
                        resultado = true;
                        pos = i;
                    }
                }
            }

            return resultado;
        }

        public void AgregarProducto(int idProducto, int cantidad)
        {
            int pos = 0;
            String nombreProducto;
            String codFamilia;
            String cantidadStock;
            String precioUnitario;
            String codImpuesto;
            String cantImpuestosInternos;
            float precioTotal = float.Parse(labelTotalProductoCant.Text);

            //Ver si existe el nro de renglon que se carga
            if (productoExisteEnTabla(idProducto, ref pos))
            {

                int filaAModificar = pos;         
                dataGridView1.Rows[filaAModificar].Cells[2].Value = Convert.ToInt32(dataGridView1.Rows[filaAModificar].Cells[2].Value) + cantidad;
                ActualizarPrecioTotalEnTabla();
            }
            else
            {
                dataGridView1.ColumnCount = 5;


                dataGridView1.RowCount = dataGridView1.RowCount + 1;
                int fila = dataGridView1.RowCount - 1;

                //HACER QUERY Y LLENAR CAMPOS
                SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
                conexion.Open();
                String query = "select * from productos where id = @id";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@id", idProducto);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    nombreProducto = reader["nombre"].ToString();
                    codFamilia = reader["codFamilia"].ToString();
                    cantidadStock = reader["cantidad"].ToString();
                    precioUnitario = Global.getImporteString(float.Parse(reader["precioUnitario"].ToString()));
                    codImpuesto = reader["codImpuesto"].ToString();
                    cantImpuestosInternos = reader["cantImpuestosInternos"].ToString();

                    dataGridView1.Rows[fila].Cells[0].Value = idProducto.ToString();
                    dataGridView1.Rows[fila].Cells[1].Value = nombreProducto;
                    dataGridView1.Rows[fila].Cells[2].Value = cantidad;
                    dataGridView1.Rows[fila].Cells[3].Value = precioUnitario;
                    dataGridView1.Rows[fila].Cells[4].Value = Global.getImporteString(precioTotal);



                }



                conexion.Close();         

            }

            ActualizarSubtotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                String idProducto = getCodigo(comboBox1.Text).ToString();
                int cantidad = int.Parse(numericUpDown1.Value.ToString());
                AgregarProducto(Convert.ToInt32(idProducto), cantidad);
            }
        }

        public void ActualizarTotalProducto(int producto, int cantidad)
        {
            float total = 0;
            float precio = 0;

            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from productos where id = @id";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@id", producto);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                precio = float.Parse(reader["precioUnitario"].ToString());
            }

            total = precio * cantidad;

            labelTotalProductoCant.Text = Global.getImporteString(total);

            conexion.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                int producto = getCodigo(comboBox1.Text);
                int cantidad = Convert.ToInt32(numericUpDown1.Value.ToString());

                ActualizarTotalProducto(producto, cantidad);
            }
            
        }

        public void listarClientes()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from clientes";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                String id = reader["id"].ToString();
                String razonSocial = reader["razonSocial"].ToString();

                comboBox4.Items.Add(id + " - " + razonSocial);

            }

            conexion.Close();
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

        public void llenarComboTiposDeComprobante()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from tiposComprobante";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                String id = reader["id"].ToString();
                String descripcion = reader["descripcion"].ToString();

                comboBox3.Items.Add(id+" - "+descripcion);

            }

            conexion.Close();
        }

        public void llenarComboPuntosDeVenta()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from puntosDeVenta";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                String numero = reader["numero"].ToString();

                comboBox2.Items.Add(numero);

            }

            conexion.Close();
        }

        private void ABMVentas_Load(object sender, EventArgs e)
        {
            listarProductos();
            listarClientes();
            listarCondicionesComerciales();
            llenarComboPuntosDeVenta();
            llenarComboTiposDeComprobante();
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            
            if(comboBox1.Text != "")
            {
                int producto = getCodigo(comboBox1.Text);
                int cantidad = Convert.ToInt32(numericUpDown1.Value.ToString());
                ActualizarTotalProducto(producto, cantidad);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }

            ActualizarSubtotal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        public Boolean ComprobarTipoComprobante()
        {
            Boolean resultado = false;

            int idCliente = getCodigo(comboBox4.Text);
            int tipoResponsable = 0;
            int codComprobante = getCodigo(comboBox3.Text);

            //Obtener TipoResponsable de CLiente
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from clientes where id = @id";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@id", idCliente);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                tipoResponsable = Convert.ToInt32(reader["codResponsable"].ToString());

                if((tipoResponsable == 1) && (codComprobante == 1))
                {
                    resultado = true;
                }
                else
                {
                    if( (tipoResponsable != 1) && (codComprobante == 6))
                    {
                        resultado = true;
                    }
                    else
                    {
                        if ((tipoResponsable != 1) && (codComprobante != 6))
                        {
                            resultado = false;
                            MessageBox.Show("El cliente no es responsable inscripto. Debe emitir FACTURA B.");
                        }
                        else
                        {
                            resultado = true;
                        }
                    }
                }



            }
            
            conexion.Close();

            //Si es responsable inscripto ver si codComprobante es 1 y sino debe ser B (no me acuerdo el codigo)


            return resultado;
        }

        public Boolean ComprobarFecha()
        {
            Boolean resultado = false;
            //Toma la fecha del datepicker
            String fecha = dateTimePicker1.Text;
            String fechaUltimoEmitido = "";

            //Toma el comprobante que quiere emitirse
            int codComprobante = getCodigo(comboBox3.Text);

            //Toma el punto de venta
            int codPuntoVenta = Convert.ToInt32(comboBox2.Text);

            //Busca en la tabla de ultimoComprobanteEmitido elComprobante y el punto de venta y compara la fecha
            //Si la fecha es menor a esa entonces devuelve falso
            if( Convert.ToDateTime(fecha) > DateTime.Now)
            {
                resultado = false;
                MessageBox.Show("La fecha no debe ser mayor a hoy.");
            }
            else
            {
                //hacer query
                SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
                conexion.Open();
                String query = "select * from ultimoComprobanteEmitido where puntoDeVenta = @codPuntoVenta and tipoComprobante = @codComprobante";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@codPuntoVenta", codPuntoVenta);
                command.Parameters.AddWithValue("@codComprobante", codComprobante);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    fechaUltimoEmitido = reader["fecha"].ToString();
                }

                if(fechaUltimoEmitido != "")
                {
                    if( Convert.ToDateTime(fecha) < Convert.ToDateTime(fechaUltimoEmitido) )
                    {
                        resultado = false;
                        MessageBox.Show("La fecha debe ser mayor al ultimo emitido en este punto de venta. ("+fechaUltimoEmitido+")");
                    }
                    else
                    {
                        resultado = true;
                    }
                }
                else
                {
                    resultado = true;
                }
                
                conexion.Close();
            }

            return resultado;
        }

        public int GetUltimoNroComprobanteEmitido()
        {
            int resultado = 0;

            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from ultimoNroComprobanteEmitido";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                resultado = Convert.ToInt32(reader["nroComprobante"].ToString());
            }

            conexion.Close();

            return resultado;
        }

        public float getPorcIva(int codProducto)
        {
            float resultado = 0;
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select tiposDeImpuesto.porcentaje from productos inner join tiposDeImpuesto on productos.codImpuesto = tiposDeImpuesto.id where productos.id = @codProducto";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@codProducto", codProducto);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                resultado = float.Parse(reader["porcentaje"].ToString());
            }

            conexion.Close();
            return resultado;
        }

        public void RegistrarRemito(int nroVenta, int codProducto, float precioUnitario, int cantidad, float porcIva)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "insert into remitos values (@nroVenta, @codProducto, @precioUnitario, @cantidad, @porcIva)";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nroVenta", nroVenta);
            command.Parameters.AddWithValue("@codProducto", codProducto);
            command.Parameters.AddWithValue("@precioUnitario", precioUnitario);
            command.Parameters.AddWithValue("@cantidad", cantidad);
            command.Parameters.AddWithValue("@porcIva", porcIva);
            command.ExecuteNonQuery();

            conexion.Close();
        }

        public void RegistrarVenta(String fecha, int puntoDeVenta, int numComprobante, int tipoComprobante, int codCliente, int codCondicion, float subtotal,float ivaVenta,float total)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "insert into ventas values (@fecha, @puntoDeVenta, @numComprobante, @tipoComprobante, @codCliente, @codCondicion, @subtotal, @ivaVenta, @total)";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@fecha", fecha);
            command.Parameters.AddWithValue("@puntoDeVenta", puntoDeVenta);
            command.Parameters.AddWithValue("@numComprobante", numComprobante);
            command.Parameters.AddWithValue("@tipoComprobante", tipoComprobante);
            command.Parameters.AddWithValue("@codCliente", codCliente);
            command.Parameters.AddWithValue("@codCondicion", codCondicion);
            command.Parameters.AddWithValue("@subtotal", subtotal);
            command.Parameters.AddWithValue("@ivaVenta", ivaVenta);
            command.Parameters.AddWithValue("@total", total);
            command.ExecuteNonQuery();
            conexion.Close(); 
        }

        public void ActualizarFechaUltimoComprobanteEmitido(int puntoDeVenta, String fecha, int tipoComprobante)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "select * from ultimoComprobanteEmitido where puntoDeVenta = @puntoDeVenta and tipoComprobante = @tipoComprobante";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@puntoDeVenta", puntoDeVenta);
            command.Parameters.AddWithValue("@tipoComprobante", tipoComprobante);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                query = "update ultimoComprobanteEmitido set fecha = @fecha ";
                SqlCommand command2 = new SqlCommand(query, conexion);
                command2.Parameters.AddWithValue("@fecha", fecha);
                command2.ExecuteNonQuery();
            }
            else
            {
                query = "insert into ultimoComprobanteEmitido values (@puntoDeVenta, @fecha, @tipoComprobante)";
                SqlCommand command3 = new SqlCommand(query, conexion);
                command3.Parameters.AddWithValue("@puntoDeVenta", puntoDeVenta);
                command3.Parameters.AddWithValue("@fecha", fecha);
                command3.Parameters.AddWithValue("@tipoComprobante", tipoComprobante);
                command3.ExecuteNonQuery();
            }
            
            conexion.Close();
        }

        public void ActualizarNroUltimoComprobanteEmitido(int nuevoNumero)
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "update ultimoNroComprobanteEmitido set nroComprobante = @nuevoNumero";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@nuevoNumero", nuevoNumero);
            command.ExecuteNonQuery();
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if( (ComprobarTipoComprobante() == true) && (ComprobarFecha() == true) && (dataGridView1.RowCount > 0))
            {
                float ivaVenta = 0;

                //Tomar datos de remitos y registrarlos
                int nroVenta = GetUltimoNroComprobanteEmitido()+1;
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int codProducto = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    float precioUnitario = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    int cantidad = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    float porcIva = getPorcIva(codProducto);

                    float ivaProducto = ((precioUnitario * cantidad) * (porcIva/100) );
                    ivaVenta = ivaVenta + ivaProducto;

                    RegistrarRemito(nroVenta, codProducto, precioUnitario, cantidad, porcIva);
                }

                //Tomar datos y emitir factura
                String fecha = dateTimePicker1.Text;
                int puntoDeVenta = Convert.ToInt32(comboBox2.Text);
                int numComprobante = GetUltimoNroComprobanteEmitido() + 1;
                int tipoComprobante = getCodigo(comboBox3.Text);
                int codCliente = getCodigo(comboBox4.Text);
                int codCondicion = getCodigo(comboBox5.Text);
                float subtotal = float.Parse(labelSubtotal.Text);
                //ivaVenta ya lo tenemos
                float total = subtotal + ivaVenta;
                RegistrarVenta(fecha, puntoDeVenta, numComprobante, tipoComprobante, codCliente, codCondicion, subtotal, ivaVenta, total);

                MessageBox.Show("Se ha registrado la emision de la factura.");
                ReiniciarFormulario();

                //Actualizar tabla de FECHA ultimoComprobante emitido
                ActualizarFechaUltimoComprobanteEmitido(puntoDeVenta, fecha, tipoComprobante);
                //ACTUALIZAR ULTIMO COMPROBANTE EMITIDO!!!!!!
                ActualizarNroUltimoComprobanteEmitido(GetUltimoNroComprobanteEmitido()+1);

            }
        }

        private void comboBox5_DropDownClosed(object sender, EventArgs e)
        {
            ActivarBotonDeEmision();
        }

        private void comboBox4_DropDownClosed(object sender, EventArgs e)
        {
            ActivarBotonDeEmision();
        }

        private void comboBox3_DropDownClosed(object sender, EventArgs e)
        {
            ActivarBotonDeEmision();
        }

        private void comboBox2_DropDownClosed(object sender, EventArgs e)
        {
            ActivarBotonDeEmision();
        }
    }
}
