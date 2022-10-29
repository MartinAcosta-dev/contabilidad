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
            query = "create table tiposDeImpuesto(id int PRIMARY KEY identity (1,1), descripcion varchar(100), porcentaje varchar(10)); ";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla condiciones comerciales
            query = "create table condicionesComerciales( id int primary key identity(1,1), descripcion varchar(100));";
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

            //Tabla Tipos de Responsable
            query = "create table tiposResponsable(id int primary key identity(1,1), descripcion varchar(100))";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();
            //Llenamos la tabla
            query = "insert into tiposResponsable values ('Responsable Inscripto');insert into tiposResponsable values ('Responsable No Inscripto');" +
                "insert into tiposResponsable values ('No Responsable');insert into tiposResponsable values ('Sujeto Exento');" +
                "insert into tiposResponsable values ('Consumidor Final');insert into tiposResponsable values ('Responsable Monotributo');" +
                "insert into tiposResponsable values ('Sujeto no Categorizado');insert into tiposResponsable values ('Proveedor del Exterior');" +
                "insert into tiposResponsable values ('Cliente del Exterior');insert into tiposResponsable values ('IVA Liberado - Ley N 19.640');" +
                "insert into tiposResponsable values ('IVA Responsable Inscripto - Agente de Percepcion');insert into tiposResponsable values ('Pequeño Contribuyente Eventual');" +
                "insert into tiposResponsable values ('Monotributista Social');insert into tiposResponsable values('Pequeño Contribuyente Eventual Social');";               
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();
           
           

            //Tabla de provincias
            query = "create table provincias(id int PRIMARY KEY identity(1,1), nombre varchar(100));";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();
            //Llenamos la tabla de provincias
            query = "insert into provincias values('Buenos Aires'); insert into provincias values('Catamarca');insert into provincias values('Chaco'); insert into provincias values('Chubut'); insert into provincias values('Cordoba');"+
            "insert into provincias values('Corrientes');"+
            "insert into provincias values('Entre Rios');" +
            "insert into provincias values('Formosa');" +
            "insert into provincias values('Jujuy');" +
            "insert into provincias values('La Pampa');" +
            "insert into provincias values('La Rioja');" +
            "insert into provincias values('Mendoza');insert into provincias values('Misiones');"+
            "insert into provincias values('Neuquen');insert into provincias values('Rio Negro');"+
            "insert into provincias values('Salta');insert into provincias values('San Juan');" +
            "insert into provincias values('San Luis');insert into provincias values('Santa Cruz');"+
            "insert into provincias values('Santa Fe');insert into provincias values('Santiago del Estero');"+
            "insert into provincias values('Tierra del Fuego');insert into provincias values('Tucuman'); ";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla de tiposDocumento
            query = "create table tiposDocumento(id varchar(100),descripcion varchar(100));";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();
            //Llenamos la tabla de tiposDocumento
            query = "insert into tiposDocumento values('0','CI Policía Federal');" +
            "insert into tiposDocumento values('1','CI Buenos Aires');"+
            " insert into tiposDocumento values('2','CI Catamarca');"+
            " insert into tiposDocumento values('3','CI Córdoba');" +
            "  insert into tiposDocumento values('4','CI Corrientes');" +
            " insert into tiposDocumento values('5','CI Entre Ríos');" +
            " insert into tiposDocumento values('6','CI Jujuy');" +
            " insert into tiposDocumento values('7','CI Mendoza');" +
            " insert into tiposDocumento values('8','CI La Rioja');" +
            " insert into tiposDocumento values('9','CI Salta');" +
            " insert into tiposDocumento values('10','CI San Juan');" +
            " insert into tiposDocumento values('11','CI San Luis');" +
            " insert into tiposDocumento values('12','CI Santa Fe');" +
            " insert into tiposDocumento values('13','CI Santiago del Estero');" +
            " insert into tiposDocumento values('14','CI Tucumán');" +
            " insert into tiposDocumento values('16','CI Chaco');" +
            " insert into tiposDocumento values('17','CI Chubut');" +
            " insert into tiposDocumento values('18','CI Formosa');" +
            " insert into tiposDocumento values('19','CI Misiones');" +
            " insert into tiposDocumento values('20','CI Neuquén');" +
            "insert into tiposDocumento values('21','CI La Pampa');" +
            "insert into tiposDocumento values('22','CI Río Negro');" +
            " insert into tiposDocumento values('23','CI Santa Cruz');" +
            "insert into tiposDocumento values('24','CI Tierra del Fuego');" +
            "insert into tiposDocumento values('80','CUIT');" +
            "insert into tiposDocumento values('86','CUIL');" +
            " insert into tiposDocumento values('87','CDI');" +
            " insert into tiposDocumento values('89','LE');" +
            "insert into tiposDocumento values('90','LC');" +
            "insert into tiposDocumento values('91','CI extranjera');" +
            "insert into tiposDocumento values('92','en trámite');" +
            "insert into tiposDocumento values('93','Acta nacimiento');" +
            "insert into tiposDocumento values('94','Pasaporte');" +
            "insert into tiposDocumento values('95','CI Bs. As. RNP');" +
            "insert into tiposDocumento values('96','DNI');" +
            "insert into tiposDocumento values('99','Sin identificar/venta global diaria');" +
            "insert into tiposDocumento values('30','Certificado de Migración');"+
            "insert into tiposDocumento values('88','Usado por Anses para Padrón'); ";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //TABLA DE TIPOS DE COMRPOBANTE
            query = "create table tiposComprobante ( id int PRIMARY KEY identity(1,1),descripcion varchar(100));";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();
            //Llenamos la tabla de tiposComprobante
            query = "insert into tiposComprobante values( 'FACTURAS A');" +
            "insert into tiposComprobante values( 'NOTAS DE DEBITO A');" +
            "insert into tiposComprobante values( 'NOTAS DE CREDITO A');" +
            "insert into tiposComprobante values( 'RECIBOS A');" +
            "insert into tiposComprobante values( 'NOTAS DE VENTA AL CONTADO A');" +
"insert into tiposComprobante values( 'FACTURAS B');" +
"insert into tiposComprobante values( 'NOTAS DE DEBITO B');" +
"insert into tiposComprobante values( 'NOTAS DE CREDITO B');" +
"insert into tiposComprobante values( 'RECIBOS B');" +
"insert into tiposComprobante values( 'NOTAS DE VENTA AL CONTADO B');" +
"insert into tiposComprobante values( 'FACTURAS C');" +
"insert into tiposComprobante values( 'NOTAS DE DEBITO C');" +
"insert into tiposComprobante values( 'NOTAS DE CREDITO C');" +
"insert into tiposComprobante values( 'RECIBOS C');" +
"insert into tiposComprobante values( 'NOTAS DE VENTA AL CONTADO C');" +
"insert into tiposComprobante values( 'LIQUIDACION DE SERVICIOS PUBLICOS CLASE A');" +
"insert into tiposComprobante values( 'LIQUIDACION DE SERVICIOS PUBLICOS CLASE B');" +
"insert into tiposComprobante values( 'FACTURAS DE EXPORTACION');" +
"insert into tiposComprobante values( 'NOTAS DE DEBITO POR OPERACIONES CON EL EXTERIOR');" +
"insert into tiposComprobante values( 'NOTAS DE CREDITO POR OPERACIONES CON EL EXTERIOR');" +
"insert into tiposComprobante values( 'FACTURAS - PERMISO EXPORTACION SIMPLIFICADO - DTO. 855/97');" +
"insert into tiposComprobante values( 'COMPROBANTES “A” DE COMPRA PRIMARIA PARA EL SECTOR PESQUERO MARITIMO');" +
"insert into tiposComprobante values( 'COMPROBANTES “A” DE CONSIGNACION PRIMARIA PARA EL SECTOR PESQUERO MARITIMO');" +
"insert into tiposComprobante values( 'COMPROBANTES “B” DE COMPRA PRIMARIA PARA EL SECTOR PESQUERO MARITIMO');" +
"insert into tiposComprobante values( 'COMPROBANTES “B” DE CONSIGNACION PRIMARIA PARA EL SECTOR PESQUERO MARITIMO');" +
"insert into tiposComprobante values( 'LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE A');" +
"insert into tiposComprobante values( 'LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE B');" +
"insert into tiposComprobante values( 'LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE C');" +
"insert into tiposComprobante values( 'COMPROBANTES DE COMPRA DE BIENES USADOS');" +
"insert into tiposComprobante values( 'MANDATO - CONSIGNACION');" +
"insert into tiposComprobante values( 'COMPROBANTES PARA RECICLAR MATERIALES');" +
"insert into tiposComprobante values( 'LIQUIDACION PRIMARIA DE GRANOS');" +
"insert into tiposComprobante values( 'COMPROBANTES A DEL APARTADO A  INCISO F)  R.G. N°  1415');" +
"insert into tiposComprobante values( 'COMPROBANTES B DEL ANEXO I, APARTADO A, INC. F), R.G. N° 1415');" +
"insert into tiposComprobante values( 'COMPROBANTES C DEL Anexo I, Apartado A, INC.F), R.G. N° 1415');" +
"insert into tiposComprobante values( 'NOTAS DE DEBITO O DOCUMENTO EQUIVALENTE QUE CUMPLAN CON LA R.G. N° 1415');" +
"insert into tiposComprobante values( 'NOTAS DE CREDITO O DOCUMENTO EQUIVALENTE QUE CUMPLAN CON LA R.G. N° 1415');" +
"insert into tiposComprobante values( 'OTROS COMPROBANTES A QUE CUMPLEN CON LA R G  1415');" +
"insert into tiposComprobante values( 'OTROS COMPROBANTES B QUE CUMPLAN CON LA R.G. N° 1415');" +
"insert into tiposComprobante values( 'OTROS COMPROBANTES C QUE CUMPLAN CON LA R.G. N° 1415');" +
"insert into tiposComprobante values( 'NOTA DE CREDITO LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE B');" +
"insert into tiposComprobante values( 'NOTA DE CREDITO LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE C');" +
"insert into tiposComprobante values( 'NOTA DE DEBITO LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE A');" +
"insert into tiposComprobante values( 'NOTA DE DEBITO LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE B');" +
"insert into tiposComprobante values( 'NOTA DE DEBITO LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE C');" +
"insert into tiposComprobante values( 'NOTA DE CREDITO LIQUIDACION UNICA COMERCIAL IMPOSITIVA CLASE A');" +
"insert into tiposComprobante values( 'COMPROBANTES DE COMPRA DE BIENES NO REGISTRABLES A CONSUMIDORES FINALES');" +
"insert into tiposComprobante values( 'RECIBO FACTURA A  REGIMEN DE FACTURA DE CREDITO ');" +
"insert into tiposComprobante values( 'FACTURAS M');" +
"insert into tiposComprobante values( 'NOTAS DE DEBITO M');" +
"insert into tiposComprobante values( 'NOTAS DE CREDITO M');" +
"insert into tiposComprobante values( 'RECIBOS M');" +
"insert into tiposComprobante values( 'NOTAS DE VENTA AL CONTADO M');" +
"insert into tiposComprobante values( 'COMPROBANTES M DEL ANEXO I  APARTADO A  INC F) R.G. N° 1415');" +
"insert into tiposComprobante values( 'OTROS COMPROBANTES M QUE CUMPLAN CON LA R.G. N° 1415');" +
"insert into tiposComprobante values( 'CUENTAS DE VENTA Y LIQUIDO PRODUCTO M');" +
"insert into tiposComprobante values( 'LIQUIDACIONES M');" +
"insert into tiposComprobante values( 'CUENTAS DE VENTA Y LIQUIDO PRODUCTO A');" +
"insert into tiposComprobante values( 'CUENTAS DE VENTA Y LIQUIDO PRODUCTO B');" +
"insert into tiposComprobante values( 'LIQUIDACIONES A');" +
"insert into tiposComprobante values( 'LIQUIDACIONES B');" +
"insert into tiposComprobante values( 'DESPACHO DE IMPORTACION');" +
"insert into tiposComprobante values( 'LIQUIDACION C');" +
"insert into tiposComprobante values( 'RECIBOS FACTURA DE CREDITO');" +
"insert into tiposComprobante values( 'INFORME DIARIO DE CIERRE (ZETA) - CONTROLADORES FISCALES');" +
"insert into tiposComprobante values( 'TIQUE FACTURA A   ');" +
"insert into tiposComprobante values( 'TIQUE FACTURA B');" +
"insert into tiposComprobante values( 'TIQUE');" +
"insert into tiposComprobante values( 'REMITO ELECTRONICO');" +
"insert into tiposComprobante values( 'RESUMEN DE DATOS');" +
"insert into tiposComprobante values( 'OTROS COMPROBANTES - DOCUMENTOS EXCEPTUADOS - NOTAS DE CREDITO');" +
"insert into tiposComprobante values( 'REMITOS R');" +
"insert into tiposComprobante values( 'OTROS COMPROBANTES QUE NO CUMPLEN O ESTÁN EXCEPTUADOS DE LA R.G. 1415 Y SUS MODIF ');" +
"insert into tiposComprobante values( 'TIQUE NOTA DE CREDITO ');" +
"insert into tiposComprobante values( 'TIQUE FACTURA C');" +
"insert into tiposComprobante values( ' TIQUE NOTA DE CREDITO A');" +
"insert into tiposComprobante values( 'TIQUE NOTA DE CREDITO B');" +
"insert into tiposComprobante values( 'TIQUE NOTA DE CREDITO C');" +
"insert into tiposComprobante values( 'TIQUE NOTA DE DEBITO A');" +
"insert into tiposComprobante values( 'TIQUE NOTA DE DEBITO B');" +
"insert into tiposComprobante values( 'TIQUE NOTA DE DEBITO C');" +
"insert into tiposComprobante values( 'TIQUE FACTURA M');" +
"insert into tiposComprobante values( 'TIQUE NOTA DE CREDITO M');" +
"insert into tiposComprobante values( 'TIQUE NOTA DE DEBITO M');" +
"insert into tiposComprobante values( 'FACTURA DE CRÉDITO ELECTRÓNICA MiPyMEs (FCE) A');" +
"insert into tiposComprobante values( 'NOTA DE DEBITO ELECTRÓNICA MiPyMEs (FCE) A');" +
"insert into tiposComprobante values( 'NOTA DE CREDITO ELECTRÓNICA MiPyMEs (FCE) A');" +
"insert into tiposComprobante values( 'FACTURA DE CRÉDITO ELECTRÓNICA MiPyMEs (FCE) B');" +
"insert into tiposComprobante values( 'NOTA DE DEBITO ELECTRÓNICA MiPyMEs (FCE) B');" +
            "insert into tiposComprobante values( 'NOTA DE CREDITO ELECTRÓNICA MiPyMEs (FCE) B');" +
            "insert into tiposComprobante values( 'FACTURA DE CRÉDITO ELECTRÓNICA MiPyMEs (FCE) C');" +
            "insert into tiposComprobante values( 'NOTA DE DEBITO ELECTRÓNICA MiPyMEs (FCE) C');" +
            "insert into tiposComprobante values( 'NOTA DE CREDITO ELECTRÓNICA MiPyMEs (FCE) C');" +
            "insert into tiposComprobante values( 'LIQUIDACION SECUNDARIA DE GRANOS');" +
            "insert into tiposComprobante values( 'CERTIFICACION ELECTRONICA (GRANOS)');" +
            "insert into tiposComprobante values( 'REMITO ELECTRÓNICO CÁRNICO ');";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla de UltimoComprobanteEmitido
            query = "create table ultimoComprobanteEmitido(puntoDeVenta int,fecha varchar(20),tipoComprobante int);";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla de ventas
            query = "create table ventas (id int PRIMARY KEY identity(1,1),fecha varchar(20),puntoDeVenta int,numComprobante int,codComprobante int,codCliente int,codCondicion int,subtotal float,iva float,total float);";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla de remitos
            query = "create table remitos(id int primary key identity(1,1),nroVenta int,codProducto int,precioUnitario float,cantidad int,porcIVA varchar(10));";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla de localidades
            query = "create table localidades(id int primary key identity(1,1),nombre varchar(100),codPostal int,codProvincia int);";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();

            //Tabla de ultimoNroComprobanteEmitido
            query = "create table ultimoNroComprobanteEmitido ( nroComprobante int);";
            command = new SqlCommand(query, conexion2);
            command.ExecuteNonQuery();
            query = "insert into ultimoNroComprobanteEmitido values (0)";
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


