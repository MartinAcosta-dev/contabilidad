namespace Sistema
{
    partial class PlanCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanCuentas));
            this.Empleadosbtn = new System.Windows.Forms.Button();
            this.CancelarEAñadir = new System.Windows.Forms.Button();
            this.AñadirEConfirm = new System.Windows.Forms.Button();
            this.documentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicasDataSet = new Sistema.PracticasDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentosTableAdapter = new Sistema.PracticasDataSetTableAdapters.documentosTableAdapter();
            this.empleadosTableAdapter = new Sistema.PracticasDataSetTableAdapters.EmpleadosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textCod = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Empleadosbtn
            // 
            this.Empleadosbtn.BackColor = System.Drawing.Color.Transparent;
            this.Empleadosbtn.FlatAppearance.BorderSize = 0;
            this.Empleadosbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Empleadosbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Empleadosbtn.ForeColor = System.Drawing.Color.Black;
//            this.Empleadosbtn.Image = global::Sistema.Properties.Resources.iconmonstr_user_29_32;
            this.Empleadosbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Empleadosbtn.Location = new System.Drawing.Point(779, 8);
            this.Empleadosbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Empleadosbtn.Name = "Empleadosbtn";
            this.Empleadosbtn.Size = new System.Drawing.Size(230, 42);
            this.Empleadosbtn.TabIndex = 1;
            this.Empleadosbtn.Text = "Plan de Cuentas";
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
            this.CancelarEAñadir.Location = new System.Drawing.Point(877, 430);
            this.CancelarEAñadir.Margin = new System.Windows.Forms.Padding(6);
            this.CancelarEAñadir.Name = "CancelarEAñadir";
            this.CancelarEAñadir.Size = new System.Drawing.Size(132, 39);
            this.CancelarEAñadir.TabIndex = 5;
            this.CancelarEAñadir.Text = "  Cancelar";
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
            this.AñadirEConfirm.Location = new System.Drawing.Point(12, 258);
            this.AñadirEConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.AñadirEConfirm.Name = "AñadirEConfirm";
            this.AñadirEConfirm.Size = new System.Drawing.Size(224, 42);
            this.AñadirEConfirm.TabIndex = 3;
            this.AñadirEConfirm.Text = "Añadir";
            this.AñadirEConfirm.UseVisualStyleBackColor = false;
            this.AñadirEConfirm.Click += new System.EventHandler(this.AñadirEConfirm_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 59);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(757, 347);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.practicasDataSet;
            // 
            // documentosTableAdapter
            // 
            this.documentosTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 312);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 367);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 39);
            this.button2.TabIndex = 17;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textCod
            // 
            this.textCod.Location = new System.Drawing.Point(12, 92);
            this.textCod.Name = "textCod";
            this.textCod.Size = new System.Drawing.Size(221, 29);
            this.textCod.TabIndex = 20;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(12, 151);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(221, 29);
            this.textNombre.TabIndex = 21;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Titulo",
            "Cuenta"});
            this.comboTipo.Location = new System.Drawing.Point(12, 217);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(221, 32);
            this.comboTipo.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Código de ordenamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(8, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tipo";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(681, 430);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 39);
            this.button3.TabIndex = 18;
            this.button3.Text = "Reporte PDF";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PlanCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1021, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textCod);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CancelarEAñadir);
            this.Controls.Add(this.AñadirEConfirm);
            this.Controls.Add(this.Empleadosbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PlanCuentas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PlanCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Empleadosbtn;

        private System.Windows.Forms.Button CancelarEAñadir;
        private System.Windows.Forms.Button AñadirEConfirm;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        private PracticasDataSet practicasDataSet;
        private System.Windows.Forms.BindingSource documentosBindingSource;
        private PracticasDataSetTableAdapters.documentosTableAdapter documentosTableAdapter;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private PracticasDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textCod;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}

