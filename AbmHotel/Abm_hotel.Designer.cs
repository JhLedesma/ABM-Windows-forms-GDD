namespace FrbaHotel.AbmHotel
{
    partial class Abm_hotel
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
            this.button_volver = new System.Windows.Forms.Button();
            this.button_Listado_seleccion_sucursales = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.boton_crear_hotel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(25, 381);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 13;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // button_Listado_seleccion_sucursales
            // 
            this.button_Listado_seleccion_sucursales.Location = new System.Drawing.Point(92, 141);
            this.button_Listado_seleccion_sucursales.Name = "button_Listado_seleccion_sucursales";
            this.button_Listado_seleccion_sucursales.Size = new System.Drawing.Size(75, 23);
            this.button_Listado_seleccion_sucursales.TabIndex = 12;
            this.button_Listado_seleccion_sucursales.Text = "Modificar";
            this.button_Listado_seleccion_sucursales.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cree un nuevo hotel:";
            // 
            // boton_crear_hotel
            // 
            this.boton_crear_hotel.Location = new System.Drawing.Point(92, 52);
            this.boton_crear_hotel.Name = "boton_crear_hotel";
            this.boton_crear_hotel.Size = new System.Drawing.Size(75, 24);
            this.boton_crear_hotel.TabIndex = 10;
            this.boton_crear_hotel.Text = "Crear";
            this.boton_crear_hotel.UseVisualStyleBackColor = true;
            this.boton_crear_hotel.Click += new System.EventHandler(this.boton_crear_hotel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione un hotel a modificar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Seleccione un hotel a eliminar:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Listar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Listar hoteles segun condiciones:";
            // 
            // Abm_hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 429);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_Listado_seleccion_sucursales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boton_crear_hotel);
            this.Controls.Add(this.label1);
            this.Name = "Abm_hotel";
            this.Text = "Abm_hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button_Listado_seleccion_sucursales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boton_crear_hotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}