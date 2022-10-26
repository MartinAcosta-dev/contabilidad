namespace Sistema.Menu.MenuFacturacion
{
    partial class ABMClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.razon = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.domicilio = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Cresponsable = new System.Windows.Forms.TextBox();
            this.Clocalidad = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.NDocumento = new System.Windows.Forms.TextBox();
            this.CDocumento = new System.Windows.Forms.TextBox();
            this.ingresos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTES";
            // 
            // razon
            // 
            this.razon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razon.ForeColor = System.Drawing.SystemColors.GrayText;
            this.razon.Location = new System.Drawing.Point(26, 12);
            this.razon.Name = "razon";
            this.razon.Size = new System.Drawing.Size(172, 26);
            this.razon.TabIndex = 1;
            this.razon.Text = "RazonSocial";
            
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.nombre.Location = new System.Drawing.Point(26, 53);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(172, 26);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "Nombre";
            
            // 
            // domicilio
            // 
            this.domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domicilio.ForeColor = System.Drawing.SystemColors.GrayText;
            this.domicilio.Location = new System.Drawing.Point(26, 95);
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(172, 26);
            this.domicilio.TabIndex = 4;
            this.domicilio.Text = "Domicilio";
           
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(223, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(680, 235);
            this.dataGridView1.TabIndex = 7;
            
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(614, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "MODIFICAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Cresponsable
            // 
            this.Cresponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cresponsable.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Cresponsable.Location = new System.Drawing.Point(26, 224);
            this.Cresponsable.Name = "Cresponsable";
            this.Cresponsable.Size = new System.Drawing.Size(172, 26);
            this.Cresponsable.TabIndex = 13;
            this.Cresponsable.Text = "CodigoResponsable";
            // 
            // Clocalidad
            // 
            this.Clocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clocalidad.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Clocalidad.Location = new System.Drawing.Point(26, 180);
            this.Clocalidad.Name = "Clocalidad";
            this.Clocalidad.Size = new System.Drawing.Size(172, 26);
            this.Clocalidad.TabIndex = 12;
            this.Clocalidad.Text = "CodigoLocalidad";
            // 
            // tel
            // 
            this.tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tel.Location = new System.Drawing.Point(26, 137);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(172, 26);
            this.tel.TabIndex = 11;
            this.tel.Text = "Tel";
            // 
            // NDocumento
            // 
            this.NDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NDocumento.ForeColor = System.Drawing.SystemColors.GrayText;
            this.NDocumento.Location = new System.Drawing.Point(26, 315);
            this.NDocumento.Name = "NDocumento";
            this.NDocumento.Size = new System.Drawing.Size(172, 26);
            this.NDocumento.TabIndex = 15;
            this.NDocumento.Text = "Nro Documento";
            // 
            // CDocumento
            // 
            this.CDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDocumento.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CDocumento.Location = new System.Drawing.Point(26, 267);
            this.CDocumento.Name = "CDocumento";
            this.CDocumento.Size = new System.Drawing.Size(172, 26);
            this.CDocumento.TabIndex = 14;
            this.CDocumento.Text = "Cod Documento";
            // 
            // ingresos
            // 
            this.ingresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ingresos.Location = new System.Drawing.Point(26, 359);
            this.ingresos.Name = "ingresos";
            this.ingresos.Size = new System.Drawing.Size(172, 26);
            this.ingresos.TabIndex = 16;
            this.ingresos.Text = "IngresosBrutos";
            // 
            // ABMClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(925, 406);
            this.Controls.Add(this.ingresos);
            this.Controls.Add(this.NDocumento);
            this.Controls.Add(this.CDocumento);
            this.Controls.Add(this.Cresponsable);
            this.Controls.Add(this.Clocalidad);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.domicilio);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.razon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABMClientes";
            this.Text = "ABMProductos";
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox razon;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox domicilio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Cresponsable;
        private System.Windows.Forms.TextBox Clocalidad;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox NDocumento;
        private System.Windows.Forms.TextBox CDocumento;
        private System.Windows.Forms.TextBox ingresos;
    }
}