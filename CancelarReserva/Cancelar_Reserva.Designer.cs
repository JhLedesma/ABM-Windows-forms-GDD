namespace FrbaHotel.CancelarReserva
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.fechacancelacion = new System.Windows.Forms.DateTimePicker();
            this.motivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.numericTextBox1 = new FrbaHotel.Model.NumericTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de reserva";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.usuario);
            this.groupBox1.Controls.Add(this.fechacancelacion);
            this.groupBox1.Controls.Add(this.motivo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complete los siguientes campos";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(148, 211);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 6;
            // 
            // fechacancelacion
            // 
            this.fechacancelacion.Location = new System.Drawing.Point(148, 151);
            this.fechacancelacion.Name = "fechacancelacion";
            this.fechacancelacion.Size = new System.Drawing.Size(200, 20);
            this.fechacancelacion.TabIndex = 5;
            // 
            // motivo
            // 
            this.motivo.Location = new System.Drawing.Point(148, 98);
            this.motivo.Multiline = true;
            this.motivo.Name = "motivo";
            this.motivo.Size = new System.Drawing.Size(100, 20);
            this.motivo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ususario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha de cancelacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Motivo de cancelacion";
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(306, 293);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 2;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(13, 292);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 3;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(161, 292);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.AllowSpace = false;
            this.numericTextBox1.Location = new System.Drawing.Point(148, 38);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericTextBox1.Size = new System.Drawing.Size(100, 20);
            this.numericTextBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 334);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cancelar Reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.DateTimePicker fechacancelacion;
        private System.Windows.Forms.TextBox motivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button limpiar;
        private Model.NumericTextBox numericTextBox1;
    }
}