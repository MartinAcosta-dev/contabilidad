namespace Sistema
{
    partial class ModificarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEmpleado));
            this.Empleadosbtn = new System.Windows.Forms.Button();
            this.CancelarEModificar = new System.Windows.Forms.Button();
            this.ModificarEConfirm = new System.Windows.Forms.Button();
            this.comboDocumentos = new System.Windows.Forms.ComboBox();
            this.nombreEbuscar = new System.Windows.Forms.TextBox();
            this.apellidoE = new System.Windows.Forms.TextBox();
            this.numeroE = new System.Windows.Forms.TextBox();
            this.dataModificar = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicasDataSet = new Sistema.PracticasDataSet();
            this.IDbuscarE = new System.Windows.Forms.TextBox();
            this.BuscarIdE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataDoc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentosTableAdapter = new Sistema.PracticasDataSetTableAdapters.documentosTableAdapter();
            this.empleadosTableAdapter = new Sistema.PracticasDataSetTableAdapters.EmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Empleadosbtn
            // 
            this.Empleadosbtn.BackColor = System.Drawing.Color.Transparent;
            this.Empleadosbtn.FlatAppearance.BorderSize = 0;
            this.Empleadosbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Empleadosbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Empleadosbtn.ForeColor = System.Drawing.Color.Black;
            this.Empleadosbtn.Image = ((System.Drawing.Image)(resources.GetObject("Empleadosbtn.Image")));
            this.Empleadosbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Empleadosbtn.Location = new System.Drawing.Point(662, 7);
            this.Empleadosbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Empleadosbtn.Name = "Empleadosbtn";
            this.Empleadosbtn.Size = new System.Drawing.Size(344, 42);
            this.Empleadosbtn.TabIndex = 1;
            this.Empleadosbtn.Text = "Empleados";
            this.Empleadosbtn.UseVisualStyleBackColor = false;
            // 
            // CancelarEModificar
            // 
            this.CancelarEModificar.BackColor = System.Drawing.Color.MintCream;
            this.CancelarEModificar.FlatAppearance.BorderSize = 0;
            this.CancelarEModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.CancelarEModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarEModificar.ForeColor = System.Drawing.Color.Black;
            this.CancelarEModificar.Image = ((System.Drawing.Image)(resources.GetObject("CancelarEModificar.Image")));
            this.CancelarEModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarEModificar.Location = new System.Drawing.Point(868, 412);
            this.CancelarEModificar.Margin = new System.Windows.Forms.Padding(6);
            this.CancelarEModificar.Name = "CancelarEModificar";
            this.CancelarEModificar.Size = new System.Drawing.Size(138, 42);
            this.CancelarEModificar.TabIndex = 5;
            this.CancelarEModificar.Text = "Cancelar";
            this.CancelarEModificar.UseVisualStyleBackColor = false;
            // 
            // ModificarEConfirm
            // 
            this.ModificarEConfirm.BackColor = System.Drawing.Color.MintCream;
            this.ModificarEConfirm.FlatAppearance.BorderSize = 0;
            this.ModificarEConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.ModificarEConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarEConfirm.ForeColor = System.Drawing.Color.Black;
            this.ModificarEConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ModificarEConfirm.Image")));
            this.ModificarEConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarEConfirm.Location = new System.Drawing.Point(662, 412);
            this.ModificarEConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.ModificarEConfirm.Name = "ModificarEConfirm";
            this.ModificarEConfirm.Size = new System.Drawing.Size(138, 42);
            this.ModificarEConfirm.TabIndex = 3;
            this.ModificarEConfirm.Text = "Modificar";
            this.ModificarEConfirm.UseVisualStyleBackColor = false;
            this.ModificarEConfirm.Click += new System.EventHandler(this.ModificarEConfirm_Click);
            // 
            // comboDocumentos
            // 
            this.comboDocumentos.DataSource = this.documentosBindingSource;
            this.comboDocumentos.DisplayMember = "Tipo";
            this.comboDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDocumentos.FormattingEnabled = true;
            this.comboDocumentos.Location = new System.Drawing.Point(662, 261);
            this.comboDocumentos.Name = "comboDocumentos";
            this.comboDocumentos.Size = new System.Drawing.Size(344, 37);
            this.comboDocumentos.TabIndex = 7;
            this.comboDocumentos.ValueMember = "Tipo (ID)";
            this.comboDocumentos.Visible = false;
            // 
            // nombreEbuscar
            // 
            this.nombreEbuscar.Location = new System.Drawing.Point(662, 134);
            this.nombreEbuscar.Name = "nombreEbuscar";
            this.nombreEbuscar.Size = new System.Drawing.Size(344, 34);
            this.nombreEbuscar.TabIndex = 8;
            this.nombreEbuscar.Text = "Nombre";
            this.nombreEbuscar.Visible = false;
            // 
            // apellidoE
            // 
            this.apellidoE.Location = new System.Drawing.Point(662, 196);
            this.apellidoE.Name = "apellidoE";
            this.apellidoE.Size = new System.Drawing.Size(344, 34);
            this.apellidoE.TabIndex = 9;
            this.apellidoE.Text = "Apellido";
            this.apellidoE.Visible = false;
            // 
            // numeroE
            // 
            this.numeroE.Location = new System.Drawing.Point(662, 329);
            this.numeroE.Name = "numeroE";
            this.numeroE.Size = new System.Drawing.Size(344, 34);
            this.numeroE.TabIndex = 10;
            this.numeroE.Text = "Numero";
            this.numeroE.Visible = false;
            // 
            // dataModificar
            // 
            this.dataModificar.AllowUserToAddRows = false;
            this.dataModificar.AllowUserToDeleteRows = false;
            this.dataModificar.AutoGenerateColumns = false;
            this.dataModificar.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataModificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dataModificar.DataSource = this.empleadosBindingSource;
            this.dataModificar.Location = new System.Drawing.Point(45, 69);
            this.dataModificar.Name = "dataModificar";
            this.dataModificar.ReadOnly = true;
            this.dataModificar.RowHeadersWidth = 51;
            this.dataModificar.Size = new System.Drawing.Size(543, 385);
            this.dataModificar.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn12.HeaderText = "ID";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn13.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn14.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "TipoDoc";
            this.dataGridViewTextBoxColumn15.HeaderText = "TipoDoc";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "NDoc";
            this.dataGridViewTextBoxColumn16.HeaderText = "NDoc";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.practicasDataSet;
            // 
            // practicasDataSet
            // 
            this.practicasDataSet.DataSetName = "PracticasDataSet";
            this.practicasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IDbuscarE
            // 
            this.IDbuscarE.Location = new System.Drawing.Point(662, 75);
            this.IDbuscarE.Name = "IDbuscarE";
            this.IDbuscarE.Size = new System.Drawing.Size(162, 34);
            this.IDbuscarE.TabIndex = 12;
            this.IDbuscarE.Text = "ID";
            // 
            // BuscarIdE
            // 
            this.BuscarIdE.BackColor = System.Drawing.Color.MintCream;
            this.BuscarIdE.FlatAppearance.BorderSize = 0;
            this.BuscarIdE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.BuscarIdE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarIdE.ForeColor = System.Drawing.Color.Black;
            this.BuscarIdE.Image = ((System.Drawing.Image)(resources.GetObject("BuscarIdE.Image")));
            this.BuscarIdE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarIdE.Location = new System.Drawing.Point(868, 69);
            this.BuscarIdE.Margin = new System.Windows.Forms.Padding(6);
            this.BuscarIdE.Name = "BuscarIdE";
            this.BuscarIdE.Size = new System.Drawing.Size(138, 42);
            this.BuscarIdE.TabIndex = 13;
            this.BuscarIdE.Text = "Buscar";
            this.BuscarIdE.UseVisualStyleBackColor = false;
            this.BuscarIdE.Click += new System.EventHandler(this.BuscarIdE_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(147, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "F1 - Alternar Tabla";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataDoc
            // 
            this.dataDoc.AllowUserToAddRows = false;
            this.dataDoc.AllowUserToDeleteRows = false;
            this.dataDoc.AutoGenerateColumns = false;
            this.dataDoc.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dataDoc.DataSource = this.documentosBindingSource;
            this.dataDoc.Location = new System.Drawing.Point(132, 69);
            this.dataDoc.Name = "dataDoc";
            this.dataDoc.ReadOnly = true;
            this.dataDoc.RowHeadersWidth = 51;
            this.dataDoc.Size = new System.Drawing.Size(345, 385);
            this.dataDoc.TabIndex = 15;
            this.dataDoc.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn10.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Longitud";
            this.dataGridViewTextBoxColumn11.HeaderText = "Longitud";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // documentosBindingSource
            // 
            this.documentosBindingSource.DataMember = "documentos";
            this.documentosBindingSource.DataSource = this.practicasDataSet;
            // 
            // documentosTableAdapter
            // 
            this.documentosTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // ModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1021, 469);
            this.Controls.Add(this.dataDoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BuscarIdE);
            this.Controls.Add(this.IDbuscarE);
            this.Controls.Add(this.dataModificar);
            this.Controls.Add(this.numeroE);
            this.Controls.Add(this.apellidoE);
            this.Controls.Add(this.nombreEbuscar);
            this.Controls.Add(this.comboDocumentos);
            this.Controls.Add(this.CancelarEModificar);
            this.Controls.Add(this.ModificarEConfirm);
            this.Controls.Add(this.Empleadosbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ModificarEmpleado";
            this.Text = "ModificarEmpleado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModificarEmpleado_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Empleadosbtn;
       // private CRUDDataSetTableAdapters.DocumentosTableAdapter documentosTableAdapter;
        private System.Windows.Forms.Button CancelarEModificar;
        private System.Windows.Forms.Button ModificarEConfirm;
        public System.Windows.Forms.ComboBox comboDocumentos;
        public System.Windows.Forms.TextBox nombreEbuscar;
        public System.Windows.Forms.TextBox apellidoE;
        public System.Windows.Forms.TextBox numeroE;
        private System.Windows.Forms.DataGridView dataModificar;
        public System.Windows.Forms.TextBox IDbuscarE;
        private System.Windows.Forms.Button BuscarIdE;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataDoc;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private PracticasDataSet practicasDataSet;
        private System.Windows.Forms.BindingSource documentosBindingSource;
        private PracticasDataSetTableAdapters.documentosTableAdapter documentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private PracticasDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}

