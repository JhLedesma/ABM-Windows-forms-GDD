namespace FrbaHotel.GenerarModificacionReserva
{
    partial class AgregarHabitacion
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
            this.btnAgregarHabitacion = new System.Windows.Forms.Button();
            this.listadoTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.lblTipoDeHabitacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarHabitacion
            // 
            this.btnAgregarHabitacion.Location = new System.Drawing.Point(138, 125);
            this.btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            this.btnAgregarHabitacion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarHabitacion.TabIndex = 53;
            this.btnAgregarHabitacion.Text = "Agregar";
            this.btnAgregarHabitacion.UseVisualStyleBackColor = true;
            this.btnAgregarHabitacion.Click += new System.EventHandler(this.btnAgregarHabitacion_Click);
            // 
            // listadoTipoHabitacion
            // 
            this.listadoTipoHabitacion.FormattingEnabled = true;
            this.listadoTipoHabitacion.Location = new System.Drawing.Point(163, 48);
            this.listadoTipoHabitacion.Name = "listadoTipoHabitacion";
            this.listadoTipoHabitacion.Size = new System.Drawing.Size(125, 21);
            this.listadoTipoHabitacion.TabIndex = 52;
            // 
            // lblTipoDeHabitacion
            // 
            this.lblTipoDeHabitacion.AutoSize = true;
            this.lblTipoDeHabitacion.Location = new System.Drawing.Point(14, 52);
            this.lblTipoDeHabitacion.Name = "lblTipoDeHabitacion";
            this.lblTipoDeHabitacion.Size = new System.Drawing.Size(129, 13);
            this.lblTipoDeHabitacion.TabIndex = 51;
            this.lblTipoDeHabitacion.Text = "Habitaciones Disponibles:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listadoTipoHabitacion);
            this.groupBox1.Controls.Add(this.lblTipoDeHabitacion);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 106);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una habitacion a reservar";
            // 
            // AgregarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 156);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarHabitacion);
            this.Name = "AgregarHabitacion";
            this.Text = "AgregarHabitacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarHabitacion;
        private System.Windows.Forms.ComboBox listadoTipoHabitacion;
        private System.Windows.Forms.Label lblTipoDeHabitacion;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}