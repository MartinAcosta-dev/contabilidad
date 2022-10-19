namespace Sistema
{
    partial class AñadirDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirDocumento));
            this.Documentosbtn = new System.Windows.Forms.Button();
            this.CancelarEAñadir = new System.Windows.Forms.Button();
            this.AñadirEConfirm = new System.Windows.Forms.Button();
            this.TipoD = new System.Windows.Forms.TextBox();
            this.DescripcionD = new System.Windows.Forms.TextBox();
            this.LongitudD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Documentosbtn
            // 
            this.Documentosbtn.BackColor = System.Drawing.Color.Transparent;
            this.Documentosbtn.FlatAppearance.BorderSize = 0;
            this.Documentosbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Documentosbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Documentosbtn.ForeColor = System.Drawing.Color.Black;
            this.Documentosbtn.Image = ((System.Drawing.Image)(resources.GetObject("Documentosbtn.Image")));
            this.Documentosbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Documentosbtn.Location = new System.Drawing.Point(16, 28);
            this.Documentosbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Documentosbtn.Name = "Documentosbtn";
            this.Documentosbtn.Size = new System.Drawing.Size(344, 42);
            this.Documentosbtn.TabIndex = 1;
            this.Documentosbtn.Text = "Documentos";
            this.Documentosbtn.UseVisualStyleBackColor = false;
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
            this.CancelarEAñadir.Location = new System.Drawing.Point(222, 355);
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
            this.AñadirEConfirm.Location = new System.Drawing.Point(16, 355);
            this.AñadirEConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.AñadirEConfirm.Name = "AñadirEConfirm";
            this.AñadirEConfirm.Size = new System.Drawing.Size(138, 42);
            this.AñadirEConfirm.TabIndex = 3;
            this.AñadirEConfirm.Text = "Añadir";
            this.AñadirEConfirm.UseVisualStyleBackColor = false;
            this.AñadirEConfirm.Click += new System.EventHandler(this.AñadirEConfirm_Click);
            // 
            // TipoD
            // 
            this.TipoD.Location = new System.Drawing.Point(16, 96);
            this.TipoD.Name = "TipoD";
            this.TipoD.Size = new System.Drawing.Size(344, 29);
            this.TipoD.TabIndex = 8;
            this.TipoD.Text = "Codigo: Tipo de documento";
            // 
            // DescripcionD
            // 
            this.DescripcionD.Location = new System.Drawing.Point(16, 158);
            this.DescripcionD.Name = "DescripcionD";
            this.DescripcionD.Size = new System.Drawing.Size(344, 29);
            this.DescripcionD.TabIndex = 9;
            this.DescripcionD.Text = "Descripcion";
            // 
            // LongitudD
            // 
            this.LongitudD.Location = new System.Drawing.Point(16, 220);
            this.LongitudD.Name = "LongitudD";
            this.LongitudD.Size = new System.Drawing.Size(344, 29);
            this.LongitudD.TabIndex = 10;
            this.LongitudD.Text = "Cantidad de digitos";
            // 
            // AñadirDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(376, 469);
            this.Controls.Add(this.LongitudD);
            this.Controls.Add(this.DescripcionD);
            this.Controls.Add(this.TipoD);
            this.Controls.Add(this.CancelarEAñadir);
            this.Controls.Add(this.AñadirEConfirm);
            this.Controls.Add(this.Documentosbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AñadirDocumento";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Documentosbtn;
       
       // private CRUDDataSetTableAdapters.DocumentosTableAdapter documentosTableAdapter;
        private System.Windows.Forms.Button CancelarEAñadir;
        private System.Windows.Forms.Button AñadirEConfirm;
        public System.Windows.Forms.TextBox TipoD;
        public System.Windows.Forms.TextBox DescripcionD;
        public System.Windows.Forms.TextBox LongitudD;
    }
}

