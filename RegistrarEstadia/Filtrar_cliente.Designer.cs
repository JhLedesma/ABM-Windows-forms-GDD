namespace FrbaHotel.RegistrarEstadia
{
    partial class Filtrar_cliente
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
            this.boton_agregar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxBusquedaCliente = new System.Windows.Forms.GroupBox();
            this.lblNumeroIdentificacion = new System.Windows.Forms.Label();
            this.filtroNumeroIdentificacion = new System.Windows.Forms.NumericUpDown();
            this.lblTipoIndentificacion = new System.Windows.Forms.Label();
            this.listadoTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.filtroMail = new System.Windows.Forms.TextBox();
            this.filtroApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.filtroNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBoxBusquedaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtroNumeroIdentificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_agregar
            // 
            this.boton_agregar.Location = new System.Drawing.Point(405, 457);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(75, 23);
            this.boton_agregar.TabIndex = 23;
            this.boton_agregar.Text = "Agregar";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(72, 457);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 188);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Location = new System.Drawing.Point(405, 170);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(120, 23);
            this.lblFiltrar.TabIndex = 20;
            this.lblFiltrar.Text = "Filtrar";
            this.lblFiltrar.UseVisualStyleBackColor = true;
            this.lblFiltrar.Click += new System.EventHandler(this.lblFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Seleccione la fila del cliente que desee eliminar:";
            // 
            // gBoxBusquedaCliente
            // 
            this.gBoxBusquedaCliente.Controls.Add(this.lblNumeroIdentificacion);
            this.gBoxBusquedaCliente.Controls.Add(this.filtroNumeroIdentificacion);
            this.gBoxBusquedaCliente.Controls.Add(this.lblTipoIndentificacion);
            this.gBoxBusquedaCliente.Controls.Add(this.listadoTipoIdentificacion);
            this.gBoxBusquedaCliente.Controls.Add(this.lblMail);
            this.gBoxBusquedaCliente.Controls.Add(this.filtroMail);
            this.gBoxBusquedaCliente.Controls.Add(this.filtroApellido);
            this.gBoxBusquedaCliente.Controls.Add(this.lblApellido);
            this.gBoxBusquedaCliente.Controls.Add(this.lblNombre);
            this.gBoxBusquedaCliente.Controls.Add(this.filtroNombre);
            this.gBoxBusquedaCliente.Location = new System.Drawing.Point(12, 12);
            this.gBoxBusquedaCliente.Name = "gBoxBusquedaCliente";
            this.gBoxBusquedaCliente.Size = new System.Drawing.Size(531, 136);
            this.gBoxBusquedaCliente.TabIndex = 18;
            this.gBoxBusquedaCliente.TabStop = false;
            this.gBoxBusquedaCliente.Text = "Busqueda de Cliente";
            // 
            // lblNumeroIdentificacion
            // 
            this.lblNumeroIdentificacion.AutoSize = true;
            this.lblNumeroIdentificacion.Location = new System.Drawing.Point(262, 70);
            this.lblNumeroIdentificacion.Name = "lblNumeroIdentificacion";
            this.lblNumeroIdentificacion.Size = new System.Drawing.Size(125, 13);
            this.lblNumeroIdentificacion.TabIndex = 9;
            this.lblNumeroIdentificacion.Text = "Numero de Identificacion";
            // 
            // filtroNumeroIdentificacion
            // 
            this.filtroNumeroIdentificacion.Location = new System.Drawing.Point(393, 67);
            this.filtroNumeroIdentificacion.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.filtroNumeroIdentificacion.Name = "filtroNumeroIdentificacion";
            this.filtroNumeroIdentificacion.Size = new System.Drawing.Size(120, 20);
            this.filtroNumeroIdentificacion.TabIndex = 8;
            // 
            // lblTipoIndentificacion
            // 
            this.lblTipoIndentificacion.AutoSize = true;
            this.lblTipoIndentificacion.Location = new System.Drawing.Point(262, 38);
            this.lblTipoIndentificacion.Name = "lblTipoIndentificacion";
            this.lblTipoIndentificacion.Size = new System.Drawing.Size(109, 13);
            this.lblTipoIndentificacion.TabIndex = 7;
            this.lblTipoIndentificacion.Text = "Tipo de Identificacion";
            // 
            // listadoTipoIdentificacion
            // 
            this.listadoTipoIdentificacion.FormattingEnabled = true;
            this.listadoTipoIdentificacion.Location = new System.Drawing.Point(393, 35);
            this.listadoTipoIdentificacion.Name = "listadoTipoIdentificacion";
            this.listadoTipoIdentificacion.Size = new System.Drawing.Size(121, 21);
            this.listadoTipoIdentificacion.TabIndex = 6;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 104);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "Mail";
            // 
            // filtroMail
            // 
            this.filtroMail.Location = new System.Drawing.Point(60, 101);
            this.filtroMail.Name = "filtroMail";
            this.filtroMail.Size = new System.Drawing.Size(100, 20);
            this.filtroMail.TabIndex = 4;
            // 
            // filtroApellido
            // 
            this.filtroApellido.Location = new System.Drawing.Point(60, 66);
            this.filtroApellido.Name = "filtroApellido";
            this.filtroApellido.Size = new System.Drawing.Size(100, 20);
            this.filtroApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 69);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // filtroNombre
            // 
            this.filtroNombre.Location = new System.Drawing.Point(60, 34);
            this.filtroNombre.Name = "filtroNombre";
            this.filtroNombre.Size = new System.Drawing.Size(100, 20);
            this.filtroNombre.TabIndex = 0;
            // 
            // Filtrar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 498);
            this.Controls.Add(this.boton_agregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBoxBusquedaCliente);
            this.Name = "Filtrar_cliente";
            this.Text = "Filtrar_cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBoxBusquedaCliente.ResumeLayout(false);
            this.gBoxBusquedaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtroNumeroIdentificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button lblFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxBusquedaCliente;
        private System.Windows.Forms.Label lblNumeroIdentificacion;
        private System.Windows.Forms.NumericUpDown filtroNumeroIdentificacion;
        private System.Windows.Forms.Label lblTipoIndentificacion;
        private System.Windows.Forms.ComboBox listadoTipoIdentificacion;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox filtroMail;
        private System.Windows.Forms.TextBox filtroApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox filtroNombre;
    }
}