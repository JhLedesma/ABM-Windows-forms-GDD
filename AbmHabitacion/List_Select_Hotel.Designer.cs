namespace FrbaHotel.AbmHabitacion
{
    partial class List_Select_Hotel
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
            this.textBox_pais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericTextBox_estrellas = new FrbaHotel.Model.NumericTextBox();
            this.lblNumeroIdentificacion = new System.Windows.Forms.Label();
            this.textBox_ciudad = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.filtroNombre = new System.Windows.Forms.TextBox();
            this.boton_volver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.boton_seleccionar = new System.Windows.Forms.Button();
            this.dataGridHoteles = new System.Windows.Forms.DataGridView();
            this.gBoxBusquedaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxBusquedaCliente
            // 
            this.gBoxBusquedaCliente.Controls.Add(this.textBox_pais);
            this.gBoxBusquedaCliente.Controls.Add(this.label1);
            this.gBoxBusquedaCliente.Controls.Add(this.numericTextBox_estrellas);
            this.gBoxBusquedaCliente.Controls.Add(this.lblNumeroIdentificacion);
            this.gBoxBusquedaCliente.Controls.Add(this.textBox_ciudad);
            this.gBoxBusquedaCliente.Controls.Add(this.lblApellido);
            this.gBoxBusquedaCliente.Controls.Add(this.lblNombre);
            this.gBoxBusquedaCliente.Controls.Add(this.filtroNombre);
            this.gBoxBusquedaCliente.Location = new System.Drawing.Point(12, 12);
            this.gBoxBusquedaCliente.Name = "gBoxBusquedaCliente";
            this.gBoxBusquedaCliente.Size = new System.Drawing.Size(531, 99);
            this.gBoxBusquedaCliente.TabIndex = 21;
            this.gBoxBusquedaCliente.TabStop = false;
            this.gBoxBusquedaCliente.Text = "Busqueda de Hotel";
            // 
            // textBox_pais
            // 
            this.textBox_pais.Location = new System.Drawing.Point(393, 66);
            this.textBox_pais.Name = "textBox_pais";
            this.textBox_pais.Size = new System.Drawing.Size(120, 20);
            this.textBox_pais.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "País";
            // 
            // numericTextBox_estrellas
            // 
            this.numericTextBox_estrellas.AllowSpace = false;
            this.numericTextBox_estrellas.Location = new System.Drawing.Point(393, 34);
            this.numericTextBox_estrellas.Name = "numericTextBox_estrellas";
            this.numericTextBox_estrellas.Size = new System.Drawing.Size(120, 20);
            this.numericTextBox_estrellas.TabIndex = 12;
            // 
            // lblNumeroIdentificacion
            // 
            this.lblNumeroIdentificacion.AutoSize = true;
            this.lblNumeroIdentificacion.Location = new System.Drawing.Point(262, 37);
            this.lblNumeroIdentificacion.Name = "lblNumeroIdentificacion";
            this.lblNumeroIdentificacion.Size = new System.Drawing.Size(105, 13);
            this.lblNumeroIdentificacion.TabIndex = 9;
            this.lblNumeroIdentificacion.Text = "Cantidad de estrellas";
            // 
            // textBox_ciudad
            // 
            this.textBox_ciudad.Location = new System.Drawing.Point(60, 66);
            this.textBox_ciudad.Name = "textBox_ciudad";
            this.textBox_ciudad.Size = new System.Drawing.Size(100, 20);
            this.textBox_ciudad.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 69);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(40, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Ciudad";
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
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(23, 490);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(120, 23);
            this.boton_volver.TabIndex = 30;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Listado de los hoteles filtrados:";
            // 
            // button_filtrar
            // 
            this.button_filtrar.Location = new System.Drawing.Point(407, 123);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(120, 23);
            this.button_filtrar.TabIndex = 27;
            this.button_filtrar.Text = "Filtrar";
            this.button_filtrar.UseVisualStyleBackColor = true;
            this.button_filtrar.Click += new System.EventHandler(this.button_filtrar_Click);
            // 
            // boton_seleccionar
            // 
            this.boton_seleccionar.Location = new System.Drawing.Point(405, 490);
            this.boton_seleccionar.Name = "boton_seleccionar";
            this.boton_seleccionar.Size = new System.Drawing.Size(120, 23);
            this.boton_seleccionar.TabIndex = 31;
            this.boton_seleccionar.Text = "Seleccionar";
            this.boton_seleccionar.UseVisualStyleBackColor = true;
            this.boton_seleccionar.Click += new System.EventHandler(this.boton_seleccionar_Click);
            // 
            // dataGridHoteles
            // 
            this.dataGridHoteles.AllowUserToAddRows = false;
            this.dataGridHoteles.AllowUserToDeleteRows = false;
            this.dataGridHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHoteles.Location = new System.Drawing.Point(14, 199);
            this.dataGridHoteles.Name = "dataGridHoteles";
            this.dataGridHoteles.ReadOnly = true;
            this.dataGridHoteles.Size = new System.Drawing.Size(531, 274);
            this.dataGridHoteles.TabIndex = 29;
            this.dataGridHoteles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHoteles_CellClick);
            // 
            // List_Select_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 526);
            this.Controls.Add(this.boton_seleccionar);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.dataGridHoteles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_filtrar);
            this.Controls.Add(this.gBoxBusquedaCliente);
            this.Name = "List_Select_Hotel";
            this.Text = "List_Select_Hotel";
            this.gBoxBusquedaCliente.ResumeLayout(false);
            this.gBoxBusquedaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHoteles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxBusquedaCliente;
        private System.Windows.Forms.TextBox textBox_pais;
        private System.Windows.Forms.Label label1;
        private Model.NumericTextBox numericTextBox_estrellas;
        private System.Windows.Forms.Label lblNumeroIdentificacion;
        private System.Windows.Forms.TextBox textBox_ciudad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox filtroNombre;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_filtrar;
        private System.Windows.Forms.Button boton_seleccionar;
        private System.Windows.Forms.DataGridView dataGridHoteles;
    }
}