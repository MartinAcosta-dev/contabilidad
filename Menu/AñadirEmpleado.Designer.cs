namespace Sistema
{
    partial class AñadirEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirEmpleado));
            this.Empleadosbtn = new System.Windows.Forms.Button();
            this.CancelarEAñadir = new System.Windows.Forms.Button();
            this.AñadirEConfirm = new System.Windows.Forms.Button();
            this.comboDocumentos = new System.Windows.Forms.ComboBox();
            this.documentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicasDataSet = new Sistema.PracticasDataSet();
            this.nombreE = new System.Windows.Forms.TextBox();
            this.apellidoE = new System.Windows.Forms.TextBox();
            this.numeroE = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TablaDocumentos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.documentosTableAdapter = new Sistema.PracticasDataSetTableAdapters.documentosTableAdapter();
            this.empleadosTableAdapter = new Sistema.PracticasDataSetTableAdapters.EmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDocumentos)).BeginInit();
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
            this.Empleadosbtn.Location = new System.Drawing.Point(628, 44);
            this.Empleadosbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Empleadosbtn.Name = "Empleadosbtn";
            this.Empleadosbtn.Size = new System.Drawing.Size(344, 42);
            this.Empleadosbtn.TabIndex = 1;
            this.Empleadosbtn.Text = "Empleados";
            this.Empleadosbtn.UseVisualStyleBackColor = false;
            // 
            // CancelarEAñadir
            // 
            this.CancelarEAñadir.BackColor = System.Drawing.Color.LightGray;
            this.CancelarEAñadir.FlatAppearance.BorderSize = 0;
            this.CancelarEAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.CancelarEAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarEAñadir.ForeColor = System.Drawing.Color.Black;
            this.CancelarEAñadir.Image = ((System.Drawing.Image)(resources.GetObject("CancelarEAñadir.Image")));
            this.CancelarEAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarEAñadir.Location = new System.Drawing.Point(834, 390);
            this.CancelarEAñadir.Margin = new System.Windows.Forms.Padding(6);
            this.CancelarEAñadir.Name = "CancelarEAñadir";
            this.CancelarEAñadir.Size = new System.Drawing.Size(138, 42);
            this.CancelarEAñadir.TabIndex = 5;
            this.CancelarEAñadir.Text = "Cancelar";
            this.CancelarEAñadir.UseVisualStyleBackColor = false;
            this.CancelarEAñadir.Click += new System.EventHandler(this.CancelarEAñadir_Click);
            // 
            // AñadirEConfirm
            // 
            this.AñadirEConfirm.BackColor = System.Drawing.Color.LightGray;
            this.AñadirEConfirm.FlatAppearance.BorderSize = 0;
            this.AñadirEConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.AñadirEConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AñadirEConfirm.ForeColor = System.Drawing.Color.Black;
            this.AñadirEConfirm.Image = ((System.Drawing.Image)(resources.GetObject("AñadirEConfirm.Image")));
            this.AñadirEConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AñadirEConfirm.Location = new System.Drawing.Point(628, 390);
            this.AñadirEConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.AñadirEConfirm.Name = "AñadirEConfirm";
            this.AñadirEConfirm.Size = new System.Drawing.Size(138, 42);
            this.AñadirEConfirm.TabIndex = 3;
            this.AñadirEConfirm.Text = "Añadir";
            this.AñadirEConfirm.UseVisualStyleBackColor = false;
            this.AñadirEConfirm.Click += new System.EventHandler(this.AñadirEConfirm_Click);
            // 
            // comboDocumentos
            // 
            this.comboDocumentos.DataSource = this.documentosBindingSource;
            this.comboDocumentos.DisplayMember = "Tipo";
            this.comboDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDocumentos.FormattingEnabled = true;
            this.comboDocumentos.Location = new System.Drawing.Point(628, 239);
            this.comboDocumentos.Name = "comboDocumentos";
            this.comboDocumentos.Size = new System.Drawing.Size(344, 32);
            this.comboDocumentos.TabIndex = 7;
            this.comboDocumentos.ValueMember = "Tipo";
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
            // nombreE
            // 
            this.nombreE.Location = new System.Drawing.Point(628, 112);
            this.nombreE.Name = "nombreE";
            this.nombreE.Size = new System.Drawing.Size(344, 29);
            this.nombreE.TabIndex = 8;
            this.nombreE.Text = "Nombre";
            // 
            // apellidoE
            // 
            this.apellidoE.Location = new System.Drawing.Point(628, 174);
            this.apellidoE.Name = "apellidoE";
            this.apellidoE.Size = new System.Drawing.Size(344, 29);
            this.apellidoE.TabIndex = 9;
            this.apellidoE.Text = "Apellido";
            // 
            // numeroE
            // 
            this.numeroE.Location = new System.Drawing.Point(628, 307);
            this.numeroE.Name = "numeroE";
            this.numeroE.Size = new System.Drawing.Size(344, 29);
            this.numeroE.TabIndex = 10;
            this.numeroE.Text = "Numero";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.empleadosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(544, 320);
            this.dataGridView1.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn6.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TipoDoc";
            this.dataGridViewTextBoxColumn7.HeaderText = "TipoDoc";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NDoc";
            this.dataGridViewTextBoxColumn8.HeaderText = "NDoc";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.practicasDataSet;
            // 
            // TablaDocumentos
            // 
            this.TablaDocumentos.AllowUserToAddRows = false;
            this.TablaDocumentos.AllowUserToDeleteRows = false;
            this.TablaDocumentos.AutoGenerateColumns = false;
            this.TablaDocumentos.BackgroundColor = System.Drawing.Color.LightGray;
            this.TablaDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.TablaDocumentos.DataSource = this.documentosBindingSource;
            this.TablaDocumentos.Location = new System.Drawing.Point(124, 112);
            this.TablaDocumentos.Name = "TablaDocumentos";
            this.TablaDocumentos.ReadOnly = true;
            this.TablaDocumentos.RowHeadersWidth = 51;
            this.TablaDocumentos.Size = new System.Drawing.Size(344, 320);
            this.TablaDocumentos.TabIndex = 16;
            this.TablaDocumentos.Visible = false;
            this.TablaDocumentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Longitud";
            this.dataGridViewTextBoxColumn3.HeaderText = "Longitud";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            this.button1.Location = new System.Drawing.Point(149, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "F1 - Alternar Tabla";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // documentosTableAdapter
            // 
            this.documentosTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // AñadirEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1021, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TablaDocumentos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numeroE);
            this.Controls.Add(this.apellidoE);
            this.Controls.Add(this.nombreE);
            this.Controls.Add(this.comboDocumentos);
            this.Controls.Add(this.CancelarEAñadir);
            this.Controls.Add(this.AñadirEConfirm);
            this.Controls.Add(this.Empleadosbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AñadirEmpleado";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AñadirEmpleado_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Empleadosbtn;
       
        private System.Windows.Forms.Button CancelarEAñadir;
        private System.Windows.Forms.Button AñadirEConfirm;
        public System.Windows.Forms.ComboBox comboDocumentos;
        public System.Windows.Forms.TextBox nombreE;
        public System.Windows.Forms.TextBox apellidoE;
        public System.Windows.Forms.TextBox numeroE;
        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView TablaDocumentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private PracticasDataSet practicasDataSet;
        private System.Windows.Forms.BindingSource documentosBindingSource;
        private PracticasDataSetTableAdapters.documentosTableAdapter documentosTableAdapter;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private PracticasDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

