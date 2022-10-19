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

namespace Sistema
{
    

    public partial class Menu1 : Form
    {
       

        //POSIBLE VAR ID EMPLEADOS

        public Menu1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.documentos' Puede moverla o quitarla según sea necesario.
            this.documentosTableAdapter.Fill(this.practicasDataSet.documentos);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.practicasDataSet.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'cRUDDataSet.Documentos' Puede moverla o quitarla según sea necesario.




            try
            {
                Global.conexion.Open();
                //MessageBox.Show("BD Conectada");
            }
            catch (Exception)
            {

                MessageBox.Show("Error BD");
            }

            Documentosbtn.Enabled = false;
            Empleadosbtn.Enabled = false;
            Mantenimientobtn.Enabled = false;
            
            Actualizar.Enabled = false;

            UserLoggedtxt.Text = Global.UserLogged[0] +" "+ Global.UserLogged[1];

            //VERIFICA QUE TIPO DE USER ES
            if (Global.UserLogged[2] == "ADMINISTRADOR" )
            {
              //HABILITAR TODO
              Documentosbtn.Enabled = true;
              Empleadosbtn.Enabled = true;
              Mantenimientobtn.Enabled = true;
              Actualizar.Enabled = true;
   
            }

            if (Global.UserLogged[2] == "AUDITOR")
            {
                //HABILITAR AUDITORIA
                Documentosbtn.Enabled = false;
                Empleadosbtn.Enabled = false;
                Mantenimientobtn.Enabled = true;
                Actualizar.Enabled = true;
                Guardar.Enabled = false;
            }

            if (Global.UserLogged[2] == "SUPERVISOR")
            {
                //HABILITAR ABM de USUARIOS
                Documentosbtn.Enabled = false;
                Empleadosbtn.Enabled = false;
                Mantenimientobtn.Enabled = true;
                Actualizar.Enabled = true;
            }

            if (Global.UserLogged[2] == "OPERARIO")
            {
                //HABILITAR ABM
                Documentosbtn.Enabled = true;
                Empleadosbtn.Enabled = true;
                Mantenimientobtn.Enabled = false;            
                Actualizar.Enabled = true;
            }

        }

        private void Documentosbtn_Click(object sender, EventArgs e)
        {
          panelDocumentos.Visible = true;
          PanelEmpleados.Visible = false;
           
          
            txtbienvenido.Visible = false;
            txtbienvenido2.Visible = false;
            Actualizar.Visible = true;
            this.documentosTableAdapter.Fill(this.practicasDataSet.documentos);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.practicasDataSet.Empleados);
        }

        private void Empleadosbtn_Click(object sender, EventArgs e)
        {
            PanelEmpleados.Visible = true;
            panelDocumentos.Visible = false;
            txtbienvenido.Visible = false;
            txtbienvenido2.Visible = false;
            Actualizar.Visible = true;
            this.documentosTableAdapter.Fill(this.practicasDataSet.documentos);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.practicasDataSet.Empleados);
        }

        private void AñadirE_Click(object sender, EventArgs e)
        {
            AñadirEmpleado AñadirEmpleadoForm = new AñadirEmpleado();
            AñadirEmpleadoForm.ShowDialog();         
        }

        private void ModificarE_Click(object sender, EventArgs e)
        {
            ModificarEmpleado modificarEmpleadoForm = new ModificarEmpleado();
            modificarEmpleadoForm.ShowDialog();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            this.documentosTableAdapter.Fill(this.practicasDataSet.documentos);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.practicasDataSet.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'cRUDDataSet.Documentos' Puede moverla o quitarla según sea necesario.


        }

        private void EliminarE_Click(object sender, EventArgs e)
        {
           EliminarEmpleado eliminarEmpleadoForm= new EliminarEmpleado();
            eliminarEmpleadoForm.ShowDialog();
        }

        private void AñadirDbtn_Click(object sender, EventArgs e)
        {
            AñadirDocumento AñadirDocumentoForm = new AñadirDocumento();
            AñadirDocumentoForm.ShowDialog();
        }

        private void ModificarDbtn_Click(object sender, EventArgs e)
        {
            ModificarDocumento ModificarDocumentoForm = new ModificarDocumento();   
            ModificarDocumentoForm.ShowDialog();    
        }

        private void EliminarDbtn_Click(object sender, EventArgs e)
        {
            EliminarDocumento EliminarDocumentoForm = new EliminarDocumento();  
            EliminarDocumentoForm.ShowDialog(); 
        }

       

        private void Auditoriabtn_Click(object sender, EventArgs e)
        {
            PanelEmpleados.Visible = false;
            panelDocumentos.Visible = false; 
            txtbienvenido.Visible = false;
            txtbienvenido2.Visible = false;
            Actualizar.Visible = true;
        }

        private void Usuariosbtn_Click(object sender, EventArgs e)
        {
            PanelEmpleados.Visible = false;
            panelDocumentos.Visible = false;            
            txtbienvenido.Visible = false;
            txtbienvenido2.Visible = false;
            Actualizar.Visible = true;
            Mantenimiento mantenimiento = new Mantenimiento();
            mantenimiento.ShowDialog();
        }

        private void Cerrarsesion_Click(object sender, EventArgs e)
        {
            Global.UserLogged[0] = "";
            Global.UserLogged[1] = "";
            Global.UserLogged[2] = "";
            Application.Restart();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AñadirUsuario añadirUsuario = new AñadirUsuario();
            añadirUsuario.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EliminarUsuario EliminarUsuario = new EliminarUsuario();
            EliminarUsuario.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ModificarUsuario ModificarUsuario = new ModificarUsuario(); 
            ModificarUsuario.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OpcionesGuardado opcionesGuardado = new OpcionesGuardado(); 
            opcionesGuardado.ShowDialog();
        }

        private void Menu_Activated(object sender, EventArgs e)
        {
            this.documentosTableAdapter.Fill(this.practicasDataSet.documentos);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.practicasDataSet.Empleados);
        }

        private void panelDocumentos_Paint(object sender, PaintEventArgs e)
        {
            this.documentosTableAdapter.Fill(this.practicasDataSet.documentos);
            // TODO: esta línea de código carga datos en la tabla 'practicasDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.practicasDataSet.Empleados);
        }
    }
}
