namespace FrbaHotel.AbmHabitacion
{
    partial class Crear_Habitacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_descripcion = new System.Windows.Forms.RichTextBox();
            this.comboBox_tipoHabitacion = new System.Windows.Forms.ComboBox();
            this.comboBox_ubicacion = new System.Windows.Forms.ComboBox();
            this.lblNumeroIdentificacion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.numericTextBox_piso = new FrbaHotel.Model.NumericTextBox();
            this.numericTextBox_numeroHab = new FrbaHotel.Model.NumericTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boton_buscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_descripcion);
            this.groupBox1.Controls.Add(this.comboBox_tipoHabitacion);
            this.groupBox1.Controls.Add(this.numericTextBox_piso);
            this.groupBox1.Controls.Add(this.numericTextBox_numeroHab);
            this.groupBox1.Controls.Add(this.comboBox_ubicacion);
            this.groupBox1.Controls.Add(this.lblNumeroIdentificacion);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 338);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos de la nueva habitacion (todos los datos son obligatorios):";
            // 
            // boton_buscar
            // 
            this.boton_buscar.Location = new System.Drawing.Point(147, 28);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(117, 23);
            this.boton_buscar.TabIndex = 62;
            this.boton_buscar.Text = "Buscar";
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Hotel:";
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.Location = new System.Drawing.Point(9, 230);
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(363, 96);
            this.textBox_descripcion.TabIndex = 60;
            this.textBox_descripcion.Text = "";
            // 
            // comboBox_tipoHabitacion
            // 
            this.comboBox_tipoHabitacion.FormattingEnabled = true;
            this.comboBox_tipoHabitacion.Location = new System.Drawing.Point(147, 161);
            this.comboBox_tipoHabitacion.Name = "comboBox_tipoHabitacion";
            this.comboBox_tipoHabitacion.Size = new System.Drawing.Size(117, 21);
            this.comboBox_tipoHabitacion.TabIndex = 59;
            // 
            // comboBox_ubicacion
            // 
            this.comboBox_ubicacion.FormattingEnabled = true;
            this.comboBox_ubicacion.Location = new System.Drawing.Point(146, 127);
            this.comboBox_ubicacion.Name = "comboBox_ubicacion";
            this.comboBox_ubicacion.Size = new System.Drawing.Size(118, 21);
            this.comboBox_ubicacion.TabIndex = 13;
            // 
            // lblNumeroIdentificacion
            // 
            this.lblNumeroIdentificacion.AutoSize = true;
            this.lblNumeroIdentificacion.Location = new System.Drawing.Point(0, 205);
            this.lblNumeroIdentificacion.Name = "lblNumeroIdentificacion";
            this.lblNumeroIdentificacion.Size = new System.Drawing.Size(135, 13);
            this.lblNumeroIdentificacion.TabIndex = 10;
            this.lblNumeroIdentificacion.Text = "Descripcion, comodidades:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 164);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(98, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Tipo de habitacion:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 130);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(58, 13);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Ubicacion:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 98);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(30, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Piso:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Numero de habitacion:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(25, 372);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 46;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(303, 372);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 45;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(167, 372);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 44;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // numericTextBox_piso
            // 
            this.numericTextBox_piso.AllowSpace = false;
            this.numericTextBox_piso.Location = new System.Drawing.Point(146, 95);
            this.numericTextBox_piso.Name = "numericTextBox_piso";
            this.numericTextBox_piso.Size = new System.Drawing.Size(117, 20);
            this.numericTextBox_piso.TabIndex = 58;
            // 
            // numericTextBox_numeroHab
            // 
            this.numericTextBox_numeroHab.AllowSpace = false;
            this.numericTextBox_numeroHab.Location = new System.Drawing.Point(146, 64);
            this.numericTextBox_numeroHab.Name = "numericTextBox_numeroHab";
            this.numericTextBox_numeroHab.Size = new System.Drawing.Size(117, 20);
            this.numericTextBox_numeroHab.TabIndex = 57;
            // 
            // Crear_Habitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 413);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Crear_Habitacion";
            this.Text = "Crear_Habitacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_tipoHabitacion;
        private Model.NumericTextBox numericTextBox_piso;
        private Model.NumericTextBox numericTextBox_numeroHab;
        private System.Windows.Forms.ComboBox comboBox_ubicacion;
        private System.Windows.Forms.Label lblNumeroIdentificacion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RichTextBox textBox_descripcion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_buscar;
    }
}