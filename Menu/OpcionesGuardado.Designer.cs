namespace Sistema
{
    partial class OpcionesGuardado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionesGuardado));
            this.titulotxt = new System.Windows.Forms.Button();
            this.Btnguardar = new System.Windows.Forms.Button();
            this.Btncancelar = new System.Windows.Forms.Button();
            this.opcionescombo = new System.Windows.Forms.ComboBox();
            this.listadode = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // titulotxt
            // 
            this.titulotxt.BackColor = System.Drawing.Color.Transparent;
            this.titulotxt.FlatAppearance.BorderSize = 0;
            this.titulotxt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.titulotxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titulotxt.ForeColor = System.Drawing.Color.Black;
            this.titulotxt.Image = ((System.Drawing.Image)(resources.GetObject("titulotxt.Image")));
            this.titulotxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titulotxt.Location = new System.Drawing.Point(13, 14);
            this.titulotxt.Margin = new System.Windows.Forms.Padding(6);
            this.titulotxt.Name = "titulotxt";
            this.titulotxt.Size = new System.Drawing.Size(344, 42);
            this.titulotxt.TabIndex = 1;
            this.titulotxt.Text = "Guardar";
            this.titulotxt.UseVisualStyleBackColor = false;
            // 
            // Btnguardar
            // 
            this.Btnguardar.BackColor = System.Drawing.Color.MintCream;
            this.Btnguardar.FlatAppearance.BorderSize = 0;
            this.Btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnguardar.ForeColor = System.Drawing.Color.Black;
            this.Btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("Btnguardar.Image")));
            this.Btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnguardar.Location = new System.Drawing.Point(64, 231);
            this.Btnguardar.Margin = new System.Windows.Forms.Padding(6);
            this.Btnguardar.Name = "Btnguardar";
            this.Btnguardar.Size = new System.Drawing.Size(238, 42);
            this.Btnguardar.TabIndex = 11;
            this.Btnguardar.Text = "Guardar";
            this.Btnguardar.UseVisualStyleBackColor = false;
            this.Btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // Btncancelar
            // 
            this.Btncancelar.BackColor = System.Drawing.Color.MintCream;
            this.Btncancelar.FlatAppearance.BorderSize = 0;
            this.Btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncancelar.ForeColor = System.Drawing.Color.Black;
            this.Btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btncancelar.Image")));
            this.Btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btncancelar.Location = new System.Drawing.Point(64, 285);
            this.Btncancelar.Margin = new System.Windows.Forms.Padding(6);
            this.Btncancelar.Name = "Btncancelar";
            this.Btncancelar.Size = new System.Drawing.Size(238, 42);
            this.Btncancelar.TabIndex = 12;
            this.Btncancelar.Text = "Cancelar";
            this.Btncancelar.UseVisualStyleBackColor = false;
            this.Btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // opcionescombo
            // 
            this.opcionescombo.FormattingEnabled = true;
            this.opcionescombo.Items.AddRange(new object[] {
            "PDF",
            "EXCEL",
            "IMPRESORA"});
            this.opcionescombo.Location = new System.Drawing.Point(64, 152);
            this.opcionescombo.Name = "opcionescombo";
            this.opcionescombo.Size = new System.Drawing.Size(238, 37);
            this.opcionescombo.TabIndex = 13;
            this.opcionescombo.Text = "Formato";
            // 
            // listadode
            // 
            this.listadode.FormattingEnabled = true;
            this.listadode.Items.AddRange(new object[] {
            "DOCUMENTOS",
            "EMPLEADOS",
            "USUARIOS"});
            this.listadode.Location = new System.Drawing.Point(64, 105);
            this.listadode.Name = "listadode";
            this.listadode.Size = new System.Drawing.Size(238, 37);
            this.listadode.TabIndex = 15;
            this.listadode.Text = "Listado";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // OpcionesGuardado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(373, 363);
            this.Controls.Add(this.listadode);
            this.Controls.Add(this.opcionescombo);
            this.Controls.Add(this.Btncancelar);
            this.Controls.Add(this.Btnguardar);
            this.Controls.Add(this.titulotxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "OpcionesGuardado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OpcionesGuardado_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button titulotxt;
        private System.Windows.Forms.Button Btnguardar;
        private System.Windows.Forms.Button Btncancelar;
        private System.Windows.Forms.ComboBox opcionescombo;
       
        private System.Windows.Forms.ComboBox listadode;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

