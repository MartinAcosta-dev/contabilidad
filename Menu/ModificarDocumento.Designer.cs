namespace Sistema
{
    partial class ModificarDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarDocumento));
            this.Empleadosbtn = new System.Windows.Forms.Button();
            this.CancelarEModificar = new System.Windows.Forms.Button();
            this.ModificarDConfirm = new System.Windows.Forms.Button();
            this.DescripcionDbuscar = new System.Windows.Forms.TextBox();
            this.LongitudDbuscar = new System.Windows.Forms.TextBox();
            this.dataModificar = new System.Windows.Forms.DataGridView();
            this.TipoBuscarD = new System.Windows.Forms.TextBox();
            this.BuscarIdE = new System.Windows.Forms.Button();
            this.practicasDataSet = new Sistema.PracticasDataSet();
            this.documentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentosTableAdapter = new Sistema.PracticasDataSetTableAdapters.documentosTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasDataSet)).BeginInit();
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
            this.Empleadosbtn.Location = new System.Drawing.Point(650, 7);
            this.Empleadosbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Empleadosbtn.Name = "Empleadosbtn";
            this.Empleadosbtn.Size = new System.Drawing.Size(344, 42);
            this.Empleadosbtn.TabIndex = 1;
            this.Empleadosbtn.Text = "Documentos";
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
            this.CancelarEModificar.Location = new System.Drawing.Point(856, 259);
            this.CancelarEModificar.Margin = new System.Windows.Forms.Padding(6);
            this.CancelarEModificar.Name = "CancelarEModificar";
            this.CancelarEModificar.Size = new System.Drawing.Size(138, 42);
            this.CancelarEModificar.TabIndex = 5;
            this.CancelarEModificar.Text = "Cancelar";
            this.CancelarEModificar.UseVisualStyleBackColor = false;
            this.CancelarEModificar.Click += new System.EventHandler(this.CancelarEAñadir_Click);
            // 
            // ModificarDConfirm
            // 
            this.ModificarDConfirm.BackColor = System.Drawing.Color.MintCream;
            this.ModificarDConfirm.FlatAppearance.BorderSize = 0;
            this.ModificarDConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.ModificarDConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarDConfirm.ForeColor = System.Drawing.Color.Black;
            this.ModificarDConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ModificarDConfirm.Image")));
            this.ModificarDConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarDConfirm.Location = new System.Drawing.Point(650, 259);
            this.ModificarDConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.ModificarDConfirm.Name = "ModificarDConfirm";
            this.ModificarDConfirm.Size = new System.Drawing.Size(138, 42);
            this.ModificarDConfirm.TabIndex = 3;
            this.ModificarDConfirm.Text = "Modificar";
            this.ModificarDConfirm.UseVisualStyleBackColor = false;
            this.ModificarDConfirm.Visible = false;
            this.ModificarDConfirm.Click += new System.EventHandler(this.ModificarEConfirm_Click);
            // 
            // DescripcionDbuscar
            // 
            this.DescripcionDbuscar.Location = new System.Drawing.Point(650, 134);
            this.DescripcionDbuscar.Name = "DescripcionDbuscar";
            this.DescripcionDbuscar.Size = new System.Drawing.Size(344, 34);
            this.DescripcionDbuscar.TabIndex = 8;
            this.DescripcionDbuscar.Text = "Nombre";
            this.DescripcionDbuscar.Visible = false;
            // 
            // LongitudDbuscar
            // 
            this.LongitudDbuscar.Location = new System.Drawing.Point(650, 196);
            this.LongitudDbuscar.Name = "LongitudDbuscar";
            this.LongitudDbuscar.Size = new System.Drawing.Size(344, 34);
            this.LongitudDbuscar.TabIndex = 9;
            this.LongitudDbuscar.Text = "Apellido";
            this.LongitudDbuscar.Visible = false;
            // 
            // dataModificar
            // 
            this.dataModificar.AllowUserToAddRows = false;
            this.dataModificar.AllowUserToDeleteRows = false;
            this.dataModificar.AutoGenerateColumns = false;
            this.dataModificar.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataModificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataModificar.DataSource = this.documentosBindingSource;
            this.dataModificar.Location = new System.Drawing.Point(104, 69);
            this.dataModificar.Name = "dataModificar";
            this.dataModificar.ReadOnly = true;
            this.dataModificar.RowHeadersWidth = 51;
            this.dataModificar.Size = new System.Drawing.Size(344, 388);
            this.dataModificar.TabIndex = 11;
            // 
            // TipoBuscarD
            // 
            this.TipoBuscarD.Location = new System.Drawing.Point(650, 75);
            this.TipoBuscarD.Name = "TipoBuscarD";
            this.TipoBuscarD.Size = new System.Drawing.Size(162, 34);
            this.TipoBuscarD.TabIndex = 12;
            this.TipoBuscarD.Text = "Tipo";
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
            this.BuscarIdE.Location = new System.Drawing.Point(856, 69);
            this.BuscarIdE.Margin = new System.Windows.Forms.Padding(6);
            this.BuscarIdE.Name = "BuscarIdE";
            this.BuscarIdE.Size = new System.Drawing.Size(138, 42);
            this.BuscarIdE.TabIndex = 13;
            this.BuscarIdE.Text = "Buscar";
            this.BuscarIdE.UseVisualStyleBackColor = false;
            this.BuscarIdE.Click += new System.EventHandler(this.BuscarIdE_Click);
            // 
            // practicasDataSet
            // 
            this.practicasDataSet.DataSetName = "PracticasDataSet";
            this.practicasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Longitud";
            this.dataGridViewTextBoxColumn6.HeaderText = "Longitud";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // ModificarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1021, 469);
            this.Controls.Add(this.BuscarIdE);
            this.Controls.Add(this.TipoBuscarD);
            this.Controls.Add(this.dataModificar);
            this.Controls.Add(this.LongitudDbuscar);
            this.Controls.Add(this.DescripcionDbuscar);
            this.Controls.Add(this.CancelarEModificar);
            this.Controls.Add(this.ModificarDConfirm);
            this.Controls.Add(this.Empleadosbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ModificarDocumento";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Empleadosbtn;
       // private CRUDDataSetTableAdapters.DocumentosTableAdapter documentosTableAdapter;
        private System.Windows.Forms.Button CancelarEModificar;
        private System.Windows.Forms.Button ModificarDConfirm;
        public System.Windows.Forms.TextBox DescripcionDbuscar;
        public System.Windows.Forms.TextBox LongitudDbuscar;
        private System.Windows.Forms.DataGridView dataModificar;
        public System.Windows.Forms.TextBox TipoBuscarD;
        private System.Windows.Forms.Button BuscarIdE;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private PracticasDataSet practicasDataSet;
        private System.Windows.Forms.BindingSource documentosBindingSource;
        private PracticasDataSetTableAdapters.documentosTableAdapter documentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

