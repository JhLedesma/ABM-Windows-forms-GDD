namespace FrbaHotel.Login
{
    partial class CambiarContrasenia
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
            this.boton_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_contra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_contraRepe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boton_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_guardar
            // 
            this.boton_guardar.Location = new System.Drawing.Point(254, 183);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Size = new System.Drawing.Size(75, 23);
            this.boton_guardar.TabIndex = 0;
            this.boton_guardar.Text = "Guardar";
            this.boton_guardar.UseVisualStyleBackColor = true;
            this.boton_guardar.Click += new System.EventHandler(this.boton_guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese una nueva contraseña:";
            // 
            // textBox_contra
            // 
            this.textBox_contra.Location = new System.Drawing.Point(193, 67);
            this.textBox_contra.Name = "textBox_contra";
            this.textBox_contra.PasswordChar = '*';
            this.textBox_contra.Size = new System.Drawing.Size(164, 20);
            this.textBox_contra.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repita la contraseña:";
            // 
            // textBox_contraRepe
            // 
            this.textBox_contraRepe.Location = new System.Drawing.Point(193, 109);
            this.textBox_contraRepe.Name = "textBox_contraRepe";
            this.textBox_contraRepe.PasswordChar = '*';
            this.textBox_contraRepe.Size = new System.Drawing.Size(164, 20);
            this.textBox_contraRepe.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cambio de contrasenia";
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(41, 183);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 6;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // CambiarContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 229);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_contraRepe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_contra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_guardar);
            this.Name = "CambiarContrasenia";
            this.Text = "CambiarContrasenia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_contra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_contraRepe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boton_volver;
    }
}