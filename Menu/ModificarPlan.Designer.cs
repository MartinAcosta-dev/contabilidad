namespace Sistema
{
    partial class ModificarPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPlan));
            this.Empleadosbtn = new System.Windows.Forms.Button();
            this.CancelarEModificar = new System.Windows.Forms.Button();
            this.ModificarDConfirm = new System.Windows.Forms.Button();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.dataModificar = new System.Windows.Forms.DataGridView();
            this.documentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicasDataSet = new Sistema.PracticasDataSet();
            this.Numerocuenta = new System.Windows.Forms.TextBox();
            this.BuscarIdE = new System.Windows.Forms.Button();
            this.documentosTableAdapter = new Sistema.PracticasDataSetTableAdapters.documentosTableAdapter();
            this.Tipotxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasDataSet)).BeginInit();
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
            this.CancelarEModificar.Location = new System.Drawing.Point(856, 412);
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
            this.ModificarDConfirm.Location = new System.Drawing.Point(650, 412);
            this.ModificarDConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.ModificarDConfirm.Name = "ModificarDConfirm";
            this.ModificarDConfirm.Size = new System.Drawing.Size(138, 42);
            this.ModificarDConfirm.TabIndex = 3;
            this.ModificarDConfirm.Text = "Modificar";
            this.ModificarDConfirm.UseVisualStyleBackColor = false;
            this.ModificarDConfirm.Visible = false;
            this.ModificarDConfirm.Click += new System.EventHandler(this.ModificarEConfirm_Click);
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(650, 195);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(344, 29);
            this.nombretxt.TabIndex = 8;
            this.nombretxt.Text = "Nombre";
            this.nombretxt.Visible = false;
            // 
            // codigotxt
            // 
            this.codigotxt.Location = new System.Drawing.Point(650, 139);
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(344, 29);
            this.codigotxt.TabIndex = 9;
            this.codigotxt.Text = "Codigo";
            this.codigotxt.Visible = false;
            // 
            // dataModificar
            // 
            this.dataModificar.AllowUserToAddRows = false;
            this.dataModificar.AllowUserToDeleteRows = false;
            this.dataModificar.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataModificar.Location = new System.Drawing.Point(104, 69);
            this.dataModificar.Name = "dataModificar";
            this.dataModificar.ReadOnly = true;
            this.dataModificar.RowHeadersWidth = 51;
            this.dataModificar.Size = new System.Drawing.Size(344, 388);
            this.dataModificar.TabIndex = 11;
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
            // Numerocuenta
            // 
            this.Numerocuenta.Location = new System.Drawing.Point(650, 75);
            this.Numerocuenta.Name = "Numerocuenta";
            this.Numerocuenta.Size = new System.Drawing.Size(162, 29);
            this.Numerocuenta.TabIndex = 12;
            this.Numerocuenta.Text = "Numero  Cuenta";
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
            // documentosTableAdapter
            // 
            this.documentosTableAdapter.ClearBeforeFill = true;
            // 
            // Tipotxt
            // 
            this.Tipotxt.Location = new System.Drawing.Point(650, 253);
            this.Tipotxt.Name = "Tipotxt";
            this.Tipotxt.Size = new System.Drawing.Size(344, 29);
            this.Tipotxt.TabIndex = 14;
            this.Tipotxt.Text = "Tipo";
            this.Tipotxt.Visible = false;
            // 
            // ModificarPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1021, 469);
            this.Controls.Add(this.Tipotxt);
            this.Controls.Add(this.BuscarIdE);
            this.Controls.Add(this.Numerocuenta);
            this.Controls.Add(this.dataModificar);
            this.Controls.Add(this.codigotxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.CancelarEModificar);
            this.Controls.Add(this.ModificarDConfirm);
            this.Controls.Add(this.Empleadosbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ModificarPlan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Empleadosbtn;
        // private CRUDDataSetTableAdapters.DocumentosTableAdapter documentosTableAdapter;
        private System.Windows.Forms.Button CancelarEModificar;
        private System.Windows.Forms.Button ModificarDConfirm;
        public System.Windows.Forms.TextBox nombretxt;
        public System.Windows.Forms.TextBox codigotxt;
        private System.Windows.Forms.DataGridView dataModificar;
        public System.Windows.Forms.TextBox Numerocuenta;
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
        public System.Windows.Forms.TextBox Tipotxt;
    }
}

