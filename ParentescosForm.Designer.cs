namespace HistoriaMedieval
{
    partial class ParentescosForm
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
            this.comboBoxpersonaje1 = new System.Windows.Forms.ComboBox();
            this.comboBoxpersonaje2 = new System.Windows.Forms.ComboBox();
            this.comboBoxtipoParentesco = new System.Windows.Forms.ComboBox();
            this.textBoxFechaInicio = new System.Windows.Forms.TextBox();
            this.textBoxFechaFin = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.dataGridViewRelaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxpersonaje1
            // 
            this.comboBoxpersonaje1.FormattingEnabled = true;
            this.comboBoxpersonaje1.Location = new System.Drawing.Point(122, 106);
            this.comboBoxpersonaje1.Name = "comboBoxpersonaje1";
            this.comboBoxpersonaje1.Size = new System.Drawing.Size(125, 21);
            this.comboBoxpersonaje1.TabIndex = 0;
            // 
            // comboBoxpersonaje2
            // 
            this.comboBoxpersonaje2.FormattingEnabled = true;
            this.comboBoxpersonaje2.Location = new System.Drawing.Point(122, 139);
            this.comboBoxpersonaje2.Name = "comboBoxpersonaje2";
            this.comboBoxpersonaje2.Size = new System.Drawing.Size(125, 21);
            this.comboBoxpersonaje2.TabIndex = 1;
            // 
            // comboBoxtipoParentesco
            // 
            this.comboBoxtipoParentesco.FormattingEnabled = true;
            this.comboBoxtipoParentesco.Location = new System.Drawing.Point(122, 172);
            this.comboBoxtipoParentesco.Name = "comboBoxtipoParentesco";
            this.comboBoxtipoParentesco.Size = new System.Drawing.Size(125, 21);
            this.comboBoxtipoParentesco.TabIndex = 2;
            this.comboBoxtipoParentesco.SelectedIndexChanged += new System.EventHandler(this.comboBoxtipoParentesco_SelectedIndexChanged);
            // 
            // textBoxFechaInicio
            // 
            this.textBoxFechaInicio.Location = new System.Drawing.Point(122, 205);
            this.textBoxFechaInicio.Name = "textBoxFechaInicio";
            this.textBoxFechaInicio.Size = new System.Drawing.Size(125, 20);
            this.textBoxFechaInicio.TabIndex = 3;
            this.textBoxFechaInicio.Visible = false;
            // 
            // textBoxFechaFin
            // 
            this.textBoxFechaFin.Location = new System.Drawing.Point(122, 237);
            this.textBoxFechaFin.Name = "textBoxFechaFin";
            this.textBoxFechaFin.Size = new System.Drawing.Size(125, 20);
            this.textBoxFechaFin.TabIndex = 4;
            this.textBoxFechaFin.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(122, 277);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Conyuge 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Conyuge 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(60, 206);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(32, 13);
            this.labelFechaInicio.TabIndex = 9;
            this.labelFechaInicio.Text = "Inicio";
            this.labelFechaInicio.Visible = false;
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Location = new System.Drawing.Point(60, 240);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(21, 13);
            this.labelFechaFin.TabIndex = 10;
            this.labelFechaFin.Text = "Fin";
            this.labelFechaFin.Visible = false;
            // 
            // dataGridViewRelaciones
            // 
            this.dataGridViewRelaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewRelaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRelaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewRelaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelaciones.Location = new System.Drawing.Point(288, 29);
            this.dataGridViewRelaciones.Name = "dataGridViewRelaciones";
            this.dataGridViewRelaciones.Size = new System.Drawing.Size(626, 396);
            this.dataGridViewRelaciones.TabIndex = 11;
            // 
            // ParentescosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.dataGridViewRelaciones);
            this.Controls.Add(this.labelFechaFin);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxFechaFin);
            this.Controls.Add(this.textBoxFechaInicio);
            this.Controls.Add(this.comboBoxtipoParentesco);
            this.Controls.Add(this.comboBoxpersonaje2);
            this.Controls.Add(this.comboBoxpersonaje1);
            this.Name = "ParentescosForm";
            this.Text = "ParentescosForm";
            this.Load += new System.EventHandler(this.ParentescosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxpersonaje1;
        private System.Windows.Forms.ComboBox comboBoxpersonaje2;
        private System.Windows.Forms.ComboBox comboBoxtipoParentesco;
        private System.Windows.Forms.TextBox textBoxFechaInicio;
        private System.Windows.Forms.TextBox textBoxFechaFin;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.DataGridView dataGridViewRelaciones;
    }
}