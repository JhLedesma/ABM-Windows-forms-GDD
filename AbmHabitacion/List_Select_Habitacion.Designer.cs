namespace FrbaHotel.AbmHabitacion
{
    partial class List_Select_Habitacion
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
            this.gBoxBusquedaCliente = new System.Windows.Forms.GroupBox();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.comboBox_tipoHabitacion = new System.Windows.Forms.ComboBox();
            this.comboBox_ubicacion = new System.Windows.Forms.ComboBox();
            this.textBox_idHotel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroIdentificacion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.boton_aceptar = new System.Windows.Forms.Button();
            this.boton_volver = new System.Windows.Forms.Button();
            this.dataGridHabitaciones = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.gBoxBusquedaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxBusquedaCliente
            // 
            this.gBoxBusquedaCliente.Controls.Add(this.boton_buscar);
            this.gBoxBusquedaCliente.Controls.Add(this.comboBox_tipoHabitacion);
            this.gBoxBusquedaCliente.Controls.Add(this.comboBox_ubicacion);
            this.gBoxBusquedaCliente.Controls.Add(this.textBox_idHotel);
            this.gBoxBusquedaCliente.Controls.Add(this.label1);
            this.gBoxBusquedaCliente.Controls.Add(this.lblNumeroIdentificacion);
            this.gBoxBusquedaCliente.Controls.Add(this.lblApellido);
            this.gBoxBusquedaCliente.Controls.Add(this.lblNombre);
            this.gBoxBusquedaCliente.Location = new System.Drawing.Point(12, 12);
            this.gBoxBusquedaCliente.Name = "gBoxBusquedaCliente";
            this.gBoxBusquedaCliente.Size = new System.Drawing.Size(531, 99);
            this.gBoxBusquedaCliente.TabIndex = 22;
            this.gBoxBusquedaCliente.TabStop = false;
            this.gBoxBusquedaCliente.Text = "Busqueda de Habitacion";
            // 
            // boton_buscar
            // 
            this.boton_buscar.Location = new System.Drawing.Point(393, 32);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(120, 23);
            this.boton_buscar.TabIndex = 17;
            this.boton_buscar.Text = "Buscar";
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // comboBox_tipoHabitacion
            // 
            this.comboBox_tipoHabitacion.FormattingEnabled = true;
            this.comboBox_tipoHabitacion.Location = new System.Drawing.Point(86, 66);
            this.comboBox_tipoHabitacion.Name = "comboBox_tipoHabitacion";
            this.comboBox_tipoHabitacion.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tipoHabitacion.TabIndex = 16;
            // 
            // comboBox_ubicacion
            // 
            this.comboBox_ubicacion.FormattingEnabled = true;
            this.comboBox_ubicacion.Location = new System.Drawing.Point(86, 34);
            this.comboBox_ubicacion.Name = "comboBox_ubicacion";
            this.comboBox_ubicacion.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ubicacion.TabIndex = 15;
            // 
            // textBox_idHotel
            // 
            this.textBox_idHotel.Enabled = false;
            this.textBox_idHotel.Location = new System.Drawing.Point(393, 66);
            this.textBox_idHotel.Name = "textBox_idHotel";
            this.textBox_idHotel.Size = new System.Drawing.Size(120, 20);
            this.textBox_idHotel.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id hotel elegido:";
            // 
            // lblNumeroIdentificacion
            // 
            this.lblNumeroIdentificacion.AutoSize = true;
            this.lblNumeroIdentificacion.Location = new System.Drawing.Point(342, 37);
            this.lblNumeroIdentificacion.Name = "lblNumeroIdentificacion";
            this.lblNumeroIdentificacion.Size = new System.Drawing.Size(35, 13);
            this.lblNumeroIdentificacion.TabIndex = 9;
            this.lblNumeroIdentificacion.Text = "Hotel:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 69);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Ubicacion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(31, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Tipo:";
            // 
            // boton_aceptar
            // 
            this.boton_aceptar.Location = new System.Drawing.Point(403, 492);
            this.boton_aceptar.Name = "boton_aceptar";
            this.boton_aceptar.Size = new System.Drawing.Size(120, 23);
            this.boton_aceptar.TabIndex = 36;
            this.boton_aceptar.Text = "Modificar";
            this.boton_aceptar.UseVisualStyleBackColor = true;
            this.boton_aceptar.Click += new System.EventHandler(this.boton_modificar_Click);
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(21, 492);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(120, 23);
            this.boton_volver.TabIndex = 35;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // dataGridHabitaciones
            // 
            this.dataGridHabitaciones.AllowUserToAddRows = false;
            this.dataGridHabitaciones.AllowUserToDeleteRows = false;
            this.dataGridHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHabitaciones.Location = new System.Drawing.Point(12, 201);
            this.dataGridHabitaciones.Name = "dataGridHabitaciones";
            this.dataGridHabitaciones.ReadOnly = true;
            this.dataGridHabitaciones.Size = new System.Drawing.Size(531, 274);
            this.dataGridHabitaciones.TabIndex = 34;
            this.dataGridHabitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHabitaciones_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Listado de las habitaciones filtradas:";
            // 
            // button_filtrar
            // 
            this.button_filtrar.Location = new System.Drawing.Point(405, 125);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(120, 23);
            this.button_filtrar.TabIndex = 32;
            this.button_filtrar.Text = "Filtrar";
            this.button_filtrar.UseVisualStyleBackColor = true;
            this.button_filtrar.Click += new System.EventHandler(this.button_filtrar_Click);
            // 
            // List_Select_Habitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.boton_aceptar);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.dataGridHabitaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_filtrar);
            this.Controls.Add(this.gBoxBusquedaCliente);
            this.Name = "List_Select_Habitacion";
            this.Text = "List_Select_Habitacion";
            this.gBoxBusquedaCliente.ResumeLayout(false);
            this.gBoxBusquedaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxBusquedaCliente;
        private System.Windows.Forms.TextBox textBox_idHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroIdentificacion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox comboBox_tipoHabitacion;
        private System.Windows.Forms.ComboBox comboBox_ubicacion;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Button boton_aceptar;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.DataGridView dataGridHabitaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_filtrar;
    }
}