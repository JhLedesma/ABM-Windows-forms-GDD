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
            this.dataGridHoteles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHoteles
            // 
            this.dataGridHoteles.AllowUserToAddRows = false;
            this.dataGridHoteles.AllowUserToDeleteRows = false;
            this.dataGridHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHoteles.Location = new System.Drawing.Point(12, 154);
            this.dataGridHoteles.Name = "dataGridHoteles";
            this.dataGridHoteles.ReadOnly = true;
            this.dataGridHoteles.Size = new System.Drawing.Size(531, 274);
            this.dataGridHoteles.TabIndex = 26;
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
            // Check_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridHoteles);
            this.Name = "Check_In";
            this.Text = "Check_In";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHoteles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHoteles;
        private System.Windows.Forms.Label label1;
    }
}