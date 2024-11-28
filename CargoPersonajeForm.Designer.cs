namespace HistoriaMedieval
{
    partial class CargoPersonajeForm
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
            this.comboBoxPersonaje = new System.Windows.Forms.ComboBox();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.textBoxFechaInicio = new System.Windows.Forms.TextBox();
            this.textBoxFechaFin = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.dataGridViewCargos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPersonaje
            // 
            this.comboBoxPersonaje.FormattingEnabled = true;
            this.comboBoxPersonaje.Location = new System.Drawing.Point(60, 0);
            this.comboBoxPersonaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPersonaje.Name = "comboBoxPersonaje";
            this.comboBoxPersonaje.Size = new System.Drawing.Size(196, 28);
            this.comboBoxPersonaje.TabIndex = 0;
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Location = new System.Drawing.Point(60, 45);
            this.comboBoxCargo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(196, 28);
            this.comboBoxCargo.TabIndex = 1;
            // 
            // textBoxFechaInicio
            // 
            this.textBoxFechaInicio.Location = new System.Drawing.Point(60, 92);
            this.textBoxFechaInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFechaInicio.Name = "textBoxFechaInicio";
            this.textBoxFechaInicio.Size = new System.Drawing.Size(196, 26);
            this.textBoxFechaInicio.TabIndex = 3;
            // 
            // textBoxFechaFin
            // 
            this.textBoxFechaFin.Location = new System.Drawing.Point(60, 135);
            this.textBoxFechaFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFechaFin.Name = "textBoxFechaFin";
            this.textBoxFechaFin.Size = new System.Drawing.Size(196, 26);
            this.textBoxFechaFin.TabIndex = 4;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(60, 178);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(198, 35);
            this.ButtonSave.TabIndex = 5;
            this.ButtonSave.Text = "Guardar";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // dataGridViewCargos
            // 
            this.dataGridViewCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCargos.Location = new System.Drawing.Point(393, 20);
            this.dataGridViewCargos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCargos.Name = "dataGridViewCargos";
            this.dataGridViewCargos.RowHeadersWidth = 62;
            this.dataGridViewCargos.Size = new System.Drawing.Size(789, 626);
            this.dataGridViewCargos.TabIndex = 6;
            this.dataGridViewCargos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCargos_CellContentClick);
            // 
            // CargoPersonajeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridViewCargos);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.textBoxFechaFin);
            this.Controls.Add(this.textBoxFechaInicio);
            this.Controls.Add(this.comboBoxCargo);
            this.Controls.Add(this.comboBoxPersonaje);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CargoPersonajeForm";
            this.Text = "CargoPersonajeForm";
            this.Load += new System.EventHandler(this.CargoPersonajeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPersonaje;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.TextBox textBoxFechaInicio;
        private System.Windows.Forms.TextBox textBoxFechaFin;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.DataGridView dataGridViewCargos;
    }
}