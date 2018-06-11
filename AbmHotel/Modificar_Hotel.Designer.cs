namespace FrbaHotel.AbmHotel
{
    partial class Modificar_Hotel
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boton_quitar = new System.Windows.Forms.Button();
            this.comboBox_regimenesAct = new System.Windows.Forms.ComboBox();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.comboBox_regimenes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericTextBox_porc_est = new FrbaHotel.Model.NumericTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericTextBox_estrellas = new FrbaHotel.Model.NumericTextBox();
            this.numericTextBox_telefono = new FrbaHotel.Model.NumericTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_pais = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_ciudad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericTextBox_nroCalle = new FrbaHotel.Model.NumericTextBox();
            this.textBox_calle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boton_guardar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(86, 40);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(121, 20);
            this.textBox_nombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 77);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(29, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Mail:";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(86, 74);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(121, 20);
            this.textBox_mail.TabIndex = 5;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 109);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(52, 13);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Estrellas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boton_quitar);
            this.groupBox1.Controls.Add(this.comboBox_regimenesAct);
            this.groupBox1.Controls.Add(this.boton_agregar);
            this.groupBox1.Controls.Add(this.comboBox_regimenes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericTextBox_porc_est);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numericTextBox_estrellas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericTextBox_telefono);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.textBox_mail);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.textBox_nombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 271);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos que desea modificar del hotel:";
            // 
            // boton_quitar
            // 
            this.boton_quitar.Location = new System.Drawing.Point(225, 227);
            this.boton_quitar.Name = "boton_quitar";
            this.boton_quitar.Size = new System.Drawing.Size(75, 23);
            this.boton_quitar.TabIndex = 67;
            this.boton_quitar.Text = "Quitar";
            this.boton_quitar.UseVisualStyleBackColor = true;
            this.boton_quitar.Click += new System.EventHandler(this.boton_quitar_Click);
            // 
            // comboBox_regimenesAct
            // 
            this.comboBox_regimenesAct.FormattingEnabled = true;
            this.comboBox_regimenesAct.Location = new System.Drawing.Point(86, 229);
            this.comboBox_regimenesAct.Name = "comboBox_regimenesAct";
            this.comboBox_regimenesAct.Size = new System.Drawing.Size(121, 21);
            this.comboBox_regimenesAct.TabIndex = 66;
            // 
            // boton_agregar
            // 
            this.boton_agregar.Location = new System.Drawing.Point(225, 197);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(75, 23);
            this.boton_agregar.TabIndex = 65;
            this.boton_agregar.Text = "Agregar";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // comboBox_regimenes
            // 
            this.comboBox_regimenes.FormattingEnabled = true;
            this.comboBox_regimenes.Location = new System.Drawing.Point(86, 199);
            this.comboBox_regimenes.Name = "comboBox_regimenes";
            this.comboBox_regimenes.Size = new System.Drawing.Size(121, 21);
            this.comboBox_regimenes.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Régimen:";
            // 
            // numericTextBox_porc_est
            // 
            this.numericTextBox_porc_est.AllowSpace = false;
            this.numericTextBox_porc_est.Location = new System.Drawing.Point(86, 167);
            this.numericTextBox_porc_est.Name = "numericTextBox_porc_est";
            this.numericTextBox_porc_est.Size = new System.Drawing.Size(121, 20);
            this.numericTextBox_porc_est.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "Recarga est:";
            // 
            // numericTextBox_estrellas
            // 
            this.numericTextBox_estrellas.AllowSpace = false;
            this.numericTextBox_estrellas.Location = new System.Drawing.Point(86, 137);
            this.numericTextBox_estrellas.Name = "numericTextBox_estrellas";
            this.numericTextBox_estrellas.Size = new System.Drawing.Size(121, 20);
            this.numericTextBox_estrellas.TabIndex = 60;
            // 
            // numericTextBox_telefono
            // 
            this.numericTextBox_telefono.AllowSpace = false;
            this.numericTextBox_telefono.Location = new System.Drawing.Point(86, 106);
            this.numericTextBox_telefono.Name = "numericTextBox_telefono";
            this.numericTextBox_telefono.Size = new System.Drawing.Size(121, 20);
            this.numericTextBox_telefono.TabIndex = 58;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_pais);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_ciudad);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numericTextBox_nroCalle);
            this.groupBox2.Controls.Add(this.textBox_calle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 199);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dirección";
            // 
            // textBox_pais
            // 
            this.textBox_pais.Location = new System.Drawing.Point(86, 152);
            this.textBox_pais.Name = "textBox_pais";
            this.textBox_pais.Size = new System.Drawing.Size(121, 20);
            this.textBox_pais.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "País:";
            // 
            // textBox_ciudad
            // 
            this.textBox_ciudad.Location = new System.Drawing.Point(86, 113);
            this.textBox_ciudad.Name = "textBox_ciudad";
            this.textBox_ciudad.Size = new System.Drawing.Size(121, 20);
            this.textBox_ciudad.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ciudad:";
            // 
            // numericTextBox_nroCalle
            // 
            this.numericTextBox_nroCalle.AllowSpace = false;
            this.numericTextBox_nroCalle.Location = new System.Drawing.Point(86, 74);
            this.numericTextBox_nroCalle.Name = "numericTextBox_nroCalle";
            this.numericTextBox_nroCalle.Size = new System.Drawing.Size(121, 20);
            this.numericTextBox_nroCalle.TabIndex = 10;
            // 
            // textBox_calle
            // 
            this.textBox_calle.Location = new System.Drawing.Point(86, 35);
            this.textBox_calle.Name = "textBox_calle";
            this.textBox_calle.Size = new System.Drawing.Size(121, 20);
            this.textBox_calle.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nro Calle:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Calle:";
            // 
            // boton_guardar
            // 
            this.boton_guardar.Location = new System.Drawing.Point(267, 515);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Size = new System.Drawing.Size(75, 23);
            this.boton_guardar.TabIndex = 66;
            this.boton_guardar.Text = "Guardar";
            this.boton_guardar.UseVisualStyleBackColor = true;
            this.boton_guardar.Click += new System.EventHandler(this.boton_guardar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 67;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 515);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 68;
            this.button4.Text = "Volver";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Modificar_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 550);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.boton_guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Modificar_Hotel";
            this.Text = "Modificar_Hotel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label lblMail;
        private Model.NumericTextBox numericTextBox_telefono;
        private System.Windows.Forms.Label label5;
        private Model.NumericTextBox numericTextBox_estrellas;
        private System.Windows.Forms.GroupBox groupBox1;
        private Model.NumericTextBox numericTextBox_porc_est;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.ComboBox comboBox_regimenes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button boton_quitar;
        private System.Windows.Forms.ComboBox comboBox_regimenesAct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_pais;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_ciudad;
        private System.Windows.Forms.Label label9;
        private Model.NumericTextBox numericTextBox_nroCalle;
        private System.Windows.Forms.TextBox textBox_calle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button boton_guardar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

    }
}