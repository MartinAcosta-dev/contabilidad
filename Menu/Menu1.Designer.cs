namespace Sistema
{
    partial class Menu1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu1));
            this.Documentosbtn = new System.Windows.Forms.Button();
            this.Empleadosbtn = new System.Windows.Forms.Button();
            this.panelDocumentos = new System.Windows.Forms.Panel();
            this.DatosD = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicasDataSet = new Sistema.PracticasDataSet();
            this.EliminarDbtn = new System.Windows.Forms.Button();
            this.ModificarDbtn = new System.Windows.Forms.Button();
            this.AñadirD = new System.Windows.Forms.Button();
            this.PanelEmpleados = new System.Windows.Forms.Panel();
            this.DatosE = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EliminarE = new System.Windows.Forms.Button();
            this.ModificarE = new System.Windows.Forms.Button();
            this.AñadirE = new System.Windows.Forms.Button();
            this.txtbienvenido = new System.Windows.Forms.Label();
            this.txtbienvenido2 = new System.Windows.Forms.Label();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Mantenimientobtn = new System.Windows.Forms.Button();
            this.UserLoggedtxt = new System.Windows.Forms.Label();
            this.Cerrarsesion = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.empleadosTableAdapter = new Sistema.PracticasDataSetTableAdapters.EmpleadosTableAdapter();
            this.documentosTableAdapter = new Sistema.PracticasDataSetTableAdapters.documentosTableAdapter();
            this.panelDocumentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasDataSet)).BeginInit();
            this.PanelEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Documentosbtn
            // 
            this.Documentosbtn.BackColor = System.Drawing.Color.LightGray;
            this.Documentosbtn.FlatAppearance.BorderSize = 0;
            this.Documentosbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Documentosbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Documentosbtn.ForeColor = System.Drawing.Color.Black;
            this.Documentosbtn.Image = ((System.Drawing.Image)(resources.GetObject("Documentosbtn.Image")));
            this.Documentosbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Documentosbtn.Location = new System.Drawing.Point(15, 67);
            this.Documentosbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Documentosbtn.Name = "Documentosbtn";
            this.Documentosbtn.Size = new System.Drawing.Size(178, 42);
            this.Documentosbtn.TabIndex = 0;
            this.Documentosbtn.Text = "Documentos";
            this.Documentosbtn.UseVisualStyleBackColor = false;
            this.Documentosbtn.Click += new System.EventHandler(this.Documentosbtn_Click);
            // 
            // Empleadosbtn
            // 
            this.Empleadosbtn.BackColor = System.Drawing.Color.LightGray;
            this.Empleadosbtn.FlatAppearance.BorderSize = 0;
            this.Empleadosbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Empleadosbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Empleadosbtn.ForeColor = System.Drawing.Color.Black;
            this.Empleadosbtn.Image = ((System.Drawing.Image)(resources.GetObject("Empleadosbtn.Image")));
            this.Empleadosbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Empleadosbtn.Location = new System.Drawing.Point(15, 134);
            this.Empleadosbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Empleadosbtn.Name = "Empleadosbtn";
            this.Empleadosbtn.Size = new System.Drawing.Size(178, 42);
            this.Empleadosbtn.TabIndex = 1;
            this.Empleadosbtn.Text = "Empleados";
            this.Empleadosbtn.UseVisualStyleBackColor = false;
            this.Empleadosbtn.Click += new System.EventHandler(this.Empleadosbtn_Click);
            // 
            // panelDocumentos
            // 
            this.panelDocumentos.BackColor = System.Drawing.Color.Transparent;
            this.panelDocumentos.Controls.Add(this.DatosD);
            this.panelDocumentos.Controls.Add(this.EliminarDbtn);
            this.panelDocumentos.Controls.Add(this.ModificarDbtn);
            this.panelDocumentos.Controls.Add(this.AñadirD);
            this.panelDocumentos.Location = new System.Drawing.Point(219, 72);
            this.panelDocumentos.Name = "panelDocumentos";
            this.panelDocumentos.Size = new System.Drawing.Size(858, 474);
            this.panelDocumentos.TabIndex = 2;
            this.panelDocumentos.Visible = false;
            this.panelDocumentos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDocumentos_Paint);
            // 
            // DatosD
            // 
            this.DatosD.AllowUserToAddRows = false;
            this.DatosD.AllowUserToDeleteRows = false;
            this.DatosD.AutoGenerateColumns = false;
            this.DatosD.BackgroundColor = System.Drawing.Color.LightGray;
            this.DatosD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.DatosD.DataSource = this.documentosBindingSource;
            this.DatosD.Location = new System.Drawing.Point(15, 3);
            this.DatosD.Name = "DatosD";
            this.DatosD.ReadOnly = true;
            this.DatosD.RowHeadersWidth = 51;
            this.DatosD.Size = new System.Drawing.Size(431, 299);
            this.DatosD.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Longitud";
            this.dataGridViewTextBoxColumn8.HeaderText = "Longitud";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // documentosBindingSource
            // 
            this.documentosBindingSource.DataMember = "documentos";
            this.documentosBindingSource.DataSource = this.practicasDataSet;
            // 
            // practicasDataSet
            // 
            this.practicasDataSet.DataSetName = "PracticasDataSet";
            this.practicasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EliminarDbtn
            // 
            this.EliminarDbtn.BackColor = System.Drawing.Color.LightGray;
            this.EliminarDbtn.FlatAppearance.BorderSize = 0;
            this.EliminarDbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.EliminarDbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarDbtn.ForeColor = System.Drawing.Color.Black;
            this.EliminarDbtn.Image = ((System.Drawing.Image)(resources.GetObject("EliminarDbtn.Image")));
            this.EliminarDbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarDbtn.Location = new System.Drawing.Point(626, 260);
            this.EliminarDbtn.Margin = new System.Windows.Forms.Padding(6);
            this.EliminarDbtn.Name = "EliminarDbtn";
            this.EliminarDbtn.Size = new System.Drawing.Size(178, 42);
            this.EliminarDbtn.TabIndex = 5;
            this.EliminarDbtn.Text = "Eliminar";
            this.EliminarDbtn.UseVisualStyleBackColor = false;
            this.EliminarDbtn.Click += new System.EventHandler(this.EliminarDbtn_Click);
            // 
            // ModificarDbtn
            // 
            this.ModificarDbtn.BackColor = System.Drawing.Color.LightGray;
            this.ModificarDbtn.FlatAppearance.BorderSize = 0;
            this.ModificarDbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.ModificarDbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarDbtn.ForeColor = System.Drawing.Color.Black;
            this.ModificarDbtn.Image = ((System.Drawing.Image)(resources.GetObject("ModificarDbtn.Image")));
            this.ModificarDbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarDbtn.Location = new System.Drawing.Point(626, 196);
            this.ModificarDbtn.Margin = new System.Windows.Forms.Padding(6);
            this.ModificarDbtn.Name = "ModificarDbtn";
            this.ModificarDbtn.Size = new System.Drawing.Size(178, 42);
            this.ModificarDbtn.TabIndex = 4;
            this.ModificarDbtn.Text = "Modificar";
            this.ModificarDbtn.UseVisualStyleBackColor = false;
            this.ModificarDbtn.Click += new System.EventHandler(this.ModificarDbtn_Click);
            // 
            // AñadirD
            // 
            this.AñadirD.BackColor = System.Drawing.Color.LightGray;
            this.AñadirD.FlatAppearance.BorderSize = 0;
            this.AñadirD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.AñadirD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AñadirD.ForeColor = System.Drawing.Color.Black;
            this.AñadirD.Image = ((System.Drawing.Image)(resources.GetObject("AñadirD.Image")));
            this.AñadirD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AñadirD.Location = new System.Drawing.Point(626, 133);
            this.AñadirD.Margin = new System.Windows.Forms.Padding(6);
            this.AñadirD.Name = "AñadirD";
            this.AñadirD.Size = new System.Drawing.Size(178, 42);
            this.AñadirD.TabIndex = 3;
            this.AñadirD.Text = "Añadir";
            this.AñadirD.UseVisualStyleBackColor = false;
            this.AñadirD.Click += new System.EventHandler(this.AñadirDbtn_Click);
            // 
            // PanelEmpleados
            // 
            this.PanelEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.PanelEmpleados.Controls.Add(this.DatosE);
            this.PanelEmpleados.Controls.Add(this.EliminarE);
            this.PanelEmpleados.Controls.Add(this.ModificarE);
            this.PanelEmpleados.Controls.Add(this.AñadirE);
            this.PanelEmpleados.Location = new System.Drawing.Point(213, 67);
            this.PanelEmpleados.Name = "PanelEmpleados";
            this.PanelEmpleados.Size = new System.Drawing.Size(861, 474);
            this.PanelEmpleados.TabIndex = 6;
            this.PanelEmpleados.Visible = false;
            // 
            // DatosE
            // 
            this.DatosE.AllowUserToAddRows = false;
            this.DatosE.AllowUserToDeleteRows = false;
            this.DatosE.AutoGenerateColumns = false;
            this.DatosE.BackgroundColor = System.Drawing.Color.LightGray;
            this.DatosE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatosE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.DatosE.DataSource = this.empleadosBindingSource;
            this.DatosE.Location = new System.Drawing.Point(3, 3);
            this.DatosE.Name = "DatosE";
            this.DatosE.ReadOnly = true;
            this.DatosE.RowHeadersWidth = 51;
            this.DatosE.Size = new System.Drawing.Size(647, 468);
            this.DatosE.TabIndex = 10;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TipoDoc";
            this.dataGridViewTextBoxColumn4.HeaderText = "TipoDoc";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NDoc";
            this.dataGridViewTextBoxColumn5.HeaderText = "NDoc";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.practicasDataSet;
            // 
            // EliminarE
            // 
            this.EliminarE.BackColor = System.Drawing.Color.LightGray;
            this.EliminarE.FlatAppearance.BorderSize = 0;
            this.EliminarE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.EliminarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarE.ForeColor = System.Drawing.Color.Black;
            this.EliminarE.Image = ((System.Drawing.Image)(resources.GetObject("EliminarE.Image")));
            this.EliminarE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarE.Location = new System.Drawing.Point(668, 257);
            this.EliminarE.Margin = new System.Windows.Forms.Padding(6);
            this.EliminarE.Name = "EliminarE";
            this.EliminarE.Size = new System.Drawing.Size(178, 42);
            this.EliminarE.TabIndex = 5;
            this.EliminarE.Text = "Eliminar";
            this.EliminarE.UseVisualStyleBackColor = false;
            this.EliminarE.Click += new System.EventHandler(this.EliminarE_Click);
            // 
            // ModificarE
            // 
            this.ModificarE.BackColor = System.Drawing.Color.LightGray;
            this.ModificarE.FlatAppearance.BorderSize = 0;
            this.ModificarE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.ModificarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarE.ForeColor = System.Drawing.Color.Black;
            this.ModificarE.Image = ((System.Drawing.Image)(resources.GetObject("ModificarE.Image")));
            this.ModificarE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarE.Location = new System.Drawing.Point(668, 193);
            this.ModificarE.Margin = new System.Windows.Forms.Padding(6);
            this.ModificarE.Name = "ModificarE";
            this.ModificarE.Size = new System.Drawing.Size(178, 42);
            this.ModificarE.TabIndex = 4;
            this.ModificarE.Text = "Modificar";
            this.ModificarE.UseVisualStyleBackColor = false;
            this.ModificarE.Click += new System.EventHandler(this.ModificarE_Click);
            // 
            // AñadirE
            // 
            this.AñadirE.BackColor = System.Drawing.Color.LightGray;
            this.AñadirE.FlatAppearance.BorderSize = 0;
            this.AñadirE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.AñadirE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AñadirE.ForeColor = System.Drawing.Color.Black;
            this.AñadirE.Image = ((System.Drawing.Image)(resources.GetObject("AñadirE.Image")));
            this.AñadirE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AñadirE.Location = new System.Drawing.Point(668, 130);
            this.AñadirE.Margin = new System.Windows.Forms.Padding(6);
            this.AñadirE.Name = "AñadirE";
            this.AñadirE.Size = new System.Drawing.Size(178, 42);
            this.AñadirE.TabIndex = 3;
            this.AñadirE.Text = "Añadir";
            this.AñadirE.UseVisualStyleBackColor = false;
            this.AñadirE.Click += new System.EventHandler(this.AñadirE_Click);
            // 
            // txtbienvenido
            // 
            this.txtbienvenido.AutoSize = true;
            this.txtbienvenido.BackColor = System.Drawing.Color.Transparent;
            this.txtbienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbienvenido.Location = new System.Drawing.Point(338, 134);
            this.txtbienvenido.Name = "txtbienvenido";
            this.txtbienvenido.Size = new System.Drawing.Size(398, 76);
            this.txtbienvenido.TabIndex = 7;
            this.txtbienvenido.Text = "Bienvenido !";
            this.txtbienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbienvenido2
            // 
            this.txtbienvenido2.AutoSize = true;
            this.txtbienvenido2.BackColor = System.Drawing.Color.Transparent;
            this.txtbienvenido2.Location = new System.Drawing.Point(357, 218);
            this.txtbienvenido2.Name = "txtbienvenido2";
            this.txtbienvenido2.Size = new System.Drawing.Size(343, 24);
            this.txtbienvenido2.TabIndex = 8;
            this.txtbienvenido2.Text = "Selecciona una seccion para comenzar";
            this.txtbienvenido2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Actualizar
            // 
            this.Actualizar.BackColor = System.Drawing.Color.LightGray;
            this.Actualizar.FlatAppearance.BorderSize = 0;
            this.Actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizar.ForeColor = System.Drawing.Color.Black;
            this.Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("Actualizar.Image")));
            this.Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Actualizar.Location = new System.Drawing.Point(15, 324);
            this.Actualizar.Margin = new System.Windows.Forms.Padding(6);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(178, 39);
            this.Actualizar.TabIndex = 10;
            this.Actualizar.Text = "Actualizar BD";
            this.Actualizar.UseVisualStyleBackColor = false;
            this.Actualizar.Visible = false;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Mantenimientobtn
            // 
            this.Mantenimientobtn.BackColor = System.Drawing.Color.LightGray;
            this.Mantenimientobtn.FlatAppearance.BorderSize = 0;
            this.Mantenimientobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Mantenimientobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mantenimientobtn.ForeColor = System.Drawing.Color.Black;
            this.Mantenimientobtn.Image = ((System.Drawing.Image)(resources.GetObject("Mantenimientobtn.Image")));
            this.Mantenimientobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mantenimientobtn.Location = new System.Drawing.Point(15, 200);
            this.Mantenimientobtn.Margin = new System.Windows.Forms.Padding(6);
            this.Mantenimientobtn.Name = "Mantenimientobtn";
            this.Mantenimientobtn.Size = new System.Drawing.Size(178, 42);
            this.Mantenimientobtn.TabIndex = 12;
            this.Mantenimientobtn.Text = "  Mantenimiento";
            this.Mantenimientobtn.UseVisualStyleBackColor = false;
            this.Mantenimientobtn.Click += new System.EventHandler(this.Usuariosbtn_Click);
            // 
            // UserLoggedtxt
            // 
            this.UserLoggedtxt.AutoSize = true;
            this.UserLoggedtxt.BackColor = System.Drawing.Color.Transparent;
            this.UserLoggedtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLoggedtxt.Location = new System.Drawing.Point(12, 30);
            this.UserLoggedtxt.Name = "UserLoggedtxt";
            this.UserLoggedtxt.Size = new System.Drawing.Size(69, 20);
            this.UserLoggedtxt.TabIndex = 13;
            this.UserLoggedtxt.Text = "nombre";
            // 
            // Cerrarsesion
            // 
            this.Cerrarsesion.BackColor = System.Drawing.Color.LightGray;
            this.Cerrarsesion.FlatAppearance.BorderSize = 0;
            this.Cerrarsesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Cerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrarsesion.ForeColor = System.Drawing.Color.Black;
            this.Cerrarsesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cerrarsesion.Location = new System.Drawing.Point(15, 507);
            this.Cerrarsesion.Margin = new System.Windows.Forms.Padding(6);
            this.Cerrarsesion.Name = "Cerrarsesion";
            this.Cerrarsesion.Size = new System.Drawing.Size(178, 42);
            this.Cerrarsesion.TabIndex = 15;
            this.Cerrarsesion.Text = "Cerrar Sesion";
            this.Cerrarsesion.UseVisualStyleBackColor = false;
            this.Cerrarsesion.Click += new System.EventHandler(this.Cerrarsesion_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.LightGray;
            this.Guardar.FlatAppearance.BorderSize = 0;
            this.Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.ForeColor = System.Drawing.Color.Black;
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.Location = new System.Drawing.Point(15, 261);
            this.Guardar.Margin = new System.Windows.Forms.Padding(6);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(178, 42);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "    Guardar Listado";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Usuario:";
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // documentosTableAdapter
            // 
            this.documentosTableAdapter.ClearBeforeFill = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1159, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Cerrarsesion);
            this.Controls.Add(this.UserLoggedtxt);
            this.Controls.Add(this.PanelEmpleados);
            this.Controls.Add(this.panelDocumentos);
            this.Controls.Add(this.Mantenimientobtn);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Empleadosbtn);
            this.Controls.Add(this.Documentosbtn);
            this.Controls.Add(this.txtbienvenido);
            this.Controls.Add(this.txtbienvenido2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Activated += new System.EventHandler(this.Menu_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDocumentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasDataSet)).EndInit();
            this.PanelEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Documentosbtn;
        private System.Windows.Forms.Button Empleadosbtn;
        private System.Windows.Forms.Panel panelDocumentos;
        private System.Windows.Forms.Button EliminarDbtn;
        private System.Windows.Forms.Button ModificarDbtn;
        private System.Windows.Forms.Button AñadirD;
        private System.Windows.Forms.Panel PanelEmpleados;
        private System.Windows.Forms.Button EliminarE;
        private System.Windows.Forms.Button ModificarE;
        private System.Windows.Forms.Button AñadirE;
        private System.Windows.Forms.Label txtbienvenido;
        private System.Windows.Forms.Label txtbienvenido2;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Mantenimientobtn;
        private System.Windows.Forms.Label UserLoggedtxt;
        private System.Windows.Forms.Button Cerrarsesion;
        private System.Windows.Forms.Button Guardar;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn1;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDocDataGridViewTextBoxColumn;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.DataGridView DatosD;
        public System.Windows.Forms.DataGridView DatosE;
        private System.Windows.Forms.Label label1;
        private PracticasDataSet practicasDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private PracticasDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.BindingSource documentosBindingSource;
        private PracticasDataSetTableAdapters.documentosTableAdapter documentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

