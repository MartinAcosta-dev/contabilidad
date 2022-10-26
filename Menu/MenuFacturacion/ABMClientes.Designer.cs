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
            this.tel = new System.Windows.Forms.TextBox();
            this.NDocumento = new System.Windows.Forms.TextBox();
            this.ingresos = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 25);
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
            this.razon.Text = "Razon Social";
            this.razon.Click += new System.EventHandler(this.razon_Click);
            this.razon.TextChanged += new System.EventHandler(this.razon_TextChanged);
            this.razon.Leave += new System.EventHandler(this.razon_Leave);
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
            this.nombre.Click += new System.EventHandler(this.nombre_Click);
            this.nombre.Leave += new System.EventHandler(this.nombre_Leave);
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
            this.domicilio.Click += new System.EventHandler(this.domicilio_Click);
            this.domicilio.Leave += new System.EventHandler(this.domicilio_Leave);
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
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(489, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.tel.Click += new System.EventHandler(this.tel_Click);
            this.tel.Leave += new System.EventHandler(this.tel_Leave);
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
            this.NDocumento.Click += new System.EventHandler(this.NDocumento_Click);
            this.NDocumento.Leave += new System.EventHandler(this.NDocumento_Leave);
            // 
            // ingresos
            // 
            this.ingresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ingresos.Location = new System.Drawing.Point(26, 359);
            this.ingresos.Name = "ingresos";
            this.ingresos.Size = new System.Drawing.Size(172, 26);
            this.ingresos.TabIndex = 16;
            this.ingresos.Text = "Ingresos Brutos";
            this.ingresos.Click += new System.EventHandler(this.ingresos_Click);
            this.ingresos.Leave += new System.EventHandler(this.ingresos_Leave);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(683, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 45);
            this.button3.TabIndex = 17;
            this.button3.Text = "MODIFICAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo Responsable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Localidad";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(26, 191);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tipo Documento";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(26, 279);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(172, 21);
            this.comboBox3.TabIndex = 22;
            // 
            // ABMClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(925, 406);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ingresos);
            this.Controls.Add(this.NDocumento);
            this.Controls.Add(this.tel);
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
            this.Load += new System.EventHandler(this.ABMClientes_Load);
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
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox NDocumento;
        private System.Windows.Forms.TextBox ingresos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}