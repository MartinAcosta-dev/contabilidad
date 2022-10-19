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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Sistema
{

    public partial class FechaListarLibroDiario : Form
    {
       

        public FechaListarLibroDiario()

        {
            InitializeComponent();

        }

        public String getStringEspaciado(String palabra)
        {
            String resultado = palabra;
            int longitudMaxima = 18;

            while (resultado.Length <= longitudMaxima)
            {
                resultado = resultado + " ";
            }

            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlanCuentas formPlanCuentas = new PlanCuentas();
            formPlanCuentas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuModuloContable_Load(object sender, EventArgs e)
        {
            label2.Text = Global.EmpresaLog;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Asientos asientosForm = new Asientos();
            asientosForm.Show();
            this.Hide();
        }

        public String escribirTitulo()
        {
            return "<h2 style='text-align: right'>Libro Diario</h2>";
        }

   
        public String agregarFila(String nroCuenta, String nombreCuenta, String fechaVto, String comprobante, String leyenda, String debe, String haber)
        {
            String resultado = "<table><tr>" + nroCuenta + "</tr><tr>" + nombreCuenta + "</tr><tr>" + fechaVto + "</tr><tr>" + comprobante + "</tr><tr>" + leyenda + "</tr><tr>" + debe + "</tr><tr>" + haber + "</tr></table>";
            return resultado;
        }


       
         public void emitirLibroDiario()
        {
            String nombrecuenta, fechaCont, comprobante,leyenda, debe, haber;
            int nroAsiento, nroRenglon,nroCuenta;
            float importe, totalDebe=0,totalHaber=0;
            string PaginaHTML_Texto = Properties.Resources.LibroDiario33333.ToString();
            string tablas = string.Empty;          
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();

            //Primero datos fijos de empresa
            String query = "select * from infoEmpresa";
            SqlCommand comandoInfoEmpresa = new SqlCommand(query, conexion);
            SqlDataReader lectorInfoEmpresa = comandoInfoEmpresa.ExecuteReader();

            String razonSocial = "";
            String localizacion = "";
            String fechaIni = "";
            String fechaCierre = "";

            
           


            while (lectorInfoEmpresa.Read())
            {
                razonSocial = lectorInfoEmpresa["razonsocial"].ToString();
                localizacion = lectorInfoEmpresa["localizacion"].ToString();
                fechaIni = lectorInfoEmpresa["fechaIni"].ToString();
                fechaCierre = lectorInfoEmpresa["fechaCierre"].ToString();
            }


            //REEMPLAZA DATOS DE LA PLANTILLA PARA EMPRESA
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NombreEmpresa", razonSocial);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Localizacion", localizacion);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@fechaIni", fechaIni);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@fechaCierre", fechaCierre);

             query = "select * from LibroMayor";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registro = comando.ExecuteReader();          
            int aux = 0;         

            //llenamos una lista (vector dinamico) con todos los numeros de los planes
            while (registro.Read())
            {

                nroAsiento = Convert.ToInt32(registro["nroAsiento"]);

                if (aux != nroAsiento)
                {
                    //Si es distinto agrega cabecera y primera linea
                    aux = nroAsiento;

                    fechaCont = registro["fechaCont"].ToString();
                    leyenda = registro["leyenda"].ToString();
                    nroCuenta = Convert.ToInt16(registro["nroCuenta"]);
                    nombrecuenta = registro["nombreCuenta"].ToString();
                    comprobante = registro["comprobante"].ToString();
                    int destino = Convert.ToInt32(registro["debehaber"]);
                    importe = float.Parse(registro["importe"].ToString());


                    if (destino == 0)
                    {
                        debe = Global.getImporteString(importe);
                        haber = "0.00";
                        totalDebe = totalDebe + importe;
                    }
                    else
                    {
                        haber = Global.getImporteString(importe);
                        debe = "0.00";
                        totalHaber = totalHaber + importe;
                    }
                    tablas += "<table class='cabeceraCuenta' align='center'>" +
                                 "<tr>" +
                                 "<td>Nro.Asiento:  " + nroAsiento.ToString() + "                              Fecha Cont:  "+fechaCont+ "  </td> "+
                                 "</tr>" +
                                 "</table>";
                    tablas += "<table class='datos' align='center'>" +
                       "<tr>" +
                       "<td>" + nroCuenta.ToString() + " </td>" +
                       "<td>" + nombrecuenta + "</td>" +
                       "<td>" + fechaCont + "</td>" +
                       "<td>" + comprobante + "</td>" +
                       "<td>" + leyenda + "</td>" +
                       "<td>" + debe + "</td>" +
                       "<td>" + haber + "</td>" +
                       "</tr>" +
                       "</table>";
                    


                }
                else //agrega una linea mas
                {
                    aux = nroAsiento;

                    fechaCont = registro["fechaCont"].ToString();
                    leyenda = registro["leyenda"].ToString();
                    nroCuenta = Convert.ToInt16(registro["nroCuenta"]);
                    nombrecuenta = registro["nombreCuenta"].ToString();
                    comprobante = registro["comprobante"].ToString();
                    int destino = Convert.ToInt32(registro["debehaber"]);
                    importe = float.Parse(registro["importe"].ToString());


                    if (destino == 0)
                    {
                        debe = Global.getImporteString(importe);
                        haber = "";
                        totalDebe = totalDebe + importe;
                    }
                    else
                    {
                        haber = Global.getImporteString(importe);
                        debe = "";
                        totalHaber = totalHaber + importe;
                    }
                    tablas += "<table class='datos' align='center'>" +
                       "<tr>" +
                       "<td>" + nroCuenta.ToString() + " </td>" +
                       "<td>" + nombrecuenta + "</td>" +
                       "<td>" + fechaCont + "</td>" +
                       "<td>" + comprobante + "</td>" +
                       "<td>" + leyenda + "</td>" +
                       "<td>" + debe + "</td>" +
                       "<td>" + haber + "</td>" +
                       "</tr>" +
                       "</table>";
                }
                
            }
            tablas += "<table class='datos' align='center'>" +
                        "<tr>" +
                        "<td></td>" +
                        "<td></td>" +
                        "<td></td>" +
                        "<td></td>" +
                        "<td></td>" +
                        "<td>" + "DEBE:" + totalDebe.ToString() + " </td>" +
                        "<td>" + "HABER: " + totalHaber.ToString() + " </td>" +
                        "</tr>" +
                        "</table>";




            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TABLAS", tablas);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);                  
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                }
            }
            conexion.Close();          
        }

         public void guardarEmision(String fecha)
        {
            //AGREGAR
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();
            String query = "UPDATE ultimaEmision SET fechaUltimaEmision = @fechaultimaEmision";
            SqlCommand comandoaux = new SqlCommand(query, conexion);
            comandoaux = new SqlCommand(query, conexion);
            comandoaux.Parameters.AddWithValue("@fechaultimaEmision", fecha);       
            comandoaux.ExecuteNonQuery();
            conexion.Close();
        }
            


        private void button1_Click_1(object sender, EventArgs e)
        {
            emitirLibroDiario();
            String fecha = dateTimePicker1.Text;
            guardarEmision(fecha);
        }
    }
}
