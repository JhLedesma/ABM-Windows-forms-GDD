namespace FrbaHotel.AbmHabitacion
{
    partial class Modificar_Habitacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_descripcion = new System.Windows.Forms.RichTextBox();
            this.numericTextBox_piso = new FrbaHotel.Model.NumericTextBox();
            this.numericTextBox_numeroHab = new FrbaHotel.Model.NumericTextBox();
            this.comboBox_ubicacion = new System.Windows.Forms.ComboBox();
            this.lblNumeroIdentificacion = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox_idHotel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_idHotel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_descripcion);
            this.groupBox1.Controls.Add(this.numericTextBox_piso);
            this.groupBox1.Controls.Add(this.numericTextBox_numeroHab);
            this.groupBox1.Controls.Add(this.comboBox_ubicacion);
            this.groupBox1.Controls.Add(this.lblNumeroIdentificacion);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 324);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifique los datos que desee";
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
            this.textBox_descripcion.Location = new System.Drawing.Point(9, 210);
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(363, 96);
            this.textBox_descripcion.TabIndex = 60;
            this.textBox_descripcion.Text = "";
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
            this.lblNumeroIdentificacion.Location = new System.Drawing.Point(6, 180);
            this.lblNumeroIdentificacion.Name = "lblNumeroIdentificacion";
            this.lblNumeroIdentificacion.Size = new System.Drawing.Size(135, 13);
            this.lblNumeroIdentificacion.TabIndex = 10;
            this.lblNumeroIdentificacion.Text = "Descripcion, comodidades:";
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
            // textBox_idHotel
            // 
            this.textBox_idHotel.Location = new System.Drawing.Point(146, 30);
            this.textBox_idHotel.Name = "textBox_idHotel";
            this.textBox_idHotel.Size = new System.Drawing.Size(118, 20);
            this.textBox_idHotel.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Modificar_Habitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 402);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Modificar_Habitacion";
            this.Text = "Modificar Habitacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_idHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBox_descripcion;
        private Model.NumericTextBox numericTextBox_piso;
        private Model.NumericTextBox numericTextBox_numeroHab;
        private System.Windows.Forms.ComboBox comboBox_ubicacion;
        private System.Windows.Forms.Label lblNumeroIdentificacion;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}