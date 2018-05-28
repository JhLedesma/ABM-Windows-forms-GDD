namespace FrbaHotel.AbmCliente
{
    partial class Abm_Cliente
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
            this.txtCrear = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtModificar = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 254);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtCrear
            // 
            this.txtCrear.AutoSize = true;
            this.txtCrear.Location = new System.Drawing.Point(104, 37);
            this.txtCrear.Name = "txtCrear";
            this.txtCrear.Size = new System.Drawing.Size(148, 13);
            this.txtCrear.TabIndex = 1;
            this.txtCrear.Text = "Seleccione un cliente a crear:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(135, 68);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtModificar
            // 
            this.txtModificar.AutoSize = true;
            this.txtModificar.Location = new System.Drawing.Point(93, 109);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(166, 13);
            this.txtModificar.TabIndex = 3;
            this.txtModificar.Text = "Seleccione un cliente a modificar:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(135, 141);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.AutoSize = true;
            this.txtEliminar.Location = new System.Drawing.Point(93, 180);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(159, 13);
            this.txtEliminar.TabIndex = 5;
            this.txtEliminar.Text = "Seleccione un cliente a eliminar:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(135, 212);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 236);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elija Opcion";
            // 
            // Abm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 289);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtCrear);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Name = "Abm_Cliente";
            this.Text = "ABM_Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label txtCrear;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label txtModificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label txtEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}