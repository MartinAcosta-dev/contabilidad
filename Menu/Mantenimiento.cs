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

namespace Sistema
{
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.auditoriaUsuarios' Puede moverla o quitarla según sea necesario.
            this.auditoriaUsuariosTableAdapter.Fill(this.practicasDataSet.auditoriaUsuarios);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.auditoriaEmpleados' Puede moverla o quitarla según sea necesario.
            this.auditoriaEmpleadosTableAdapter.Fill(this.practicasDataSet.auditoriaEmpleados);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.auditoriaDoc' Puede moverla o quitarla según sea necesario.
            this.auditoriaDocTableAdapter.Fill(this.practicasDataSet.auditoriaDoc);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.practicasDataSet.usuarios);

            // TODO: esta línea de código carga datos en la tabla 'cRUDDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            if (Global.UserLogged[2] == "AUDITOR" )
            {
            Usuariosbtn.Enabled = false;
            Auditoriabtn.Enabled = true;
            }
            if (Global.UserLogged[2] == "SUPERVISOR")
            {
                Usuariosbtn.Enabled = true;
                Auditoriabtn.Enabled = false;
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
        AñadirUsuario añadirUsuario = new AñadirUsuario();
         añadirUsuario.ShowDialog();
            añadirUsuario.Activate();
        }

        private void modifuserbtn_Click(object sender, EventArgs e)
        {
        ModificarUsuario modificarUsuario = new ModificarUsuario();
        modificarUsuario.ShowDialog();
        }

        private void elimuserbtn_Click(object sender, EventArgs e)
        {
        EliminarUsuario eliminarUsuario = new EliminarUsuario();    
         eliminarUsuario.ShowDialog();
        }

        private void AñadirEConfirm_Click(object sender, EventArgs e)
        {
            PanelUsuarios.Visible = true;
            PanelBtnAud.Visible = false;
            PanelAudD.Visible = false;
            PanelAudE.Visible = false;
            PanelAudU.Visible = false;
            PanelUsuarios.Location = new Point(162, 84);
            this.auditoriaUsuariosTableAdapter.Fill(this.practicasDataSet.auditoriaUsuarios);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.auditoriaEmpleados' Puede moverla o quitarla según sea necesario.
            this.auditoriaEmpleadosTableAdapter.Fill(this.practicasDataSet.auditoriaEmpleados);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.auditoriaDoc' Puede moverla o quitarla según sea necesario.
            this.auditoriaDocTableAdapter.Fill(this.practicasDataSet.auditoriaDoc);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.practicasDataSet.usuarios);

        }

        private void CancelarEAñadir_Click(object sender, EventArgs e)
        {
            PanelUsuarios.Visible=false;
            PanelBtnAud.Visible = true; 

            
        }

        //private void Mantenimiento_Click(object sender, EventArgs e)
        //{
        //    this.auditoriaUsuariosTableAdapter.Fill(this.practicasDataSet.auditoriaUsuarios);
        //    // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.auditoriaEmpleados' Puede moverla o quitarla según sea necesario.
        //    this.auditoriaEmpleadosTableAdapter.Fill(this.practicasDataSet.auditoriaEmpleados);
        //    // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.auditoriaDoc' Puede moverla o quitarla según sea necesario.
        //    this.auditoriaDocTableAdapter.Fill(this.practicasDataSet.auditoriaDoc);
        //    // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        //    this.usuariosTableAdapter.Fill(this.practicasDataSet.usuarios);
        //}

        

        private void MostrarUsuarios_Click(object sender, EventArgs e)
        {
            //this.auditoriaUsuariosTableAdapter.Fill(this.practicasDataSet.auditoriaUsuarios);
            PanelAudU.Location = new Point(162, 84);
            PanelAudD.Visible = false;
            PanelAudE.Visible = false;
            PanelAudU.Visible = true;     
            

            
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.auditoriaEmpleados' Puede moverla o quitarla según sea necesario.
          
        }

        private void MostrarDocumentos_Click(object sender, EventArgs e)
        {
           // this.auditoriaDocTableAdapter.Fill(this.practicasDataSet.auditoriaDoc);
            PanelAudD.Location = new Point(161, 83);
            PanelAudU.Visible = false;
            PanelAudE.Visible = false;
            PanelAudD.Visible = true;
           

           
         
        }

        private void MostrarEmpleados_Click(object sender, EventArgs e)
        {
            //this.auditoriaEmpleadosTableAdapter.Fill(this.practicasDataSet.auditoriaEmpleados);
            PanelAudE.Location = new Point(163, 85);
            PanelAudD.Visible = false;
            PanelAudU.Visible = false;
            PanelAudE.Visible = true; 
           
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.auditoriaDoc' Puede moverla o quitarla según sea necesario.
            
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelUsuarios_Paint(object sender, PaintEventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.practicasDataSet.usuarios);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.auditoriaUsuariosTableAdapter.Fill(this.practicasDataSet.auditoriaUsuarios);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.auditoriaEmpleados' Puede moverla o quitarla según sea necesario.
            this.auditoriaEmpleadosTableAdapter.Fill(this.practicasDataSet.auditoriaEmpleados);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.auditoriaDoc' Puede moverla o quitarla según sea necesario.
            this.auditoriaDocTableAdapter.Fill(this.practicasDataSet.auditoriaDoc);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.practicasDataSet.usuarios);
        }

        private void backupToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
