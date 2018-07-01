namespace FrbaHotel.RegistrarEstadia
{
    partial class Check_out
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
            this.boton_continuar = new System.Windows.Forms.Button();
            this.numeric_textBox_reserva = new FrbaHotel.Model.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(32, 116);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 7;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            // 
            // boton_continuar
            // 
            this.boton_continuar.Location = new System.Drawing.Point(180, 116);
            this.boton_continuar.Name = "boton_continuar";
            this.boton_continuar.Size = new System.Drawing.Size(75, 23);
            this.boton_continuar.TabIndex = 6;
            this.boton_continuar.Text = "Continuar";
            this.boton_continuar.UseVisualStyleBackColor = true;
            this.boton_continuar.Click += new System.EventHandler(this.boton_continuar_Click);
            // 
            // numeric_textBox_reserva
            // 
            this.numeric_textBox_reserva.AllowSpace = false;
            this.numeric_textBox_reserva.Location = new System.Drawing.Point(93, 62);
            this.numeric_textBox_reserva.Name = "numeric_textBox_reserva";
            this.numeric_textBox_reserva.Size = new System.Drawing.Size(100, 20);
            this.numeric_textBox_reserva.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el numero de reserva correspondiente:";
            // 
            // Check_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 172);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.boton_continuar);
            this.Controls.Add(this.numeric_textBox_reserva);
            this.Controls.Add(this.label1);
            this.Name = "Check_out";
            this.Text = "Check_out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Button boton_continuar;
        private Model.NumericTextBox numeric_textBox_reserva;
        private System.Windows.Forms.Label label1;
    }
}