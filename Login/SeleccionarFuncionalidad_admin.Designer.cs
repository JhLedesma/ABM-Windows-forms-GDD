namespace FrbaHotel.Login
{
    partial class SeleccionarFuncionalidad_admin
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
            this.boton_abm_hotel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(28, 392);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 11;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            // 
            // boton_abm_hotel
            // 
            this.boton_abm_hotel.Location = new System.Drawing.Point(73, 52);
            this.boton_abm_hotel.Margin = new System.Windows.Forms.Padding(2);
            this.boton_abm_hotel.Name = "boton_abm_hotel";
            this.boton_abm_hotel.Size = new System.Drawing.Size(125, 19);
            this.boton_abm_hotel.TabIndex = 10;
            this.boton_abm_hotel.Text = "ABM Hotel";
            this.boton_abm_hotel.UseVisualStyleBackColor = true;
            this.boton_abm_hotel.Click += new System.EventHandler(this.boton_abm_hotel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Altas, bajas y modificaciones de roles de hoteles";
            // 
            // SeleccionarFuncionalidad_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 431);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.boton_abm_hotel);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionarFuncionalidad_admin";
            this.Text = "SeleccionarFuncionalidad_admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Button boton_abm_hotel;
        private System.Windows.Forms.Label label1;
    }
}