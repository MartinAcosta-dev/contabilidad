using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema
{
    

    internal class Global //CONEXION GLOBAL A LA BASE DE DATOS
    {
        //Primera conexion para la tabla de empresas
        static public SqlConnection conexion = new SqlConnection(@"server=DESKTOP-LNJ6R1G;database=empresas; integrated security=true;MultipleActiveResultSets=True");
        static public String[] UserLogged = new String[5]; //Usuario loggeado

        //Segunda conexion para la empresa que entre
        static public String EmpresaLog;
    
        public static SqlConnection getConexion2(String nombreEmpresa)
        {
            // Franco (falta cambiar codigo de server)
            // SqlConnection resultado = new SqlConnection(@"server=DESKTOP-LNJ6R1G;database=" + nombreEmpresa + "; integrated security=true;MultipleActiveResultSets=True");

            // Martin
            SqlConnection resultado = new SqlConnection(@"server=DESKTOP-LNJ6R1G;database=" + nombreEmpresa + "; integrated security=true;MultipleActiveResultSets=True");


            return resultado;
        }

        public static String getImporteString(double importe)
        {
            String resultado = importe.ToString();

            if (resultado.Contains(","))
            {
                int n = resultado.IndexOf(",");

                if(resultado.Length < n + 3)
                {
                    resultado = resultado + "0";
                }
                else
                {
                    if(resultado.Length > n + 3) //o sea es un numero con muchos decimales
                    {
                        int maxLength = n + 3;

                        resultado = resultado.Substring(0, maxLength);
                    }
                }
            }
            else
            {
                resultado = resultado + ",00";
            }

            return resultado;
        }
    }
}







