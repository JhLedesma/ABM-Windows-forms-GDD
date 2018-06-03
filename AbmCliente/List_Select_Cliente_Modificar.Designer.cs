namespace FrbaHotel.AbmCliente
{
    partial class List_Select_Cliente_Modificar
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dataGridModificar = new System.Windows.Forms.DataGridView();
            this.lblFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxBusquedaCliente = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroIdentificacion = new System.Windows.Forms.Label();
            this.lblTipoIndentificacion = new System.Windows.Forms.Label();
            this.listadoTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.filtroMail = new System.Windows.Forms.TextBox();
            this.filtroApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.filtroNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModificar)).BeginInit();
            this.gBoxBusquedaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(72, 465);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 23;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(405, 465);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dataGridModificar
            // 
            this.dataGridModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridModificar.Location = new System.Drawing.Point(12, 246);
            this.dataGridModificar.Name = "dataGridModificar";
            this.dataGridModificar.Size = new System.Drawing.Size(531, 188);
            this.dataGridModificar.TabIndex = 21;
            this.dataGridModificar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridModificar_CellClick);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Location = new System.Drawing.Point(405, 178);
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
            this.label1.Location = new System.Drawing.Point(30, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Seleccione la fila del cliente que desee modificar:";
            // 
            // gBoxBusquedaCliente
            // 
            this.gBoxBusquedaCliente.Controls.Add(this.numericUpDown1);
            this.gBoxBusquedaCliente.Controls.Add(this.lblNumeroIdentificacion);
            this.gBoxBusquedaCliente.Controls.Add(this.lblTipoIndentificacion);
            this.gBoxBusquedaCliente.Controls.Add(this.listadoTipoIdentificacion);
            this.gBoxBusquedaCliente.Controls.Add(this.lblMail);
            this.gBoxBusquedaCliente.Controls.Add(this.filtroMail);
            this.gBoxBusquedaCliente.Controls.Add(this.filtroApellido);
            this.gBoxBusquedaCliente.Controls.Add(this.lblApellido);
            this.gBoxBusquedaCliente.Controls.Add(this.lblNombre);
            this.gBoxBusquedaCliente.Controls.Add(this.filtroNombre);
            this.gBoxBusquedaCliente.Location = new System.Drawing.Point(12, 20);
            this.gBoxBusquedaCliente.Name = "gBoxBusquedaCliente";
            this.gBoxBusquedaCliente.Size = new System.Drawing.Size(531, 136);
            this.gBoxBusquedaCliente.TabIndex = 18;
            this.gBoxBusquedaCliente.TabStop = false;
            this.gBoxBusquedaCliente.Text = "Busqueda de Cliente";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(393, 67);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1241513984,
            370409800,
            542101,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
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
            // List_Select_Cliente_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 508);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridModificar);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBoxBusquedaCliente);
            this.Name = "List_Select_Cliente_Modificar";
            this.Text = "List_Select_Cliente_Modificar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModificar)).EndInit();
            this.gBoxBusquedaCliente.ResumeLayout(false);
            this.gBoxBusquedaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dataGridModificar;
        private System.Windows.Forms.Button lblFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxBusquedaCliente;
        private System.Windows.Forms.Label lblNumeroIdentificacion;
        private System.Windows.Forms.Label lblTipoIndentificacion;
        private System.Windows.Forms.ComboBox listadoTipoIdentificacion;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox filtroMail;
        private System.Windows.Forms.TextBox filtroApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox filtroNombre;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}