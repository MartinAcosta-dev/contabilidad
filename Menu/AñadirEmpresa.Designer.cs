using System.Drawing;
using System.Windows.Forms;

namespace Sistema
{
    partial class AñadirEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirEmpresa));
            this.Documentosbtn = new System.Windows.Forms.Button();
            this.CancelarEAñadir = new System.Windows.Forms.Button();
            this.AñadirEConfirm = new System.Windows.Forms.Button();
            this.nombreEmpresatxt = new System.Windows.Forms.TextBox();
            this.localizacionEmpresatxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.razonSocialtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTipoResp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cuitTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fechaIniDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.fechaCierreDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.Documentosbtn.Location = new System.Drawing.Point(34, 15);
            this.Documentosbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Documentosbtn.Name = "Documentosbtn";
            this.Documentosbtn.Size = new System.Drawing.Size(293, 42);
            this.Documentosbtn.TabIndex = 99;
            this.Documentosbtn.Text = "Nueva Empresa";
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
            this.CancelarEAñadir.Location = new System.Drawing.Point(189, 659);
            this.CancelarEAñadir.Margin = new System.Windows.Forms.Padding(6);
            this.CancelarEAñadir.Name = "CancelarEAñadir";
            this.CancelarEAñadir.Size = new System.Drawing.Size(138, 42);
            this.CancelarEAñadir.TabIndex = 89;
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
            this.AñadirEConfirm.Location = new System.Drawing.Point(43, 659);
            this.AñadirEConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.AñadirEConfirm.Name = "AñadirEConfirm";
            this.AñadirEConfirm.Size = new System.Drawing.Size(138, 42);
            this.AñadirEConfirm.TabIndex = 88;
            this.AñadirEConfirm.Text = "Añadir";
            this.AñadirEConfirm.UseVisualStyleBackColor = false;
            this.AñadirEConfirm.Click += new System.EventHandler(this.AñadirEConfirm_Click);
            // 
            // nombreEmpresatxt
            // 
            this.nombreEmpresatxt.Location = new System.Drawing.Point(12, 111);
            this.nombreEmpresatxt.Name = "nombreEmpresatxt";
            this.nombreEmpresatxt.Size = new System.Drawing.Size(344, 29);
            this.nombreEmpresatxt.TabIndex = 1;
            // 
            // localizacionEmpresatxt
            // 
            this.localizacionEmpresatxt.Location = new System.Drawing.Point(12, 242);
            this.localizacionEmpresatxt.Name = "localizacionEmpresatxt";
            this.localizacionEmpresatxt.Size = new System.Drawing.Size(344, 29);
            this.localizacionEmpresatxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Localizacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(8, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Razon social";
            // 
            // razonSocialtxt
            // 
            this.razonSocialtxt.Location = new System.Drawing.Point(12, 176);
            this.razonSocialtxt.Name = "razonSocialtxt";
            this.razonSocialtxt.Size = new System.Drawing.Size(344, 29);
            this.razonSocialtxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(8, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo Responsable";
            // 
            // comboBoxTipoResp
            // 
            this.comboBoxTipoResp.FormattingEnabled = true;
            this.comboBoxTipoResp.Items.AddRange(new object[] {
            "1 - Responsable inscripto",
            "2 - Responsable no inscripto",
            "3 - No responsable",
            "4 - Sujeto exento",
            "5 - Consumidor final",
            "6 - Responsable monotributo",
            "7 - Sujeto no categorizado",
            "8 - Proveedor del exterior",
            "9 - Cliente del exterior",
            "10 - IVA liberado - Ley n 19.640",
            "11 - IVA Responsable inscripto - Agente de percepcion",
            "12 - Pequeño contribuyente eventual",
            "13 - Monotributista social",
            "14 - Pequeño contribuyente eventual social"});
            this.comboBoxTipoResp.Location = new System.Drawing.Point(12, 308);
            this.comboBoxTipoResp.Name = "comboBoxTipoResp";
            this.comboBoxTipoResp.Size = new System.Drawing.Size(340, 32);
            this.comboBoxTipoResp.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(8, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "CUIT";
            // 
            // cuitTxt
            // 
            this.cuitTxt.Location = new System.Drawing.Point(12, 379);
            this.cuitTxt.Name = "cuitTxt";
            this.cuitTxt.Size = new System.Drawing.Size(344, 29);
            this.cuitTxt.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(8, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fecha inicio ej.";
            // 
            // fechaIniDateTimePicker
            // 
            this.fechaIniDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.fechaIniDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaIniDateTimePicker.Location = new System.Drawing.Point(12, 451);
            this.fechaIniDateTimePicker.Name = "fechaIniDateTimePicker";
            this.fechaIniDateTimePicker.Size = new System.Drawing.Size(344, 29);
            this.fechaIniDateTimePicker.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 15);
            this.label7.TabIndex = 100;
            this.label7.Text = "(no puede incluir espacios en blanco)";
            // 
            // fechaCierreDateTimePicker
            // 
            this.fechaCierreDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.fechaCierreDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaCierreDateTimePicker.Location = new System.Drawing.Point(17, 531);
            this.fechaCierreDateTimePicker.Name = "fechaCierreDateTimePicker";
            this.fechaCierreDateTimePicker.Size = new System.Drawing.Size(344, 29);
            this.fechaCierreDateTimePicker.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(13, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 24);
            this.label8.TabIndex = 102;
            this.label8.Text = "Fecha cierre ej.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 608);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 29);
            this.textBox1.TabIndex = 103;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(13, 581);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 104;
            this.label9.Text = "Contraseña";
            // 
            // AñadirEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(390, 716);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fechaCierreDateTimePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fechaIniDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cuitTxt);
            this.Controls.Add(this.comboBoxTipoResp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.razonSocialtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.localizacionEmpresatxt);
            this.Controls.Add(this.nombreEmpresatxt);
            this.Controls.Add(this.CancelarEAñadir);
            this.Controls.Add(this.AñadirEConfirm);
            this.Controls.Add(this.Documentosbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AñadirEmpresa";
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
        public System.Windows.Forms.TextBox nombreEmpresatxt;
        public System.Windows.Forms.TextBox localizacionEmpresatxt;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox razonSocialtxt;
        private Label label4;
        private ComboBox comboBoxTipoResp;
        private Label label5;
        public TextBox cuitTxt;
        private Label label6;
        private DateTimePicker fechaIniDateTimePicker;
        private Label label7;
        private DateTimePicker fechaCierreDateTimePicker;
        private Label label8;
        private TextBox textBox1;
        private Label label9;

        public SizeF AutoScaleDimensions { get; private set; }
        public AutoScaleMode AutoScaleMode { get; private set; }
        public Image BackgroundImage { get; private set; }
        public Size ClientSize { get; private set; }
    }
}

