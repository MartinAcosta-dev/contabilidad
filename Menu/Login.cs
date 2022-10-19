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

    public partial class Login : Form
    {
       

        public Login()

        {
            InitializeComponent();

        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            String nombreEmp = Global.EmpresaLog;
            SqlConnection conexion = Global.getConexion2(nombreEmp);

            String vpassword = Passtxt.Text;


            conexion.Open();
            String query = "select * FROM password WHERE password = @vpassword";
            SqlCommand comando = new SqlCommand(query, conexion);
         //   comando.Parameters.AddWithValue("@vusername", Usertxt.Text); //toma valor de login a variable
            comando.Parameters.AddWithValue("@vpassword", vpassword);

            SqlDataReader lector = comando.ExecuteReader(); //lee consulta y guarda en lector

            
            if (lector.Read()) //Si encontro el user, entra
            {
                //Global.UserLogged[0] = lector["nombre"].ToString();
                //Global.UserLogged[1] = lector["apellido"].ToString();
                //Global.UserLogged[2] = lector["tipouser"].ToString();
                //Global.UserLogged[3] = lector["ID"].ToString();

                //string localIP = string.Empty;
               // using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
               // {
               //     socket.Connect("8.8.8.8", 65530);
               //     IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                //    localIP = endPoint.Address.ToString();
               // }

               // Global.UserLogged[4] = localIP;
               // MessageBox.Show(localIP);
                MenuPrincipal menuprincipal = new MenuPrincipal();
                menuprincipal.ShowDialog();
                this.Hide();

                conexion.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos ");
                conexion.Close();
            }
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Passtxt_MouseClick(object sender, MouseEventArgs e)
        {
            Passtxt.Text = "";
            Passtxt.UseSystemPasswordChar = true;
            Passtxt.ForeColor = Color.Black;
        }

        private void Usertxt_MouseClick(object sender, MouseEventArgs e)
        {
            Usertxt.Text = "";
            Usertxt.ForeColor = Color.Black;
        }

        private void Login_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usertxt_Click(object sender, EventArgs e)
        {

        }
    }
}
