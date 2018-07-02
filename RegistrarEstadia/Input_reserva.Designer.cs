namespace FrbaHotel.RegistrarEstadia
{
    partial class Input_reserva
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
            this.numeric_textBox_reserva = new FrbaHotel.Model.NumericTextBox();
            this.boton_siguiente = new System.Windows.Forms.Button();
            this.boton_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el numero de reserva correspondiente:";
            // 
            // numeric_textBox_reserva
            // 
            this.numeric_textBox_reserva.AllowSpace = false;
            this.numeric_textBox_reserva.Location = new System.Drawing.Point(88, 78);
            this.numeric_textBox_reserva.Name = "numeric_textBox_reserva";
            this.numeric_textBox_reserva.Size = new System.Drawing.Size(100, 20);
            this.numeric_textBox_reserva.TabIndex = 1;
            // 
            // boton_siguiente
            // 
            this.boton_siguiente.Location = new System.Drawing.Point(177, 141);
            this.boton_siguiente.Name = "boton_siguiente";
            this.boton_siguiente.Size = new System.Drawing.Size(75, 23);
            this.boton_siguiente.TabIndex = 2;
            this.boton_siguiente.Text = "Siguiente";
            this.boton_siguiente.UseVisualStyleBackColor = true;
            this.boton_siguiente.Click += new System.EventHandler(this.boton_siguiente_Click);
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(29, 141);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 3;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // Input_reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 183);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.boton_siguiente);
            this.Controls.Add(this.numeric_textBox_reserva);
            this.Controls.Add(this.label1);
            this.Name = "Input_reserva";
            this.Text = "Input_reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Model.NumericTextBox numeric_textBox_reserva;
        private System.Windows.Forms.Button boton_siguiente;
        private System.Windows.Forms.Button boton_volver;
    }
}