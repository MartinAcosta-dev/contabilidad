namespace Sistema
{
    partial class AñadirPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirPlan));
            this.Nuevousuariotxt = new System.Windows.Forms.Button();
            this.CancelarEAñadir = new System.Windows.Forms.Button();
            this.AñadirEConfirm = new System.Windows.Forms.Button();
            this.codigotxt = new System.Windows.Forms.TextBox();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.tipotxt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nuevousuariotxt
            // 
            this.Nuevousuariotxt.BackColor = System.Drawing.Color.Transparent;
            this.Nuevousuariotxt.FlatAppearance.BorderSize = 0;
            this.Nuevousuariotxt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Nuevousuariotxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevousuariotxt.ForeColor = System.Drawing.Color.Black;
            this.Nuevousuariotxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevousuariotxt.Location = new System.Drawing.Point(16, 20);
            this.Nuevousuariotxt.Margin = new System.Windows.Forms.Padding(6);
            this.Nuevousuariotxt.Name = "Nuevousuariotxt";
            this.Nuevousuariotxt.Size = new System.Drawing.Size(344, 42);
            this.Nuevousuariotxt.TabIndex = 1;
            this.Nuevousuariotxt.Text = "Añadir Plan de cuentas";
            this.Nuevousuariotxt.UseVisualStyleBackColor = false;
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
            this.CancelarEAñadir.Location = new System.Drawing.Point(196, 292);
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
            this.AñadirEConfirm.Location = new System.Drawing.Point(46, 292);
            this.AñadirEConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.AñadirEConfirm.Name = "AñadirEConfirm";
            this.AñadirEConfirm.Size = new System.Drawing.Size(138, 42);
            this.AñadirEConfirm.TabIndex = 3;
            this.AñadirEConfirm.Text = "Añadir";
            this.AñadirEConfirm.UseVisualStyleBackColor = false;
            this.AñadirEConfirm.Click += new System.EventHandler(this.AñadirEConfirm_Click);
            // 
            // codigotxt
            // 
            this.codigotxt.Location = new System.Drawing.Point(16, 101);
            this.codigotxt.Name = "codigotxt";
            this.codigotxt.Size = new System.Drawing.Size(344, 29);
            this.codigotxt.TabIndex = 8;
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(16, 176);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(344, 29);
            this.Nombretxt.TabIndex = 10;
            // 
            // tipotxt
            // 
            this.tipotxt.DisplayMember = "ADMINISTRADOR";
            this.tipotxt.FormattingEnabled = true;
            this.tipotxt.Items.AddRange(new object[] {
            "Titulo",
            "Cuenta"});
            this.tipotxt.Location = new System.Drawing.Point(16, 242);
            this.tipotxt.Name = "tipotxt";
            this.tipotxt.Size = new System.Drawing.Size(344, 32);
            this.tipotxt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Codigo de registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tipo";
            // 
            // AñadirPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(375, 352);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipotxt);
            this.Controls.Add(this.Nombretxt);
            this.Controls.Add(this.codigotxt);
            this.Controls.Add(this.CancelarEAñadir);
            this.Controls.Add(this.AñadirEConfirm);
            this.Controls.Add(this.Nuevousuariotxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AñadirPlan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Nuevousuariotxt;

        // private CRUDDataSetTableAdapters.DocumentosTableAdapter documentosTableAdapter;
        private System.Windows.Forms.Button CancelarEAñadir;
        private System.Windows.Forms.Button AñadirEConfirm;
        public System.Windows.Forms.TextBox codigotxt;
        public System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.ComboBox tipotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

