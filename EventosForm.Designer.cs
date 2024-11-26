namespace HistoriaMedieval
{
    partial class EventosForm
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
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxFechaInicio = new System.Windows.Forms.TextBox();
            this.textBoxFechaFin = new System.Windows.Forms.TextBox();
            this.textBoxLugar_id = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFin = new System.Windows.Forms.Label();
            this.labelLugar = new System.Windows.Forms.Label();
            this.labelInicio = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventos.Location = new System.Drawing.Point(195, 12);
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.Size = new System.Drawing.Size(776, 414);
            this.dataGridViewEventos.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(89, 21);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxFechaInicio
            // 
            this.textBoxFechaInicio.Location = new System.Drawing.Point(90, 51);
            this.textBoxFechaInicio.Name = "textBoxFechaInicio";
            this.textBoxFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaInicio.TabIndex = 2;
            // 
            // textBoxFechaFin
            // 
            this.textBoxFechaFin.Location = new System.Drawing.Point(89, 81);
            this.textBoxFechaFin.Name = "textBoxFechaFin";
            this.textBoxFechaFin.Size = new System.Drawing.Size(100, 20);
            this.textBoxFechaFin.TabIndex = 3;
            // 
            // textBoxLugar_id
            // 
            this.textBoxLugar_id.Location = new System.Drawing.Point(89, 111);
            this.textBoxLugar_id.Name = "textBoxLugar_id";
            this.textBoxLugar_id.Size = new System.Drawing.Size(100, 20);
            this.textBoxLugar_id.TabIndex = 4;
            this.textBoxLugar_id.Click += new System.EventHandler(this.textBoxLugar_id_Click);
            this.textBoxLugar_id.Enter += new System.EventHandler(this.textBoxLugar_id_Click);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(89, 141);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescripcion.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(89, 202);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(89, 249);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Borrar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(13, 27);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 8;
            this.labelNombre.Text = "Nombre";
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.Location = new System.Drawing.Point(13, 87);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(21, 13);
            this.labelFin.TabIndex = 9;
            this.labelFin.Text = "Fin";
            // 
            // labelLugar
            // 
            this.labelLugar.AutoSize = true;
            this.labelLugar.Location = new System.Drawing.Point(13, 117);
            this.labelLugar.Name = "labelLugar";
            this.labelLugar.Size = new System.Drawing.Size(34, 13);
            this.labelLugar.TabIndex = 10;
            this.labelLugar.Text = "Lugar";
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Location = new System.Drawing.Point(13, 57);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(32, 13);
            this.labelInicio.TabIndex = 11;
            this.labelInicio.Text = "Inicio";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(13, 147);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 12;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // EventosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 450);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelInicio);
            this.Controls.Add(this.labelLugar);
            this.Controls.Add(this.labelFin);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxLugar_id);
            this.Controls.Add(this.textBoxFechaFin);
            this.Controls.Add(this.textBoxFechaInicio);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.dataGridViewEventos);
            this.Name = "EventosForm";
            this.Text = "EventosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxFechaInicio;
        private System.Windows.Forms.TextBox textBoxFechaFin;
        private System.Windows.Forms.TextBox textBoxLugar_id;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.Label labelLugar;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Label labelDescripcion;
    }
}