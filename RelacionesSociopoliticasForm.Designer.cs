namespace HistoriaMedieval
{
    partial class RelacionesSociopoliticasForm
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
            this.comboBoxPersonaje1 = new System.Windows.Forms.ComboBox();
            this.comboBoxPersonaje2 = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoRelacion = new System.Windows.Forms.ComboBox();
            this.dataGridViewRelaciones = new System.Windows.Forms.DataGridView();
            this.textBoxFechaInicio = new System.Windows.Forms.TextBox();
            this.textBoxFechaFin = new System.Windows.Forms.TextBox();
            this.labelPersona1 = new System.Windows.Forms.Label();
            this.labelPersona2 = new System.Windows.Forms.Label();
            this.labelRelacion = new System.Windows.Forms.Label();
            this.labelInicio = new System.Windows.Forms.Label();
            this.labelFin = new System.Windows.Forms.Label();
            this.buttonRSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPersonaje1
            // 
            this.comboBoxPersonaje1.FormattingEnabled = true;
            this.comboBoxPersonaje1.Location = new System.Drawing.Point(111, 47);
            this.comboBoxPersonaje1.Name = "comboBoxPersonaje1";
            this.comboBoxPersonaje1.Size = new System.Drawing.Size(138, 21);
            this.comboBoxPersonaje1.TabIndex = 0;
            // 
            // comboBoxPersonaje2
            // 
            this.comboBoxPersonaje2.FormattingEnabled = true;
            this.comboBoxPersonaje2.Location = new System.Drawing.Point(111, 75);
            this.comboBoxPersonaje2.Name = "comboBoxPersonaje2";
            this.comboBoxPersonaje2.Size = new System.Drawing.Size(138, 21);
            this.comboBoxPersonaje2.TabIndex = 1;
            // 
            // comboBoxTipoRelacion
            // 
            this.comboBoxTipoRelacion.FormattingEnabled = true;
            this.comboBoxTipoRelacion.Location = new System.Drawing.Point(111, 103);
            this.comboBoxTipoRelacion.Name = "comboBoxTipoRelacion";
            this.comboBoxTipoRelacion.Size = new System.Drawing.Size(138, 21);
            this.comboBoxTipoRelacion.TabIndex = 2;
            // 
            // dataGridViewRelaciones
            // 
            this.dataGridViewRelaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelaciones.Location = new System.Drawing.Point(319, 12);
            this.dataGridViewRelaciones.Name = "dataGridViewRelaciones";
            this.dataGridViewRelaciones.Size = new System.Drawing.Size(625, 358);
            this.dataGridViewRelaciones.TabIndex = 3;
            this.dataGridViewRelaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRelaciones_CellContentClick);
            this.dataGridViewRelaciones.Click += new System.EventHandler(this.dataGridViewRelaciones_SelectionChanged);
            // 
            // textBoxFechaInicio
            // 
            this.textBoxFechaInicio.Location = new System.Drawing.Point(111, 131);
            this.textBoxFechaInicio.Name = "textBoxFechaInicio";
            this.textBoxFechaInicio.Size = new System.Drawing.Size(138, 20);
            this.textBoxFechaInicio.TabIndex = 4;
            // 
            // textBoxFechaFin
            // 
            this.textBoxFechaFin.Location = new System.Drawing.Point(111, 157);
            this.textBoxFechaFin.Name = "textBoxFechaFin";
            this.textBoxFechaFin.Size = new System.Drawing.Size(138, 20);
            this.textBoxFechaFin.TabIndex = 5;
            // 
            // labelPersona1
            // 
            this.labelPersona1.AutoSize = true;
            this.labelPersona1.Location = new System.Drawing.Point(38, 52);
            this.labelPersona1.Name = "labelPersona1";
            this.labelPersona1.Size = new System.Drawing.Size(55, 13);
            this.labelPersona1.TabIndex = 7;
            this.labelPersona1.Text = "Persona 1";
            // 
            // labelPersona2
            // 
            this.labelPersona2.AutoSize = true;
            this.labelPersona2.Location = new System.Drawing.Point(38, 79);
            this.labelPersona2.Name = "labelPersona2";
            this.labelPersona2.Size = new System.Drawing.Size(52, 13);
            this.labelPersona2.TabIndex = 8;
            this.labelPersona2.Text = "Persona2";
            // 
            // labelRelacion
            // 
            this.labelRelacion.AutoSize = true;
            this.labelRelacion.Location = new System.Drawing.Point(38, 106);
            this.labelRelacion.Name = "labelRelacion";
            this.labelRelacion.Size = new System.Drawing.Size(49, 13);
            this.labelRelacion.TabIndex = 9;
            this.labelRelacion.Text = "Relacion";
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Location = new System.Drawing.Point(38, 133);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(32, 13);
            this.labelInicio.TabIndex = 10;
            this.labelInicio.Text = "Inicio";
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.Location = new System.Drawing.Point(38, 160);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(21, 13);
            this.labelFin.TabIndex = 11;
            this.labelFin.Text = "Fin";
            // 
            // buttonRSave
            // 
            this.buttonRSave.Location = new System.Drawing.Point(111, 196);
            this.buttonRSave.Name = "buttonRSave";
            this.buttonRSave.Size = new System.Drawing.Size(75, 23);
            this.buttonRSave.TabIndex = 13;
            this.buttonRSave.Text = "&Guardar";
            this.buttonRSave.UseVisualStyleBackColor = true;
            this.buttonRSave.Click += new System.EventHandler(this.buttonRSave_Click);
            // 
            // RelacionesSociopoliticasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.buttonRSave);
            this.Controls.Add(this.labelFin);
            this.Controls.Add(this.labelInicio);
            this.Controls.Add(this.labelRelacion);
            this.Controls.Add(this.labelPersona2);
            this.Controls.Add(this.labelPersona1);
            this.Controls.Add(this.textBoxFechaFin);
            this.Controls.Add(this.textBoxFechaInicio);
            this.Controls.Add(this.dataGridViewRelaciones);
            this.Controls.Add(this.comboBoxTipoRelacion);
            this.Controls.Add(this.comboBoxPersonaje2);
            this.Controls.Add(this.comboBoxPersonaje1);
            this.Name = "RelacionesSociopoliticasForm";
            this.Text = "RelacionesSociopoliticasForm";
            this.Load += new System.EventHandler(this.RelacionesSociopoliticasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPersonaje1;
        private System.Windows.Forms.ComboBox comboBoxPersonaje2;
        private System.Windows.Forms.ComboBox comboBoxTipoRelacion;
        private System.Windows.Forms.DataGridView dataGridViewRelaciones;
        private System.Windows.Forms.TextBox textBoxFechaInicio;
        private System.Windows.Forms.TextBox textBoxFechaFin;
        private System.Windows.Forms.Label labelPersona1;
        private System.Windows.Forms.Label labelPersona2;
        private System.Windows.Forms.Label labelRelacion;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.Button buttonRSave;
    }
}