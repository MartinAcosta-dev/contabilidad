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

    public partial class RegistrarEntreFechas : Form
    {
       

        public RegistrarEntreFechas()

        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        public String getFechaString(DateTime fecha)
        {
            String resultado = "";

            String fechaString = fecha.ToString();

            for(int i = 0; i <= 9; i++)
            {
                resultado = resultado + fechaString[i];
            }

            return resultado;
        }

        public DateTime getFechaDate(String fecha)
        {
            DateTime resultado;

            CultureInfoConverter CultureInfo = new CultureInfoConverter();

            resultado = DateTime.ParseExact(fecha, "dd/MM/yyyy", null);

            return resultado;
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

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = (dateTimePicker1.Value);
            DateTime fecha2 = (dateTimePicker2.Value);
            int contador = 0;
            int nroAsientoAux = 0;

            if(fecha1 > fecha2)
            {
                MessageBox.Show("La fecha 1 debe ser menor que la fecha 2.");
            }
            else
            {
                //HACER QUERY
                SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
                conexion.Open();
                String query = "select * from asientosTemp";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {    
                    String fechaOp = lector["fechaOp"].ToString();
                    

                    if((getFechaDate(fechaOp) >= fecha1 ) && (getFechaDate(fechaOp) <= fecha2))
                    {
                        int nroAsiento = Convert.ToInt32(lector["nroAsiento"]);
                        RegistrarAsiento(nroAsiento);

                        if (nroAsiento != nroAsientoAux)
                        {
                            contador++;
                        }

                        nroAsientoAux = nroAsiento;

                    }
                    
                }

                MessageBox.Show("Se han registrado los asientos " + contador.ToString()+" asientos.");

                conexion.Close();
            }
            
        }
    }
}
