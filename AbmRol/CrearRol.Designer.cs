namespace FrbaHotel.AbmRol
{
    partial class CrearRol
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
            this.comboFuncionalidades = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.RadioActivo = new System.Windows.Forms.RadioButton();
            this.radioInactivo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BotonCrearRol = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BotonLimpiar = new System.Windows.Forms.Button();
            this.BotonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboFuncionalidades
            // 
            this.comboFuncionalidades.FormattingEnabled = true;
            this.comboFuncionalidades.Location = new System.Drawing.Point(106, 111);
            this.comboFuncionalidades.Name = "comboFuncionalidades";
            this.comboFuncionalidades.Size = new System.Drawing.Size(121, 21);
            this.comboFuncionalidades.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(106, 57);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // RadioActivo
            // 
            this.RadioActivo.AutoSize = true;
            this.RadioActivo.Location = new System.Drawing.Point(106, 170);
            this.RadioActivo.Name = "RadioActivo";
            this.RadioActivo.Size = new System.Drawing.Size(55, 17);
            this.RadioActivo.TabIndex = 2;
            this.RadioActivo.TabStop = true;
            this.RadioActivo.Text = "Activo";
            this.RadioActivo.UseVisualStyleBackColor = true;
            // 
            // radioInactivo
            // 
            this.radioInactivo.AutoSize = true;
            this.radioInactivo.Location = new System.Drawing.Point(106, 193);
            this.radioInactivo.Name = "radioInactivo";
            this.radioInactivo.Size = new System.Drawing.Size(63, 17);
            this.radioInactivo.TabIndex = 3;
            this.radioInactivo.TabStop = true;
            this.radioInactivo.Text = "Inactivo";
            this.radioInactivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Funcionalidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado";
            // 
            // BotonCrearRol
            // 
            this.BotonCrearRol.Location = new System.Drawing.Point(187, 226);
            this.BotonCrearRol.Name = "BotonCrearRol";
            this.BotonCrearRol.Size = new System.Drawing.Size(75, 23);
            this.BotonCrearRol.TabIndex = 7;
            this.BotonCrearRol.Text = "Crear";
            this.BotonCrearRol.UseVisualStyleBackColor = true;
            this.BotonCrearRol.Click += new System.EventHandler(this.BotonCrearRol_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BotonLimpiar
            // 
            this.BotonLimpiar.Location = new System.Drawing.Point(106, 226);
            this.BotonLimpiar.Name = "BotonLimpiar";
            this.BotonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BotonLimpiar.TabIndex = 9;
            this.BotonLimpiar.Text = "Limpiar";
            this.BotonLimpiar.UseVisualStyleBackColor = true;
            this.BotonLimpiar.Click += new System.EventHandler(this.BotonLimpiar_Click);
            // 
            // BotonVolver
            // 
            this.BotonVolver.Location = new System.Drawing.Point(25, 226);
            this.BotonVolver.Name = "BotonVolver";
            this.BotonVolver.Size = new System.Drawing.Size(75, 23);
            this.BotonVolver.TabIndex = 10;
            this.BotonVolver.Text = "Volver";
            this.BotonVolver.UseVisualStyleBackColor = true;
            this.BotonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // CrearRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 277);
            this.Controls.Add(this.BotonVolver);
            this.Controls.Add(this.BotonLimpiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BotonCrearRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioInactivo);
            this.Controls.Add(this.RadioActivo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.comboFuncionalidades);
            this.Name = "CrearRol";
            this.Text = "Crear Rol";
            this.Load += new System.EventHandler(this.CrearRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFuncionalidades;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.RadioButton RadioActivo;
        private System.Windows.Forms.RadioButton radioInactivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BotonCrearRol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BotonLimpiar;
        private System.Windows.Forms.Button BotonVolver;

    }
}