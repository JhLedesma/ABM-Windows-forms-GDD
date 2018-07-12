namespace FrbaHotel.GenerarModificacionReserva
{
    partial class ModificarReserva
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitarHabitacion = new System.Windows.Forms.Button();
            this.btnAgregarHabitacion = new System.Windows.Forms.Button();
            this.listadoTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.lblTipoDeHabitacion = new System.Windows.Forms.Label();
            this.lblCostoHabitacion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblHabitacionPorDia = new System.Windows.Forms.Label();
            this.listadoHoteles = new System.Windows.Forms.ComboBox();
            this.lblHotel = new System.Windows.Forms.Label();
            this.btnRegimen = new System.Windows.Forms.Button();
            this.tbRegimen = new System.Windows.Forms.TextBox();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblRegimen = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnConfirmar);
            this.groupBox2.Controls.Add(this.lblCostoTotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 127);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PASO 2: Confirme la Reserva";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(171, 91);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(266, 91);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(236, 44);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(45, 24);
            this.lblCostoTotal.TabIndex = 13;
            this.lblCostoTotal.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Costo total de reserva:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitarHabitacion);
            this.groupBox1.Controls.Add(this.btnAgregarHabitacion);
            this.groupBox1.Controls.Add(this.listadoTipoHabitacion);
            this.groupBox1.Controls.Add(this.lblTipoDeHabitacion);
            this.groupBox1.Controls.Add(this.lblCostoHabitacion);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.lblHabitacionPorDia);
            this.groupBox1.Controls.Add(this.listadoHoteles);
            this.groupBox1.Controls.Add(this.lblHotel);
            this.groupBox1.Controls.Add(this.btnRegimen);
            this.groupBox1.Controls.Add(this.tbRegimen);
            this.groupBox1.Controls.Add(this.lblFechaDesde);
            this.groupBox1.Controls.Add(this.lblRegimen);
            this.groupBox1.Controls.Add(this.lblHasta);
            this.groupBox1.Controls.Add(this.dtHasta);
            this.groupBox1.Controls.Add(this.dtDesde);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 311);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PASO 1: Ingrese los siguientes datos para generar Reserva";
            // 
            // btnQuitarHabitacion
            // 
            this.btnQuitarHabitacion.Location = new System.Drawing.Point(309, 147);
            this.btnQuitarHabitacion.Name = "btnQuitarHabitacion";
            this.btnQuitarHabitacion.Size = new System.Drawing.Size(32, 23);
            this.btnQuitarHabitacion.TabIndex = 51;
            this.btnQuitarHabitacion.Text = "AC";
            this.btnQuitarHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarHabitacion
            // 
            this.btnAgregarHabitacion.Location = new System.Drawing.Point(266, 147);
            this.btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            this.btnAgregarHabitacion.Size = new System.Drawing.Size(32, 23);
            this.btnAgregarHabitacion.TabIndex = 50;
            this.btnAgregarHabitacion.Text = "+";
            this.btnAgregarHabitacion.UseVisualStyleBackColor = true;
            // 
            // listadoTipoHabitacion
            // 
            this.listadoTipoHabitacion.FormattingEnabled = true;
            this.listadoTipoHabitacion.Location = new System.Drawing.Point(135, 148);
            this.listadoTipoHabitacion.Name = "listadoTipoHabitacion";
            this.listadoTipoHabitacion.Size = new System.Drawing.Size(125, 21);
            this.listadoTipoHabitacion.TabIndex = 14;
            // 
            // lblTipoDeHabitacion
            // 
            this.lblTipoDeHabitacion.AutoSize = true;
            this.lblTipoDeHabitacion.Location = new System.Drawing.Point(6, 151);
            this.lblTipoDeHabitacion.Name = "lblTipoDeHabitacion";
            this.lblTipoDeHabitacion.Size = new System.Drawing.Size(115, 13);
            this.lblTipoDeHabitacion.TabIndex = 13;
            this.lblTipoDeHabitacion.Text = "Habitaciones Elegidas:";
            // 
            // lblCostoHabitacion
            // 
            this.lblCostoHabitacion.AutoSize = true;
            this.lblCostoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoHabitacion.Location = new System.Drawing.Point(233, 229);
            this.lblCostoHabitacion.Name = "lblCostoHabitacion";
            this.lblCostoHabitacion.Size = new System.Drawing.Size(45, 24);
            this.lblCostoHabitacion.TabIndex = 12;
            this.lblCostoHabitacion.Text = "0.00";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(266, 277);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(171, 277);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblHabitacionPorDia
            // 
            this.lblHabitacionPorDia.AutoSize = true;
            this.lblHabitacionPorDia.Location = new System.Drawing.Point(6, 235);
            this.lblHabitacionPorDia.Name = "lblHabitacionPorDia";
            this.lblHabitacionPorDia.Size = new System.Drawing.Size(152, 13);
            this.lblHabitacionPorDia.TabIndex = 9;
            this.lblHabitacionPorDia.Text = "Valor de habitacion/es por dia:";
            // 
            // listadoHoteles
            // 
            this.listadoHoteles.FormattingEnabled = true;
            this.listadoHoteles.Location = new System.Drawing.Point(135, 109);
            this.listadoHoteles.Name = "listadoHoteles";
            this.listadoHoteles.Size = new System.Drawing.Size(125, 21);
            this.listadoHoteles.TabIndex = 8;
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
            // btnRegimen
            // 
            this.btnRegimen.Location = new System.Drawing.Point(266, 188);
            this.btnRegimen.Name = "btnRegimen";
            this.btnRegimen.Size = new System.Drawing.Size(75, 23);
            this.btnRegimen.TabIndex = 6;
            this.btnRegimen.Text = "Seleccionar";
            this.btnRegimen.UseVisualStyleBackColor = true;
            // 
            // tbRegimen
            // 
            this.tbRegimen.Enabled = false;
            this.tbRegimen.Location = new System.Drawing.Point(135, 190);
            this.tbRegimen.Name = "tbRegimen";
            this.tbRegimen.Size = new System.Drawing.Size(125, 20);
            this.tbRegimen.TabIndex = 5;
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
            // lblRegimen
            // 
            this.lblRegimen.AutoSize = true;
            this.lblRegimen.Location = new System.Drawing.Point(6, 193);
            this.lblRegimen.Name = "lblRegimen";
            this.lblRegimen.Size = new System.Drawing.Size(52, 13);
            this.lblRegimen.TabIndex = 4;
            this.lblRegimen.Text = "Regimen:";
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
            // dtHasta
            // 
            this.dtHasta.Location = new System.Drawing.Point(135, 72);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(200, 20);
            this.dtHasta.TabIndex = 3;
            this.dtHasta.Value = new System.DateTime(2021, 1, 2, 0, 0, 0, 0);
            // 
            // dtDesde
            // 
            this.dtDesde.Location = new System.Drawing.Point(135, 34);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(200, 20);
            this.dtDesde.TabIndex = 2;
            this.dtDesde.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(21, 472);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Enabled = false;
            this.btnTerminar.Location = new System.Drawing.Point(278, 472);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(75, 23);
            this.btnTerminar.TabIndex = 19;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            // 
            // ModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 502);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarReserva";
            this.Text = "ModificarReserva";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuitarHabitacion;
        private System.Windows.Forms.Button btnAgregarHabitacion;
        private System.Windows.Forms.ComboBox listadoTipoHabitacion;
        private System.Windows.Forms.Label lblTipoDeHabitacion;
        private System.Windows.Forms.Label lblCostoHabitacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblHabitacionPorDia;
        private System.Windows.Forms.ComboBox listadoHoteles;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Button btnRegimen;
        private System.Windows.Forms.TextBox tbRegimen;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblRegimen;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnTerminar;
    }
}