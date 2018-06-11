namespace FrbaHotel.AbmHotel
{
    partial class Crear_Hotel
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
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_regimen = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_pais = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_ciudad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_calle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boton_crearHotel = new System.Windows.Forms.Button();
            this.boton_volver = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.numericTextBox_porc_est = new FrbaHotel.Model.NumericTextBox();
            this.numericTextBox_nroCalle = new FrbaHotel.Model.NumericTextBox();
            this.numericTextBox_telefono = new FrbaHotel.Model.NumericTextBox();
            this.numericTextBox_estrellas = new FrbaHotel.Model.NumericTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese los datos del nuevo hotel (todos los campos son obligatorios):";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(93, 43);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(129, 20);
            this.textBox_nombre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(93, 80);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(129, 20);
            this.textBox_mail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estrellas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Régimen:";
            // 
            // comboBox_regimen
            // 
            this.comboBox_regimen.FormattingEnabled = true;
            this.comboBox_regimen.Location = new System.Drawing.Point(93, 228);
            this.comboBox_regimen.Name = "comboBox_regimen";
            this.comboBox_regimen.Size = new System.Drawing.Size(129, 21);
            this.comboBox_regimen.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_pais);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_ciudad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numericTextBox_nroCalle);
            this.groupBox1.Controls.Add(this.textBox_calle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(15, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 199);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dirección";
            // 
            // textBox_pais
            // 
            this.textBox_pais.Location = new System.Drawing.Point(78, 152);
            this.textBox_pais.Name = "textBox_pais";
            this.textBox_pais.Size = new System.Drawing.Size(129, 20);
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
            this.textBox_ciudad.Location = new System.Drawing.Point(78, 113);
            this.textBox_ciudad.Name = "textBox_ciudad";
            this.textBox_ciudad.Size = new System.Drawing.Size(129, 20);
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
            // textBox_calle
            // 
            this.textBox_calle.Location = new System.Drawing.Point(78, 35);
            this.textBox_calle.Name = "textBox_calle";
            this.textBox_calle.Size = new System.Drawing.Size(129, 20);
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
            // boton_crearHotel
            // 
            this.boton_crearHotel.Location = new System.Drawing.Point(255, 496);
            this.boton_crearHotel.Name = "boton_crearHotel";
            this.boton_crearHotel.Size = new System.Drawing.Size(75, 23);
            this.boton_crearHotel.TabIndex = 17;
            this.boton_crearHotel.Text = "Crear";
            this.boton_crearHotel.UseVisualStyleBackColor = true;
            this.boton_crearHotel.Click += new System.EventHandler(this.boton_crearHotel_Click);
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(25, 496);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 18;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Recarga est:";
            // 
            // boton_agregar
            // 
            this.boton_agregar.Location = new System.Drawing.Point(255, 226);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(75, 23);
            this.boton_agregar.TabIndex = 21;
            this.boton_agregar.Text = "Agregar";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // numericTextBox_porc_est
            // 
            this.numericTextBox_porc_est.AllowSpace = false;
            this.numericTextBox_porc_est.Location = new System.Drawing.Point(93, 191);
            this.numericTextBox_porc_est.Name = "numericTextBox_porc_est";
            this.numericTextBox_porc_est.Size = new System.Drawing.Size(129, 20);
            this.numericTextBox_porc_est.TabIndex = 20;
            // 
            // numericTextBox_nroCalle
            // 
            this.numericTextBox_nroCalle.AllowSpace = false;
            this.numericTextBox_nroCalle.Location = new System.Drawing.Point(78, 74);
            this.numericTextBox_nroCalle.Name = "numericTextBox_nroCalle";
            this.numericTextBox_nroCalle.Size = new System.Drawing.Size(129, 20);
            this.numericTextBox_nroCalle.TabIndex = 10;
            // 
            // numericTextBox_telefono
            // 
            this.numericTextBox_telefono.AllowSpace = false;
            this.numericTextBox_telefono.Location = new System.Drawing.Point(93, 117);
            this.numericTextBox_telefono.Name = "numericTextBox_telefono";
            this.numericTextBox_telefono.Size = new System.Drawing.Size(129, 20);
            this.numericTextBox_telefono.TabIndex = 13;
            // 
            // numericTextBox_estrellas
            // 
            this.numericTextBox_estrellas.AllowSpace = false;
            this.numericTextBox_estrellas.Location = new System.Drawing.Point(93, 154);
            this.numericTextBox_estrellas.Name = "numericTextBox_estrellas";
            this.numericTextBox_estrellas.Size = new System.Drawing.Size(129, 20);
            this.numericTextBox_estrellas.TabIndex = 12;
            // 
            // CrearHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 536);
            this.Controls.Add(this.boton_agregar);
            this.Controls.Add(this.numericTextBox_porc_est);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.boton_crearHotel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_regimen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericTextBox_telefono);
            this.Controls.Add(this.numericTextBox_estrellas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearHotel";
            this.Text = "CrearHotel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Model.NumericTextBox numericTextBox_estrellas;
        private Model.NumericTextBox numericTextBox_telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_regimen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_pais;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_ciudad;
        private System.Windows.Forms.Label label9;
        private Model.NumericTextBox numericTextBox_nroCalle;
        private System.Windows.Forms.TextBox textBox_calle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button boton_crearHotel;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Label label11;
        private Model.NumericTextBox numericTextBox_porc_est;
        private System.Windows.Forms.Button boton_agregar;
    }
}