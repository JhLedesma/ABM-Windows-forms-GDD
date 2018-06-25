namespace FrbaHotel.GenerarModificacionReserva
{
    partial class Generar_Reserva_Guest
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
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.lblRegimen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRegimen = new System.Windows.Forms.TextBox();
            this.btnRegimen = new System.Windows.Forms.Button();
            this.lblHotel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblHabitacionPorDia = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCostoHabitacion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(6, 40);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(41, 13);
            this.lblFechaDesde.TabIndex = 0;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(6, 78);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtDesde
            // 
            this.dtDesde.Location = new System.Drawing.Point(77, 34);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(200, 20);
            this.dtDesde.TabIndex = 2;
            // 
            // dtHasta
            // 
            this.dtHasta.Location = new System.Drawing.Point(77, 72);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(200, 20);
            this.dtHasta.TabIndex = 3;
            // 
            // lblRegimen
            // 
            this.lblRegimen.AutoSize = true;
            this.lblRegimen.Location = new System.Drawing.Point(6, 151);
            this.lblRegimen.Name = "lblRegimen";
            this.lblRegimen.Size = new System.Drawing.Size(52, 13);
            this.lblRegimen.TabIndex = 4;
            this.lblRegimen.Text = "Regimen:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCostoHabitacion);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.lblHabitacionPorDia);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblHotel);
            this.groupBox1.Controls.Add(this.btnRegimen);
            this.groupBox1.Controls.Add(this.tbRegimen);
            this.groupBox1.Controls.Add(this.lblFechaDesde);
            this.groupBox1.Controls.Add(this.lblRegimen);
            this.groupBox1.Controls.Add(this.lblHasta);
            this.groupBox1.Controls.Add(this.dtHasta);
            this.groupBox1.Controls.Add(this.dtDesde);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 270);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PASO 1: Ingrese los siguientes datos para generar Reserva";
            // 
            // tbRegimen
            // 
            this.tbRegimen.Enabled = false;
            this.tbRegimen.Location = new System.Drawing.Point(77, 148);
            this.tbRegimen.Name = "tbRegimen";
            this.tbRegimen.Size = new System.Drawing.Size(100, 20);
            this.tbRegimen.TabIndex = 5;
            // 
            // btnRegimen
            // 
            this.btnRegimen.Location = new System.Drawing.Point(202, 146);
            this.btnRegimen.Name = "btnRegimen";
            this.btnRegimen.Size = new System.Drawing.Size(75, 23);
            this.btnRegimen.TabIndex = 6;
            this.btnRegimen.Text = "Seleccionar";
            this.btnRegimen.UseVisualStyleBackColor = true;
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Location = new System.Drawing.Point(6, 114);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(35, 13);
            this.lblHotel.TabIndex = 7;
            this.lblHotel.Text = "Hotel:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // lblHabitacionPorDia
            // 
            this.lblHabitacionPorDia.AutoSize = true;
            this.lblHabitacionPorDia.Location = new System.Drawing.Point(6, 193);
            this.lblHabitacionPorDia.Name = "lblHabitacionPorDia";
            this.lblHabitacionPorDia.Size = new System.Drawing.Size(136, 13);
            this.lblHabitacionPorDia.TabIndex = 9;
            this.lblHabitacionPorDia.Text = "Valor de habitacion por dia:";
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(35, 237);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(162, 237);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblCostoHabitacion
            // 
            this.lblCostoHabitacion.AutoSize = true;
            this.lblCostoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoHabitacion.Location = new System.Drawing.Point(198, 185);
            this.lblCostoHabitacion.Name = "lblCostoHabitacion";
            this.lblCostoHabitacion.Size = new System.Drawing.Size(45, 24);
            this.lblCostoHabitacion.TabIndex = 12;
            this.lblCostoHabitacion.Text = "0.00";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(25, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 113);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PASO 2: Confirme la Reserva";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(25, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 223);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PASO 3: Ingrese datos de Cliente";
            // 
            // Generar_Reserva_Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 660);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Generar_Reserva_Guest";
            this.Text = "Generar Reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.Label lblRegimen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCostoHabitacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblHabitacionPorDia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Button btnRegimen;
        private System.Windows.Forms.TextBox tbRegimen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}