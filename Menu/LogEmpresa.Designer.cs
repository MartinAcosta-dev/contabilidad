namespace Sistema
{
    partial class LogEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogEmpresa));
            this.Empresatxt = new System.Windows.Forms.Button();
            this.Btnlogin = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRUDDataSet = new Sistema.CRUDDataSet();
            this.empresasTableAdapter = new Sistema.CRUDDataSetTableAdapters.EmpresasTableAdapter();
            this.configEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirEmpresaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEmpresaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboEmpresas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.configEmpresasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configEmpresasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Empresatxt
            // 
            this.Empresatxt.BackColor = System.Drawing.Color.Transparent;
            this.Empresatxt.FlatAppearance.BorderSize = 0;
            this.Empresatxt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Empresatxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Empresatxt.ForeColor = System.Drawing.Color.Black;
            this.Empresatxt.Image = ((System.Drawing.Image)(resources.GetObject("Empresatxt.Image")));
            this.Empresatxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Empresatxt.Location = new System.Drawing.Point(139, 74);
            this.Empresatxt.Margin = new System.Windows.Forms.Padding(6);
            this.Empresatxt.Name = "Empresatxt";
            this.Empresatxt.Size = new System.Drawing.Size(344, 42);
            this.Empresatxt.TabIndex = 1;
            this.Empresatxt.Text = "Empresa";
            this.Empresatxt.UseVisualStyleBackColor = false;
            // 
            // Btnlogin
            // 
            this.Btnlogin.BackColor = System.Drawing.Color.LightGray;
            this.Btnlogin.FlatAppearance.BorderSize = 0;
            this.Btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnlogin.ForeColor = System.Drawing.Color.Black;
            this.Btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("Btnlogin.Image")));
            this.Btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnlogin.Location = new System.Drawing.Point(139, 258);
            this.Btnlogin.Margin = new System.Windows.Forms.Padding(6);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(138, 42);
            this.Btnlogin.TabIndex = 11;
            this.Btnlogin.Text = "Ingresar";
            this.Btnlogin.UseVisualStyleBackColor = false;
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.BackColor = System.Drawing.Color.LightGray;
            this.Btnsalir.FlatAppearance.BorderSize = 0;
            this.Btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnsalir.ForeColor = System.Drawing.Color.Black;
            this.Btnsalir.Image = global::Sistema.Properties.Resources.icons8_logout_241;
            this.Btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnsalir.Location = new System.Drawing.Point(361, 258);
            this.Btnsalir.Margin = new System.Windows.Forms.Padding(6);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(138, 42);
            this.Btnsalir.TabIndex = 12;
            this.Btnsalir.Text = "Cerrar";
            this.Btnsalir.UseVisualStyleBackColor = false;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.cRUDDataSet;
            // 
            // cRUDDataSet
            // 
            this.cRUDDataSet.DataSetName = "CRUDDataSet";
            this.cRUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // configEmpresasToolStripMenuItem
            // 
            this.configEmpresasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirEmpresaToolStripMenuItem1,
            this.eliminarEmpresaToolStripMenuItem1});
            this.configEmpresasToolStripMenuItem.Name = "configEmpresasToolStripMenuItem";
            this.configEmpresasToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.configEmpresasToolStripMenuItem.Text = "Config Empresas";
            // 
            // añadirEmpresaToolStripMenuItem1
            // 
            this.añadirEmpresaToolStripMenuItem1.Name = "añadirEmpresaToolStripMenuItem1";
            this.añadirEmpresaToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.añadirEmpresaToolStripMenuItem1.Text = "Añadir Empresa";
            this.añadirEmpresaToolStripMenuItem1.Click += new System.EventHandler(this.añadirEmpresaToolStripMenuItem1_Click);
            // 
            // eliminarEmpresaToolStripMenuItem1
            // 
            this.eliminarEmpresaToolStripMenuItem1.Name = "eliminarEmpresaToolStripMenuItem1";
            this.eliminarEmpresaToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.eliminarEmpresaToolStripMenuItem1.Text = "Eliminar Empresa";
            this.eliminarEmpresaToolStripMenuItem1.Click += new System.EventHandler(this.eliminarEmpresaToolStripMenuItem1_Click);
            // 
            // ComboEmpresas
            // 
            this.ComboEmpresas.AllowDrop = true;
            this.ComboEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboEmpresas.FormattingEnabled = true;
            this.ComboEmpresas.Location = new System.Drawing.Point(139, 155);
            this.ComboEmpresas.Name = "ComboEmpresas";
            this.ComboEmpresas.Size = new System.Drawing.Size(344, 32);
            this.ComboEmpresas.TabIndex = 13;
            this.ComboEmpresas.SelectedIndexChanged += new System.EventHandler(this.ComboEmpresas_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = global::Sistema.Properties.Resources.output_onlinepngtools;
            this.button1.Location = new System.Drawing.Point(497, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // configEmpresasToolStripMenuItem1
            // 
            this.configEmpresasToolStripMenuItem1.Name = "configEmpresasToolStripMenuItem1";
            this.configEmpresasToolStripMenuItem1.Size = new System.Drawing.Size(108, 20);
            this.configEmpresasToolStripMenuItem1.Text = "Config Empresas";
            this.configEmpresasToolStripMenuItem1.Click += new System.EventHandler(this.configEmpresasToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configEmpresasToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configEmpresasToolStripMenuItem2
            // 
            this.configEmpresasToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirEmpresaToolStripMenuItem,
            this.eliminarEmpresaToolStripMenuItem});
            this.configEmpresasToolStripMenuItem2.Name = "configEmpresasToolStripMenuItem2";
            this.configEmpresasToolStripMenuItem2.Size = new System.Drawing.Size(108, 20);
            this.configEmpresasToolStripMenuItem2.Text = "Config empresas";
            // 
            // añadirEmpresaToolStripMenuItem
            // 
            this.añadirEmpresaToolStripMenuItem.Name = "añadirEmpresaToolStripMenuItem";
            this.añadirEmpresaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.añadirEmpresaToolStripMenuItem.Text = "Añadir empresa";
            this.añadirEmpresaToolStripMenuItem.Click += new System.EventHandler(this.añadirEmpresaToolStripMenuItem_Click_2);
            // 
            // eliminarEmpresaToolStripMenuItem
            // 
            this.eliminarEmpresaToolStripMenuItem.Name = "eliminarEmpresaToolStripMenuItem";
            this.eliminarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.eliminarEmpresaToolStripMenuItem.Text = "Eliminar empresa";
            // 
            // LogEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(649, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComboEmpresas);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btnlogin);
            this.Controls.Add(this.Empresatxt);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LogEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Empresatxt;
        private System.Windows.Forms.Button Btnlogin;
        private System.Windows.Forms.Button Btnsalir;
        private CRUDDataSet cRUDDataSet;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private CRUDDataSetTableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem configEmpresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirEmpresaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarEmpresaToolStripMenuItem1;
        private System.Windows.Forms.ComboBox ComboEmpresas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem configEmpresasToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configEmpresasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem añadirEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEmpresaToolStripMenuItem;
    }
}

