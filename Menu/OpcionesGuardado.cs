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
//lib
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using iTextSharp.tool.xml.html.table;
using SpreadsheetLight;
using System.Drawing.Printing;
using Font = System.Drawing.Font;

namespace Sistema
{
    
    public partial class OpcionesGuardado : Form
    {
       



        public OpcionesGuardado()

        {
            InitializeComponent();
            
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {

            Global.conexion.Open();
            string query;
            SqlCommand comando ;
            SqlDataReader registro;



            //LISTADO EMPLEADOS 
           
            if (listadode.Text == "EMPLEADOS")
            {
                query = "SELECT * FROM Empleados";
                comando = new SqlCommand(query, Global.conexion);
                registro = comando.ExecuteReader();
                //PDF
                if (opcionescombo.Text == "PDF")
                {
                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                    string PaginaHTML_Texto = Properties.Resources.EmpleadosPlantilla.ToString();
                    //REEMPLAZA DATOS DE LA PLANTILLA PARA EMPRESA
                    //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txtnombres.Text);
                    // PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", txtdocumento.Text);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                    string filas = string.Empty;
                    while (registro.Read())
                    {
                        filas += "<tr>";
                        filas += "<td>" + registro["ID"].ToString() + "</td>";
                        filas += "<td>" + registro["Nombre"].ToString() + "</td>";
                        filas += "<td>" + registro["Apellido"].ToString() + "</td>";
                        filas += "<td>" + registro["TipoDoc"].ToString() + "</td>";
                        filas += "<td>" + registro["NDoc"].ToString() + "</td>";                    
                        filas += "</tr>";
                    }
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
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
                }//PDF

                //EXCEL
                if (opcionescombo.Text == "EXCEL")
                {
                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format("{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                    SLDocument oSLDocument = new SLDocument();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    //Columnas
                    dt.Columns.Add("ID",typeof(string));
                    dt.Columns.Add("Nombre", typeof(string));
                    dt.Columns.Add("Apellido", typeof(string));
                    dt.Columns.Add("TipoDoc", typeof(string));
                    dt.Columns.Add("NDoc", typeof(string));
                    //Registros
                    while (registro.Read())
                    {
                        dt.Rows.Add(registro["ID"].ToString(), registro["Nombre"].ToString(), registro["Apellido"].ToString(), registro["TipoDoc"].ToString(), registro["NDoc"].ToString());
                    }
                    oSLDocument.ImportDataTable(1, 1, dt, true);
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {                    
                     oSLDocument.SaveAs(savefile.FileName);                      
                        }
                    }

                //IMPRIMIR
                //IMPRESORA
                if (opcionescombo.Text == "IMPRESORA")
                {
                    printDocument1 = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    printDocument1.PrinterSettings = ps;
                    printDocument1.PrintPage += ImprimirDocumentos;
                    printDocument1.Print();

                }
            }

            //LISTADO DOCUMENTOS
            if (listadode.Text == "DOCUMENTOS")
            {
                query = "SELECT * FROM Documentos";
                comando = new SqlCommand(query, Global.conexion);
                registro = comando.ExecuteReader();
                //PDF
                if (opcionescombo.Text == "PDF")
                {
                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                    string PaginaHTML_Texto = Properties.Resources.DocumentosPlantilla.ToString();
                    //REEMPLAZA DATOS DE LA PLANTILLA PARA EMPRESA
                    //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txtnombres.Text);
                    // PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", txtdocumento.Text);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                    string filas = string.Empty;
                    while (registro.Read())
                    {
                        filas += "<tr>";
                        filas += "<td>" + registro["Tipo"].ToString() + "</td>";
                        filas += "<td>" + registro["Descripcion"].ToString() + "</td>";
                        filas += "<td>" + registro["Longitud"].ToString() + "</td>";                  
                        filas += "</tr>";
                    }
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
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
                }//PDF
                //EXCEL
                if (opcionescombo.Text == "EXCEL")
                {
                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format("{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));                 
                    SLDocument oSLDocument = new SLDocument();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    //Columnas
                    dt.Columns.Add("Tipo", typeof(string));
                    dt.Columns.Add("Descripcion", typeof(string));
                    dt.Columns.Add("Longitud", typeof(string));               
                    //Registros
                    while (registro.Read())
                    {
                        dt.Rows.Add(registro["Tipo"].ToString(), registro["Descripcion"].ToString(), registro["Longitud"].ToString());
                    }
                    oSLDocument.ImportDataTable(1, 1, dt, true);
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        oSLDocument.SaveAs(savefile.FileName);
                    }
                }//E

                //IMPRESORA
                if (opcionescombo.Text == "IMPRESORA")
                {
                    printDocument1 = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    printDocument1.PrinterSettings = ps;
                    printDocument1.PrintPage += ImprimirDocumentos;
                    printDocument1.Print();
                    
                }
            }


            //LISTADO USUARIOS

            if (listadode.Text == "USUARIOS")
            {
            query = "SELECT * FROM Usuarios";
            comando = new SqlCommand(query, Global.conexion);
            registro = comando.ExecuteReader();
            //PDF
            if (opcionescombo.Text == "PDF")
               {
                string[] UsuariosTabla = { "ID", "Usuario", "Contraseña", "Nombre", "Apellido", "TipoUsuario" };
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));          
                string PaginaHTML_Texto = Properties.Resources.UsuariosPlantilla.ToString();
                //REEMPLAZA DATOS DE LA PLANTILLA PARA EMPRESA
                //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txtnombres.Text);
                // PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", txtdocumento.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                string filas = string.Empty;
                while (registro.Read())
                {
                    filas += "<tr>";
                    filas += "<td>" + registro["ID"].ToString() + "</td>";
                    filas += "<td>" + registro["username"].ToString() + "</td>";
                    filas += "<td>" + registro["password"].ToString() + "</td>";
                    filas += "<td>" + registro["nombre"].ToString() + "</td>";
                    filas += "<td>" + registro["apellido"].ToString() + "</td>";
                    filas += "<td>" + registro["tipouser"].ToString() + "</td>";
                    filas += "</tr>";
                }
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        //Creamos un nuevo documento y lo definimos como PDF
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        ////Agregamos la imagen del banner al documento
                        //iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.shop, System.Drawing.Imaging.ImageFormat.Png);
                        //img.ScaleToFit(60, 60);
                        //img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        ////img.SetAbsolutePosition(10,100);
                        //img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        //pdfDoc.Add(img);
                        //pdfDoc.Add(new Phrase("Hola Mundo"));
                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }
                        pdfDoc.Close();
                        stream.Close();
                    }
                }
            }//PDF

            //EXCEL
                if (opcionescombo.Text == "EXCEL")
                {
                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format("{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                    SLDocument oSLDocument = new SLDocument();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    //Columnas
                    dt.Columns.Add("ID", typeof(string));
                    dt.Columns.Add("username", typeof(string));
                    dt.Columns.Add("password", typeof(string));
                    dt.Columns.Add("Nombre", typeof(string));
                    dt.Columns.Add("Apellido", typeof(string));
                    dt.Columns.Add("TipoUsuario", typeof(string));
                    //Registros
                    while (registro.Read())
                    {
                        dt.Rows.Add(registro["ID"].ToString(), registro["username"].ToString(), registro["password"].ToString(), registro["nombre"].ToString(), registro["apellido"].ToString(), registro["Tipouser"].ToString());
                    }
                    oSLDocument.ImportDataTable(1, 1, dt, true);
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        oSLDocument.SaveAs(savefile.FileName);
                    }
                }//E
                //IMPRESORA
                if (opcionescombo.Text == "IMPRESORA")
                {
                    printDocument1 = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    printDocument1.PrinterSettings = ps;
                    printDocument1.PrintPage += ImprimirDocumentos;
                    printDocument1.Print();

                }
            }//USUARIOS
        }

        private void ImprimirDocumentos(object sender, PrintPageEventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-8VUNRM4\\SQLEXPRESS;database=Practicas; integrated security=true;MultipleActiveResultSets=True");
            conexion.Open();          
            SqlCommand comando;
            SqlDataReader registro;

            Font font = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
            string query = "";
            
           
            int x = 10, y = 10;

            if (listadode.Text == "USUARIOS")
            {
                query = "SELECT * FROM USUARIOS";
                comando = new SqlCommand(query, conexion);
                registro = comando.ExecuteReader();
                e.Graphics.DrawString("ID", font, Brushes.Black, x, y); x += 50;
                e.Graphics.DrawString("USUARIO", font, Brushes.Black, x, y); x += 150;
                e.Graphics.DrawString("CONTRASEÑA", font, Brushes.Black, x, y); x += 150;
                e.Graphics.DrawString("NOMBRE", font, Brushes.Black, x, y); x += 150;
                e.Graphics.DrawString("APELLIDO", font, Brushes.Black, x, y); x += 150;
                e.Graphics.DrawString("TIPO.USUARIO", font, Brushes.Black, x, y); 
                x = 10; y = 50;
                while (registro.Read())
                {
                    e.Graphics.DrawString(registro["ID"].ToString(), font, Brushes.Black, x, y); x += 50;
                    e.Graphics.DrawString(registro["username"].ToString(), font, Brushes.Black, x, y);  x += 150;
                    e.Graphics.DrawString(registro["password"].ToString(), font, Brushes.Black, x, y); x += 150;
                    e.Graphics.DrawString(registro["nombre"].ToString(), font, Brushes.Black, x, y); x += 150;
                    e.Graphics.DrawString(registro["apellido"].ToString(), font, Brushes.Black, x, y); x += 150;
                    e.Graphics.DrawString(registro["tipouser"].ToString(), font, Brushes.Black, x, y); x += 150;
                    y += 40; x = 10;
                }
                      
            }

            if (listadode.Text == "EMPLEADOS")
            {
                 query = "SELECT * FROM EMPLEADOS";
                comando = new SqlCommand(query, conexion);
                registro = comando.ExecuteReader();
                e.Graphics.DrawString("ID", font, Brushes.Black, x, y); x += 50;
                e.Graphics.DrawString("NOMBRE", font, Brushes.Black, x, y); x += 150;
                e.Graphics.DrawString("APELLIDO", font, Brushes.Black, x, y); x += 150;
                e.Graphics.DrawString("TIPO.DOC", font, Brushes.Black, x, y); x += 150;
                e.Graphics.DrawString("N.DOC", font, Brushes.Black, x, y); x += 150;              
                x = 10; y = 50;
                while (registro.Read())
                {
                    e.Graphics.DrawString(registro["ID"].ToString(), font, Brushes.Black, x, y); x += 50;
                    e.Graphics.DrawString(registro["Nombre"].ToString(), font, Brushes.Black, x, y); x += 150;
                    e.Graphics.DrawString(registro["Apellido"].ToString(), font, Brushes.Black, x, y); x += 150;
                    e.Graphics.DrawString(registro["TipoDoc"].ToString(), font, Brushes.Black, x, y); x += 150;
                    e.Graphics.DrawString(registro["NDoc"].ToString(), font, Brushes.Black, x, y); x += 150;                  
                    y += 40; x = 10;
                }

            }

            if (listadode.Text == "DOCUMENTOS")
            {
                query = "SELECT * FROM Documentos";
                comando = new SqlCommand(query, conexion);
                registro = comando.ExecuteReader();
                e.Graphics.DrawString("TIPO", font, Brushes.Black, x, y); x += 300;
                e.Graphics.DrawString("DESCRIPCION", font, Brushes.Black, x, y); x += 300;
                e.Graphics.DrawString("LONGITUD", font, Brushes.Black, x, y);
                x = 10; y = 50;
                while (registro.Read())
                {
                    e.Graphics.DrawString(registro["Tipo"].ToString(), font, Brushes.Black, x, y);
                    x += 250;
                    e.Graphics.DrawString(registro["Descripcion"].ToString(), font, Brushes.Black, x, y);
                    x += 350;
                    e.Graphics.DrawString(registro["Longitud"].ToString(), font, Brushes.Black, x, y);
                    y += 40; x = 10;
                }

            }

          






        }

        private void OpcionesGuardado_Load(object sender, EventArgs e)
        {
           

            if (Global.UserLogged[2] == "OPERARIO")
            {
                listadode.Items.Remove("AUDITORIA");
                listadode.Items.Remove("USUARIOS");
            }

            if (Global.UserLogged[2] == "SUPERVISOR")
            {
                listadode.Items.Remove("AUDITORIA");
            }

        

        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
