namespace Sistema
{
    partial class EliminarDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarDocumento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Empleadosbtn = new System.Windows.Forms.Button();
            this.CancelarDModificar = new System.Windows.Forms.Button();
            this.EliminarDconfirm = new System.Windows.Forms.Button();
            this.DescripcionDBuscar = new System.Windows.Forms.TextBox();
            this.LongitudDBuscar = new System.Windows.Forms.TextBox();
            this.dataModificar = new System.Windows.Forms.DataGridView();
            this.TipoDBuscar = new System.Windows.Forms.TextBox();
            this.BuscarTipoD = new System.Windows.Forms.Button();
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
            this.Empleadosbtn.Location = new System.Drawing.Point(662, 7);
            this.Empleadosbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Empleadosbtn.Name = "Empleadosbtn";
            this.Empleadosbtn.Size = new System.Drawing.Size(344, 42);
            this.Empleadosbtn.TabIndex = 1;
            this.Empleadosbtn.Text = "Documentos";
            this.Empleadosbtn.UseVisualStyleBackColor = false;
            // 
            // CancelarDModificar
            // 
            this.CancelarDModificar.BackColor = System.Drawing.Color.LightGray;
            this.CancelarDModificar.FlatAppearance.BorderSize = 0;
            this.CancelarDModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.CancelarDModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarDModificar.ForeColor = System.Drawing.Color.Black;
            this.CancelarDModificar.Image = ((System.Drawing.Image)(resources.GetObject("CancelarDModificar.Image")));
            this.CancelarDModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarDModificar.Location = new System.Drawing.Point(868, 263);
            this.CancelarDModificar.Margin = new System.Windows.Forms.Padding(6);
            this.CancelarDModificar.Name = "CancelarDModificar";
            this.CancelarDModificar.Size = new System.Drawing.Size(138, 42);
            this.CancelarDModificar.TabIndex = 5;
            this.CancelarDModificar.Text = "Cancelar";
            this.CancelarDModificar.UseVisualStyleBackColor = false;
            this.CancelarDModificar.Click += new System.EventHandler(this.CancelarEAñadir_Click);
            // 
            // EliminarDconfirm
            // 
            this.EliminarDconfirm.BackColor = System.Drawing.Color.LightGray;
            this.EliminarDconfirm.FlatAppearance.BorderSize = 0;
            this.EliminarDconfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.EliminarDconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarDconfirm.ForeColor = System.Drawing.Color.Black;
            this.EliminarDconfirm.Image = ((System.Drawing.Image)(resources.GetObject("EliminarDconfirm.Image")));
            this.EliminarDconfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarDconfirm.Location = new System.Drawing.Point(662, 263);
            this.EliminarDconfirm.Margin = new System.Windows.Forms.Padding(6);
            this.EliminarDconfirm.Name = "EliminarDconfirm";
            this.EliminarDconfirm.Size = new System.Drawing.Size(138, 42);
            this.EliminarDconfirm.TabIndex = 3;
            this.EliminarDconfirm.Text = "Eliminar";
            this.EliminarDconfirm.UseVisualStyleBackColor = false;
            this.EliminarDconfirm.Visible = false;
            this.EliminarDconfirm.Click += new System.EventHandler(this.EliminarEConfirm_Click);
            // 
            // DescripcionDBuscar
            // 
            this.DescripcionDBuscar.Enabled = false;
            this.DescripcionDBuscar.Location = new System.Drawing.Point(662, 134);
            this.DescripcionDBuscar.Name = "DescripcionDBuscar";
            this.DescripcionDBuscar.Size = new System.Drawing.Size(344, 34);
            this.DescripcionDBuscar.TabIndex = 8;
            this.DescripcionDBuscar.Text = "Descripcion";
            this.DescripcionDBuscar.Visible = false;
            // 
            // LongitudDBuscar
            // 
            this.LongitudDBuscar.Enabled = false;
            this.LongitudDBuscar.Location = new System.Drawing.Point(662, 196);
            this.LongitudDBuscar.Name = "LongitudDBuscar";
            this.LongitudDBuscar.Size = new System.Drawing.Size(344, 34);
            this.LongitudDBuscar.TabIndex = 9;
            this.LongitudDBuscar.Text = "Longitud";
            this.LongitudDBuscar.Visible = false;
            // 
            // dataModificar
            // 
            this.dataModificar.AllowUserToAddRows = false;
            this.dataModificar.AllowUserToDeleteRows = false;
            this.dataModificar.AllowUserToOrderColumns = true;
            this.dataModificar.AutoGenerateColumns = false;
            this.dataModificar.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataModificar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataModificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataModificar.DataSource = this.documentosBindingSource;
            this.dataModificar.Location = new System.Drawing.Point(106, 69);
            this.dataModificar.Name = "dataModificar";
            this.dataModificar.ReadOnly = true;
            this.dataModificar.RowHeadersWidth = 51;
            this.dataModificar.Size = new System.Drawing.Size(432, 400);
            this.dataModificar.TabIndex = 11;
            // 
            // TipoDBuscar
            // 
            this.TipoDBuscar.Location = new System.Drawing.Point(662, 75);
            this.TipoDBuscar.Name = "TipoDBuscar";
            this.TipoDBuscar.Size = new System.Drawing.Size(162, 34);
            this.TipoDBuscar.TabIndex = 12;
            this.TipoDBuscar.Text = "Tipo Documento";
            // 
            // BuscarTipoD
            // 
            this.BuscarTipoD.BackColor = System.Drawing.Color.LightGray;
            this.BuscarTipoD.FlatAppearance.BorderSize = 0;
            this.BuscarTipoD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.BuscarTipoD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarTipoD.ForeColor = System.Drawing.Color.Black;
            this.BuscarTipoD.Image = ((System.Drawing.Image)(resources.GetObject("BuscarTipoD.Image")));
            this.BuscarTipoD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarTipoD.Location = new System.Drawing.Point(868, 69);
            this.BuscarTipoD.Margin = new System.Windows.Forms.Padding(6);
            this.BuscarTipoD.Name = "BuscarTipoD";
            this.BuscarTipoD.Size = new System.Drawing.Size(138, 42);
            this.BuscarTipoD.TabIndex = 13;
            this.BuscarTipoD.Text = "Buscar";
            this.BuscarTipoD.UseVisualStyleBackColor = false;
            this.BuscarTipoD.Click += new System.EventHandler(this.BuscarIdE_Click);
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
            // EliminarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1021, 469);
            this.Controls.Add(this.BuscarTipoD);
            this.Controls.Add(this.TipoDBuscar);
            this.Controls.Add(this.dataModificar);
            this.Controls.Add(this.LongitudDBuscar);
            this.Controls.Add(this.DescripcionDBuscar);
            this.Controls.Add(this.CancelarDModificar);
            this.Controls.Add(this.EliminarDconfirm);
            this.Controls.Add(this.Empleadosbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EliminarDocumento";
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
        private System.Windows.Forms.Button CancelarDModificar;
        private System.Windows.Forms.Button EliminarDconfirm;
        public System.Windows.Forms.TextBox DescripcionDBuscar;
        public System.Windows.Forms.TextBox LongitudDBuscar;
        private System.Windows.Forms.DataGridView dataModificar;
        public System.Windows.Forms.TextBox TipoDBuscar;
        private System.Windows.Forms.Button BuscarTipoD;
       
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

