namespace FrbaHotel.AbmUsuario
{
    partial class Crear_Usuario
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
            this.ListadoRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.numericTelefono = new System.Windows.Forms.NumericUpDown();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.listadoTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.lblTipoIndentificacion = new System.Windows.Forms.Label();
            this.numericNumeroIdentificacion = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroIdentificacion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDpto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.numericPiso = new System.Windows.Forms.NumericUpDown();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.numericNumero = new System.Windows.Forms.NumericUpDown();
            this.lblNumero = new System.Windows.Forms.Label();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgregarHotel = new System.Windows.Forms.Button();
            this.listadoHoteles = new System.Windows.Forms.ComboBox();
            this.lblHoteles = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeroIdentificacion)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumero)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListadoRol);
            this.groupBox1.Controls.Add(this.lblRol);
            this.groupBox1.Controls.Add(this.lblPass);
            this.groupBox1.Controls.Add(this.tbPass);
            this.groupBox1.Controls.Add(this.numericTelefono);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.dtFechaNacimiento);
            this.groupBox1.Controls.Add(this.lblFechaNacimiento);
            this.groupBox1.Controls.Add(this.listadoTipoIdentificacion);
            this.groupBox1.Controls.Add(this.lblTipoIndentificacion);
            this.groupBox1.Controls.Add(this.numericNumeroIdentificacion);
            this.groupBox1.Controls.Add(this.lblNumeroIdentificacion);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.tbMail);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.tbApellido);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 372);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos del nuevo usuario (todos los datos son obligatorios):";
            // 
            // ListadoRol
            // 
            this.ListadoRol.FormattingEnabled = true;
            this.ListadoRol.Location = new System.Drawing.Point(157, 108);
            this.ListadoRol.Name = "ListadoRol";
            this.ListadoRol.Size = new System.Drawing.Size(118, 21);
            this.ListadoRol.TabIndex = 62;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(18, 111);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 13);
            this.lblRol.TabIndex = 62;
            this.lblRol.Text = "Rol:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(17, 78);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(56, 13);
            this.lblPass.TabIndex = 58;
            this.lblPass.Text = "Password:";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(157, 75);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(118, 20);
            this.tbPass.TabIndex = 57;
            // 
            // numericTelefono
            // 
            this.numericTelefono.Location = new System.Drawing.Point(157, 241);
            this.numericTelefono.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numericTelefono.Name = "numericTelefono";
            this.numericTelefono.Size = new System.Drawing.Size(118, 20);
            this.numericTelefono.TabIndex = 56;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(157, 43);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(118, 20);
            this.tbUsername.TabIndex = 19;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(17, 43);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "Username:";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Location = new System.Drawing.Point(158, 338);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtFechaNacimiento.TabIndex = 17;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(18, 344);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 16;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // listadoTipoIdentificacion
            // 
            this.listadoTipoIdentificacion.FormattingEnabled = true;
            this.listadoTipoIdentificacion.Location = new System.Drawing.Point(157, 304);
            this.listadoTipoIdentificacion.Name = "listadoTipoIdentificacion";
            this.listadoTipoIdentificacion.Size = new System.Drawing.Size(118, 21);
            this.listadoTipoIdentificacion.TabIndex = 13;
            // 
            // lblTipoIndentificacion
            // 
            this.lblTipoIndentificacion.AutoSize = true;
            this.lblTipoIndentificacion.Location = new System.Drawing.Point(17, 307);
            this.lblTipoIndentificacion.Name = "lblTipoIndentificacion";
            this.lblTipoIndentificacion.Size = new System.Drawing.Size(112, 13);
            this.lblTipoIndentificacion.TabIndex = 12;
            this.lblTipoIndentificacion.Text = "Tipo de Identificacion:";
            // 
            // numericNumeroIdentificacion
            // 
            this.numericNumeroIdentificacion.Location = new System.Drawing.Point(158, 273);
            this.numericNumeroIdentificacion.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numericNumeroIdentificacion.Name = "numericNumeroIdentificacion";
            this.numericNumeroIdentificacion.Size = new System.Drawing.Size(117, 20);
            this.numericNumeroIdentificacion.TabIndex = 11;
            // 
            // lblNumeroIdentificacion
            // 
            this.lblNumeroIdentificacion.AutoSize = true;
            this.lblNumeroIdentificacion.Location = new System.Drawing.Point(17, 275);
            this.lblNumeroIdentificacion.Name = "lblNumeroIdentificacion";
            this.lblNumeroIdentificacion.Size = new System.Drawing.Size(128, 13);
            this.lblNumeroIdentificacion.TabIndex = 10;
            this.lblNumeroIdentificacion.Text = "Numero de Identificacion:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(17, 243);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono:";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(158, 206);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(117, 20);
            this.tbMail.TabIndex = 7;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(17, 209);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Mail:";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(158, 174);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(117, 20);
            this.tbApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(17, 177);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(158, 140);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(117, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 143);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(29, 663);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 47;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDpto);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lblCiudad);
            this.groupBox2.Controls.Add(this.tbPais);
            this.groupBox2.Controls.Add(this.lblPais);
            this.groupBox2.Controls.Add(this.tbLocalidad);
            this.groupBox2.Controls.Add(this.lblLocalidad);
            this.groupBox2.Controls.Add(this.numericPiso);
            this.groupBox2.Controls.Add(this.lblPiso);
            this.groupBox2.Controls.Add(this.lblDepartamento);
            this.groupBox2.Controls.Add(this.numericNumero);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Controls.Add(this.tbCalle);
            this.groupBox2.Controls.Add(this.lblCalle);
            this.groupBox2.Location = new System.Drawing.Point(12, 484);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 165);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Direccion";
            // 
            // tbDpto
            // 
            this.tbDpto.Location = new System.Drawing.Point(295, 59);
            this.tbDpto.Name = "tbDpto";
            this.tbDpto.Size = new System.Drawing.Size(68, 20);
            this.tbDpto.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 55;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(23, 100);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 54;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(85, 133);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(130, 20);
            this.tbPais.TabIndex = 53;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(23, 136);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 52;
            this.lblPais.Text = "Pais:";
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(85, 60);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(130, 20);
            this.tbLocalidad.TabIndex = 51;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(23, 62);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 50;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // numericPiso
            // 
            this.numericPiso.Location = new System.Drawing.Point(295, 98);
            this.numericPiso.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numericPiso.Name = "numericPiso";
            this.numericPiso.Size = new System.Drawing.Size(68, 20);
            this.numericPiso.TabIndex = 49;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(237, 100);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 47;
            this.lblPiso.Text = "Piso:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(237, 62);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(27, 13);
            this.lblDepartamento.TabIndex = 46;
            this.lblDepartamento.Text = "Dto:";
            // 
            // numericNumero
            // 
            this.numericNumero.Location = new System.Drawing.Point(295, 25);
            this.numericNumero.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numericNumero.Name = "numericNumero";
            this.numericNumero.Size = new System.Drawing.Size(68, 20);
            this.numericNumero.TabIndex = 45;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(237, 27);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 44;
            this.lblNumero.Text = "Numero:";
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(85, 25);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(130, 20);
            this.tbCalle.TabIndex = 43;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(23, 27);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 42;
            this.lblCalle.Text = "Calle:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(307, 663);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 45;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(171, 663);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 44;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAgregarHotel);
            this.groupBox3.Controls.Add(this.listadoHoteles);
            this.groupBox3.Controls.Add(this.lblHoteles);
            this.groupBox3.Location = new System.Drawing.Point(12, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 88);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hoteles donde se desempeña";
            // 
            // btnAgregarHotel
            // 
            this.btnAgregarHotel.Location = new System.Drawing.Point(240, 39);
            this.btnAgregarHotel.Name = "btnAgregarHotel";
            this.btnAgregarHotel.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarHotel.TabIndex = 49;
            this.btnAgregarHotel.Text = "Agregar";
            this.btnAgregarHotel.UseVisualStyleBackColor = true;
            this.btnAgregarHotel.Click += new System.EventHandler(this.btnAgregarHotel_Click);
            // 
            // listadoHoteles
            // 
            this.listadoHoteles.FormattingEnabled = true;
            this.listadoHoteles.Location = new System.Drawing.Point(85, 40);
            this.listadoHoteles.Name = "listadoHoteles";
            this.listadoHoteles.Size = new System.Drawing.Size(118, 21);
            this.listadoHoteles.TabIndex = 60;
            // 
            // lblHoteles
            // 
            this.lblHoteles.AutoSize = true;
            this.lblHoteles.Location = new System.Drawing.Point(23, 43);
            this.lblHoteles.Name = "lblHoteles";
            this.lblHoteles.Size = new System.Drawing.Size(46, 13);
            this.lblHoteles.TabIndex = 59;
            this.lblHoteles.Text = "Hoteles:";
            // 
            // Crear_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 693);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Crear_Usuario";
            this.Text = "Crear_Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumeroIdentificacion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumero)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.NumericUpDown numericTelefono;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.ComboBox listadoTipoIdentificacion;
        private System.Windows.Forms.Label lblTipoIndentificacion;
        private System.Windows.Forms.NumericUpDown numericNumeroIdentificacion;
        private System.Windows.Forms.Label lblNumeroIdentificacion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox ListadoRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDpto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.NumericUpDown numericPiso;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.NumericUpDown numericNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgregarHotel;
        private System.Windows.Forms.ComboBox listadoHoteles;
        private System.Windows.Forms.Label lblHoteles;
    }
}