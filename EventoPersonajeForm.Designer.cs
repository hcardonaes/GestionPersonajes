namespace HistoriaMedieval
{
    partial class EventoPersonajeForm
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
            this.comboBoxEvento = new System.Windows.Forms.ComboBox();
            this.comboBoxPersonaje = new System.Windows.Forms.ComboBox();
            this.dataGridViewEventoPersonajes = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventoPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEvento
            // 
            this.comboBoxEvento.FormattingEnabled = true;
            this.comboBoxEvento.Location = new System.Drawing.Point(0, 0);
            this.comboBoxEvento.Name = "comboBoxEvento";
            this.comboBoxEvento.Size = new System.Drawing.Size(121, 28);
            this.comboBoxEvento.TabIndex = 0;
            // 
            // comboBoxPersonaje
            // 
            this.comboBoxPersonaje.FormattingEnabled = true;
            this.comboBoxPersonaje.Location = new System.Drawing.Point(0, 34);
            this.comboBoxPersonaje.Name = "comboBoxPersonaje";
            this.comboBoxPersonaje.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPersonaje.TabIndex = 1;
            // 
            // dataGridViewEventoPersonajes
            // 
            this.dataGridViewEventoPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventoPersonajes.Location = new System.Drawing.Point(255, 12);
            this.dataGridViewEventoPersonajes.Name = "dataGridViewEventoPersonajes";
            this.dataGridViewEventoPersonajes.RowHeadersWidth = 62;
            this.dataGridViewEventoPersonajes.RowTemplate.Height = 28;
            this.dataGridViewEventoPersonajes.Size = new System.Drawing.Size(533, 426);
            this.dataGridViewEventoPersonajes.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(23, 91);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(114, 62);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EventoPersonajeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewEventoPersonajes);
            this.Controls.Add(this.comboBoxPersonaje);
            this.Controls.Add(this.comboBoxEvento);
            this.Name = "EventoPersonajeForm";
            this.Text = "EventoPersonajeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventoPersonajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEvento;
        private System.Windows.Forms.ComboBox comboBoxPersonaje;
        private System.Windows.Forms.DataGridView dataGridViewEventoPersonajes;
        private System.Windows.Forms.Button buttonSave;
    }
}