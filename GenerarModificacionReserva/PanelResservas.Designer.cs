namespace FrbaHotel.GenerarModificacionReserva
{
    partial class PanelResservas
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
            this.boton_volver = new System.Windows.Forms.Button();
            this.boton_modificar = new System.Windows.Forms.Button();
            this.boton_reservar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(12, 243);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(68, 23);
            this.boton_volver.TabIndex = 9;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // boton_modificar
            // 
            this.boton_modificar.Location = new System.Drawing.Point(108, 169);
            this.boton_modificar.Name = "boton_modificar";
            this.boton_modificar.Size = new System.Drawing.Size(108, 23);
            this.boton_modificar.TabIndex = 8;
            this.boton_modificar.Text = "Modificar Reserva";
            this.boton_modificar.UseVisualStyleBackColor = true;
            this.boton_modificar.Click += new System.EventHandler(this.boton_modificar_Click);
            // 
            // boton_reservar
            // 
            this.boton_reservar.Location = new System.Drawing.Point(108, 76);
            this.boton_reservar.Name = "boton_reservar";
            this.boton_reservar.Size = new System.Drawing.Size(108, 23);
            this.boton_reservar.TabIndex = 7;
            this.boton_reservar.Text = "Reservar";
            this.boton_reservar.UseVisualStyleBackColor = true;
            this.boton_reservar.Click += new System.EventHandler(this.boton_reservar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modificar una reserva realizada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Realizar una reserva en un hotel de la cadena:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boton_modificar);
            this.groupBox1.Controls.Add(this.boton_reservar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 225);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elija Opcion";
            // 
            // PanelResservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 273);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.groupBox1);
            this.Name = "PanelResservas";
            this.Text = "PanelResservas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Button boton_modificar;
        private System.Windows.Forms.Button boton_reservar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}