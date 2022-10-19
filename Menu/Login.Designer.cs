namespace Sistema
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Documentosbtn = new System.Windows.Forms.Button();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.Passtxt = new System.Windows.Forms.TextBox();
            this.Btnlogin = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
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
            this.Documentosbtn.Location = new System.Drawing.Point(310, 116);
            this.Documentosbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Documentosbtn.Name = "Documentosbtn";
            this.Documentosbtn.Size = new System.Drawing.Size(344, 42);
            this.Documentosbtn.TabIndex = 1;
            this.Documentosbtn.Text = "Login";
            this.Documentosbtn.UseVisualStyleBackColor = false;
            // 
            // Usertxt
            // 
            this.Usertxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Usertxt.Location = new System.Drawing.Point(310, 209);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(344, 29);
            this.Usertxt.TabIndex = 9;
            this.Usertxt.Text = "Usuario";
            this.Usertxt.Click += new System.EventHandler(this.Usertxt_Click);
            this.Usertxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Usertxt_MouseClick);
            this.Usertxt.TextChanged += new System.EventHandler(this.Usertxt_TextChanged);
            // 
            // Passtxt
            // 
            this.Passtxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Passtxt.Location = new System.Drawing.Point(310, 261);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.Size = new System.Drawing.Size(344, 29);
            this.Passtxt.TabIndex = 10;
            this.Passtxt.Text = "Contraseña";
            this.Passtxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Passtxt_MouseClick);
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
            this.Btnlogin.Location = new System.Drawing.Point(310, 348);
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
            this.Btnsalir.Location = new System.Drawing.Point(516, 348);
            this.Btnsalir.Margin = new System.Windows.Forms.Padding(6);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(138, 42);
            this.Btnsalir.TabIndex = 12;
            this.Btnsalir.Text = "Cerrar";
            this.Btnsalir.UseVisualStyleBackColor = false;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1021, 469);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btnlogin);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.Documentosbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Documentosbtn;
        public System.Windows.Forms.TextBox Usertxt;
        public System.Windows.Forms.TextBox Passtxt;
        private System.Windows.Forms.Button Btnlogin;
        private System.Windows.Forms.Button Btnsalir;
    }
}

