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
    public partial class AñadirEmpresa : Form
    {
        public AñadirEmpresa()

        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CancelarEAñadir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        public Boolean empresaExiste(String nombreEmpresa)
        {
            Boolean resultado;

            Global.conexion.Open();
            String query = "Select * from empresas where nombre=@nombreEmpresa";
            SqlCommand command = new SqlCommand(query, Global.conexion);
            command.Parameters.AddWithValue("@nombreEmpresa", nombreEmpresa);
            SqlDataReader reader = command.ExecuteReader();
            

            if (reader.Read())
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            Global.conexion.Close();

            return resultado;
        }

        public void crearTablas (String nombre, String razonSocial, String localizacion, String tipoResponsable, String cuit, String fechaIni, String fechaCierre, String password) //Crea todas las tablas de info
        {
            SqlConnection conexion2 = Global.getConexion2(nombre);

            conexion2.Open();

            //Tabla contraseña
            String query = "create table password( password varchar(100) )";
            SqlCommand command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();
            //Insertamos la contraseña
            query = "insert into password values(@password)";
            command = new SqlCommand(query, conexion2);
            command.Parameters.AddWithValue("@password", password);
            command.ExecuteNonQuery();

            //Tabla info empresa
            query = "create table infoEmpresa( nombre varchar(100), razonsocial varchar(100), localizacion varchar(100), tiporesponsable varchar(100) , cuit varchar(100), fechaIni varchar(100), fechaCierre varchar(100))";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();
            //insertamos info a esta tabla
            query = "insert into infoEmpresa( nombre , razonsocial , localizacion, tiporesponsable , cuit, fechaIni, fechaCierre) VALUES (@nombre , @razonsocial , @localizacion, @tiporesponsable , @cuit, @fechaIni, @fechaCierre)";
            command = new SqlCommand(query, conexion2);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@razonsocial", razonSocial);
            command.Parameters.AddWithValue("@localizacion", localizacion);
            command.Parameters.AddWithValue("@tiporesponsable", tipoResponsable);
            command.Parameters.AddWithValue("@cuit", cuit);
            command.Parameters.AddWithValue("@fechaIni", fechaIni);
            command.Parameters.AddWithValue("@fechaCierre", fechaCierre);

            command.ExecuteNonQuery();

            //Tabla documentos
            query = "create table documentos (Tipo int,Descripcion varchar(50),Longitud decimal(18, 0)); ";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla Empleados
            query = "create table empleados (ID int IDENTITY(1,1),Nombre varchar(50),Apellido varchar(50),TipoDoc varchar(50),NDoc decimal(18, 0)); ";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla Usuarios
            query = "create table usuarios (ID int IDENTITY(1,1),username varchar(50),password varchar(50),nombre varchar(50),apellido varchar(50),tipouser varchar(50)); ";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla auditoria documentos
            query = " create table auditoriaDoc(Responsable varchar(50),Accion varchar(50),TipoDoc varchar(50),Descripcion varchar(50),Longitud varchar(50),Fecha smalldatetime,Hora time(7),IP varchar(50)); ";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla auditoria empleados
            query = " create table auditoriaEmpleados(Responsable varchar(50),Accion varchar(50),ID varchar(50),Nombre varchar(50),Apellido varchar(50),TipoDoc varchar(50),NDoc varchar(50),Fecha smalldatetime,Hora time(7),IP varchar(50)); ";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla auditoria usuarios
            query = "create table auditoriaUsuarios (Responsable varchar(50),Accion varchar(50),ID varchar(50),username varchar(50),password varchar(50),nombre varchar(50),apellido varchar(50),tipouser varchar(50),Fecha smalldatetime,Hora time(7),IP varchar(50)); ";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla Plan de cuentas
            query = "create table PlanDeCuentas(codigo varchar(50),Numero int not null PRIMARY KEY IDENTITY(1, 1),Nombre varchar(50),Tipo int);";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla Auditoria plan de cuentas
            query = "create table AuditoriaPlanCuentas(Accion varchar(50),Usuario varchar(50),CodigoPlan varchar(50),Numero int not null PRIMARY KEY IDENTITY(1, 1),Nombre varchar(50),Tipo int,Fecha smalldatetime,Hora time(7),IP varchar(50));";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla asientosTemp
            query = "create table asientosTemp(fechaCont varchar(20), nroAsiento int, tipo int, nroRenglon int, nroCuenta int, nombreCuenta varchar(100), fechaOp varchar(20), fechaVto varchar(20), comprobante varchar(100), debehaber int, importe float, leyenda varchar(100)) ";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla asientosRegistrados (LIBRO MAYOR)
            query = "create table libroMayor(fechaCont varchar(20), nroAsiento int, tipo int, nroRenglon int, nroCuenta int, nombreCuenta varchar(100), fechaOp varchar(20), fechaVto varchar(20), comprobante varchar(100), debehaber int, importe float, leyenda varchar(100)) ";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla ultimo numero de asientos
            query = "create table ultimoNroAsiento(numero int)";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();
            query = "insert into ultimoNroAsiento(numero) values(1)"; //Insertamos un 1 que luego se ira autosumando mientras cargamos asientos
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla ultima emision diario
            query = "create table ultimaEmision(fechaUltimaEmision varchar(50))";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();
            query = "insert into ultimaemision values('03/04/1992')"; //ultimo hecho
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla puntos de venta
            query = "create table puntosDeVenta( id int PRIMARY KEY identity(1, 1), numero int)";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla productos
            query = "create table productos(id int PRIMARY KEY identity (1,1), nombre varchar(100), codFamilia int, cantidad int, precioUnitario float, codImpuesto int, cantImpuestosInternos int); ";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla Tipos de Impuesto
            query = "create table productos(id int PRIMARY KEY identity (1,1), descripcion varchar(100), porcentaje varchar(10)); ";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla condiciones comerciales
            query = "create table condicionesComerciales( id int primary key identity(1,1), descripcion varchar(100));";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla productos
            query = "create table productos( id int primary key identity(1,1), descripcion varchar(100));";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla Familias
            query = "create table familias( id int primary key identity(1,1), nombre varchar(100));";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla Clientes
            query = "create table clientes( id int primary key identity(1,1), razonSocial varchar(100), nombreFantasia varchar(100) , domicilio varchar(100), telefono varchar(100), codLocalidad varchar(100), codResponsable varchar(100), codDocumento varchar(100), nroDocumento varchar(100), nroIngresosBrutos varchar(100));";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();


            conexion2.Close();
        }

        public void cargarEmpresa(String nombre, String razonSocial, String localizacion, String tipoResponsable, String cuit, String fechaIni, String fechaCierre, String password)
        {
            //Se agrega el registro a la tabla de empresas
            Global.conexion.Open();
            String query = "insert into empresas (nombre, razonsocial, localizacion,tiporesponsable,cuit, fechaIni, fechaCierre) VALUES (@nombre,@razonsocial,@localizacion,@tiporesponsable,@cuit,@fechaIni,@fechaCierre)";
            SqlCommand command = new SqlCommand(query, Global.conexion);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@razonsocial", razonSocial);
            command.Parameters.AddWithValue("@localizacion", localizacion);
            command.Parameters.AddWithValue("@tiporesponsable", tipoResponsable);
            command.Parameters.AddWithValue("@cuit", cuit);
            command.Parameters.AddWithValue("@fechaIni", fechaIni);
            command.Parameters.AddWithValue("@fechaCierre", fechaCierre);
            SqlDataReader reader = command.ExecuteReader();
            Global.conexion.Close();

            //Se crea la Base de datos para esa empresa
            Global.conexion.Open();
            query = "create database "+nombre+";";
            SqlCommand commandaux = new SqlCommand(query, Global.conexion);
            commandaux.Parameters.AddWithValue("@nombre", nombre);
            commandaux.ExecuteNonQuery();
            Global.conexion.Close();

            //Se crean todas las tablas para la nueva base de datos 

            //Establecemos la conexion2 con el nombre de la empresa
            Global.EmpresaLog = nombre;

            //Creamos tablas ---------------------------------------------------------------------------

            crearTablas(nombre, razonSocial, localizacion, tipoResponsable, cuit, fechaIni, fechaCierre, password);



            MessageBox.Show("Se ha dado de alta la empresa " + nombre);
        }
        
        public void limpiarPantalla()
        {
            this.nombreEmpresatxt.Text = "";
            this.razonSocialtxt.Text = "";
            this.localizacionEmpresatxt.Text = "";
            this.comboBoxTipoResp.Text = "";
            this.cuitTxt.Text = "";
            this.fechaIniDateTimePicker.Text = "";
            this.textBox1.Text = "";
        }

     
        private void AñadirEConfirm_Click(object sender, EventArgs e)
        {     
            String nombre = nombreEmpresatxt.Text;             //Nombre de la empresa para el sistema
            String razonSocial = razonSocialtxt.Text;          //Nombre posta de la empresa
            String localizacion = localizacionEmpresatxt.Text; 
            String tipoResponsable = comboBoxTipoResp.Text;
            String cuit = cuitTxt.Text;
            String fechaIni = fechaIniDateTimePicker.Text;
            String fechaCierre = fechaCierreDateTimePicker.Text;
            String password = textBox1.Text;

            if ( (nombre == "") || (razonSocial == "") || (localizacion == "") || (tipoResponsable == "") || (cuit == "") || (fechaIni == "") )
            {
                MessageBox.Show("Complete todos los campos.");
            }
            else
            {
                if (nombre.Contains(" "))
                {
                    MessageBox.Show("El nombre de usuario no puede incluir espacios en blanco");
            }
                else
                {
                    if (empresaExiste(nombre))
                    {
                        MessageBox.Show("Este nombre ya está en uso");
                    }
                    else
                    {
                        cargarEmpresa(nombre, razonSocial, localizacion, tipoResponsable, cuit, fechaIni, fechaCierre, password);
                        limpiarPantalla();
                        this.Close();                     
                    }
                }
               
            }
            
         }


     }
}


