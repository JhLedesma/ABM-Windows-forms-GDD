namespace FrbaHotel.RegistrarEstadia
{
    partial class Ingreso_Egreso
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
            this.boton_check_in = new System.Windows.Forms.Button();
            this.boton_check_out = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_check_in
            // 
            this.boton_check_in.Location = new System.Drawing.Point(96, 56);
            this.boton_check_in.Name = "boton_check_in";
            this.boton_check_in.Size = new System.Drawing.Size(75, 23);
            this.boton_check_in.TabIndex = 0;
            this.boton_check_in.Text = "Check-In";
            this.boton_check_in.UseVisualStyleBackColor = true;
            this.boton_check_in.Click += new System.EventHandler(this.boton_check_in_Click);
            // 
            // boton_check_out
            // 
            this.boton_check_out.Location = new System.Drawing.Point(96, 147);
            this.boton_check_out.Name = "boton_check_out";
            this.boton_check_out.Size = new System.Drawing.Size(75, 23);
            this.boton_check_out.TabIndex = 1;
            this.boton_check_out.Text = "Check-Out";
            this.boton_check_out.UseVisualStyleBackColor = true;
            this.boton_check_out.Click += new System.EventHandler(this.boton_check_out_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proceso de Check-Out:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proceso de Check-In:";
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(12, 204);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 4;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // Ingreso_Egreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 244);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_check_out);
            this.Controls.Add(this.boton_check_in);
            this.Name = "Ingreso_Egreso";
            this.Text = "Ingreso_Egreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_check_in;
        private System.Windows.Forms.Button boton_check_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_volver;
    }
}