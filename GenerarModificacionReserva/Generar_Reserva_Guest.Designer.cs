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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(6, 32);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(41, 13);
            this.lblFechaDesde.TabIndex = 0;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(6, 68);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtDesde
            // 
            this.dtDesde.Location = new System.Drawing.Point(135, 26);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(200, 20);
            this.dtDesde.TabIndex = 2;
            this.dtDesde.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtDesde.ValueChanged += new System.EventHandler(this.resetearPorCambioDeHotel);
            // 
            // dtHasta
            // 
            this.dtHasta.Location = new System.Drawing.Point(135, 62);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(200, 20);
            this.dtHasta.TabIndex = 3;
            this.dtHasta.Value = new System.DateTime(2021, 1, 2, 0, 0, 0, 0);
            this.dtHasta.ValueChanged += new System.EventHandler(this.resetearPorCambioDeHotel);
            // 
            // lblRegimen
            // 
            this.lblRegimen.AutoSize = true;
            this.lblRegimen.Location = new System.Drawing.Point(6, 183);
            this.lblRegimen.Name = "lblRegimen";
            this.lblRegimen.Size = new System.Drawing.Size(52, 13);
            this.lblRegimen.TabIndex = 4;
            this.lblRegimen.Text = "Regimen:";
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
            this.groupBox1.Location = new System.Drawing.Point(19, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 295);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PASO 1: Ingrese los siguientes datos para generar Reserva";
            // 
            // btnQuitarHabitacion
            // 
            this.btnQuitarHabitacion.Location = new System.Drawing.Point(309, 137);
            this.btnQuitarHabitacion.Name = "btnQuitarHabitacion";
            this.btnQuitarHabitacion.Size = new System.Drawing.Size(32, 23);
            this.btnQuitarHabitacion.TabIndex = 51;
            this.btnQuitarHabitacion.Text = "AC";
            this.btnQuitarHabitacion.UseVisualStyleBackColor = true;
            this.btnQuitarHabitacion.Click += new System.EventHandler(this.btnQuitarHabitacion_Click);
            // 
            // btnAgregarHabitacion
            // 
            this.btnAgregarHabitacion.Location = new System.Drawing.Point(266, 137);
            this.btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            this.btnAgregarHabitacion.Size = new System.Drawing.Size(32, 23);
            this.btnAgregarHabitacion.TabIndex = 50;
            this.btnAgregarHabitacion.Text = "+";
            this.btnAgregarHabitacion.UseVisualStyleBackColor = true;
            this.btnAgregarHabitacion.Click += new System.EventHandler(this.btnAgregarHabitacion_Click);
            // 
            // listadoTipoHabitacion
            // 
            this.listadoTipoHabitacion.FormattingEnabled = true;
            this.listadoTipoHabitacion.Location = new System.Drawing.Point(135, 138);
            this.listadoTipoHabitacion.Name = "listadoTipoHabitacion";
            this.listadoTipoHabitacion.Size = new System.Drawing.Size(125, 21);
            this.listadoTipoHabitacion.TabIndex = 14;
            this.listadoTipoHabitacion.SelectedValueChanged += new System.EventHandler(this.actualizarRegimen_Click);
            // 
            // lblTipoDeHabitacion
            // 
            this.lblTipoDeHabitacion.AutoSize = true;
            this.lblTipoDeHabitacion.Location = new System.Drawing.Point(6, 141);
            this.lblTipoDeHabitacion.Name = "lblTipoDeHabitacion";
            this.lblTipoDeHabitacion.Size = new System.Drawing.Size(115, 13);
            this.lblTipoDeHabitacion.TabIndex = 13;
            this.lblTipoDeHabitacion.Text = "Habitaciones Elegidas:";
            // 
            // lblCostoHabitacion
            // 
            this.lblCostoHabitacion.AutoSize = true;
            this.lblCostoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoHabitacion.Location = new System.Drawing.Point(233, 219);
            this.lblCostoHabitacion.Name = "lblCostoHabitacion";
            this.lblCostoHabitacion.Size = new System.Drawing.Size(45, 24);
            this.lblCostoHabitacion.TabIndex = 12;
            this.lblCostoHabitacion.Text = "0.00";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(266, 267);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(171, 267);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblHabitacionPorDia
            // 
            this.lblHabitacionPorDia.AutoSize = true;
            this.lblHabitacionPorDia.Location = new System.Drawing.Point(6, 225);
            this.lblHabitacionPorDia.Name = "lblHabitacionPorDia";
            this.lblHabitacionPorDia.Size = new System.Drawing.Size(152, 13);
            this.lblHabitacionPorDia.TabIndex = 9;
            this.lblHabitacionPorDia.Text = "Valor de habitacion/es por dia:";
            // 
            // listadoHoteles
            // 
            this.listadoHoteles.FormattingEnabled = true;
            this.listadoHoteles.Location = new System.Drawing.Point(135, 99);
            this.listadoHoteles.Name = "listadoHoteles";
            this.listadoHoteles.Size = new System.Drawing.Size(125, 21);
            this.listadoHoteles.TabIndex = 8;
            this.listadoHoteles.Click += new System.EventHandler(this.resetearPorCambioDeHotel);
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Location = new System.Drawing.Point(6, 104);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(35, 13);
            this.lblHotel.TabIndex = 7;
            this.lblHotel.Text = "Hotel:";
            // 
            // btnRegimen
            // 
            this.btnRegimen.Location = new System.Drawing.Point(266, 178);
            this.btnRegimen.Name = "btnRegimen";
            this.btnRegimen.Size = new System.Drawing.Size(75, 23);
            this.btnRegimen.TabIndex = 6;
            this.btnRegimen.Text = "Seleccionar";
            this.btnRegimen.UseVisualStyleBackColor = true;
            this.btnRegimen.Click += new System.EventHandler(this.btnRegimen_Click);
            // 
            // tbRegimen
            // 
            this.tbRegimen.Enabled = false;
            this.tbRegimen.Location = new System.Drawing.Point(135, 180);
            this.tbRegimen.Name = "tbRegimen";
            this.tbRegimen.Size = new System.Drawing.Size(125, 20);
            this.tbRegimen.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnConfirmar);
            this.groupBox2.Controls.Add(this.lblCostoTotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(19, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 117);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PASO 2: Confirme la Reserva";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(171, 84);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(266, 84);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(236, 37);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(45, 24);
            this.lblCostoTotal.TabIndex = 13;
            this.lblCostoTotal.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Costo total de reserva:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCliente);
            this.groupBox3.Controls.Add(this.tbCliente);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.rbNo);
            this.groupBox3.Controls.Add(this.rbSi);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(19, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 139);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PASO 3: Ingrese datos de Cliente";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(51, 100);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 16;
            this.lblCliente.Text = "Cliente:";
            // 
            // tbCliente
            // 
            this.tbCliente.Enabled = false;
            this.tbCliente.Location = new System.Drawing.Point(193, 97);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(102, 20);
            this.tbCliente.TabIndex = 15;
            this.tbCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "¿Ya es cliente registrado?";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(259, 51);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.abrirCrearCliente_Click);
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(196, 51);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(34, 17);
            this.rbSi.TabIndex = 0;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            this.rbSi.CheckedChanged += new System.EventHandler(this.abrirListadoCliente_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Enabled = false;
            this.btnTerminar.Location = new System.Drawing.Point(285, 578);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(75, 23);
            this.btnTerminar.TabIndex = 17;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(28, 578);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Generar_Reserva_Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(390, 611);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Name = "Generar_Reserva_Guest";
            this.Text = "Generar Reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.ComboBox listadoHoteles;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Button btnRegimen;
        private System.Windows.Forms.TextBox tbRegimen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox listadoTipoHabitacion;
        private System.Windows.Forms.Label lblTipoDeHabitacion;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Button btnAgregarHabitacion;
        private System.Windows.Forms.Button btnQuitarHabitacion;
    }
}