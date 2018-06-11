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
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_listar = new System.Windows.Forms.Button();
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
            // boton_eliminar
            // 
            this.boton_eliminar.Location = new System.Drawing.Point(92, 229);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(75, 23);
            this.boton_eliminar.TabIndex = 15;
            this.boton_eliminar.Text = "Inhabilitar";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Seleccione un hotel a inhabilitar:";
            // 
            // boton_listar
            // 
            this.boton_listar.Location = new System.Drawing.Point(92, 317);
            this.boton_listar.Name = "boton_listar";
            this.boton_listar.Size = new System.Drawing.Size(75, 23);
            this.boton_listar.TabIndex = 17;
            this.boton_listar.Text = "Listar";
            this.boton_listar.UseVisualStyleBackColor = true;
            this.boton_listar.Click += new System.EventHandler(this.boton_listar_Click);
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
            this.Controls.Add(this.boton_listar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boton_eliminar);
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
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_listar;
        private System.Windows.Forms.Label label4;
    }
}