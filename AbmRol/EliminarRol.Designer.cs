namespace FrbaHotel.AbmRol
{
    partial class EliminarRol
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
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.habilitado = new System.Windows.Forms.RadioButton();
            this.inhabilitado = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(204, 232);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Aceptar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox2
            // 
            this.listBox2.Enabled = false;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(45, 105);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 6;
            // 
            // habilitado
            // 
            this.habilitado.AutoSize = true;
            this.habilitado.Enabled = false;
            this.habilitado.Location = new System.Drawing.Point(194, 124);
            this.habilitado.Name = "habilitado";
            this.habilitado.Size = new System.Drawing.Size(72, 17);
            this.habilitado.TabIndex = 7;
            this.habilitado.TabStop = true;
            this.habilitado.Text = "Habilitado";
            this.habilitado.UseVisualStyleBackColor = true;
            // 
            // inhabilitado
            // 
            this.inhabilitado.AutoSize = true;
            this.inhabilitado.Enabled = false;
            this.inhabilitado.Location = new System.Drawing.Point(194, 147);
            this.inhabilitado.Name = "inhabilitado";
            this.inhabilitado.Size = new System.Drawing.Size(79, 17);
            this.inhabilitado.TabIndex = 8;
            this.inhabilitado.TabStop = true;
            this.inhabilitado.Text = "Inhabilitado";
            this.inhabilitado.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox1.Location = new System.Drawing.Point(109, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "RolElegido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Funcionalidades";
            // 
            // EliminarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 295);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inhabilitado);
            this.Controls.Add(this.habilitado);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Name = "EliminarRol";
            this.Text = "Eliminar Rol";
            this.Load += new System.EventHandler(this.EliminarRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RadioButton habilitado;
        private System.Windows.Forms.RadioButton inhabilitado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}