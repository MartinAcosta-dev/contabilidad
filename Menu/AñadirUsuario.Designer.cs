namespace Sistema
{
    partial class AñadirUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirUsuario));
            this.Nuevousuariotxt = new System.Windows.Forms.Button();
            this.CancelarEAñadir = new System.Windows.Forms.Button();
            this.AñadirEConfirm = new System.Windows.Forms.Button();
            this.nombreusuariotxt = new System.Windows.Forms.TextBox();
            this.Contraseñatxt = new System.Windows.Forms.TextBox();
            this.NombreUtxt = new System.Windows.Forms.TextBox();
            this.ApellidoUtxt = new System.Windows.Forms.TextBox();
            this.TiposUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Nuevousuariotxt
            // 
            this.Nuevousuariotxt.BackColor = System.Drawing.Color.Transparent;
            this.Nuevousuariotxt.FlatAppearance.BorderSize = 0;
            this.Nuevousuariotxt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.Nuevousuariotxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevousuariotxt.ForeColor = System.Drawing.Color.Black;
            this.Nuevousuariotxt.Image = global::Sistema.Properties.Resources.iconmonstr_user_23_32;
            this.Nuevousuariotxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevousuariotxt.Location = new System.Drawing.Point(16, 20);
            this.Nuevousuariotxt.Margin = new System.Windows.Forms.Padding(6);
            this.Nuevousuariotxt.Name = "Nuevousuariotxt";
            this.Nuevousuariotxt.Size = new System.Drawing.Size(344, 42);
            this.Nuevousuariotxt.TabIndex = 1;
            this.Nuevousuariotxt.Text = "Nuevo Usuario";
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
            this.CancelarEAñadir.Location = new System.Drawing.Point(222, 388);
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
            this.AñadirEConfirm.Location = new System.Drawing.Point(16, 388);
            this.AñadirEConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.AñadirEConfirm.Name = "AñadirEConfirm";
            this.AñadirEConfirm.Size = new System.Drawing.Size(138, 42);
            this.AñadirEConfirm.TabIndex = 3;
            this.AñadirEConfirm.Text = "Añadir";
            this.AñadirEConfirm.UseVisualStyleBackColor = false;
            this.AñadirEConfirm.Click += new System.EventHandler(this.AñadirEConfirm_Click);
            // 
            // nombreusuariotxt
            // 
            this.nombreusuariotxt.Location = new System.Drawing.Point(16, 88);
            this.nombreusuariotxt.Name = "nombreusuariotxt";
            this.nombreusuariotxt.Size = new System.Drawing.Size(344, 29);
            this.nombreusuariotxt.TabIndex = 8;
            this.nombreusuariotxt.Text = "Nombre de usuario";
            // 
            // Contraseñatxt
            // 
            this.Contraseñatxt.Location = new System.Drawing.Point(16, 138);
            this.Contraseñatxt.Name = "Contraseñatxt";
            this.Contraseñatxt.Size = new System.Drawing.Size(344, 29);
            this.Contraseñatxt.TabIndex = 9;
            this.Contraseñatxt.Text = "Contraseña";
            // 
            // NombreUtxt
            // 
            this.NombreUtxt.Location = new System.Drawing.Point(16, 231);
            this.NombreUtxt.Name = "NombreUtxt";
            this.NombreUtxt.Size = new System.Drawing.Size(344, 29);
            this.NombreUtxt.TabIndex = 10;
            this.NombreUtxt.Text = "Nombre";
            // 
            // ApellidoUtxt
            // 
            this.ApellidoUtxt.Location = new System.Drawing.Point(16, 278);
            this.ApellidoUtxt.Name = "ApellidoUtxt";
            this.ApellidoUtxt.Size = new System.Drawing.Size(344, 29);
            this.ApellidoUtxt.TabIndex = 11;
            this.ApellidoUtxt.Text = "Apellido";
            // 
            // TiposUsuario
            // 
            this.TiposUsuario.DisplayMember = "ADMINISTRADOR";
            this.TiposUsuario.FormattingEnabled = true;
            this.TiposUsuario.Items.AddRange(new object[] {
            "AUDITOR",
            "SUPERVISOR",
            "OPERARIO"});
            this.TiposUsuario.Location = new System.Drawing.Point(16, 184);
            this.TiposUsuario.Name = "TiposUsuario";
            this.TiposUsuario.Size = new System.Drawing.Size(344, 32);
            this.TiposUsuario.TabIndex = 13;
            this.TiposUsuario.Text = "Tipo de usuario";
            // 
            // AñadirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(375, 469);
            this.Controls.Add(this.TiposUsuario);
            this.Controls.Add(this.ApellidoUtxt);
            this.Controls.Add(this.NombreUtxt);
            this.Controls.Add(this.Contraseñatxt);
            this.Controls.Add(this.nombreusuariotxt);
            this.Controls.Add(this.CancelarEAñadir);
            this.Controls.Add(this.AñadirEConfirm);
            this.Controls.Add(this.Nuevousuariotxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AñadirUsuario";
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
        public System.Windows.Forms.TextBox nombreusuariotxt;
        public System.Windows.Forms.TextBox Contraseñatxt;
        public System.Windows.Forms.TextBox NombreUtxt;
        public System.Windows.Forms.TextBox ApellidoUtxt;
        private System.Windows.Forms.ComboBox TiposUsuario;
    }
}

