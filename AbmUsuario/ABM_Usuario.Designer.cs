namespace FrbaHotel.AbmUsuario
{
    partial class ABM_Usuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtModificar = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtCrear = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(16, 255);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.txtModificar);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.txtCrear);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 236);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elija Opcion";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(127, 194);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtEliminar
            // 
            this.txtEliminar.AutoSize = true;
            this.txtEliminar.Location = new System.Drawing.Point(85, 162);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(162, 13);
            this.txtEliminar.TabIndex = 11;
            this.txtEliminar.Text = "Seleccione un usuario a eliminar:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(127, 123);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtModificar
            // 
            this.txtModificar.AutoSize = true;
            this.txtModificar.Location = new System.Drawing.Point(85, 91);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(169, 13);
            this.txtModificar.TabIndex = 9;
            this.txtModificar.Text = "Seleccione un usuario a modificar:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(127, 50);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtCrear
            // 
            this.txtCrear.AutoSize = true;
            this.txtCrear.Location = new System.Drawing.Point(96, 19);
            this.txtCrear.Name = "txtCrear";
            this.txtCrear.Size = new System.Drawing.Size(151, 13);
            this.txtCrear.TabIndex = 7;
            this.txtCrear.Text = "Seleccione un usuario a crear:";
            // 
            // ABM_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 291);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Name = "ABM_Usuario";
            this.Text = "ABM_Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label txtEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label txtModificar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label txtCrear;
    }
}