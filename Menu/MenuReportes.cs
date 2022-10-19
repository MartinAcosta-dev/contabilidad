using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{

    public partial class MenuReportes : Form
    {
       

        public MenuReportes()

        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlanCuentas formPlanCuentas = new PlanCuentas();
            formPlanCuentas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuModuloContable menu = new MenuModuloContable();
            menu.Show();
            this.Close();

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

        struct registroCuentaPlanDeCuentas
        {
            public String codigo;
            public int numero;
            public String nombre;
            public int tipo;
        }

        class registroBalance
        {
            public int nroCuenta;
            public String codigoCuenta;
            public String nombreCuenta;
            public int tipoCuenta;
            public float saldoInicial;
            public float debitos;
            public float creditos;
            public float saldoAcum;
            public float saldoActual;


            public void setNroCuenta(int nroCuenta)
            {
                this.nroCuenta = nroCuenta;
            }

            public void setCodigoCuenta(String codigoCuenta)
            {
                this.codigoCuenta = codigoCuenta;
            }

            public void setNombreCuenta(String nombreCuenta)
            {
                this.nombreCuenta = nombreCuenta;
            }

            public void setSaldoInicial(float saldoInicial)
            {
                this.saldoInicial = saldoInicial;
            }

            public void setDebitos(float debitos)
            {
                this.debitos = debitos;
            }

            public void setCreditos(float creditos)
            {
                this.creditos = creditos;
            }

            public void setSaldoAcum(float saldoAcum)
            {
                this.saldoAcum = saldoAcum;
            }

            public void setSaldoActual(float saldoActual)
            {
                this.saldoActual = saldoActual;
            }

        }

        public Boolean esHija(String codigo1, String codigo2)
        {
            Boolean resultado = false;

            if( (codigo2.Contains(codigo1)) && (codigo2.Length == codigo1.Length + 2 ) && (codigo2[0].Equals(codigo1[0])))
            {
                resultado = true;
            }


            return resultado;
        }

        public void exportarBalance()
        {
            SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            conexion.Open();

            //DATOS FIJOS DE EMPRESA
            String razonSocial = "";
            String localizacion = "";
  

            String query = "select * from infoEmpresa";
            SqlCommand comandoInfoEmpresa = new SqlCommand(query, conexion);
            SqlDataReader lectorInfoEmpresa = comandoInfoEmpresa.ExecuteReader();


            while (lectorInfoEmpresa.Read())
            {
                razonSocial = lectorInfoEmpresa["razonsocial"].ToString();
                localizacion = lectorInfoEmpresa["localizacion"].ToString();
            }


            //REEMPLAZA DATOS DE LA PLANTILLA PARA EMPRESA

            string PaginaHTML_Texto = Properties.Resources.BalanceGeneral.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NombreEmpresa", razonSocial);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Localizacion", localizacion);
        

            //Variables
            List<registroCuentaPlanDeCuentas> cuentas = new List<registroCuentaPlanDeCuentas>();
            registroCuentaPlanDeCuentas registrocuenta = new registroCuentaPlanDeCuentas();

            List<registroBalance> balances = new List<registroBalance>();
            

            String tablas = "";

            query = "select * from plandecuentas order by codigo asc";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader registro = command.ExecuteReader();

            while (registro.Read())
            {
                registrocuenta.codigo = registro["codigo"].ToString();
                registrocuenta.numero = Convert.ToInt32(registro["numero"]);
                registrocuenta.nombre = registro["nombre"].ToString();
                registrocuenta.tipo = Convert.ToInt32(registro["tipo"]);

                cuentas.Add(registrocuenta);
            }

            int cantidadDeCuentas = cuentas.Count();

            for (int i = 0; i < cantidadDeCuentas; i++)
            {
                //creamos un objeto por cada registro del balance
                registroBalance registrobalance = new registroBalance();

                float saldoInicial = 0, saldoAcum = 0, saldoActual = 0, debitos = 0, creditos = 0;

                String codigoCuenta = cuentas[i].codigo.ToString();
                int numeroCuenta = Convert.ToInt32(cuentas[i].numero);
                String nombreCuenta = cuentas[i].nombre.ToString();
                int tipoCuenta = Convert.ToInt32(cuentas[i].tipo);

                if(tipoCuenta == 1)
                {
                    query = "select * from libroMayor where nroCuenta = @nroCuenta";
                    SqlCommand command1 = new SqlCommand(query, conexion);
                    command1.Parameters.AddWithValue("@nroCuenta", numeroCuenta);
                    SqlDataReader lector = command1.ExecuteReader();

                    while (lector.Read())
                    {

                        if (Convert.ToInt32(lector["tipo"]) == 1)
                        {
                            //Es de apertura entonces
                            saldoInicial = saldoInicial + float.Parse(lector["importe"].ToString());
                        }
                        else
                        {
                            if (Convert.ToInt32(lector["debehaber"]) == 0)
                            {
                                debitos = debitos + float.Parse(lector["importe"].ToString());

                            }
                            else
                            {
                                creditos = creditos + float.Parse(lector["importe"].ToString());
                            }
      
                        }
                    }

                    saldoAcum = debitos - creditos;
                    saldoActual = saldoInicial + saldoAcum;


                    
                    registrobalance.nroCuenta = numeroCuenta;
                    registrobalance.codigoCuenta = codigoCuenta;
                    registrobalance.nombreCuenta = nombreCuenta;
                    registrobalance.tipoCuenta = tipoCuenta;
                    registrobalance.saldoInicial = saldoInicial;
                    registrobalance.creditos = creditos;
                    registrobalance.debitos = debitos;
                    registrobalance.saldoAcum = saldoAcum;
                    registrobalance.saldoActual = saldoActual;

                    //AGREGAR A VECTOR
                    balances.Add(registrobalance);


                }
                else
                {
                    registrobalance.nroCuenta = numeroCuenta;
                    registrobalance.codigoCuenta = codigoCuenta;
                    registrobalance.nombreCuenta = nombreCuenta;
                    registrobalance.tipoCuenta = tipoCuenta;
                    registrobalance.saldoInicial = saldoInicial;
                    registrobalance.creditos = creditos;
                    registrobalance.debitos = debitos;
                    registrobalance.saldoAcum = saldoAcum;
                    registrobalance.saldoActual = saldoActual;

                    //AGREGAR A VECTOR
                    balances.Add(registrobalance);
                }
            }

            //Hasta aca estan cargadas las cuentas imputables, faltan los atributos de los titulos

            for(int q = balances.Count - 1; q >= 0 ; q--)
            {
                float saldoInicial = 0, debitos = 0, creditos = 0, saldoAcum = 0, saldoActual = 0;   
                if (balances[q].tipoCuenta == 0)
                {
                    for(int h = q+1 ; h < balances.Count; h++)
                    {
                        if (esHija(balances[q].codigoCuenta, balances[h].codigoCuenta) == true)
                        {
                            //Sumar el importe de la hija al total
                            saldoInicial = saldoInicial + balances[h].saldoInicial;
                            debitos = debitos + balances[h].debitos;
                            creditos = creditos + balances[h].creditos;
                            saldoAcum = saldoAcum + balances[h].saldoAcum;
                            saldoActual = saldoActual + balances[h].saldoActual;

                        }
                    }

                    //Modificar en balance[q] los atributos
                    balances[q].setSaldoInicial(saldoInicial);
                    balances[q].setDebitos(debitos);
                    balances[q].setCreditos(creditos);
                    balances[q].setSaldoAcum(saldoAcum);
                    balances[q].setSaldoActual(saldoActual);


                }

            }


            //Reportear todos los registros del vector balances
            for(int n = 0; n < balances.Count; n++)
            {
          
                tablas += "<table class='datos' align='center'>" +
                        "<tr>" +
                        "<td>" + balances[n].nroCuenta.ToString() + " </td>" +
                        "<td>" + balances[n].codigoCuenta.ToString() + " </td>" +
                        "<td id='nombreCuenta'>" + balances[n].nombreCuenta.ToString() + " </td>" +
                        "<td>" + Global.getImporteString(balances[n].saldoInicial) + " </td>" +
                        "<td>" + Global.getImporteString(balances[n].debitos) + " </td>" +
                        "<td>" + Global.getImporteString(balances[n].creditos) + " </td>" +
                        "<td>" + Global.getImporteString(balances[n].saldoAcum) + " </td>" +
                        "<td>" + Global.getImporteString(balances[n].saldoActual) + " </td>" +                      
                        "</tr>" +
                        "</table>";
            }

            //REEMPLAZAR @TABLA por tabla
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
        private void button2_Click_1(object sender, EventArgs e) //BALANCE
        {
            exportarBalance();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FechaListarLibroDiario formFecha = new FechaListarLibroDiario();
            formFecha.Show();
        }

        struct registroCuenta
        {
            public int nroCuenta;
            public String nombre;
            public String codigo;
        }
        public void exportarMayor()
        {
            String nroAsiento, nroRenglon, fechaCont, comprobante, debe, haber, leyenda;



            //Creamos vectores dinamicos que guardaran las cuentas
            List<registroCuenta> cuentas = new List<registroCuenta>();    //este vector guarda los registros de las cuentas

            string PaginaHTML_Texto = Properties.Resources.mayoresDeCuentas.ToString();
            string tablas = string.Empty;
            registroCuenta registrocuenta = new registroCuenta();


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

            query = "select * from libroMayor order by nroCuenta"; //Vamos a obtener solo las que tengan movimientos
            int aux = 0;
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            //llenamos una lista (vector dinamico) con todos los numeros de los planes
            while (registro.Read())
            {

                int num = Convert.ToInt32(registro["nroCuenta"]);

                if (aux != num)
                {
                    aux = num;

                    query = "select * from PlanDeCuentas where numero = @numero";
                    SqlCommand comandoAux = new SqlCommand(query, conexion);
                    comandoAux.Parameters.AddWithValue("@numero", num);
                    SqlDataReader lector = comandoAux.ExecuteReader(); //Ejecutamos esta query para tener el codigo y el nombre


                    while (lector.Read())
                    {
                        registrocuenta.nroCuenta = num;
                        registrocuenta.codigo = lector["codigo"].ToString();
                        registrocuenta.nombre = lector["nombre"].ToString();
                    }

                    cuentas.Add(registrocuenta);

                }
            }

            //ahora por cada uno de estos codigos consultar la BB.DD

            int cantidadCuentas = cuentas.Count();


            for (int i = 0; i < cantidadCuentas; i++)
            {
                float importe;
                float saldo = 0;
                float totalDebe = 0;
                float totalHaber = 0;

                int nroCuenta = cuentas[i].nroCuenta;
                String nombreCuenta = cuentas[i].nombre;
                String codigo = cuentas[i].codigo;

                query = "select * from libroMayor where nroCuenta = @nroCuenta ";
                SqlCommand comando2 = new SqlCommand(query, conexion);
                comando2.Parameters.AddWithValue("@nroCuenta", nroCuenta);
                SqlDataReader registro2 = comando2.ExecuteReader();

                //Escribir cabecera
                tablas += "<table class='cabeceraCuenta' align='center'>" +
                                  "<tr>" +
                                  "<td>Nro.Cta:  <b>" + nroCuenta.ToString() + "</b>  </td>" +
                                  "<td>Nombre cta:  <b>" + nombreCuenta + "</b>  </td>" +
                                  "<td>Cód. ord:  <b>" + codigo + "</b>  </td>" +
                                  "</tr>" +
                                  "</table>";

                while (registro2.Read())
                {
                    nroAsiento = registro2["nroAsiento"].ToString();
                    nroRenglon = registro2["nroRenglon"].ToString();
                    nombreCuenta = registro2["nombreCuenta"].ToString();
                    fechaCont = registro2["fechaCont"].ToString();
                    comprobante = registro2["comprobante"].ToString();
                    leyenda = registro2["leyenda"].ToString();
                    int destino = Convert.ToInt32(registro2["debehaber"]);
                    importe = float.Parse(registro2["importe"].ToString());

                    if (destino == 0)
                    {
                        debe = Global.getImporteString(importe);
                        haber = "0.00";

                        saldo = saldo + importe;

                        totalDebe = totalDebe + importe;
                    }
                    else
                    {
                        haber = Global.getImporteString(importe);
                        debe = "0.00";

                        saldo = saldo - importe;

                        totalHaber = totalHaber + importe;
                    }


                    tablas += "<table class='datos' align='center'>" +
                        "<tr>" +
                        "<td>" + nroAsiento + " </td>" +
                        "<td>" + nroRenglon + "</td>" +
                        "<td>" + fechaCont + "</td>" +
                        "<td>" + comprobante + "</td>" +
                        "<td>" + leyenda + "</td>" +
                        "<td>" + debe + "</td>" +
                        "<td>" + haber + "</td>" +
                        "<td>" + Global.getImporteString(saldo) + "</td>" +
                        "</tr>" +
                        "</table>";


                }

                //Agregamos otra fila mas para totalizar importes

                tablas += "<table class='datos' align='center'>" +
                    "<tr>" +
                    "<td> - </td>" +
                    "<td> - </td>" +
                    "<td> - </td>" +
                    "<td> - </td>" +
                    "<td> - </td>" +
                    "<td> <b>" + Global.getImporteString(totalDebe) + " </b></td>" +
                    "<td> <b>" + Global.getImporteString(totalHaber) + "</b> </td>" +
                    "<td> <b>" + Global.getImporteString(totalDebe - totalHaber) + "</b></td>" +
                    "</tr>" +
                    "</table>";
            }

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
        private void button1_Click_1(object sender, EventArgs e)
        {
            exportarMayor();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //LIBRO DIARIO
            //String query = "SELECT * FROM PlanDeCuentas order by codigo";
            //SqlConnection conexion = Global.getConexion2(Global.EmpresaLog);
            //conexion.Open();

            //SqlCommand comando = new SqlCommand(query, conexion);
            //SqlDataReader registro = comando.ExecuteReader();

            //SaveFileDialog savefile = new SaveFileDialog();
            //savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));
            //string PaginaHTML_Texto = Properties.Resources.Cuentas.ToString();
            ////REEMPLAZA DATOS DE LA PLANTILLA PARA EMPRESA
            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Empresa", Global.EmpresaLog);
            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Lista", "LIBRO DIARIO");
            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", "Asientos");
            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Numero", "1");
            //string filas = string.Empty;
            //string titulo1 = String.Empty;
            //string titulo2 = String.Empty;
            //float totaldebe = 0,totalhaber=0;
            //while (registro.Read())
            //{
            //    //cambiar @ por la var del registro
            //    titulo1 += "<th>Fecha cont: @FECHACONT</th>< th > Nro Asiento: @NROASIENTO </ th > < th > Tipo: @TIPO </ th > " ;


            //    titulo2 += "<th>NRenglon</th>< th > NCuenta </ th >< th > Nombre </ th > < th > Comprobante </ th >< th > FechaOp </ th >< th > FechaVto </ th >< th > Leyenda </ th > < th > Debe </ th >< th > Haber </ th >< th > Total </ th > ";
            //    filas += "<tr>";
            //    filas += "<td>" + sNroRenglon + "</td>";
            //    filas += "<td>" + sNroCuenta + "</td>";
            //    filas += "<td>" + nombreCuenta + "</td>";
            //    filas += "<td>" + comprobante + "</td>";
            //    filas += "<td>" + fechaOp + "</td>";
            //    filas += "<td>" + fechaVto + "</td>";
            //    filas += "<td>" + leyenda + "</td>";              
            //    filas += "<td>" + Global.getImporteString(float.Parse(debe)) + "</td>";
            //    filas += "<td>" + Global.getImporteString(float.Parse(haber)) + "</td>";
            //    totaldebe = totaldebe + debe;
            //    totalhaber = totalhaber + debe;
            //    filas += "<td>" + Global.getImporteString(total) + "</td>";
            //    filas += "</tr>";
            //}
            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO1", titulo1);
            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO2", titulo2);
            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTALDEBE", totaldebe);
            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTALHABER", totalhaber);

            //if (savefile.ShowDialog() == DialogResult.OK)
            //{
            //    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
            //    {
            //        //Creamos un nuevo documento y lo definimos como PDF
            //        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
            //        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
            //        pdfDoc.Open();
            //        pdfDoc.Add(new Phrase(""));
            //        using (StringReader sr = new StringReader(PaginaHTML_Texto))
            //        {
            //            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
            //        }
            //        pdfDoc.Close();
            //        stream.Close();
            //    }
            //}
            //conexion.Close();
            //PDF
        }
    }
    }

