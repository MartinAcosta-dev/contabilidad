namespace Sistema
{
    partial class ModificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarUsuario));
            this.Empleadosbtn = new System.Windows.Forms.Button();
            this.CancelarEModificar = new System.Windows.Forms.Button();
            this.ModificarDConfirm = new System.Windows.Forms.Button();
            this.usuariotxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.dataModificar = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicasDataSet = new Sistema.PracticasDataSet();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.BuscarIdE = new System.Windows.Forms.Button();
            this.apellidotxt = new System.Windows.Forms.TextBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.tipousertxt = new System.Windows.Forms.ComboBox();
            this.usuariosTableAdapter = new Sistema.PracticasDataSetTableAdapters.usuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
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
            this.Empleadosbtn.Image = global::Sistema.Properties.Resources.iconmonstr_user_29_32;
            this.Empleadosbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Empleadosbtn.Location = new System.Drawing.Point(650, 7);
            this.Empleadosbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Empleadosbtn.Name = "Empleadosbtn";
            this.Empleadosbtn.Size = new System.Drawing.Size(344, 42);
            this.Empleadosbtn.TabIndex = 1;
            this.Empleadosbtn.Text = "Usuarios";
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
            this.CancelarEModificar.Location = new System.Drawing.Point(856, 415);
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
            this.ModificarDConfirm.Location = new System.Drawing.Point(650, 415);
            this.ModificarDConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.ModificarDConfirm.Name = "ModificarDConfirm";
            this.ModificarDConfirm.Size = new System.Drawing.Size(138, 42);
            this.ModificarDConfirm.TabIndex = 3;
            this.ModificarDConfirm.Text = "Modificar";
            this.ModificarDConfirm.UseVisualStyleBackColor = false;
            this.ModificarDConfirm.Visible = false;
            this.ModificarDConfirm.Click += new System.EventHandler(this.ModificarEConfirm_Click);
            // 
            // usuariotxt
            // 
            this.usuariotxt.Location = new System.Drawing.Point(650, 134);
            this.usuariotxt.Name = "usuariotxt";
            this.usuariotxt.Size = new System.Drawing.Size(344, 34);
            this.usuariotxt.TabIndex = 8;
            this.usuariotxt.Text = "Usuario";
            this.usuariotxt.Visible = false;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(650, 182);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(344, 34);
            this.passtxt.TabIndex = 9;
            this.passtxt.Text = "Contraseña";
            this.passtxt.Visible = false;
            // 
            // dataModificar
            // 
            this.dataModificar.AllowUserToAddRows = false;
            this.dataModificar.AllowUserToDeleteRows = false;
            this.dataModificar.AutoGenerateColumns = false;
            this.dataModificar.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataModificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataModificar.DataSource = this.usuariosBindingSource;
            this.dataModificar.Location = new System.Drawing.Point(-1, 69);
            this.dataModificar.Name = "dataModificar";
            this.dataModificar.ReadOnly = true;
            this.dataModificar.RowHeadersWidth = 51;
            this.dataModificar.Size = new System.Drawing.Size(632, 388);
            this.dataModificar.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn2.HeaderText = "username";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn3.HeaderText = "password";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "apellido";
            this.dataGridViewTextBoxColumn5.HeaderText = "apellido";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tipouser";
            this.dataGridViewTextBoxColumn6.HeaderText = "tipouser";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.practicasDataSet;
            // 
            // practicasDataSet
            // 
            this.practicasDataSet.DataSetName = "PracticasDataSet";
            this.practicasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(650, 75);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(162, 34);
            this.idtxt.TabIndex = 12;
            this.idtxt.Text = "ID";
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
            // apellidotxt
            // 
            this.apellidotxt.Location = new System.Drawing.Point(650, 282);
            this.apellidotxt.Name = "apellidotxt";
            this.apellidotxt.Size = new System.Drawing.Size(344, 34);
            this.apellidotxt.TabIndex = 16;
            this.apellidotxt.Text = "Apellido";
            this.apellidotxt.Visible = false;
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(650, 232);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(344, 34);
            this.nombretxt.TabIndex = 15;
            this.nombretxt.Text = "Nombre";
            this.nombretxt.Visible = false;
            // 
            // tipousertxt
            // 
            this.tipousertxt.Enabled = false;
            this.tipousertxt.FormattingEnabled = true;
            this.tipousertxt.Items.AddRange(new object[] {
            "AUDITOR",
            "SUPERVISOR",
            "OPERARIO"});
            this.tipousertxt.Location = new System.Drawing.Point(650, 339);
            this.tipousertxt.Name = "tipousertxt";
            this.tipousertxt.Size = new System.Drawing.Size(344, 37);
            this.tipousertxt.TabIndex = 17;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1021, 469);
            this.Controls.Add(this.tipousertxt);
            this.Controls.Add(this.apellidotxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.BuscarIdE);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.dataModificar);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usuariotxt);
            this.Controls.Add(this.CancelarEModificar);
            this.Controls.Add(this.ModificarDConfirm);
            this.Controls.Add(this.Empleadosbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ModificarUsuario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Empleadosbtn;
        // private CRUDDataSetTableAdapters.DocumentosTableAdapter documentosTableAdapter;
        private System.Windows.Forms.Button CancelarEModificar;
        private System.Windows.Forms.Button ModificarDConfirm;
        public System.Windows.Forms.TextBox usuariotxt;
        public System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.DataGridView dataModificar;
        public System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Button BuscarIdE;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox apellidotxt;
        public System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.ComboBox tipousertxt;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipouserDataGridViewTextBoxColumn;
        private PracticasDataSet practicasDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private PracticasDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

