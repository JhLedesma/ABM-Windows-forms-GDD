namespace FrbaHotel.ListadoEstadistico
{
    partial class Listado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_anio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_trimestre = new System.Windows.Forms.NumericUpDown();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGrid_estadisticas = new System.Windows.Forms.DataGridView();
            this.boton_volver = new System.Windows.Forms.Button();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_anio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_trimestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_estadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boton_buscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_tipo);
            this.groupBox1.Controls.Add(this.numeric_trimestre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numeric_anio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // numeric_anio
            // 
            this.numeric_anio.Location = new System.Drawing.Point(41, 31);
            this.numeric_anio.Name = "numeric_anio";
            this.numeric_anio.Size = new System.Drawing.Size(87, 20);
            this.numeric_anio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trimestre:";
            // 
            // numeric_trimestre
            // 
            this.numeric_trimestre.Location = new System.Drawing.Point(212, 31);
            this.numeric_trimestre.Name = "numeric_trimestre";
            this.numeric_trimestre.Size = new System.Drawing.Size(87, 20);
            this.numeric_trimestre.TabIndex = 3;
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Location = new System.Drawing.Point(409, 30);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(199, 21);
            this.comboBox_tipo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de listado:";
            // 
            // dataGrid_estadisticas
            // 
            this.dataGrid_estadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_estadisticas.Location = new System.Drawing.Point(12, 149);
            this.dataGrid_estadisticas.Name = "dataGrid_estadisticas";
            this.dataGrid_estadisticas.Size = new System.Drawing.Size(617, 248);
            this.dataGrid_estadisticas.TabIndex = 1;
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(21, 425);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(75, 23);
            this.boton_volver.TabIndex = 2;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            // 
            // boton_buscar
            // 
            this.boton_buscar.Location = new System.Drawing.Point(41, 80);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(87, 23);
            this.boton_buscar.TabIndex = 6;
            this.boton_buscar.Text = "Buscar";
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 469);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.dataGrid_estadisticas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Listado";
            this.Text = "Listados de estadisticas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_anio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_trimestre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_estadisticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numeric_anio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_trimestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.DataGridView dataGrid_estadisticas;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Button boton_buscar;
    }
}