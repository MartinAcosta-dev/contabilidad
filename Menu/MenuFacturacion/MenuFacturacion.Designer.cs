namespace Sistema.Menu.MenuFacturacion
{
    partial class MenuFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaFamiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntosDeVentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeImpuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aBMToolStripMenuItem.Text = "Inicio";
            this.aBMToolStripMenuItem.Click += new System.EventHandler(this.aBMToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem1,
            this.puntosDeVentaToolStripMenuItem1,
            this.clientesToolStripMenuItem,
            this.localidadesToolStripMenuItem,
            this.tipoDeImpuestosToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(165, 20);
            this.salirToolStripMenuItem.Text = "Altas, Bajas, Modificaciones";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaFamiliaToolStripMenuItem,
            this.nuevoProductoToolStripMenuItem});
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem1.Text = "Productos";
            this.productosToolStripMenuItem1.Click += new System.EventHandler(this.productosToolStripMenuItem1_Click);
            // 
            // nuevaFamiliaToolStripMenuItem
            // 
            this.nuevaFamiliaToolStripMenuItem.Name = "nuevaFamiliaToolStripMenuItem";
            this.nuevaFamiliaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaFamiliaToolStripMenuItem.Text = "Nueva Familia...";
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo Producto...";
            this.nuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProductoToolStripMenuItem_Click);
            // 
            // puntosDeVentaToolStripMenuItem1
            // 
            this.puntosDeVentaToolStripMenuItem1.Name = "puntosDeVentaToolStripMenuItem1";
            this.puntosDeVentaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.puntosDeVentaToolStripMenuItem1.Text = "Puntos de venta";
            this.puntosDeVentaToolStripMenuItem1.Click += new System.EventHandler(this.puntosDeVentaToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            // 
            // tipoDeImpuestosToolStripMenuItem
            // 
            this.tipoDeImpuestosToolStripMenuItem.Name = "tipoDeImpuestosToolStripMenuItem";
            this.tipoDeImpuestosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoDeImpuestosToolStripMenuItem.Text = "Tipo de impuestos";
            this.tipoDeImpuestosToolStripMenuItem.Click += new System.EventHandler(this.tipoDeImpuestosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 406);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MenuFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(925, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Facturacion";
            this.Load += new System.EventHandler(this.MenuFacturacion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem puntosDeVentaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevaFamiliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeImpuestosToolStripMenuItem;
    }
}