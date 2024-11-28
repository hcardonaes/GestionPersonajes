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
            this.buttonOpenParentescos = new System.Windows.Forms.Button();
            this.buttonOpenRelaciones = new System.Windows.Forms.Button();
            this.buttonOpenCargos = new System.Windows.Forms.Button();
            this.buttonEventos = new System.Windows.Forms.Button();
            this.buttonLugares = new System.Windows.Forms.Button();
            this.buttonOpenProtagonistas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personajesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personajesDataGridView
            // 
            this.personajesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personajesDataGridView.Location = new System.Drawing.Point(18, 18);
            this.personajesDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.personajesDataGridView.Name = "personajesDataGridView";
            this.personajesDataGridView.RowHeadersWidth = 62;
            this.personajesDataGridView.Size = new System.Drawing.Size(1197, 655);
            this.personajesDataGridView.TabIndex = 0;
            this.personajesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personajesDataGridView_CellContentClick);
            this.personajesDataGridView.SelectionChanged += new System.EventHandler(this.personajesDataGridView_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1228, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1228, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1228, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1228, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mote";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1228, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1228, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Muerte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1226, 351);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Importancia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1228, 392);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Biografia";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(1322, 91);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(148, 26);
            this.idTextBox.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(1322, 134);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(148, 26);
            this.nombreTextBox.TabIndex = 10;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(1322, 177);
            this.apellidoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(148, 26);
            this.apellidoTextBox.TabIndex = 11;
            // 
            // moteTextBox
            // 
            this.moteTextBox.Location = new System.Drawing.Point(1322, 220);
            this.moteTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.moteTextBox.Name = "moteTextBox";
            this.moteTextBox.Size = new System.Drawing.Size(148, 26);
            this.moteTextBox.TabIndex = 12;
            // 
            // fechaNacimientoTextBox
            // 
            this.fechaNacimientoTextBox.Location = new System.Drawing.Point(1322, 263);
            this.fechaNacimientoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaNacimientoTextBox.Name = "fechaNacimientoTextBox";
            this.fechaNacimientoTextBox.Size = new System.Drawing.Size(148, 26);
            this.fechaNacimientoTextBox.TabIndex = 13;
            // 
            // fechaMuerteTextBox
            // 
            this.fechaMuerteTextBox.Location = new System.Drawing.Point(1322, 306);
            this.fechaMuerteTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaMuerteTextBox.Name = "fechaMuerteTextBox";
            this.fechaMuerteTextBox.Size = new System.Drawing.Size(148, 26);
            this.fechaMuerteTextBox.TabIndex = 14;
            // 
            // importanciaTextBox
            // 
            this.importanciaTextBox.Location = new System.Drawing.Point(1322, 349);
            this.importanciaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.importanciaTextBox.Name = "importanciaTextBox";
            this.importanciaTextBox.Size = new System.Drawing.Size(148, 26);
            this.importanciaTextBox.TabIndex = 16;
            // 
            // biografiaTextBox
            // 
            this.biografiaTextBox.Location = new System.Drawing.Point(1322, 392);
            this.biografiaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.biografiaTextBox.Name = "biografiaTextBox";
            this.biografiaTextBox.Size = new System.Drawing.Size(148, 26);
            this.biografiaTextBox.TabIndex = 17;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1338, 435);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 35);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // buttonOpenParentescos
            // 
            this.buttonOpenParentescos.Location = new System.Drawing.Point(1224, 542);
            this.buttonOpenParentescos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenParentescos.Name = "buttonOpenParentescos";
            this.buttonOpenParentescos.Size = new System.Drawing.Size(129, 35);
            this.buttonOpenParentescos.TabIndex = 19;
            this.buttonOpenParentescos.Text = "Parentescos";
            this.buttonOpenParentescos.UseVisualStyleBackColor = true;
            this.buttonOpenParentescos.Click += new System.EventHandler(this.buttonOpenParentescos_Click);
            // 
            // buttonOpenRelaciones
            // 
            this.buttonOpenRelaciones.Location = new System.Drawing.Point(1224, 586);
            this.buttonOpenRelaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenRelaciones.Name = "buttonOpenRelaciones";
            this.buttonOpenRelaciones.Size = new System.Drawing.Size(129, 35);
            this.buttonOpenRelaciones.TabIndex = 20;
            this.buttonOpenRelaciones.Text = "Relaciones";
            this.buttonOpenRelaciones.UseVisualStyleBackColor = true;
            this.buttonOpenRelaciones.Click += new System.EventHandler(this.buttonOpenRelaciones_Click);
            // 
            // buttonOpenCargos
            // 
            this.buttonOpenCargos.Location = new System.Drawing.Point(1224, 631);
            this.buttonOpenCargos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenCargos.Name = "buttonOpenCargos";
            this.buttonOpenCargos.Size = new System.Drawing.Size(129, 35);
            this.buttonOpenCargos.TabIndex = 21;
            this.buttonOpenCargos.Text = "Cargos Pers";
            this.buttonOpenCargos.UseVisualStyleBackColor = true;
            this.buttonOpenCargos.Click += new System.EventHandler(this.buttonOpenCargos_Click);
            // 
            // buttonEventos
            // 
            this.buttonEventos.Location = new System.Drawing.Point(1216, 18);
            this.buttonEventos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEventos.Name = "buttonEventos";
            this.buttonEventos.Size = new System.Drawing.Size(112, 35);
            this.buttonEventos.TabIndex = 22;
            this.buttonEventos.Text = "Eventos";
            this.buttonEventos.UseVisualStyleBackColor = true;
            this.buttonEventos.Click += new System.EventHandler(this.buttonEventos_Click);
            // 
            // buttonLugares
            // 
            this.buttonLugares.Location = new System.Drawing.Point(1346, 18);
            this.buttonLugares.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLugares.Name = "buttonLugares";
            this.buttonLugares.Size = new System.Drawing.Size(112, 35);
            this.buttonLugares.TabIndex = 23;
            this.buttonLugares.Text = "Lugares";
            this.buttonLugares.UseVisualStyleBackColor = true;
            this.buttonLugares.Click += new System.EventHandler(this.buttonLugares_Click);
            // 
            // buttonOpenProtagonistas
            // 
            this.buttonOpenProtagonistas.Location = new System.Drawing.Point(1383, 548);
            this.buttonOpenProtagonistas.Name = "buttonOpenProtagonistas";
            this.buttonOpenProtagonistas.Size = new System.Drawing.Size(144, 40);
            this.buttonOpenProtagonistas.TabIndex = 24;
            this.buttonOpenProtagonistas.Text = "Protagonistas\r\n";
            this.buttonOpenProtagonistas.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 695);
            this.Controls.Add(this.buttonOpenProtagonistas);
            this.Controls.Add(this.buttonLugares);
            this.Controls.Add(this.buttonEventos);
            this.Controls.Add(this.buttonOpenCargos);
            this.Controls.Add(this.buttonOpenRelaciones);
            this.Controls.Add(this.buttonOpenParentescos);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button buttonOpenParentescos;
        private System.Windows.Forms.Button buttonOpenRelaciones;
        private System.Windows.Forms.Button buttonOpenCargos;
        private System.Windows.Forms.Button buttonEventos;
        private System.Windows.Forms.Button buttonLugares;
        private System.Windows.Forms.Button buttonOpenProtagonistas;
    }
}

