namespace FrbaHotel.RegistrarEstadia
{
    partial class Check_In
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
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.boton_crear = new System.Windows.Forms.Button();
            this.boton_volver = new System.Windows.Forms.Button();
            this.boton_confirmar = new System.Windows.Forms.Button();
            this.boton_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(12, 154);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.Size = new System.Drawing.Size(531, 274);
            this.dataGridClientes.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ingrese todos los huespedes correspondientes a esta reserva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Agregar cliente existente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Crear y agregar nuevo cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Huespedes registrados:";
            // 
            // boton_buscar
            // 
            this.boton_buscar.Location = new System.Drawing.Point(141, 69);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(75, 23);
            this.boton_buscar.TabIndex = 31;
            this.boton_buscar.Text = "Buscar";
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // boton_crear
            // 
            this.boton_crear.Location = new System.Drawing.Point(452, 69);
            this.boton_crear.Name = "boton_crear";
            this.boton_crear.Size = new System.Drawing.Size(75, 23);
            this.boton_crear.TabIndex = 32;
            this.boton_crear.Text = "Crear";
            this.boton_crear.UseVisualStyleBackColor = true;
            this.boton_crear.Click += new System.EventHandler(this.boton_crear_Click);
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(12, 487);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 33;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            // 
            // boton_confirmar
            // 
            this.boton_confirmar.Location = new System.Drawing.Point(468, 487);
            this.boton_confirmar.Name = "boton_confirmar";
            this.boton_confirmar.Size = new System.Drawing.Size(75, 23);
            this.boton_confirmar.TabIndex = 34;
            this.boton_confirmar.Text = "Confirmar";
            this.boton_confirmar.UseVisualStyleBackColor = true;
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Location = new System.Drawing.Point(452, 434);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(75, 23);
            this.boton_eliminar.TabIndex = 35;
            this.boton_eliminar.Text = "Eliminar";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            // 
            // Check_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 535);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_confirmar);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.boton_crear);
            this.Controls.Add(this.boton_buscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridClientes);
            this.Name = "Check_In";
            this.Text = "Check_In";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Button boton_crear;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Button boton_confirmar;
        private System.Windows.Forms.Button boton_eliminar;
    }
}