namespace FrbaHotel.AbmRol
{
    partial class ModificarRol
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
            this.Lfuncionalidades = new System.Windows.Forms.ListBox();
            this.LFuncionalidadesActuales = new System.Windows.Forms.ListBox();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.BotonQuitar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioHabilitado = new System.Windows.Forms.RadioButton();
            this.radioInhabilitado = new System.Windows.Forms.RadioButton();
            this.BotonVolver = new System.Windows.Forms.Button();
            this.BotonLimpiar = new System.Windows.Forms.Button();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lfuncionalidades
            // 
            this.Lfuncionalidades.FormattingEnabled = true;
            this.Lfuncionalidades.Location = new System.Drawing.Point(39, 47);
            this.Lfuncionalidades.Name = "Lfuncionalidades";
            this.Lfuncionalidades.Size = new System.Drawing.Size(120, 95);
            this.Lfuncionalidades.TabIndex = 0;
            // 
            // LFuncionalidadesActuales
            // 
            this.LFuncionalidadesActuales.FormattingEnabled = true;
            this.LFuncionalidadesActuales.Location = new System.Drawing.Point(321, 47);
            this.LFuncionalidadesActuales.Name = "LFuncionalidadesActuales";
            this.LFuncionalidadesActuales.Size = new System.Drawing.Size(120, 95);
            this.LFuncionalidadesActuales.TabIndex = 1;
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Location = new System.Drawing.Point(205, 59);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(75, 23);
            this.BotonAgregar.TabIndex = 2;
            this.BotonAgregar.Text = "Agregar ->";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            // 
            // BotonQuitar
            // 
            this.BotonQuitar.Location = new System.Drawing.Point(205, 107);
            this.BotonQuitar.Name = "BotonQuitar";
            this.BotonQuitar.Size = new System.Drawing.Size(75, 23);
            this.BotonQuitar.TabIndex = 3;
            this.BotonQuitar.Text = "<- Quitar";
            this.BotonQuitar.UseVisualStyleBackColor = true;
            this.BotonQuitar.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BotonAgregar);
            this.groupBox1.Controls.Add(this.BotonQuitar);
            this.groupBox1.Controls.Add(this.Lfuncionalidades);
            this.groupBox1.Controls.Add(this.LFuncionalidadesActuales);
            this.groupBox1.Location = new System.Drawing.Point(13, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 161);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar Funcionalidaes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Funcionalidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Funcionalidades Actuales";
            // 
            // radioHabilitado
            // 
            this.radioHabilitado.AutoSize = true;
            this.radioHabilitado.Location = new System.Drawing.Point(87, 255);
            this.radioHabilitado.Name = "radioHabilitado";
            this.radioHabilitado.Size = new System.Drawing.Size(72, 17);
            this.radioHabilitado.TabIndex = 5;
            this.radioHabilitado.TabStop = true;
            this.radioHabilitado.Text = "Habilitado";
            this.radioHabilitado.UseVisualStyleBackColor = true;
            // 
            // radioInhabilitado
            // 
            this.radioInhabilitado.AutoSize = true;
            this.radioInhabilitado.Location = new System.Drawing.Point(337, 255);
            this.radioInhabilitado.Name = "radioInhabilitado";
            this.radioInhabilitado.Size = new System.Drawing.Size(79, 17);
            this.radioInhabilitado.TabIndex = 6;
            this.radioInhabilitado.TabStop = true;
            this.radioInhabilitado.Text = "Inhabilitado";
            this.radioInhabilitado.UseVisualStyleBackColor = true;
            // 
            // BotonVolver
            // 
            this.BotonVolver.Location = new System.Drawing.Point(52, 312);
            this.BotonVolver.Name = "BotonVolver";
            this.BotonVolver.Size = new System.Drawing.Size(75, 23);
            this.BotonVolver.TabIndex = 7;
            this.BotonVolver.Text = "Volver";
            this.BotonVolver.UseVisualStyleBackColor = true;
            // 
            // BotonLimpiar
            // 
            this.BotonLimpiar.Location = new System.Drawing.Point(218, 312);
            this.BotonLimpiar.Name = "BotonLimpiar";
            this.BotonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BotonLimpiar.TabIndex = 8;
            this.BotonLimpiar.Text = "Limpiar";
            this.BotonLimpiar.UseVisualStyleBackColor = true;
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.Location = new System.Drawing.Point(379, 312);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(75, 23);
            this.BotonAceptar.TabIndex = 9;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 58);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Estado";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(98, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre del Rol";
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 355);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.BotonLimpiar);
            this.Controls.Add(this.BotonVolver);
            this.Controls.Add(this.radioInhabilitado);
            this.Controls.Add(this.radioHabilitado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ModificarRol";
            this.Text = "Modificar Rol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lfuncionalidades;
        private System.Windows.Forms.ListBox LFuncionalidadesActuales;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Button BotonQuitar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioHabilitado;
        private System.Windows.Forms.RadioButton radioInhabilitado;
        private System.Windows.Forms.Button BotonVolver;
        private System.Windows.Forms.Button BotonLimpiar;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}