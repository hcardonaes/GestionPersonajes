namespace HistoriaMedieval
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.personajesDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.moteTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoTextBox = new System.Windows.Forms.TextBox();
            this.fechaMuerteTextBox = new System.Windows.Forms.TextBox();
            this.importanciaTextBox = new System.Windows.Forms.TextBox();
            this.biografiaTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personajesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personajesDataGridView
            // 
            this.personajesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personajesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.personajesDataGridView.Name = "personajesDataGridView";
            this.personajesDataGridView.Size = new System.Drawing.Size(798, 426);
            this.personajesDataGridView.TabIndex = 0;
            this.personajesDataGridView.SelectionChanged += new System.EventHandler(this.personajesDataGridView_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(842, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(842, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(842, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(842, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mote";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(842, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(842, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Muerte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(840, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Importancia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(842, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Biografia";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(902, 72);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(902, 107);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 10;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(902, 142);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 11;
            // 
            // moteTextBox
            // 
            this.moteTextBox.Location = new System.Drawing.Point(902, 177);
            this.moteTextBox.Name = "moteTextBox";
            this.moteTextBox.Size = new System.Drawing.Size(100, 20);
            this.moteTextBox.TabIndex = 12;
            // 
            // fechaNacimientoTextBox
            // 
            this.fechaNacimientoTextBox.Location = new System.Drawing.Point(902, 212);
            this.fechaNacimientoTextBox.Name = "fechaNacimientoTextBox";
            this.fechaNacimientoTextBox.Size = new System.Drawing.Size(100, 20);
            this.fechaNacimientoTextBox.TabIndex = 13;
            // 
            // fechaMuerteTextBox
            // 
            this.fechaMuerteTextBox.Location = new System.Drawing.Point(902, 247);
            this.fechaMuerteTextBox.Name = "fechaMuerteTextBox";
            this.fechaMuerteTextBox.Size = new System.Drawing.Size(100, 20);
            this.fechaMuerteTextBox.TabIndex = 14;
            // 
            // importanciaTextBox
            // 
            this.importanciaTextBox.Location = new System.Drawing.Point(902, 282);
            this.importanciaTextBox.Name = "importanciaTextBox";
            this.importanciaTextBox.Size = new System.Drawing.Size(100, 20);
            this.importanciaTextBox.TabIndex = 16;
            // 
            // biografiaTextBox
            // 
            this.biografiaTextBox.Location = new System.Drawing.Point(902, 317);
            this.biografiaTextBox.Name = "biografiaTextBox";
            this.biografiaTextBox.Size = new System.Drawing.Size(100, 20);
            this.biografiaTextBox.TabIndex = 17;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(912, 343);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 452);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.biografiaTextBox);
            this.Controls.Add(this.importanciaTextBox);
            this.Controls.Add(this.fechaMuerteTextBox);
            this.Controls.Add(this.fechaNacimientoTextBox);
            this.Controls.Add(this.moteTextBox);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personajesDataGridView);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personajesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView personajesDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox moteTextBox;
        private System.Windows.Forms.TextBox fechaNacimientoTextBox;
        private System.Windows.Forms.TextBox fechaMuerteTextBox;
        private System.Windows.Forms.TextBox importanciaTextBox;
        private System.Windows.Forms.TextBox biografiaTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}

