namespace FrbaHotel.Login
{
    partial class SeleccionDeRol
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
            this.selectorDeRol = new System.Windows.Forms.ComboBox();
            this.boton_volver = new System.Windows.Forms.Button();
            this.boton_aceptar_rol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione Rol";
            // 
            // selectorDeRol
            // 
            this.selectorDeRol.FormattingEnabled = true;
            this.selectorDeRol.Location = new System.Drawing.Point(65, 48);
            this.selectorDeRol.Margin = new System.Windows.Forms.Padding(2);
            this.selectorDeRol.Name = "selectorDeRol";
            this.selectorDeRol.Size = new System.Drawing.Size(142, 21);
            this.selectorDeRol.TabIndex = 2;
            this.selectorDeRol.SelectedIndexChanged += new System.EventHandler(this.selectorDeRol_SelectedIndexChanged);
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(44, 119);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 5;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // boton_aceptar_rol
            // 
            this.boton_aceptar_rol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.boton_aceptar_rol.Location = new System.Drawing.Point(151, 119);
            this.boton_aceptar_rol.Margin = new System.Windows.Forms.Padding(2);
            this.boton_aceptar_rol.Name = "boton_aceptar_rol";
            this.boton_aceptar_rol.Size = new System.Drawing.Size(76, 23);
            this.boton_aceptar_rol.TabIndex = 4;
            this.boton_aceptar_rol.Text = "Aceptar";
            this.boton_aceptar_rol.UseVisualStyleBackColor = false;
            this.boton_aceptar_rol.Click += new System.EventHandler(this.boton_aceptar_rol_Click);
            // 
            // SeleccionDeRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 183);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.boton_aceptar_rol);
            this.Controls.Add(this.selectorDeRol);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionDeRol";
            this.Text = "Seleccion de rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectorDeRol;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Button boton_aceptar_rol;
    }
}